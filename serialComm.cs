using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace California_Instruments_CSW5550_Software
{
    public struct SerialPortSettings
    {
        public string port_name;
        public int baud_rate;
        public int data_bits;
        public StopBits stop_bits;
        public Parity parity;
        public bool rts;
    }

    public class serialComm : IDisposable
    {
        public SerialPort m_SerialPort = new SerialPort();
        //private SerialPort m_SerialPort = new SerialPort("COM4", baud_rate)..try this constructor
        public SerialPortSettings m_CommSettings;

        public void load_defaults()
        {
            m_CommSettings.data_bits = 8;
            m_CommSettings.stop_bits = StopBits.One;
            m_CommSettings.parity = Parity.None;
            m_CommSettings.port_name = "COM8";
            m_CommSettings.baud_rate = 460800;
            m_CommSettings.rts = false;
        }

        // Opens com port and configures it with required settings
        //return false if port could not be opened
         
        public bool Open()
        {
            bool status;
            string comm_port_name;
            //read_comm_settings_file();
            //load_defaults();

            m_SerialPort.PortName = m_CommSettings.port_name;
            m_SerialPort.BaudRate = m_CommSettings.baud_rate;
            m_SerialPort.Parity = m_CommSettings.parity;
            m_SerialPort.DataBits = m_CommSettings.data_bits;
            m_SerialPort.StopBits = m_CommSettings.stop_bits;   // System.IO.Ports.StopBits.One;
            m_SerialPort.Handshake = Handshake.None;

            m_SerialPort.ReadTimeout = 800;
            m_SerialPort.WriteTimeout = 800;

            try
            {
                m_SerialPort.Open();
                status = true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = false;
            }

            comm_port_name = m_CommSettings.port_name;

            if (comm_port_name.Length > 4)
            {
                comm_port_name = "\\\\.\\" + comm_port_name;
            }

            comm_port_name += ":";

            return ( status );
        }

        public void Close()
        {
            m_SerialPort.Close();
        }

        public void LoadSettings()
        {
            read_comm_settings_file();
        }

        public void SaveSettings()
        {
            write_comm_settings_file();
        }

        private void read_comm_settings_file()
        {
            XmlSerializer serial_obj = new XmlSerializer(typeof(SerialPortSettings));

            //Create new file stream for reading XML file
            try
            {
                FileStream rd_file_stream = new FileStream(@"serial_settings.xml", FileMode.Open, FileAccess.Read, System.IO.FileShare.Read);
                m_CommSettings = (SerialPortSettings)serial_obj.Deserialize(rd_file_stream);
                rd_file_stream.Close();
            }
            catch
            {
                this.load_defaults();
                write_comm_settings_file();
            }
        }

        private void write_comm_settings_file()
        {
            XmlSerializer serial_obj = new XmlSerializer(typeof(SerialPortSettings));
            TextWriter wr_file_stream = new StreamWriter(@"serial_settings.xml");
            serial_obj.Serialize(wr_file_stream, m_CommSettings);
            wr_file_stream.Close();
        }

        public bool transmit_message(string msg)
        {
            bool reply;
            
            try
            {
                m_SerialPort.WriteLine(msg);
                reply = true;
            }
            catch(Exception e)
            {
                reply = false;
            }

            return (reply);
        }
        public bool receive_message(ref char[] msg, ref int msg_len, int max_len, int exp_resp_len)
        {
            bool msg_complete, reply;
            int offset;
            int num_read, k;


            reply = true;
            msg_complete = false;
            msg_len = 0;
            offset = 0;

            // This do-while loop will exit under any of the following conditions;
            //   
            //   1. The total number of bytes received = the expected number of bytes.
            //      If this occurs the reply value = true, and the calling function
            //      will perform additional error checks.
            //
            //   2. A TimeoutException occurs, currently set to 100 mSec.
            //      If this occurs the reply value = true, and the calling function 
            //      will perform additional error checks. It is important that a timeout
            //      is NOT immediately considered to be a comm failure. It may be due
            //      to the fact that the slave device has provided a response that 
            //      was not expected, resulting in a shorter length response, ultimately
            //      resulting in a timeout. Ex. error response, ie. "invalid command"
            //
            //   3. A different exception occurred. For instance, buffer overruns. In
            //      these cases the entire response is considered invalid, reply = false.
            //

            do
            {
                try
                {
                    num_read = m_SerialPort.Read(msg, offset, (max_len - offset));

                    offset += num_read;
                    msg_len = offset;

                    for (k = 0; k < msg_len; k++)
                    {
                        if (msg[k] == 10) //carriage return
                        {
                            msg_complete = true;
                        }
                    }
            
                }
                catch (TimeoutException)
                {
                    msg_complete = true;
                }
                catch (Exception)
                {
                    reply = false;
                    msg_complete = true;
                }

            } while (msg_complete == false);

            delay(5);

            return (reply);

        }

        // For IDisposable
        public void Dispose()
        {
           Close();
        }
            //destructor
             ~serialComm() { Close();  }

        public void delay(int msec_delay)
        {
            DateTime start = DateTime.Now;
            TimeSpan delay = new TimeSpan((Int64)msec_delay * 10000);
            DateTime end = start.Add(delay);
            DateTime x1;
            DateTime x2;
            int k;

            while (DateTime.Now.Ticks < end.Ticks)
                ;

            x1 = DateTime.Now;
            x2 = x1.Add(delay);
            k = 0;
            k++;
        }

        public bool set_voltage_command(string voltage)
        {
            bool reply = false;
            string str1 = "SOURce:VOLTage:AMPLitude ";

       
            if (transmit_message(str1 + voltage))
            {
                reply = true;
            }

            return reply;
        }
     

        public bool set_frequency_command(string freq)
        {
            bool reply = false;
            string str1 = "SOURce:FREQ ";

            if (transmit_message(str1 + freq))
            {
                reply = true;
            }
            return reply;
        }
        
       
        
    }
}

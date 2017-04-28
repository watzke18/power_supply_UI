using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace California_Instruments_CSW5550_Software
{
    public partial class InitialParams : Form
    {
        public NominalParameters m_nominalParameters;
    
        public InitialParams()
        {
            InitializeComponent();
        }

        private void InitialParams_Load(object sender, EventArgs e)
        {
            VoltageScroll.Value = (int)m_nominalParameters.voltage;
            FrequencyScroll.Value = (int)m_nominalParameters.frequency;
            labelVoltage.Text = m_nominalParameters.voltage.ToString();
            labelFrequency.Text = m_nominalParameters.frequency.ToString();
        }

        public void setVoltageScroll(int value)
        {
            VoltageScroll.Value = value;
        }

        public void setFrequencyScroll(int value)
        {
            FrequencyScroll.Value = value;
        }

        /* Ok button - once this buttin is pressed, the
         * output status windows on the bottom right should be updated 
         * with current voltage and frequency
         * */
        private void OkBtn_Click(object sender, EventArgs e) 
        {
            m_nominalParameters.voltage = VoltageScroll.Value;
            m_nominalParameters.frequency = FrequencyScroll.Value;

   

            /*bool reply;
            string msg;

            char[] v_recv = new char[10];
            char[] f_recv = new char[10];
            char[] getRid = { '\0', '\n' };
            int vrecv_len = 0;
            int frecv_len = 0;*/

            /*
            //do something with elgar
          //  reply = main_form.m_Comm.set_voltage_command(VoltageScroll.Value.ToString());
           // if (!reply)
           // {
            //    main_form.console.AppendText("Failed to set voltage");
           // }
            m_global.vrmsout = VoltageScroll.Value.ToString();

            reply = main_form.m_Comm.set_frequency_command(FrequencyScroll.Value.ToString());
            if(!reply)
            {
                main_form.console.AppendText("Failed to set frequency");
            }
            m_global.freqout = FrequencyScroll.Value.ToString();


            //measure voltage after setting
            reply = main_form.m_Comm.measure_voltage_command(ref v_recv, ref vrecv_len, 10);
            if(reply)
            {
                string str = new string(v_recv);
                string newstr = str.Trim(getRid);
            }
            else
            {
                main_form.console.AppendText("failed to receive response from power supply");
            }
            
            //measure frequency
            reply = main_form.m_Comm.measure_frequency_command(ref f_recv, ref frecv_len, 10);
            if (reply) //check to make sure power supply sent something back
            { 
                string str = new string(f_recv);
                string newstr = str.Trim(getRid);
            }
            else
            {
                main_form.console.AppendText("failed to receive response from power supply");
            }
            */

            //Print the output values to their respective picture boxes

            /*int vrms_out = Int32.Parse(m_global.vrmsout);

            if (!(vrms_out >= m_global.Voltage - 5 && vrms_out <= m_global.Voltage + 5))
            {
                msg = "The Elgar did not initialize properly. ";
                msg += "Check to see that the devices attached ";
                msg += "are not drawing more than the 5.00A max "; //5 amps max? check**
                msg += "current limit."; // + chr10 + chr(10) ??
                msg += "Pres OK to try again.";
                //one more line
            }
            else
            {
                main_form.TestModeBtn.Enabled = true;
                main_form.DropOutBtn.Enabled = false;
                main_form.RunTestBtn.Enabled = false;

                //  main_form.OutputFrame.visisble = true find out what output frame is
                main_form.ActualVoltage.Visible = true;
                main_form.ActualFrequency.Visible = true;
                main_form.ActualCurrent.Visible = true;

                if (Convert.ToDouble(m_global.vrmsout) > 30)
                {
                    main_form.ActualVoltage.BackColor = Color.Yellow;
                    main_form.HighVoltageBox.Visible = true;
                    main_form.CautionTimer.Enabled = true;
                }
                else
                {
                    //change back color
                    main_form.ActualVoltage.BackColor = Color.LightPink;
                    main_form.HighVoltageBox.Visible = false;
                }
            }*/

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void VoltageScroll_ValueChanged(Object sender, ScrollEventArgs e)
        {
            labelVoltage.Text = VoltageScroll.Value.ToString();
        }

        private void FrequencyScroll_ValueChanged(Object sender, ScrollEventArgs e)
        {
            labelFrequency.Text = FrequencyScroll.Value.ToString();
        } 

        public HScrollBar getHScrollBar1()
        {
            return VoltageScroll;
        }
    }
}

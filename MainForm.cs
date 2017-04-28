using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace California_Instruments_CSW5550_Software
{
    public struct NominalParameters
    {
        public int voltage;
        public int frequency;
    }

    public struct MeasuredValues
    {
        public int voltage;
        public int frequency;
        public float current;
    }

    public struct TestParameters
    {
        public int test_type;
        public int drop_volt_min;
        public int drop_volt_max;
        public int drop_volt_step;
        public int phase;
        public int drop_time_min;
        public int drop_time_min_units;    //0=ms, 1=s, 2=min
        public int drop_time_min_ms;
        public int drop_time_max;
        public int drop_time_max_units;    //0=ms, 1=s, 2=min
        public int drop_time_max_ms;
        public int drop_time_step;
        public int drop_time_step_units;   //0=ms, 1=s, 2=min
        public int drop_time_step_ms;
        public int delay;
        public int delay_units;            //0=ms, 1=s, 2=min
        public int delay_ms;
        public int loops;
    }

    public struct SpecialTestParameters
    {
        public int drop_volt;
        public int drop_time;
        public int drop_time_units;
        public int phase;   
    }

    public struct TestStatus
    {
        public int current_drop_voltage;
        public int current_drop_time;
        public int current_loop;
    }

    public partial class MainForm : Form
    {
        public DropoutParams dropoutParams;
        public serialComm m_Comm = new serialComm();
        public NominalParameters m_nominalParameters = new NominalParameters();
        public MeasuredValues m_measuredValues = new MeasuredValues();
        public TestParameters m_testParameters = new TestParameters();
        public SpecialTestParameters[] m_specialTestParameters = new SpecialTestParameters[99];
        public TestStatus m_testStatus = new TestStatus();

        public int output_state;
        public int test_state; // 1 = running, 0 = stopped, -1 = aborted

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            m_Comm.LoadSettings();
          //  m_Comm.m_SerialPort.DiscardInBuffer();
          //  m_Comm.m_SerialPort.DiscardOutBuffer();


            m_nominalParameters.voltage = 120;
            m_nominalParameters.frequency = 60;

            m_testParameters.test_type = 0;
            m_testParameters.drop_volt_min = 0;
            m_testParameters.drop_volt_max = 100;
            m_testParameters.drop_volt_step = 10;
            m_testParameters.phase = 0;
            m_testParameters.drop_time_min = 1;
            m_testParameters.drop_time_min_units = 1;
            m_testParameters.drop_time_max = 5;
            m_testParameters.drop_time_max_units = 1;
            m_testParameters.drop_time_step = 1;
            m_testParameters.drop_time_step_units = 1;
            m_testParameters.delay = 10;
            m_testParameters.delay_units = 1;
            m_testParameters.loops = 1;

            //initialize special parameter struct (test 4) -- consider combining into testParameters struct
            m_specialTestParameters[0].drop_volt = 0;
            m_specialTestParameters[0].drop_time = 1;
            m_specialTestParameters[0].drop_time_units = 1;
            m_specialTestParameters[0].phase = 0;

          //  m_specialTestParameters[0].loops = 1;

            m_testStatus.current_drop_voltage = 100;
            m_testStatus.current_drop_time = 100;
            m_testStatus.current_loop = 1;

            openCom.Enabled = true;
            InitialParamBtn.Enabled = false;
            TestModeBtn.Enabled = false;
            DropOutBtn.Enabled = false;
            RunTestBtn.Enabled = false;
            buttonAbortTest.Visible = false;
            saveToolStripMenuItem.Enabled = false;

            StatusMsg.Text = "Open Comm Port";

        }

       /*****************************************************************
        * 
        * MAINFORM EVENT METHODS
        * 
        ****************************************************************/

        public void openCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Stream myStream = null;
            int count = 0;
            string tmp;
            bool Error;
            bool reply;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (StreamReader sr = new StreamReader(myStream))
                        {
                            // Insert code to read the stream here.
  */
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeProgram();
        }

        private void openCom_Click(object sender, EventArgs e)
        {
            bool reply;
            reply = m_Comm.Open();

            if (!reply)
            {
                AppendConsoleText("Comm Failed to open");
            }
            else
            {
                AppendConsoleText("Comm Opened Successfully");
                StatusMsg.Text = "Set nominal parameters";
                InitialParamBtn.Enabled = true;
                openCom.Enabled = false;
            }
        }


        private void InitialParamBtn_Click(object sender, EventArgs e)
        {
            InitialParams initializeForm = new InitialParams();
            initializeForm.m_nominalParameters = m_nominalParameters;

            if (initializeForm.ShowDialog() == DialogResult.OK)
            {
                m_nominalParameters = initializeForm.m_nominalParameters;

                setNominalParameters();
                readOutputData();

                ActualVoltage.Visible = true;
                ActualFrequency.Visible = true;
                ActualCurrent.Visible = true;

                if (m_measuredValues.voltage > 30)
                {
                    ActualVoltage.BackColor = Color.Yellow;
                    HighVoltageBox.Visible = true;
                    CautionTimer.Enabled = true;
                }
                else
                {
                    ActualVoltage.BackColor = Color.LightPink;
                    HighVoltageBox.Visible = false;
                }

                StatusMsg.Text = "Select the test to perform";
                TestModeBtn.Enabled = true;
            }
        }

        private void TestModeBtn_Click(object sender, EventArgs e)
        {
            testModeConfig testModeForm = new testModeConfig();
            testModeForm.m_testParameters = m_testParameters;

            if (testModeForm.ShowDialog() == DialogResult.OK)
            {
                m_testParameters = testModeForm.m_testParameters;


                StatusMsg.Text = "Specify the test parameters";

                DropOutBtn.Enabled = true;
                
                if(m_testParameters.test_type == 4)
                {
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    labelNextDropoutVoltage.Visible = false;
                    labelNextDropoutTime.Visible = false;
                    labelLoopNumber.Visible = false;

                }
                else
                {
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    labelNextDropoutVoltage.Visible = true;
                    labelNextDropoutTime.Visible = true;
                    labelLoopNumber.Visible = true;
                }
            }
        }

        private void DropOutBtn_Click(object sender, EventArgs e)
        {
            dropoutParams = new DropoutParams();
            dropoutParams.m_nominalParameters = m_nominalParameters;
            dropoutParams.m_testParameters = m_testParameters;
            dropoutParams.m_specialTestParameters = m_specialTestParameters;
   

            if (dropoutParams.ShowDialog() == DialogResult.OK)
            {
                m_testParameters = dropoutParams.m_testParameters;
                m_specialTestParameters = dropoutParams.m_specialTestParameters;

                if(m_testParameters.test_type == 4)
                {
                    AppendConsoleText("***DROP OUT LIST*** \n");
                    foreach(string item in dropoutParams.listBoxDropOutSteps.Items)
                    {
                        AppendConsoleText(item);
                    }
                }

                RunTestBtn.Enabled = true;
            }
            else //cancel button pressed from DropoutParams form
            {
                RunTestBtn.Enabled = false;
            }
        }

        private void RunTestBtn_Click(object sender, EventArgs e)
        {
            m_testStatus.current_drop_voltage = m_testParameters.drop_volt_max;
            m_testStatus.current_drop_time = m_testParameters.drop_time_min_ms;
            m_testStatus.current_loop = 1;
            test_state = 1;


            switch (m_testParameters.test_type)
            {
                case 1:
                    m_Comm.transmit_message("INST:NSEL 1");     //select phase A
                    m_Comm.transmit_message("IEC411:STAT ON");
                    m_Comm.transmit_message("IEC411:NOM:VOLT " + m_nominalParameters.voltage.ToString());   //set nominal voltage for test

                    m_Comm.transmit_message("IEC411:DIPS:VOLT " + voltageToPercent(m_testStatus.current_drop_voltage, m_nominalParameters.voltage).ToString());
                    m_Comm.transmit_message("IEC411:DIPS:CYCL " + timeToCycles(m_testStatus.current_drop_time).ToString());
                    m_Comm.transmit_message("IEC411:DIPS:ANGL " + m_testParameters.phase.ToString());

                    m_Comm.transmit_message("IEC411:DIPS:RUN:SING");
                    PauseBtn.Visible = true;
                    break;

                case 2:
                    multipleTestTimer.Interval = (int)m_testParameters.delay_ms;

                    m_Comm.transmit_message("INST:NSEL 1");     //select phase A
                    m_Comm.transmit_message("IEC411:STAT ON");
                    m_Comm.transmit_message("IEC411:NOM:VOLT " + m_nominalParameters.voltage.ToString());   //set nominal voltage for test

                    updateParamDisplay();

                    multipleTestTimer.Enabled = true;
                    PauseBtn.Visible = true;
                    break;

                case 3:
                    incrementTestTimer.Interval = 1000; //wait 1 sec before starting test

                    m_Comm.transmit_message("INST:NSEL 1");     //select phase A
                    m_Comm.transmit_message("IEC411:STAT ON");
                    m_Comm.transmit_message("IEC411:NOM:VOLT " + m_nominalParameters.voltage.ToString());   //set nominal voltage for test

                    updateParamDisplay();

                    incrementTestTimer.Enabled = true;
                    PauseBtn.Visible = true;
                    break;

                case 4:
                    //build array with all voltage/times for custom dropout test
                    //    m_specialTestParameters = buildArray(m_specialTestParameters);
                    countArrayElements(m_specialTestParameters);
                   // stateTimer.Enabled = true;
                  //  countTimer.Enabled = true;
                    VaryingTest();
 
                  
                   // m_Comm.transmit_message("INST:NSEL 1");     //select phase A

                    break;
            }

            enterTestMode();
        }
    

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            closeProgram();
        }

        private void buttonAbortTest_Click(object sender, EventArgs e)
        {
            test_state = -1;
            exitTestMode();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if (test_state == 1)
            {
                PauseBtn.Text = "Resume Test";
                switch (m_testParameters.test_type)
                {
                    case 1:
                        test_state = 0;
                        break;

                    case 2:
                        multipleTestTimer.Stop();
                        test_state = 0;
                        break;

                    case 3:
                        incrementTestTimer.Stop();
                        test_state = 0;
                        break;
                    case 4:
                        //VaryingTest();
                        multipleTestTimer.Stop();   //select phase A
                        test_state = 0;
                        break;
                }

                AppendConsoleText("Test Resumed");
            }
            else
            {
                PauseBtn.Text = "Pause Test";
                switch (m_testParameters.test_type)
                {
                    case 1:

                        test_state = 1;
                        break;

                    case 2:
                        multipleTestTimer.Start();
                        test_state = 1;
                        break;

                    case 3:
                        incrementTestTimer.Interval = m_testParameters.delay_ms;
                        incrementTestTimer.Start();
                        test_state = 1;
                        break;
                    case 4:
                        //VaryingTest();
                        multipleTestTimer.Start();   //select phase A
                        test_state = 1;
                        break;
                }

                AppendConsoleText("Test Paused");
            }

        }

        private void configureCommPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigCOMM dlg = new ConfigCOMM();

            dlg.m_Settings = m_Comm.m_CommSettings;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                m_Comm.Close();
                m_Comm.m_CommSettings = dlg.m_Settings;
                m_Comm.SaveSettings();
            }
        }

        /*****************************************************************
         * 
         * END MAINFORM EVENT METHODS
         * 
         ****************************************************************/

        public void enterTestMode()
        {
            InitialParamBtn.Enabled = false;
            TestModeBtn.Enabled = false;
            DropOutBtn.Enabled = false;
            RunTestBtn.Enabled = false;
            QuitBtn.Enabled = false;

            buttonAbortTest.Visible = true;

            StatusMsg.Text = "Test in Progress";
            AppendConsoleText("Test Started");

            //readDwellData();
        }

        public void exitTestMode()
        {
            m_Comm.transmit_message("OUTP:STAT 1"); //turn output back to nominal value
            StatusMsg.Text = "";

            InitialParamBtn.Enabled = true;
            TestModeBtn.Enabled = true;
            DropOutBtn.Enabled = true;
            QuitBtn.Enabled = true;
            buttonAbortTest.Visible = false;
            PauseBtn.Visible = false;

            multipleTestTimer.Enabled = false;
            incrementTestTimer.Enabled = false;
            stateTimer.Enabled = false;
            countTimer.Enabled = false;

            
            if(test_state == -1)
            {
                AppendConsoleText("Test Aborted");
            }
            else
            {
                AppendConsoleText("Test Completed");
            }
           

            //need a way to re-init array incase user wants to enter test mode again eventually
            if(m_testParameters.test_type == 4)
            {
                Array.Resize(ref m_specialTestParameters, 99);
            }

        }

        private void setNominalParameters()
        {
            //Reset the Elgar
            m_Comm.transmit_message("*RST");

            m_Comm.transmit_message("OUTP:STAT 0"); //turn output off
            if (m_nominalParameters.voltage > 156)
                m_Comm.transmit_message("SOUR:VOLT:RANG 312");
            else
                m_Comm.transmit_message("SOUR:VOLT:RANG 156");

            m_Comm.transmit_message("SOUR:FUNC:SIN"); //check
            m_Comm.delay(300);
            //Edit sine wave output to the initialize parameters, Voltage & Frequency
            m_Comm.transmit_message("SOUR:VOLT:LEV:IMM:AMPL " + m_nominalParameters.voltage.ToString());
            m_Comm.transmit_message("SOUR:FREQ " + m_nominalParameters.frequency.ToString());
            m_Comm.delay(300);
            //Enable the CSW output to the Initial settings
            m_Comm.transmit_message("OUTP:STAT 1"); //turn output on

            CautionTimer.Enabled = true;
        }

        public void AppendConsoleText(string str)
        {
            console.AppendText(">" + str + "\n");
        }





       


        private bool SeqDone()
        {
            char[] recv = new char[4];
            int recv_len = 4;
            int exp_resp_len = 4;

            m_Comm.transmit_message("SOUR:SEQUENCE:STATE?");
            m_Comm.receive_message(ref recv, ref recv_len, recv.Length, exp_resp_len);

            string str = new string(recv);
            string newstr = str.Trim('\0');

            if (newstr.CompareTo("STOP") == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void MultipleTest()
        {
            if (m_testStatus.current_loop >= m_testParameters.loops)
                exitTestMode();     //end test
            else
                m_testStatus.current_loop++;
        }

        private void IncrementTest()
        {
            if (m_testStatus.current_drop_voltage - m_testParameters.drop_volt_step < m_testParameters.drop_volt_min) //done with current set of dropout voltages
            {
                if ((m_testStatus.current_drop_time + m_testParameters.drop_time_step_ms) > m_testParameters.drop_time_max_ms) //done with current loop
                {
                    if (m_testStatus.current_loop >= m_testParameters.loops) //last loop?
                    {
                        exitTestMode();     //end test
                    }
                    else //increment loop counter and reset 
                    {
                        m_testStatus.current_drop_voltage = m_testParameters.drop_volt_max;
                        m_testStatus.current_drop_time = m_testParameters.drop_time_min_ms;
                        m_testStatus.current_loop++;
                    }
                }
                else //go down to next dropout time period and reset the voltage
                {
                    m_testStatus.current_drop_voltage = m_testParameters.drop_volt_max;
                    m_testStatus.current_drop_time = m_testStatus.current_drop_time + m_testParameters.drop_time_step_ms;
                }
            }
            else //go down to next dropout voltage
            {
                m_testStatus.current_drop_voltage = m_testStatus.current_drop_voltage - m_testParameters.drop_volt_step;
            }


        }

        private void VaryingTest()
        {

            m_Comm.transmit_message("INST:NSEL 1");
            m_Comm.transmit_message("VOLTage:MODE LIST");
            m_Comm.transmit_message("FREQuency:MODE LIST");

            m_Comm.transmit_message("LIST:VOLTage " + buildVoltageList(m_specialTestParameters));
            m_Comm.transmit_message("LIST:FREQuency " + buildFrequencyList(m_specialTestParameters));
            m_Comm.transmit_message("LIST:DWELl " + buildDwellList(m_specialTestParameters));
            m_Comm.transmit_message("LIST:COUNt " + m_testParameters.loops);
            m_Comm.transmit_message("LIST:STEP AUTO");
            m_Comm.transmit_message("INITiate:CONTinuous ON");
            m_Comm.transmit_message("TRIGger: SOURce IMM");
            m_Comm.transmit_message("INIT");
        }


        private void updateParamDisplay()
        {
            labelNextDropoutVoltage.Text = m_testStatus.current_drop_voltage.ToString() + "V";
            labelNextDropoutTime.Text = m_testStatus.current_drop_time.ToString() + "ms";
            labelLoopNumber.Text = (m_testStatus.current_loop.ToString() + "/" + m_testParameters.loops);

        }

        private uint voltageToPercent(int dropVoltage, int nominalVoltage)
        {
            double percent;
            percent = ((double)dropVoltage / (double)nominalVoltage) * 100;
            return Convert.ToUInt32(percent);
        }

        private int timeToCycles(int DropOutTime)
        {
            int numCycles;
            double inSeconds;

            inSeconds = (double)DropOutTime / 1000;

            numCycles = (int)(inSeconds * 60);

            if (numCycles > 3000)
            {
                //print error message
            }
            return numCycles;
        }

        /*****************************************************************
         * 
         * TIMERS 
         * 
         * ***************************************************************/

        private void multipleTestTimer_Tick(object sender, EventArgs e)
        {
            m_Comm.transmit_message("IEC411:DIPS:VOLT " + voltageToPercent(m_testStatus.current_drop_voltage, m_nominalParameters.voltage).ToString());
            m_Comm.transmit_message("IEC411:DIPS:CYCL " + timeToCycles(m_testStatus.current_drop_time).ToString());
            m_Comm.transmit_message("IEC411:DIPS:ANGL " + m_testParameters.phase.ToString());
            m_Comm.transmit_message("IEC411:DIPS:RUN:SING");

            MultipleTest();
            updateParamDisplay();
        }

        private void incrementTestTimer_Tick(object sender, EventArgs e)
        {
        
            m_Comm.transmit_message("IEC411:DIPS:VOLT " + voltageToPercent(m_testStatus.current_drop_voltage, m_nominalParameters.voltage).ToString());
            m_Comm.transmit_message("IEC411:DIPS:CYCL " + timeToCycles(m_testStatus.current_drop_time).ToString());
            m_Comm.transmit_message("IEC411:DIPS:ANGL " + m_testParameters.phase.ToString());
            m_Comm.transmit_message("IEC411:DIPS:RUN:SING");

            IncrementTest(); //update variables for next step in test

            incrementTestTimer.Interval = m_testStatus.current_drop_time + m_testParameters.delay_ms;

            updateParamDisplay();
        }
        private void stateTimer_Tick(object sender, EventArgs e)
        {
            string state = readStateData();

            if(state == "IDLE" || state == "WTRIG")
            {
                exitTestMode();
            }
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            string count = readCountData();
        }


        private void CautionTimer_Tick(object sender, EventArgs e)
        {
            if (HighVoltageBox.Visible == true)
            {
                HighVoltageBox.Visible = false;
            }
            else
            {
                HighVoltageBox.Visible = true;
            }
        }

      /*****************************************************************
      * 
      * END TIMERS
      * 
      ****************************************************************/

 

        public bool read_voltage_command(ref char[] resp_msg, ref int resp_len, int max_resp_length)
        {
            bool reply = false;

            char[] recv = new char[max_resp_length];
            int recv_len, expected_recv_len, k;

            recv_len = 0;
            expected_recv_len = 10;
            resp_len = 0;

            if (m_Comm.transmit_message("VOLTAGE?"))
            {
                if (m_Comm.receive_message(ref recv, ref recv_len, recv.Length, expected_recv_len))
                {
                    resp_len = recv_len;
                    for (k = 0; k < resp_len; k++)
                    {
                        resp_msg[k] = recv[k];
                    }
                    reply = true;
                }
                else
                {
                    Debug.WriteLine("Failed to receive voltage from VOLTAGE? command.");
                }
            }
            return reply;
        }

        public bool read_frequency_command(ref char[] resp_msg, ref int resp_len, int max_resp_length)
        {
            bool reply = false;

            char[] recv = new char[max_resp_length];
            int recv_len, expected_recv_len, k;

            recv_len = 0;
            expected_recv_len = 10;
            resp_len = 0;

            //   m_SerialPort.DiscardInBuffer();

            if (m_Comm.transmit_message("FREQUENCY?"))
            {

                if (m_Comm.receive_message(ref recv, ref recv_len, recv.Length, expected_recv_len))
                {
                    resp_len = recv_len;
                    for (k = 0; k < resp_len; k++)
                    {
                        resp_msg[k] = recv[k];
                    }
                    reply = true;
                }
                else
                {
                    Debug.WriteLine("Failed to receive frequency from FREQUENCY? command.");
                }
            }
            return reply;
        }


        public bool read_current_command(ref char[] resp_msg, ref int resp_len, int max_resp_length)
        {
            bool reply = false;

            char[] recv = new char[max_resp_length];
            int recv_len, expected_recv_len, k;

            recv_len = 0;
            expected_recv_len = 10;
            resp_len = 0;

            //  m_SerialPort.DiscardInBuffer();

            if (m_Comm.transmit_message("CURRENT?"))
            {

                if (m_Comm.receive_message(ref recv, ref recv_len, recv.Length, expected_recv_len))
                {
                    resp_len = recv_len;
                    for (k = 0; k < resp_len; k++)
                    {
                        resp_msg[k] = recv[k];
                    }
                    reply = true;
                }
                else
                {
                    AppendConsoleText("Failed to receive current from CURRENT? command.");
                }
            }
            return reply;
        }
        public bool read_count_command(ref char[] resp_msg, ref int resp_len, int max_resp_length)
        {
            bool reply = false;

            char[] recv = new char[max_resp_length];
            int recv_len, expected_recv_len, k;

            recv_len = 0;
            expected_recv_len = 10;
            resp_len = 0;

            //  m_SerialPort.DiscardInBuffer();

            if (m_Comm.transmit_message("[SOURce:]LIST:DWELl?"))
            {
               if(m_Comm.receive_message(ref recv, ref recv_len, recv.Length, expected_recv_len))
                {
                    resp_len = recv_len;
                    for (k = 0; k < resp_len; k++)
                    {
                        resp_msg[k] = recv[k];
                    }
                    reply = true;
                }
                else
                {
                    Debug.WriteLine("failed to receive message after transmitting count command");
                }
            }
            return reply;
        }
        private string readCountData()
        {
            char[] recv = new char[10];
            char[] resp_msg = new char[10];
            int recv_len = 0;
            int exp_resp_len = 6;
            bool reply;
            string count = "";

            try
            {
                reply = read_count_command(ref recv, ref recv_len, exp_resp_len);

                if (reply)
                {
                    
                    int k = 0;

                    while (recv[k] != 10)
                    {
                        count += recv[k];
                        k++;
                    }

                    ActualVoltage.Text = (count + " V");
                }
                else
                {
                    AppendConsoleText("Error reading voltage");
                }
            }
            catch
            {
                MessageBox.Show("error reading output values from unit");
            }

            return count;
        }

        public bool read_state_command(ref char[] resp_msg, ref int resp_len, int max_resp_length)
        {
            bool reply = false;

            char[] recv = new char[max_resp_length];
            int recv_len, expected_recv_len, k;

            recv_len = 0;
            expected_recv_len = 10;
            resp_len = 0;

            if (m_Comm.transmit_message("TRIG:STATe?"))
            {
                m_Comm.receive_message(ref recv, ref recv_len, recv.Length, expected_recv_len);
                //m_Comm.transmit_message("*WAI");

                //{
                resp_len = recv_len;
                for (k = 0; k < resp_len; k++)
                {
                    resp_msg[k] = recv[k];
                }
                reply = true;
                //}
                //  else
                //  {
                //       Debug.WriteLine("failed to receive message");
                //    }
            }
            return reply;
        }
        private string readStateData()
        {
            char[] recv = new char[10];
            char[] resp_msg = new char[10];
            int recv_len = 0;
            int exp_resp_len = 6;
            bool reply;

            string state = "";

            try
            {
                reply = read_state_command(ref recv, ref recv_len, exp_resp_len);

                if (reply)
                {
                    int k = 0;

                    while (recv[k] != 10)
                    {
                        state += recv[k];
                        k++;
                    }

                    //ActualVoltage.Text = (dwell + " V");
                }
                else
                {
                    AppendConsoleText("Error reading voltage");
                }
            }
            catch
            {
                MessageBox.Show("error reading output values from unit");
            }

            return state;
        }

        private void readOutputData()
        {
            char[] recv = new char[10];
            char[] resp_msg = new char[10];
            int recv_len = 0;
            int exp_resp_len = 6;
            bool reply;

            try
            {
                reply = read_voltage_command(ref recv, ref recv_len, exp_resp_len);

                if (reply)
                {
                    string voltage = "";
                    int k = 0;

                    while (recv[k] != 10)
                    {
                        voltage += recv[k];
                        k++;
                    }

                    ActualVoltage.Text = (voltage + " Vrms");
                }
                else
                {
                    AppendConsoleText("Error reading voltage");
                }

                reply = read_frequency_command(ref recv, ref recv_len, exp_resp_len);

                if (reply)
                {
                    string frequency = "";
                    int j = 0;

                    while (recv[j] != 10)
                    {
                        frequency += recv[j];
                        j++;
                    }

                    ActualFrequency.Text = (frequency + " Hz");

                }
                else
                {
                    AppendConsoleText("Error reading frequency");
                }

                reply = read_current_command(ref recv, ref recv_len, exp_resp_len);

                if (reply)
                {
                    string current = "";
                    int j = 0;

                    while (recv[j] != 10)
                    {
                        current += recv[j];
                        j++;
                    }

                    ActualCurrent.Text = (current + " A");
                }
                else
                {
                    AppendConsoleText("Error reading current");
                }
            }
            catch
            {
                MessageBox.Show("error reading output values from unit");
            }
        }


        public void countArrayElements(SpecialTestParameters[] arr) //resizes array so that there are not unused indexes.
        {
            int count = 0;
            int i = 0;
            while (arr[i].drop_time != 0)
            {
                count++;
                i++;
            }

            Array.Resize(ref m_specialTestParameters, count);
        }

        public string buildVoltageList(SpecialTestParameters[] list)
        {
            string voltages = "";
            for(int i=0; i<=list.Length-1; i++)
            {
                if(i==list.Length-1)
                {
                    voltages += list[i].drop_volt + " " + m_nominalParameters.voltage; //no space at end of list.
                }
                else
                {
                    voltages += list[i].drop_volt + " " + m_nominalParameters.voltage + " ";
                }
            } 
            return voltages;
        }

        public string buildFrequencyList(SpecialTestParameters[] list)
        {
            string frequencies = "";

            for (int i=0; i<=list.Length*2-1; i++) //need to set frequency for 120V steps in list as well
            {
                if (i==list.Length*2-1)
                {
                    frequencies += m_nominalParameters.frequency;
                }
                else
                {
                    frequencies += m_nominalParameters.frequency + " ";
                }
            }
            return frequencies;
        }

        public string buildDwellList(SpecialTestParameters[] list)
        {
            string dwellTimes = "";
            for (int i=0; i<=list.Length - 1; i++)
            {
                if (i==list.Length - 1)
                {
                    dwellTimes += toSeconds(list[i].drop_time, list[i].drop_time_units) + " " + toSeconds(m_testParameters.delay, m_testParameters.delay_units);
                }
                else
                {
                    dwellTimes += toSeconds(list[i].drop_time, list[i].drop_time_units) + " "  + toSeconds(m_testParameters.delay, m_testParameters.delay_units) + " ";
                }
            }
            return dwellTimes;
        }

        public int toSeconds(int time, int unit)
        {
            int inSeconds;
            if (unit == 0)
            {
                inSeconds = time / 1000;
            }
            else if (unit == 2)
            {
                inSeconds = time * 60;
            }
            else
            {
                inSeconds = time;
            }
            return inSeconds;
        }

        private void closeProgram()
        {
            if (MessageBox.Show("Are you sure you want to quit?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                    m_Comm.transmit_message("SOUR: SEQ:STATE STOP");
                    m_Comm.transmit_message("*RST");
                    m_Comm.Close();
                    this.Close();
               
            }
        }


    }
}

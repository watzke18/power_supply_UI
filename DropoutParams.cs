using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace California_Instruments_CSW5550_Software
{
    public partial class DropoutParams : Form
    {
        public NominalParameters m_nominalParameters;
        public TestParameters m_testParameters;
        public SpecialTestParameters[] m_specialTestParameters = new SpecialTestParameters[99]; //intialize array for storing user custom dropouts - max 100 for 4th test type only
        //public SpecialTestParameters[] m_reOpenParams;
        private int minimumDropout;
        public static int currentStep;
        private int loaded = 0;

        public DropoutParams()
        {
            InitializeComponent();
        }

        private void dropoutParams_Load(object sender, EventArgs e)
        {
            numericUpDownDropVoltMin.Value = m_testParameters.drop_volt_min;
            numericUpDownPhase.Value = m_testParameters.phase;
            numericUpDownDropTimeMin.Value = m_testParameters.drop_time_min;
            comboBoxDropTimeMin.SelectedIndex = (int)m_testParameters.drop_time_min_units;

            minimumDropout = (1000 / (m_nominalParameters.frequency));

            switch (m_testParameters.test_type)
            {
                case 1:     //single dropout
                default:
                    labelDropVoltStep.Enabled = false;
                    numericUpDownDropVoltStep.Enabled = false;
                    labelDropVoltMax.Enabled = false;
                    numericUpDownDropVoltMax.Enabled = false;

                    labelDropTimeStep.Enabled = false;
                    numericUpDownDropTimeStep.Enabled = false;
                    comboBoxDropTimeStep.Enabled = false;
                    labelDropTimeMax.Enabled = false;
                    numericUpDownDropTimeMax.Enabled = false;
                    comboBoxDropTimeMax.Enabled = false;    
                
                    labelDelay.Enabled = false;
                    numericUpDownDelay.Enabled = false;
                    comboBoxDelay.Enabled = false;

                    labelLoops.Enabled = false;
                    numericUpDownLoops.Enabled = false;

                    buttonAddDropout.Enabled = false;
                    buttonDeleteLastEntry.Enabled = false;
                    break;

                case 2:     //multiple of same dropout
                    labelDropVoltStep.Enabled = false;
                    numericUpDownDropVoltStep.Enabled = false;
                    labelDropVoltMax.Enabled = false;
                    numericUpDownDropVoltMax.Enabled = false;

                    labelDropTimeStep.Enabled = false;
                    numericUpDownDropTimeStep.Enabled = false;
                    comboBoxDropTimeStep.Enabled = false;
                    labelDropTimeMax.Enabled = false;
                    numericUpDownDropTimeMax.Enabled = false;
                    comboBoxDropTimeMax.Enabled = false;

                    labelDelay.Enabled = true;
                    numericUpDownDelay.Enabled = true;
                    comboBoxDelay.Enabled = true;

                    labelLoops.Enabled = true;
                    numericUpDownLoops.Enabled = true;

                    buttonAddDropout.Enabled = false;
                    buttonDeleteLastEntry.Enabled = false;

                    numericUpDownDelay.Value = m_testParameters.delay;
                    comboBoxDelay.SelectedIndex = (int)m_testParameters.delay_units;
                    numericUpDownLoops.Value = m_testParameters.loops;
                    break;

                case 3:     //multiple incrementing dropouts
                    labelDropVoltStep.Enabled = true;
                    numericUpDownDropVoltStep.Enabled = true;
                    labelDropVoltMax.Enabled = true;
                    numericUpDownDropVoltMax.Enabled = true;

                    labelDropTimeStep.Enabled = true;
                    numericUpDownDropTimeStep.Enabled = true;
                    comboBoxDropTimeStep.Enabled = true;
                    labelDropTimeMax.Enabled = true;
                    numericUpDownDropTimeMax.Enabled = true;
                    comboBoxDropTimeMax.Enabled = true;

                    labelDelay.Enabled = true;
                    numericUpDownDelay.Enabled = true;
                    comboBoxDelay.Enabled = true;

                    labelLoops.Enabled = true;
                    numericUpDownLoops.Enabled = true;

                    buttonAddDropout.Enabled = false;
                    buttonDeleteLastEntry.Enabled = false;

                    numericUpDownDropVoltMax.Value = m_testParameters.drop_volt_max;
                    numericUpDownDropVoltStep.Value = m_testParameters.drop_volt_step;
                                        
                    numericUpDownDropTimeStep.Value = m_testParameters.drop_time_step;
                    comboBoxDropTimeStep.SelectedIndex = (int)m_testParameters.drop_time_step_units;
                    numericUpDownDropTimeMax.Value = m_testParameters.drop_time_max;
                    comboBoxDropTimeMax.SelectedIndex = (int)m_testParameters.drop_time_max_units;

                    numericUpDownDelay.Value = m_testParameters.delay;
                    comboBoxDelay.SelectedIndex = (int)m_testParameters.delay_units;
                    numericUpDownLoops.Value = m_testParameters.loops;
                    break;

                case 4:     //multiple varying dropouts (custom list)

                    labelDropVoltMin.Text = "Drop Out Voltage (Vrms):";
                    labelDropTimeMin.Text = "Drop Out Time: ";
                    labelDropVoltStep.Enabled = false;
                    numericUpDownDropVoltStep.Enabled = false;
                    labelDropVoltMax.Enabled = false;
                    numericUpDownDropVoltMax.Enabled = false;

                    labelDropTimeStep.Enabled = false;
                    numericUpDownDropTimeStep.Enabled = false;
                    comboBoxDropTimeStep.Enabled = false;
                    labelDropTimeMax.Enabled = false;
                    numericUpDownDropTimeMax.Enabled = false;
                    comboBoxDropTimeMax.Enabled = false;


                    buttonAddDropout.Enabled = true;
                    buttonDeleteLastEntry.Enabled = true;


                    //fill form
                    numericUpDownDropVoltMax.Value = m_testParameters.drop_volt_max;
                    numericUpDownDropVoltStep.Value = m_testParameters.drop_volt_step;

                    numericUpDownDropTimeStep.Value = m_testParameters.drop_time_step;
                    comboBoxDropTimeStep.SelectedIndex = (int)m_testParameters.drop_time_step_units;
                    numericUpDownDropTimeMax.Value = m_testParameters.drop_time_max;
                    comboBoxDropTimeMax.SelectedIndex = (int)m_testParameters.drop_time_max_units;

                    numericUpDownDelay.Value = m_testParameters.delay;
                    comboBoxDelay.SelectedIndex = (int)m_testParameters.delay_units;
                    numericUpDownLoops.Value = m_testParameters.loops;

                    if(currentStep == 0)
                    {
                        buttonDeleteLastEntry.Enabled = false;
                    }

                    populateListBox(); //other ways to do this?
                    loaded = 1;

                    break;
            }
        }

        private int getTimeMs(int time, int units)
        {
            switch (units)
            {
                case 0:
                default:
                    break;

                case 1:
                    time = time * 1000;
                    break;

                case 2:
                    time = time * 60000;
                    break;
            }
            return time;
        }

        private void buttonAddDropout_Click(object sender, EventArgs e)
        {
            if (currentStep == 0)
            {
                if (paramCheck()) //check parameters entered to make sure they are valid, then add dropout
                {
                    addDropOut(currentStep);
                    listBoxDropOutSteps.Items.Add("Nominal Voltage: " + m_nominalParameters.voltage + "V");
                    listBoxDropOutSteps.Items.Add(" ");
                    listBoxDropOutSteps.Items.Add("Loops:  " + numericUpDownLoops.Value);
                    listBoxDropOutSteps.Items.Add("Delay:  " + numericUpDownDelay.Value + " " + comboBoxDelay.Text);
                    listBoxDropOutSteps.Items.Add(" "); 
                    listBoxDropOutSteps.Items.Add("D" + (currentStep + 1) + ": " + m_specialTestParameters[currentStep].drop_volt + "V, " + m_specialTestParameters[currentStep].phase + "D, for " + m_specialTestParameters[currentStep].drop_time + " " + comboBoxDropTimeMin.Text);
                    buttonDeleteLastEntry.Enabled = true;
                    currentStep++;

                }
                else
                {
                    //throw error?
                }
            }
            else
            {
                if(currentStep < 50)
                {
                    if (paramCheck())
                    {
                        addDropOut(currentStep);
                        listBoxDropOutSteps.Items.Add("D" + (currentStep + 1) + ": " + m_specialTestParameters[currentStep].drop_volt + "V, " + m_specialTestParameters[currentStep].phase + "D, for " + m_specialTestParameters[currentStep].drop_time + " " + comboBoxDropTimeMin.Text);
                        currentStep++;
                    }
                }
                else
                {
                    MessageBox.Show("Max number of dropouts = 50", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            

            }

            listBoxDropOutSteps.SelectedIndex = listBoxDropOutSteps.Items.Count - 1;

        }

        private void buttonDeleteLastEntry_Click(object sender, EventArgs e)
        {
            if (currentStep <= 1) //set loops/delay available again for user to set if deleted first drop out
            {
                listBoxDropOutSteps.Items.Clear();

                numericUpDownDelay.Enabled = true;
                comboBoxDelay.Enabled = true;
                numericUpDownLoops.Enabled = true;
                labelDelay.Enabled = true;
                labelLoops.Enabled = true;
                buttonDeleteLastEntry.Enabled = false;
                Array.Clear(m_specialTestParameters, 0, 1);

                currentStep = 0;
            }
            else
            {
                listBoxDropOutSteps.Items.RemoveAt(currentStep + 4); //add 2 because of first two entries of listbox (loops/delay)
                Array.Clear(m_specialTestParameters, currentStep-1, 1);
                currentStep--;
            }

        } 

        private void buttonOK_Click(object sender, EventArgs e)
        {
            m_testParameters.drop_volt_min = (int)numericUpDownDropVoltMin.Value;
            m_testParameters.phase = (int)numericUpDownPhase.Value;
            m_testParameters.drop_time_min = int.Parse(numericUpDownDropTimeMin.Text);
            m_testParameters.drop_time_min_units = comboBoxDropTimeMin.SelectedIndex;

            switch (m_testParameters.test_type)
            {
                case 1:     //single dropout
                default:
                    //do nothing
                    break;

                case 2:     //multiple of same dropout
                    m_testParameters.delay = int.Parse(numericUpDownDelay.Text);
                    m_testParameters.delay_units = comboBoxDelay.SelectedIndex;
                    m_testParameters.loops = (int)numericUpDownLoops.Value;
                    break;

                case 3:     //multiple incrementing dropouts
                    m_testParameters.drop_volt_step = int.Parse(numericUpDownDropVoltStep.Text);
                    m_testParameters.drop_volt_max = (int)numericUpDownDropVoltMax.Value;
                    
                    m_testParameters.drop_time_step = int.Parse(numericUpDownDropTimeStep.Text);
                    m_testParameters.drop_time_step_units = comboBoxDropTimeStep.SelectedIndex;
                    m_testParameters.drop_time_max = int.Parse(numericUpDownDropTimeMax.Text);
                    m_testParameters.drop_time_max_units = comboBoxDropTimeMax.SelectedIndex;

                    m_testParameters.delay = int.Parse(numericUpDownDelay.Text);
                    m_testParameters.delay_units = comboBoxDelay.SelectedIndex;
                    m_testParameters.loops = (int)numericUpDownLoops.Value;
                    break;

                case 4:

                    //multiple varying dropouts (custom list)               
                    m_testParameters.delay = int.Parse(numericUpDownDelay.Text);
                    m_testParameters.delay_units = comboBoxDelay.SelectedIndex;
                    m_testParameters.loops = (int)numericUpDownLoops.Value;

                    break;
            }

            //convert all times to ms
            m_testParameters.drop_time_min_ms = getTimeMs(m_testParameters.drop_time_min, m_testParameters.drop_time_min_units);
            m_testParameters.drop_time_step_ms = getTimeMs(m_testParameters.drop_time_step, m_testParameters.drop_time_step_units);
            m_testParameters.drop_time_max_ms = getTimeMs(m_testParameters.drop_time_max, m_testParameters.drop_time_max_units);
            m_testParameters.delay_ms = getTimeMs(m_testParameters.delay, m_testParameters.delay_units);

            if (paramCheck())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

     
        private void addDropOut(int index) //add dropout to list of custom dropouts
        {
            m_specialTestParameters[currentStep].drop_volt = (int)numericUpDownDropVoltMin.Value;
            m_specialTestParameters[currentStep].drop_time = (int)numericUpDownDropTimeMin.Value;
            m_specialTestParameters[currentStep].drop_time_units = comboBoxDropTimeMin.SelectedIndex;
            m_specialTestParameters[currentStep].phase = (int)numericUpDownPhase.Value;
        }

        private void populateListBox()
        {
            int count = 1;
            if (currentStep != 0)
            {
                listBoxDropOutSteps.Items.Add("Nominal Voltage: " + m_nominalParameters.voltage);
                listBoxDropOutSteps.Items.Add(" ");
                listBoxDropOutSteps.Items.Add("Loops:  " + numericUpDownLoops.Value);
                listBoxDropOutSteps.Items.Add("Delay:  " + numericUpDownDelay.Value + " " + comboBoxDelay.Text);
                listBoxDropOutSteps.Items.Add(" ");

                for (int i = 0; i < currentStep; i++)
                {
                     listBoxDropOutSteps.Items.Add("D" + count + ": " + m_specialTestParameters[i].drop_volt + "V, " + m_specialTestParameters[i].phase + "D, for " + m_specialTestParameters[i].drop_time + " " + comboBoxDropTimeMin.Text);
                     count++; 
                }
            }
        }

        private void numericUpDownDelay_ValueChanged(Object sender, EventArgs e)
        {
            if (loaded == 1)
            {
                if (currentStep > 0)
                {
                    listBoxDropOutSteps.Items.RemoveAt(3);
                    listBoxDropOutSteps.Items.Insert(3, "Delay:  " + numericUpDownDelay.Value + " " + comboBoxDelay.Text);
                }
            }
        }

        private void numericUpDownLoops_ValueChanged(Object sender, EventArgs e)
        {
            if(loaded == 1)
            {
                if (currentStep > 0)
                {
                    listBoxDropOutSteps.Items.RemoveAt(2);
                    listBoxDropOutSteps.Items.Insert(2, "Loops:  " + numericUpDownLoops.Value);
                }
            } 
        }

        private void comboBoxDelay_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (loaded == 1)
            {
                if (currentStep > 0)
                {
                    listBoxDropOutSteps.Items.RemoveAt(3);
                    listBoxDropOutSteps.Items.Insert(3, "Delay:  " + numericUpDownDelay.Value + " " + comboBoxDelay.Text);
                }
            }

        }

        private void DropoutParams_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK) //OK button was pressed, no dropouts in list 
            {
                if (currentStep == 0 && m_testParameters.test_type == 4)
                {
                    MessageBox.Show("At least one drop out required for test.", "Invalid Parameters", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
            }
        }

        public bool paramCheck()
        {
            bool result = true;
            string message = "";

            if (m_testParameters.test_type == 3)
            {
                if (m_testParameters.drop_volt_min >= m_testParameters.drop_volt_max)
                {
                    result = false;
                    message += "-Dropout voltage min larger than max\n";
                }
                else
                {
                    if (m_testParameters.drop_volt_step > (m_testParameters.drop_volt_max - m_testParameters.drop_volt_min))
                    {
                        result = false;
                        message += "-Voltage dropout step size too large\n";
                    }
                }

                if (m_testParameters.drop_time_min_ms >= m_testParameters.drop_time_max_ms)
                {
                    result = false;
                    message += "-Dropout time min larger than max\n";
                }
                else
                {
                    if (m_testParameters.drop_time_step_ms > (m_testParameters.drop_time_max_ms - m_testParameters.drop_time_min_ms))
                    {
                        result = false;
                        message += "-Voltage dropout step size too large\n";
                    }
                }

                if (m_testParameters.drop_time_max_ms > m_testParameters.delay_ms)
                {
                    result = false;
                    message += "-Delay time too short\n";
                }

                if (m_testParameters.drop_time_min_ms < minimumDropout)
                {
                    result = false;
                    message += "-Minimum dropout time must be larger than 1 cycle at " + m_nominalParameters.frequency + "Hz (" + minimumDropout + "ms)\n";
                }
            }

            if (m_testParameters.test_type == 4) //varying drop outs
            {
                if ((int)numericUpDownDropVoltMin.Value > m_nominalParameters.voltage)
                {
                    result = false;
                    message += "-Dropout voltage cannot be greater than nominal voltage";
                }
            }

            if (result == false)
                MessageBox.Show(message, "Invalid Parameters", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return result;
        }


    }
}

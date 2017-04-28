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
    public partial class testModeConfig : Form
    {
        public TestParameters m_testParameters;

        public testModeConfig()
        {
            InitializeComponent();
        }

        private void testModeConfig_Load(object sender, EventArgs e)
        {
            switch (m_testParameters.test_type)
            {
                case 1:
                default:
                    SingleButton.Checked = true;
                    MultipleButton.Checked = false;
                    AutomaticButton.Checked = false;
                    SpecialButton.Checked = false;

                    break;

                case 2:
                    SingleButton.Checked = false;
                    MultipleButton.Checked = true;
                    AutomaticButton.Checked = false;
                    SpecialButton.Checked = false;

                    break;

                case 3:
                    SingleButton.Checked = false;
                    MultipleButton.Checked = false;
                    AutomaticButton.Checked = true;
                    SpecialButton.Checked = false;

                    break;

                case 4:
                    SingleButton.Checked = false;
                    MultipleButton.Checked = false;
                    AutomaticButton.Checked = false;
                    SpecialButton.Checked = true;

                    break;
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if(SingleButton.Checked) //single drop out is selected
                m_testParameters.test_type = 1;
            else if(MultipleButton.Checked) //multiple idential drop outs
                m_testParameters.test_type = 2;
            else if(AutomaticButton.Checked)//multiple drop outs, incremening time/voltage selected
                m_testParameters.test_type = 3;
            else if(SpecialButton.Checked)//multiple drop outs, varying time/voltage
                m_testParameters.test_type = 4;
            else //single drop out is selected
                m_testParameters.test_type = 1;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void automatedCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

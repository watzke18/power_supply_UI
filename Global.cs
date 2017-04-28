using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;


namespace California_Instruments_CSW5550_Software
{
    public class Global
    {
        public int Voltage;
        public int Frequency;
        public int DropOutVoltage;
        public int DropOutPhase;
        public int DropOutTime;
        public int TestDelayTime;
        public int StepSize;
        public int VStepSize;
        public int MaxDropOutTime;

        public int MaxDropOutVoltage;
        public int MaxLoopCount;
        public int currentLoopCount;
        public int dev_addr;
        public int TestType;
        public int TestStatus;

        public int currentStep;
        public int totalSteps;

        public bool initialized;
        public bool StopTest;
        public bool ErrorOccured;
        public bool automated;

        public string DropOutUnits;
        public string MaxDropOutTimeUnits;
        public string TestDelayUnits;
        public string TimeStepSizeUnits;
        public string vrmsout;
        public string freqout;
        public string currout;
        public string error_msg;

        public string VoltageList;
        public string FrequencyList;
        public string DwellList;

        public const int MAX_STEPS = 1000000;   

        public serialComm m_Comm;
        public MainForm main_form;
        public SpecialDropOutRecord SpecialDropOut;

        public Step[] steps; //this will hold all steps in a test sequence

        public struct Step
        {
            public int stepVoltage;
            public int stepPhase;
            public int stepTime;
            public int stepFreq;
            public string stepUnits;
        }
        
        public struct SpecialDropOutRecord
        {
         
            public int n;           //number of dropouts
            public int InitVolts;
            public int InitFreq;
            public int MaxLoopCount;
            public int TestDelayTime;
            public string TestDelayUnits;

            //public DropOutRecord[] DropOut;
        }
        
        public Global(MainForm m1, serialComm s1)
        {
            m_Comm = s1;
            main_form = m1;
            SpecialDropOut = new SpecialDropOutRecord();
            //   SpecialDropOut.DropOut = new DropOutRecord[100];
        }

        public void buildStepArray() //for incrementing test ONLY
        {
            int i = 0;
            int j = 0;
            int count = 0;

            bool lastStep = false;

            //will build all steps based in ms for ease of timer
            int varyingVoltage;
            int maxVoltage;
            int varyingTime;
            int maxTime;
            int timeStepSize;
            int endStep;
            int endTime;

             varyingVoltage = DropOutVoltage;
             maxVoltage = MaxDropOutVoltage;

           // varyingTime = toMilliSeconds(DropOutTime, DropOutUnits);
            timeStepSize = toMilliSeconds(StepSize, TimeStepSizeUnits);
            maxTime = toMilliSeconds(MaxDropOutTime, MaxDropOutTimeUnits);

            currentLoopCount = 0;

            do
            {
                varyingTime = toMilliSeconds(DropOutTime, DropOutUnits);
                do
                {
                    varyingVoltage = DropOutVoltage;

                    //make sure you don't exceed max drop out time 
                    if (varyingTime >= maxTime)
                    {
                        if (varyingTime > maxTime)
                        {
                            endTime = varyingTime - timeStepSize;
                            endStep = maxTime - endTime;
                            varyingTime = endTime + endStep;
                        }
                            lastStep = true;
                    } 

                    do
                    {
                        //this block sets current step for control output back to nominal voltage after dropout
                        steps[i].stepVoltage = Voltage;
                        steps[i].stepPhase = DropOutPhase;
                        steps[i].stepTime = toMilliSeconds(TestDelayTime, TestDelayUnits);
                        steps[i].stepFreq = Frequency;
                        steps[i].stepUnits = "ms";
                        i++;

                        //dropout step
                        steps[i].stepVoltage = varyingVoltage;
                        steps[i].stepPhase = DropOutPhase;
                        steps[i].stepTime = varyingTime;
                        steps[i].stepFreq = Frequency;
                        steps[i].stepUnits = "ms";
                        i++;

                        varyingVoltage = varyingVoltage + VStepSize;

                    } while (varyingVoltage <= MaxDropOutVoltage);

                    varyingTime = varyingTime + timeStepSize;     
                } while (lastStep != true); //account for one time step greater than max time so time isn't cut short
                currentLoopCount = currentLoopCount + 1;
            } while (currentLoopCount != MaxLoopCount);

            //count steps
             while (steps[j].stepUnits != null)
              {
           
               count++;
                j++;
            }



            Array.Resize(ref steps, count);
            totalSteps = steps.Length;
      
        }

        public void addStep(int stepVoltage, int stepPhase, int stepTime, string stepUnits, int currentStep)
        {
            steps[currentStep].stepVoltage = stepVoltage;
            steps[currentStep].stepPhase = stepPhase;
            steps[currentStep].stepTime = stepTime;
            steps[currentStep].stepFreq = Frequency;
            steps[currentStep].stepUnits = stepUnits;
        }

      
    

        public int toMilliSeconds(int time, string unit)
        {
            int mSec;
            if(unit == "sec")
            {
                mSec = time * 1000;
            }
            else if(unit == "min")
            {
                mSec = time * 60000;
            }
            else
            {
                mSec = time;
            }

            return mSec;
        }

        public void csw_init()
        {
            //establish comm with comm port and csw5550
            //bool reply;
            //byte[] msg = new byte[50];

            steps = new Step[MAX_STEPS]; //create new step array that will hold all steps of the tst sequence
            currentStep = 0;
            //Reset the Elgar
            m_Comm.transmit_message("*RST");

            //Configure the output for correct voltage range
        

            //Reset the Output Sync to trgger only on selected segments
            m_Comm.transmit_message("SYST:SYNC 0");

            //Init. the output subsys for low freq operation (for faster output response)
            //note: this severely Degrades output load regulation at higher frequencies
            m_Comm.transmit_message("SYST:EXT:LOWFREQ 1");

            //Load the initial Sine wave from SW library
            m_Comm.transmit_message("SOURce:SINe:"); //check
            m_Comm.delay(300);

            if (Voltage > 156)
            {
                m_Comm.transmit_message("OUTPut:STATe 0");

                m_Comm.transmit_message("SOUR:VOLT:RANG 312");
                // m_Comm.transmit_message("SOURCE:VOLT:PROT:LEV 510");
            }
            //Edit sine wave output to the initialize parameters, Voltage & Frequency
            m_Comm.transmit_message("SOUR:VOLT:LEV:IMM:AMPL " + (Voltage.ToString()));
            m_Comm.transmit_message("SOUR:FREQ " + (Frequency.ToString()));

            //Enable the CSW output to the Initial settings
            m_Comm.transmit_message("OUTPut:STATe 1");


        }

        public int getValFromString(string str1)
        {
            int val;
            string[] strings = str1.Split('=');
            val = Convert.ToInt32(strings[1]);
            return val;
        }

        public string getUnitFromString(string str1)
        {
            string[] strings = str1.Split('=');
            return strings[1];
        }  
    }
}

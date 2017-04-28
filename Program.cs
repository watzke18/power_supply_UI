using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;

namespace California_Instruments_CSW5550_Software
{
    public class Program 
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        
   
       
        


    }

     
 }
   


     



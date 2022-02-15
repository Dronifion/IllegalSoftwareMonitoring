using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace IllegalSwDLPPoc
{
    public partial class Form3 : Form
    {
        private static string sDBWhiteListFullPath = Application.StartupPath + "\\..\\database\\whitelistdb.txt";

        public Form3()
        {
            InitializeComponent();
        }

        //Initial Form1, so that Form3 can update Form1 components.
        private Form1 mainForm = null;
        public Form3(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sExecDesc = "";
            string sExecPath = "";
            string sDBPath = "";

            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Process");

                //FileStream aFile = new FileStream("WhiteListData1.txt", FileMode.OpenOrCreate);
                //StreamWriter sw = new StreamWriter(aFile);
                
                sDBPath = sDBWhiteListFullPath;
                FileInfo bFile = new FileInfo(sDBPath);
                if (bFile.Exists)
                {
                    File.Delete(sDBPath);

                    //Write data onto database
                    StreamWriter sw = File.CreateText(sDBPath);

                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        //listBox2.Items.Add("ProcessId: {0}" + queryObj["ProcessId"] + " - " + "Description: {0}" + queryObj["Description"] + " - " + "ExecutablePath: {0}" + queryObj["ExecutablePath"]);

                        sExecDesc = Convert.ToString(queryObj["Description"]).ToUpper();
                        sExecPath = Convert.ToString(queryObj["ExecutablePath"]).ToUpper();
                        if (sExecPath == "") 
                            sExecPath = "NONE";

                        if ((listBox2.Items.Contains(sExecDesc) == false) || (listBox3.Items.Contains(sExecPath) == false))
                        {
                            listBox3.Items.Add(sExecPath);

                            listBox2.Items.Add(sExecDesc);

                            listBox1.Items.Add(sExecDesc + "," + sExecPath);

                            sw.WriteLine(sExecDesc + "," + sExecPath);
                        }

                    }

                    sw.Close();

                    this.mainForm.SignalTextFrm3 = "INITIATED";
                }

            }
            catch (ManagementException exp)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + exp.Message);
            }

        }
    }
}

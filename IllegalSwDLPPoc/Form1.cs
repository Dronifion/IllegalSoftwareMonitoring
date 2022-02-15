using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace IllegalSwDLPPoc
{
    public partial class Form1 : Form
    {
        private static string sDBWhiteListFullPath = Application.StartupPath + "\\..\\database\\whitelistdb.txt";

        public Form1()
        {
            InitializeComponent();
        }

        //Initial Form1, so that Form2 can update Form1 components.
        private string sSignalFrm2 = "";
        public string SignalTextFrm2
        {
            get { return sSignalFrm2; }
            set { sSignalFrm2 = value; }
        }

        //Initial Form1, so that Form3 can update Form1 components.
        private string sSignalFrm3 = "";
        public string SignalTextFrm3
        {
            get { return sSignalFrm3; }
            set { sSignalFrm3 = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Step 1
            UpdateList();

            //Step 2
            lblStatus.Text = "";
            btnCancelPolicy.Enabled = false;
        }

        private void UpdateList()
        {
            string line;

            try
            {
                FileStream aFile = new FileStream(sDBWhiteListFullPath, FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                cbLegal.Items.Clear();
                line = sr.ReadLine();

                // Read data in line by line.
                while (line != null)
                {
                    if (line != "")
                        cbLegal.Items.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                cbLegal.SelectedIndex = 0;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }


        private void btnSetPolicy_Click(object sender, EventArgs e)
        {
            try
            {

                if ((cbLegal.Items.Count == 0))
                {
                    MessageBox.Show("Enable to proceed. Make sure the white list is not empty.");
                }
                else
                {
                    //Step 1
                    ckbBlock.Enabled = false;
                    ckbKill.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnInitDB.Enabled = false;

                    //Step 2
                    SplitString(); //To split desc and path to 2 list box for further data manipulation
                    btnCancelPolicy.Enabled = true;
                    btnSetPolicy.Enabled = false;
                    lbInfo.Items.Add("Monitoring Started...");

                    //Timer
                    tmrMonitor.Enabled = true;

                    /*
                    ckbKill1.Checked = ckbKill.Checked;
                    ckbBlock1.Checked = ckbBlock.Checked;

                    //Update cbLegal1 with cbLegal contain
                    cbLegal1.Items.Clear();
                    foreach (string item in cbLegal.Items)
                    {
                        cbLegal1.Items.Add(item.ToString());
                    }

                    cbLegal1.SelectedIndex = 0;
                    **/


                };

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancelPolicy_Click(object sender, EventArgs e)
        {
            //Step 1
            ckbBlock.Enabled = true;
            ckbKill.Enabled = true;
            btnUpdate.Enabled = true;
            btnInitDB.Enabled = true;

            //Step 2
            btnCancelPolicy.Enabled = false;
            btnSetPolicy.Enabled = true;
            lbInfo.Items.Clear();
            lbInfo.Items.Add("Monitoring Stopped...");
            lblStatus.Text = "";

            //Step 2 - backend hidden listbox
            lbAppDesc.Items.Clear();
            lbAppPath.Items.Clear();

            //Timer
            tmrMonitor.Enabled = false;
        }

        private void SplitString()
        {
            string sAppDesc = "";
            string sAppPath = "";
            string[] saColumn;

            lbAppDesc.Items.Clear();
            lbAppPath.Items.Clear();

            try
            {
                foreach (string line in cbLegal.Items)
                {
                    if (line != "")
                    {
                        saColumn = line.Split(',');
                        sAppDesc = saColumn[0];
                        sAppPath = saColumn[1];

                        lbAppDesc.Items.Add(sAppDesc);
                        lbAppPath.Items.Add(sAppPath);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtInfo.Text = exp.Message;
            }

        }

        private bool FindMatch(string sAppPath)
        {          
            return lbAppPath.Items.Contains(sAppPath);
        }

        private void tmrMonitor_Tick(object sender, EventArgs e)
        {
                        
            string sExecDesc = "";
            string sExecPath = "";
            string sProcessID = "";
            bool bMatch = false;
            string sTerminateAppResult = "";

            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Process");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    //listBox2.Items.Add("ProcessId: {0}" + queryObj["ProcessId"] + " - " + "Description: {0}" + queryObj["Description"] + " - " + "ExecutablePath: {0}" + queryObj["ExecutablePath"]);

                    sExecDesc = Convert.ToString(queryObj["Description"]).ToUpper();
                    sExecPath = Convert.ToString(queryObj["ExecutablePath"]).ToUpper();
                    sProcessID = Convert.ToString(queryObj["ProcessId"]);

                    bMatch = FindMatch(sExecPath);

                    if ((sExecPath != "") && (bMatch == false) && (sExecPath != "C:\\Windows\\System32\\svchost.exe"))
                    {
                        if (ckbKill.Checked == true)
                        {
                            TerminateApp(sProcessID, out sTerminateAppResult);
                            if (sTerminateAppResult == "0")
                            {
                                lblStatus.Text = DateTime.Now.ToString() + ": Illegal application - [" + sExecDesc + "] has been successfully terminated.";
                                lbInfo.Items.Add(DateTime.Now.ToString() + ": Illegal Application - [" + sExecDesc + "] has been successfully terminated.");
                            }
                            else
                            {
                                lblStatus.Text = DateTime.Now.ToString() + ": Unable to terminate illegal application - [" + sExecDesc + "]. Error: " + sTerminateAppResult;
                                lbInfo.Items.Add(DateTime.Now.ToString() + ": Illegal application - [" + sExecDesc + "] has been successfully terminated.");
                            }
                        }
                        else
                        {
                            lblStatus.Text = DateTime.Now.ToString() + ": Illegal application - [" + sExecDesc + "] has been initiated.";
                            lbInfo.Items.Add(DateTime.Now.ToString() + ": Illegal Application - [" + sExecDesc + "] has been initiated.");
                        }
                    }

                }

            }
            catch (ManagementException exp)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + exp.Message);
            }
             

        }

        private static void TerminateApp(string sAppPath, out string sResult)
        {
            sResult = "";

            try
            {
                ManagementObject classInstance =
                    new ManagementObject("root\\CIMV2",
                    "Win32_Process.Handle='" + sAppPath + "'",
                    null);

                // Obtain in-parameters for the method
                ManagementBaseObject inParams =
                    classInstance.GetMethodParameters("Terminate");

                // Add the input parameters.

                // Execute the method and obtain the return values.
                ManagementBaseObject outParams =
                    classInstance.InvokeMethod("Terminate", inParams, null);

                // List outParams
                //Console.WriteLine("Out parameters:");
                //Console.WriteLine("ReturnValue: " + outParams["ReturnValue"]);

                sResult = Convert.ToString(outParams["ReturnValue"]);

                //MessageBox.Show("ReturnValue: " + outParams["ReturnValue"]);
            }
            catch (ManagementException err)
            {
                MessageBox.Show("An error occurred while trying to execute the WMI method: " + err.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);

            frm.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (sSignalFrm2 == "SAVED")
            {
                UpdateList();
                sSignalFrm2 = "";
            }

            if (sSignalFrm3 == "INITIATED")
            {
                UpdateList();
                sSignalFrm3 = "";
            }
            
        }

        private void btnInitDB_Click(object sender, EventArgs e)
        {
            btnCancelPolicy.PerformClick();

            Form3 frm = new Form3(this);

            frm.Show();

        }
    }
}

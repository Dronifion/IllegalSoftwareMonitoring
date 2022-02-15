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
    public partial class Form2 : Form
    {
        private static string sDBWhiteListFullPath = Application.StartupPath + "\\..\\database\\whitelistdb.txt";

        public Form2()
        {
            InitializeComponent();
        }

        //Initial Form1, so that Form2 can update Form1 components.
        private Form1 mainForm = null;
        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void UpdateList()
        {
            string line;

            try
            {
                FileStream aFile = new FileStream(sDBWhiteListFullPath, FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                lbWhiteList.Items.Clear();
                line = sr.ReadLine();

                // Read data in line by line.
                lbWhiteList.BeginUpdate();
                while (line != null)
                {
                    if (line != "")
                        lbWhiteList.Items.Add(line);
                    line = sr.ReadLine();
                }
                lbWhiteList.EndUpdate();
                sr.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateList();
            lbWhiteList.Sorted = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string line = "";
            string sDBPath = "";
            try
            {
                //foreach (string line in lbWhiteList.Items)
                //{
                //    if ( line != "" )
                //        sw.WriteLine(line);   
                //}


                sDBPath = sDBWhiteListFullPath;
                FileInfo bFile = new FileInfo(sDBPath);
                if (bFile.Exists)
                {
                    File.Delete(sDBPath);

                    //Write data onto database
                    StreamWriter sw = File.CreateText(sDBPath);
                    for (int i = 0; i < lbWhiteList.Items.Count; i++)
                    {
                        line = lbWhiteList.Items[i].ToString();
                        if (line != "")
                        {
                            sw.WriteLine(line);
                        }
                    }
                    sw.Close();
                }
                else
                {
                    MessageBox.Show("White list database does not exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MessageBox.Show("White list saved");

                UpdateList();
                this.mainForm.SignalTextFrm2 = "SAVED";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbWhiteList.BeginUpdate();

            if (lbWhiteList.SelectedIndex != -1)
                lbWhiteList.Items.RemoveAt(lbWhiteList.SelectedIndex);

            lbWhiteList.EndUpdate();
            lbWhiteList.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool bMatch = false;

            if (txtNew.Text != "")
            {
                bMatch = lbWhiteList.Items.Contains(txtNew.Text.ToUpper().Trim());

                if (bMatch == false)
                    lbWhiteList.Items.Add(txtNew.Text.ToUpper().Trim());
                else
                    MessageBox.Show("Application already exist!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbWhiteList.Sorted = true;
        }

        private void lbWhiteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbWhiteList.SelectedIndex != -1)
                txtNew.Text = lbWhiteList.Items[lbWhiteList.SelectedIndex].ToString();
             
        }


    }
}

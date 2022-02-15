namespace IllegalSwDLPPoc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tmrMonitor = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbLegal = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckbBlock = new System.Windows.Forms.CheckBox();
            this.ckbKill = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnInitDB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelPolicy = new System.Windows.Forms.Button();
            this.btnSetPolicy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.lbAppPath = new System.Windows.Forms.ListBox();
            this.lbAppDesc = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tmrMonitor
            // 
            this.tmrMonitor.Interval = 1000;
            this.tmrMonitor.Tick += new System.EventHandler(this.tmrMonitor_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(565, 390);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(557, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Step 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnCancelPolicy);
            this.tabPage2.Controls.Add(this.btnSetPolicy);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(557, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Step 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Step 1 - Define Security Policy (In the Server)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbLegal);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(20, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 76);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Define Legal Software White List";
            // 
            // cbLegal
            // 
            this.cbLegal.FormattingEnabled = true;
            this.cbLegal.Items.AddRange(new object[] {
            "abc",
            "def"});
            this.cbLegal.Location = new System.Drawing.Point(103, 24);
            this.cbLegal.Name = "cbLegal";
            this.cbLegal.Size = new System.Drawing.Size(364, 21);
            this.cbLegal.TabIndex = 24;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(473, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(33, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "... ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Legal Software:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ckbBlock);
            this.groupBox4.Controls.Add(this.ckbKill);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(20, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 73);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Define Action Taken Against Illegal Software";
            // 
            // ckbBlock
            // 
            this.ckbBlock.AutoSize = true;
            this.ckbBlock.Location = new System.Drawing.Point(302, 33);
            this.ckbBlock.Name = "ckbBlock";
            this.ckbBlock.Size = new System.Drawing.Size(122, 17);
            this.ckbBlock.TabIndex = 26;
            this.ckbBlock.Text = "Set Block at Firewall";
            this.ckbBlock.UseVisualStyleBackColor = true;
            this.ckbBlock.Visible = false;
            // 
            // ckbKill
            // 
            this.ckbKill.AutoSize = true;
            this.ckbKill.Location = new System.Drawing.Point(170, 33);
            this.ckbKill.Name = "ckbKill";
            this.ckbKill.Size = new System.Drawing.Size(118, 17);
            this.ckbKill.TabIndex = 25;
            this.ckbKill.Text = "Terminate Software";
            this.ckbKill.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Action On Illegal Software:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnInitDB);
            this.groupBox5.Location = new System.Drawing.Point(20, 247);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(521, 82);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tool - Reinitiate the White List Database";
            // 
            // btnInitDB
            // 
            this.btnInitDB.Location = new System.Drawing.Point(22, 29);
            this.btnInitDB.Name = "btnInitDB";
            this.btnInitDB.Size = new System.Drawing.Size(476, 23);
            this.btnInitDB.TabIndex = 10;
            this.btnInitDB.Text = "Click here to reinitiate the white list database";
            this.btnInitDB.UseVisualStyleBackColor = true;
            this.btnInitDB.Click += new System.EventHandler(this.btnInitDB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Step 2 - Start the monitoring process. (At the endpoint)";
            // 
            // btnCancelPolicy
            // 
            this.btnCancelPolicy.Location = new System.Drawing.Point(295, 65);
            this.btnCancelPolicy.Name = "btnCancelPolicy";
            this.btnCancelPolicy.Size = new System.Drawing.Size(242, 23);
            this.btnCancelPolicy.TabIndex = 19;
            this.btnCancelPolicy.Text = "Click here to stop the monitoring process";
            this.btnCancelPolicy.UseVisualStyleBackColor = true;
            this.btnCancelPolicy.Click += new System.EventHandler(this.btnCancelPolicy_Click);
            // 
            // btnSetPolicy
            // 
            this.btnSetPolicy.Location = new System.Drawing.Point(20, 65);
            this.btnSetPolicy.Name = "btnSetPolicy";
            this.btnSetPolicy.Size = new System.Drawing.Size(269, 23);
            this.btnSetPolicy.TabIndex = 18;
            this.btnSetPolicy.Text = "Click here to start the monitoring process";
            this.btnSetPolicy.UseVisualStyleBackColor = true;
            this.btnSetPolicy.Click += new System.EventHandler(this.btnSetPolicy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbInfo);
            this.groupBox2.Controls.Add(this.lbAppPath);
            this.groupBox2.Controls.Add(this.lbAppDesc);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Location = new System.Drawing.Point(20, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 251);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Illegal Software Monitoring Status:";
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.HorizontalScrollbar = true;
            this.lbInfo.Location = new System.Drawing.Point(21, 52);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(478, 186);
            this.lbInfo.TabIndex = 8;
            // 
            // lbAppPath
            // 
            this.lbAppPath.FormattingEnabled = true;
            this.lbAppPath.HorizontalScrollbar = true;
            this.lbAppPath.Location = new System.Drawing.Point(212, 35);
            this.lbAppPath.Name = "lbAppPath";
            this.lbAppPath.Size = new System.Drawing.Size(241, 173);
            this.lbAppPath.TabIndex = 7;
            this.lbAppPath.Visible = false;
            // 
            // lbAppDesc
            // 
            this.lbAppDesc.FormattingEnabled = true;
            this.lbAppDesc.HorizontalScrollbar = true;
            this.lbAppDesc.Location = new System.Drawing.Point(73, 35);
            this.lbAppDesc.Name = "lbAppDesc";
            this.lbAppDesc.Size = new System.Drawing.Size(120, 173);
            this.lbAppDesc.TabIndex = 6;
            this.lbAppDesc.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(18, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(481, 30);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLP Agent Function (Illegal Software Tracking) POC";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Timer tmrMonitor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbLegal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ckbBlock;
        private System.Windows.Forms.CheckBox ckbKill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnInitDB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.ListBox lbAppPath;
        private System.Windows.Forms.ListBox lbAppDesc;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCancelPolicy;
        private System.Windows.Forms.Button btnSetPolicy;
        private System.Windows.Forms.Label label6;
    }
}


namespace PNoise3D
{
    partial class BatchProcessing
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbExtension = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIndexInt = new System.Windows.Forms.CheckBox();
            this.chkIndexChar = new System.Windows.Forms.CheckBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.btnSetOutputdir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetOutputdir);
            this.groupBox1.Controls.Add(this.txtOutputDir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudCount);
            this.groupBox1.Controls.Add(this.chkIndexChar);
            this.groupBox1.Controls.Add(this.chkIndexInt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cmbExtension);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.lstLog);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(96, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Format";
            // 
            // cmbExtension
            // 
            this.cmbExtension.FormattingEnabled = true;
            this.cmbExtension.Items.AddRange(new object[] {
            "*.bmp",
            "*.png",
            "*.jpeg"});
            this.cmbExtension.Location = new System.Drawing.Point(114, 32);
            this.cmbExtension.Name = "cmbExtension";
            this.cmbExtension.Size = new System.Drawing.Size(96, 21);
            this.cmbExtension.TabIndex = 3;
            this.cmbExtension.Text = "=choose=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "G";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "A";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(105, 31);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(27, 20);
            this.txtB.TabIndex = 26;
            this.txtB.Text = "255";
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(72, 31);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(27, 20);
            this.txtG.TabIndex = 25;
            this.txtG.Text = "255";
            this.txtG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtG_KeyPress);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(39, 31);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(27, 20);
            this.txtR.TabIndex = 24;
            this.txtR.Text = "255";
            this.txtR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtR_KeyPress);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(6, 31);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(27, 20);
            this.txtA.TabIndex = 22;
            this.txtA.Text = "255";
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtA);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtR);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtG);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(216, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ColorARGB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Indexing Settings";
            // 
            // chkIndexInt
            // 
            this.chkIndexInt.AutoSize = true;
            this.chkIndexInt.Checked = true;
            this.chkIndexInt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIndexInt.Location = new System.Drawing.Point(9, 86);
            this.chkIndexInt.Name = "chkIndexInt";
            this.chkIndexInt.Size = new System.Drawing.Size(109, 17);
            this.chkIndexInt.TabIndex = 5;
            this.chkIndexInt.Text = "integer (01,02,03)";
            this.chkIndexInt.UseVisualStyleBackColor = true;
            // 
            // chkIndexChar
            // 
            this.chkIndexChar.AutoSize = true;
            this.chkIndexChar.Location = new System.Drawing.Point(124, 86);
            this.chkIndexChar.Name = "chkIndexChar";
            this.chkIndexChar.Size = new System.Drawing.Size(98, 17);
            this.chkIndexChar.TabIndex = 6;
            this.chkIndexChar.Text = "char (aa,ab,ac)";
            this.chkIndexChar.UseVisualStyleBackColor = true;
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(6, 17);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(354, 95);
            this.lstLog.TabIndex = 0;
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(313, 83);
            this.nudCount.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(43, 20);
            this.nudCount.TabIndex = 7;
            this.nudCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "How many:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Output dir:";
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PNoise3D.Properties.Settings.Default, "batchOutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtOutputDir.Location = new System.Drawing.Point(68, 113);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(239, 20);
            this.txtOutputDir.TabIndex = 10;
            this.txtOutputDir.Text = global::PNoise3D.Properties.Settings.Default.batchOutputDir;
            // 
            // btnSetOutputdir
            // 
            this.btnSetOutputdir.Location = new System.Drawing.Point(313, 111);
            this.btnSetOutputdir.Name = "btnSetOutputdir";
            this.btnSetOutputdir.Size = new System.Drawing.Size(43, 23);
            this.btnSetOutputdir.TabIndex = 1;
            this.btnSetOutputdir.Text = "Set";
            this.btnSetOutputdir.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(47, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(313, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // BatchProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BatchProcessing";
            this.Text = "Batch Processing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetOutputdir;
        private System.Windows.Forms.TextBox txtOutputDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.CheckBox chkIndexChar;
        private System.Windows.Forms.CheckBox chkIndexInt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
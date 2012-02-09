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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchProcessing));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetOutputdir = new System.Windows.Forms.Button();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.chkIndexChar = new System.Windows.Forms.CheckBox();
            this.chkIndexInt = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbExtension = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkCustom = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHeigth = new System.Windows.Forms.TextBox();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSetRandomSeed = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetRandomSeed);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtSeed);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtHeigth);
            this.groupBox1.Controls.Add(this.chkCustom);
            this.groupBox1.Controls.Add(this.btnSetOutputdir);
            this.groupBox1.Controls.Add(this.txtDimension);
            this.groupBox1.Controls.Add(this.txtOutputDir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkIndexChar);
            this.groupBox1.Controls.Add(this.nudCount);
            this.groupBox1.Controls.Add(this.chkIndexInt);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cmbExtension);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // btnSetOutputdir
            // 
            this.btnSetOutputdir.Location = new System.Drawing.Point(251, 106);
            this.btnSetOutputdir.Name = "btnSetOutputdir";
            this.btnSetOutputdir.Size = new System.Drawing.Size(43, 23);
            this.btnSetOutputdir.TabIndex = 1;
            this.btnSetOutputdir.Text = "Set";
            this.btnSetOutputdir.UseVisualStyleBackColor = true;
            this.btnSetOutputdir.Click += new System.EventHandler(this.btnSetOutputdir_Click);
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PNoise3D.Properties.Settings.Default, "batchOutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtOutputDir.Location = new System.Drawing.Point(9, 108);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(236, 20);
            this.txtOutputDir.TabIndex = 10;
            this.txtOutputDir.Text = global::PNoise3D.Properties.Settings.Default.batchOutputDir;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Output dir:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Count";
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(251, 32);
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
            // chkIndexChar
            // 
            this.chkIndexChar.AutoSize = true;
            this.chkIndexChar.Location = new System.Drawing.Point(124, 147);
            this.chkIndexChar.Name = "chkIndexChar";
            this.chkIndexChar.Size = new System.Drawing.Size(98, 17);
            this.chkIndexChar.TabIndex = 6;
            this.chkIndexChar.Text = "char (aa,ab,ac)";
            this.chkIndexChar.UseVisualStyleBackColor = true;
            // 
            // chkIndexInt
            // 
            this.chkIndexInt.AutoSize = true;
            this.chkIndexInt.Checked = true;
            this.chkIndexInt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIndexInt.Location = new System.Drawing.Point(9, 147);
            this.chkIndexInt.Name = "chkIndexInt";
            this.chkIndexInt.Size = new System.Drawing.Size(109, 17);
            this.chkIndexInt.TabIndex = 5;
            this.chkIndexInt.Text = "integer (01,02,03)";
            this.chkIndexInt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Indexing Settings";
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
            this.groupBox3.Location = new System.Drawing.Point(309, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ColorARGB";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(17, 31);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(27, 20);
            this.txtA.TabIndex = 22;
            this.txtA.Text = "255";
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "B";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(50, 31);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(27, 20);
            this.txtR.TabIndex = 24;
            this.txtR.Text = "255";
            this.txtR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtR_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "G";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(83, 31);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(27, 20);
            this.txtG.TabIndex = 25;
            this.txtG.Text = "255";
            this.txtG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtG_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "R";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(116, 31);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(27, 20);
            this.txtB.TabIndex = 26;
            this.txtB.Text = "255";
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "A";
            // 
            // cmbExtension
            // 
            this.cmbExtension.FormattingEnabled = true;
            this.cmbExtension.Items.AddRange(new object[] {
            ".bmp",
            ".png",
            ".jpeg"});
            this.cmbExtension.Location = new System.Drawing.Point(131, 32);
            this.cmbExtension.Name = "cmbExtension";
            this.cmbExtension.Size = new System.Drawing.Size(114, 21);
            this.cmbExtension.TabIndex = 3;
            this.cmbExtension.Text = "=select=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File extension";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "output";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLog);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 319);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(297, 19);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(6, 17);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(458, 95);
            this.lstLog.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(406, 317);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // chkCustom
            // 
            this.chkCustom.AutoSize = true;
            this.chkCustom.Location = new System.Drawing.Point(228, 147);
            this.chkCustom.Name = "chkCustom";
            this.chkCustom.Size = new System.Drawing.Size(70, 17);
            this.chkCustom.TabIndex = 11;
            this.chkCustom.Text = "Custom >";
            this.chkCustom.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "alpha,beta,gamma,epsilon,zeta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Height";
            // 
            // txtHeigth
            // 
            this.txtHeigth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeigth.Location = new System.Drawing.Point(68, 69);
            this.txtHeigth.Name = "txtHeigth";
            this.txtHeigth.Size = new System.Drawing.Size(35, 20);
            this.txtHeigth.TabIndex = 15;
            this.txtHeigth.Text = "128";
            this.txtHeigth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeigth_KeyPress);
            // 
            // txtDimension
            // 
            this.txtDimension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDimension.Location = new System.Drawing.Point(9, 69);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(53, 20);
            this.txtDimension.TabIndex = 14;
            this.txtDimension.Text = "1024";
            this.txtDimension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDimension_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Dimension";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(309, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 60);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // btnSetRandomSeed
            // 
            this.btnSetRandomSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetRandomSeed.Location = new System.Drawing.Point(230, 69);
            this.btnSetRandomSeed.Name = "btnSetRandomSeed";
            this.btnSetRandomSeed.Size = new System.Drawing.Size(64, 21);
            this.btnSetRandomSeed.TabIndex = 36;
            this.btnSetRandomSeed.Text = "Random";
            this.btnSetRandomSeed.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(128, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Seed";
            // 
            // txtSeed
            // 
            this.txtSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeed.Location = new System.Drawing.Point(131, 69);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(93, 20);
            this.txtSeed.TabIndex = 34;
            this.txtSeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeed_KeyPress);
            // 
            // BatchProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BatchProcessing";
            this.Text = "Batch Processing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BatchProcessing_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button btnStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkCustom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHeigth;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSetRandomSeed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSeed;
    }
}
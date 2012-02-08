﻿using System.Drawing;
using System.Windows.Forms;

namespace PNoise3D
{
    partial class MainForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetRandomSeed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.txtHeigth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbWatercolor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.chkCustomColor = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblxChunks = new System.Windows.Forms.Label();
            this.lblzChunks = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnFullscreen = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(455, 383);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 21);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generieren";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(374, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Beenden";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSeed
            // 
            this.txtSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeed.Location = new System.Drawing.Point(374, 25);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(88, 20);
            this.txtSeed.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seed";
            // 
            // btnSetRandomSeed
            // 
            this.btnSetRandomSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetRandomSeed.Location = new System.Drawing.Point(468, 25);
            this.btnSetRandomSeed.Name = "btnSetRandomSeed";
            this.btnSetRandomSeed.Size = new System.Drawing.Size(62, 21);
            this.btnSetRandomSeed.TabIndex = 5;
            this.btnSetRandomSeed.Text = "Random";
            this.btnSetRandomSeed.UseVisualStyleBackColor = true;
            this.btnSetRandomSeed.Click += new System.EventHandler(this.btnSetRandomSeed_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dimension";
            // 
            // txtDimension
            // 
            this.txtDimension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDimension.Location = new System.Drawing.Point(374, 64);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(75, 20);
            this.txtDimension.TabIndex = 7;
            this.txtDimension.Text = "1024";
            // 
            // txtHeigth
            // 
            this.txtHeigth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeigth.Location = new System.Drawing.Point(455, 64);
            this.txtHeigth.Name = "txtHeigth";
            this.txtHeigth.Size = new System.Drawing.Size(75, 20);
            this.txtHeigth.TabIndex = 8;
            this.txtHeigth.Text = "128";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Höhe";
            // 
            // cmbWatercolor
            // 
            this.cmbWatercolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWatercolor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWatercolor.FormattingEnabled = true;
            this.cmbWatercolor.Location = new System.Drawing.Point(374, 127);
            this.cmbWatercolor.Name = "cmbWatercolor";
            this.cmbWatercolor.Size = new System.Drawing.Size(156, 21);
            this.cmbWatercolor.TabIndex = 10;
            this.cmbWatercolor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbWatercolor_DrawItem);
            this.cmbWatercolor.SelectedIndexChanged += new System.EventHandler(this.cmbWatercolor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wasserfarbe";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlpha.Location = new System.Drawing.Point(495, 101);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(35, 20);
            this.txtAlpha.TabIndex = 12;
            this.txtAlpha.Text = "128";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Alpha";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtG);
            this.groupBox1.Controls.Add(this.txtR);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(374, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 63);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Eigene Farbe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "G";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "A";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(114, 37);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(27, 20);
            this.txtB.TabIndex = 18;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(81, 37);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(27, 20);
            this.txtG.TabIndex = 17;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(48, 37);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(27, 20);
            this.txtR.TabIndex = 16;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(15, 37);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(27, 20);
            this.txtA.TabIndex = 15;
            // 
            // chkCustomColor
            // 
            this.chkCustomColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCustomColor.AutoSize = true;
            this.chkCustomColor.Location = new System.Drawing.Point(374, 163);
            this.chkCustomColor.Name = "chkCustomColor";
            this.chkCustomColor.Size = new System.Drawing.Size(15, 14);
            this.chkCustomColor.TabIndex = 22;
            this.chkCustomColor.UseVisualStyleBackColor = true;
            this.chkCustomColor.CheckedChanged += new System.EventHandler(this.chkCustomColor_CheckedChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(371, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "xChunks:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(371, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "zChunks | overall:";
            // 
            // lblxChunks
            // 
            this.lblxChunks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblxChunks.Location = new System.Drawing.Point(455, 235);
            this.lblxChunks.Name = "lblxChunks";
            this.lblxChunks.Size = new System.Drawing.Size(75, 13);
            this.lblxChunks.TabIndex = 27;
            this.lblxChunks.Text = "0";
            this.lblxChunks.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblzChunks
            // 
            this.lblzChunks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblzChunks.Location = new System.Drawing.Point(455, 248);
            this.lblzChunks.Name = "lblzChunks";
            this.lblzChunks.Size = new System.Drawing.Size(75, 13);
            this.lblzChunks.TabIndex = 28;
            this.lblzChunks.Text = "0";
            this.lblzChunks.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(455, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.Filter = "\"Bitmap File|*.bmp\"";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(374, 356);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 21);
            this.btnAbout.TabIndex = 30;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullscreen.Location = new System.Drawing.Point(374, 329);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(156, 21);
            this.btnFullscreen.TabIndex = 31;
            this.btnFullscreen.Text = "Fullscreen";
            this.btnFullscreen.UseVisualStyleBackColor = true;
            this.btnFullscreen.Click += new System.EventHandler(this.btnFullscreen_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Render Target";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PNoise3D.Properties.Resources._155x60_AldoGiese1;
            this.pictureBox2.Location = new System.Drawing.Point(374, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 60);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 416);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnFullscreen);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblzChunks);
            this.Controls.Add(this.lblxChunks);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkCustomColor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlpha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbWatercolor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeigth);
            this.Controls.Add(this.txtDimension);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSetRandomSeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Perlin Noise3D Map Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetRandomSeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.TextBox txtHeigth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbWatercolor;
        private System.Windows.Forms.Label label4;

        private void cmbWatercolor_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;

            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }

        private TextBox txtAlpha;
        private Label label5;
        private GroupBox groupBox1;
        private CheckBox chkCustomColor;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtB;
        private TextBox txtG;
        private TextBox txtR;
        private TextBox txtA;
        private Label label11;
        private Label label12;
        private Label lblxChunks;
        private Label lblzChunks;
        private Timer timer1;
        private Button btnSave;
        private SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnAbout;
        private Button btnFullscreen;
        private PictureBox pictureBox2;
        private Label label10;
    }
}


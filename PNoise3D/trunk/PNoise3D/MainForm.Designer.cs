#region License | GNU GPL v3
//Perlin Noise 3D Map Generator - Generate random Perlin Noise 3D Bitmaps for further using in Game Development
//Copyright (C) 2012  Aldo Giese

//This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License 
//as published by the Free Software Foundation; either version 3 of the License, or (at your option) any later version.
//This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty
//of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.

//You should have received a copy of the GNU General Public License along with this program;
//if not, see <http://www.gnu.org/licenses/>.
#endregion

using System.Drawing;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkMinimalview = new System.Windows.Forms.CheckBox();
            this.btnBatch = new System.Windows.Forms.Button();
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
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerateClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(374, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Quit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // txtSeed
            // 
            this.txtSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeed.Location = new System.Drawing.Point(374, 25);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(88, 20);
            this.txtSeed.TabIndex = 3;
            this.txtSeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeed_KeyPress);
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
            this.btnSetRandomSeed.Click += new System.EventHandler(this.BtnSetRandomSeedClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dimension";
            // 
            // txtDimension
            // 
            this.txtDimension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDimension.Location = new System.Drawing.Point(374, 66);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(75, 20);
            this.txtDimension.TabIndex = 7;
            this.txtDimension.Text = "1024";
            this.txtDimension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDimension_KeyPress);
            // 
            // txtHeigth
            // 
            this.txtHeigth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeigth.Location = new System.Drawing.Point(455, 66);
            this.txtHeigth.Name = "txtHeigth";
            this.txtHeigth.Size = new System.Drawing.Size(75, 20);
            this.txtHeigth.TabIndex = 8;
            this.txtHeigth.Text = "128";
            this.txtHeigth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeigth_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height";
            // 
            // cmbWatercolor
            // 
            this.cmbWatercolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWatercolor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWatercolor.FormattingEnabled = true;
            this.cmbWatercolor.Location = new System.Drawing.Point(374, 116);
            this.cmbWatercolor.Name = "cmbWatercolor";
            this.cmbWatercolor.Size = new System.Drawing.Size(156, 21);
            this.cmbWatercolor.TabIndex = 10;
            this.cmbWatercolor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbWatercolor_DrawItem);
            this.cmbWatercolor.SelectedIndexChanged += new System.EventHandler(this.CmbWatercolorSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Watercolor";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlpha.Location = new System.Drawing.Point(495, 90);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(35, 20);
            this.txtAlpha.TabIndex = 12;
            this.txtAlpha.Text = "128";
            this.txtAlpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlpha_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 93);
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
            this.groupBox1.Location = new System.Drawing.Point(374, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 63);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Custom Color";
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
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(81, 37);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(27, 20);
            this.txtG.TabIndex = 17;
            this.txtG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtG_KeyPress);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(48, 37);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(27, 20);
            this.txtR.TabIndex = 16;
            this.txtR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtR_KeyPress);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(15, 37);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(27, 20);
            this.txtA.TabIndex = 15;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // chkCustomColor
            // 
            this.chkCustomColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCustomColor.AutoSize = true;
            this.chkCustomColor.Location = new System.Drawing.Point(374, 143);
            this.chkCustomColor.Name = "chkCustomColor";
            this.chkCustomColor.Size = new System.Drawing.Size(15, 14);
            this.chkCustomColor.TabIndex = 22;
            this.chkCustomColor.UseVisualStyleBackColor = true;
            this.chkCustomColor.CheckedChanged += new System.EventHandler(this.ChkCustomColorCheckedChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(371, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "xChunks:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(371, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "zChunks | overall:";
            // 
            // lblxChunks
            // 
            this.lblxChunks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblxChunks.Location = new System.Drawing.Point(455, 209);
            this.lblxChunks.Name = "lblxChunks";
            this.lblxChunks.Size = new System.Drawing.Size(75, 13);
            this.lblxChunks.TabIndex = 27;
            this.lblxChunks.Text = "0";
            this.lblxChunks.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblzChunks
            // 
            this.lblzChunks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblzChunks.Location = new System.Drawing.Point(455, 222);
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
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "output";
            this.saveFileDialog1.Filter = "Bitmap File(*.png)|*.bmp | PNG Graphic(*.png) |*.png | Jpeg Graphic(*.jpeg)|*.jpe" +
                "g";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1RunWorkerCompleted);
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
            this.btnAbout.Click += new System.EventHandler(this.BtnAboutClick);
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullscreen.Location = new System.Drawing.Point(455, 329);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(75, 21);
            this.btnFullscreen.TabIndex = 31;
            this.btnFullscreen.Text = "Fullscreen";
            this.btnFullscreen.UseVisualStyleBackColor = true;
            this.btnFullscreen.Click += new System.EventHandler(this.BtnFullscreenClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::PNoise3D.Properties.Resources._155x60_AldoGiese1;
            this.pictureBox2.Location = new System.Drawing.Point(374, 238);
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
            // chkMinimalview
            // 
            this.chkMinimalview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMinimalview.AutoSize = true;
            this.chkMinimalview.Checked = global::PNoise3D.Properties.Settings.Default.minimalView;
            this.chkMinimalview.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PNoise3D.Properties.Settings.Default, "minimalView", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkMinimalview.Location = new System.Drawing.Point(442, 306);
            this.chkMinimalview.Name = "chkMinimalview";
            this.chkMinimalview.Size = new System.Drawing.Size(87, 17);
            this.chkMinimalview.TabIndex = 33;
            this.chkMinimalview.Text = "Minimal View";
            this.chkMinimalview.UseVisualStyleBackColor = true;
            this.chkMinimalview.CheckedChanged += new System.EventHandler(this.chkMinimalview_CheckedChanged);
            // 
            // btnBatch
            // 
            this.btnBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatch.Location = new System.Drawing.Point(374, 329);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(75, 21);
            this.btnBatch.TabIndex = 34;
            this.btnBatch.Text = "Batch";
            this.btnBatch.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 416);
            this.Controls.Add(this.btnBatch);
            this.Controls.Add(this.chkMinimalview);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
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
        private CheckBox chkMinimalview;
        private Button btnBatch;
    }
}


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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PNoise3D
{
    public partial class MainForm : Form
    {
        #region Member Data ------------------------------------------------------------------------------

        /// <summary>
        /// The Target Bitmap to Render
        /// </summary>
        private Bitmap _bmp;

        /// <summary>
        /// The Random Seed
        /// </summary>
        private Int32 _seed;

        /// <summary>
        /// Dimension
        /// </summary>
        private Int32 _dimension;

        /// <summary>
        /// World Height
        /// </summary>
        private Int32 _height;

        /// <summary>
        /// List of System Colors
        /// </summary>
        private readonly List<Color> _colorList = new List<Color>();

        /// <summary>
        /// Single color that fill be used for fill in system colors
        /// </summary>
        private Color _colors = Color.Empty;

        /// <summary>
        /// Random generator
        /// </summary>
        private Random _rnd;


        /// <summary>
        /// All zChunks
        /// </summary>
        private int _overallzChunks;

        /// <summary>
        /// If we use Custom colors?
        /// </summary>
        private bool _useCustomColor;

        /// <summary>
        /// ARGB color values
        /// </summary>
        private int _a, _r, _g, _b;

        #endregion ---------------------------------------------------------------------------------------

        #region Contructors ------------------------------------------------------------------------------

        public MainForm()
        {
            InitializeComponent();
            Size = Properties.Settings.Default.minimalView ? new Size(185, Size.Height) : new Size(548, Size.Height);
            GetComboBoxColors();
            SetRandomSeed();
        }

        #endregion ---------------------------------------------------------------------------------------

        #region Events -----------------------------------------------------------------------------------

        private void BackgroundWorker1DoWork(object sender, DoWorkEventArgs e)
        {
            _dimension = Convert.ToInt32(txtDimension.Text);
            _height = Convert.ToInt32(txtHeigth.Text);
            _seed = Convert.ToInt32(txtSeed.Text);

            _bmp = new Bitmap(_dimension, _dimension, PixelFormat.Format32bppArgb);
            pictureBox1.Image = _bmp;


            var cmb = e.Argument;

            PerlinNoise3D perlinNoise3D = new PerlinNoise3D(_seed);


            for (int xChunk = 0; xChunk < _dimension; xChunk += 16)
            {

                InvokeIfRequired(lblxChunks, (MethodInvoker)delegate
                {
                    lblxChunks.Text = xChunk.ToString();
                });

                for (int zChunk = 0; zChunk < _dimension; zChunk += 16)
                {
                    _overallzChunks += 16;

                    InvokeIfRequired(lblzChunks, (MethodInvoker)delegate
                    {
                        lblzChunks.Text = string.Format("{0}|{1}",
                                                        zChunk,
                                                        _overallzChunks);
                    });


                    int[,] buffer = new int[16, 16];

                    for (int y = 0; y < _height; y++)
                    {
                        Single heightmod = (Single)((((Double)y / _height) - 0.5) * 2);

                        for (int x = 0; x < 16; x++)
                            for (int z = 0; z < 16; z++)
                            {
                                Single value = heightmod +
                                               perlinNoise3D.GetValue(x + xChunk, y, z + zChunk, .01875f, 1f, .5f, 8);

                                if (value <= 0)
                                    buffer[x, z] = y;
                            }
                    }
                    try
                    {
                        using (Graphics gBmp = Graphics.FromImage(_bmp))
                        {
                            for (int x = 0; x < 16; x++)
                                for (int z = 0; z < 16; z++)
                                {
                                    int y = buffer[x, z];
                                    Color color = Color.FromArgb(y * 2, y * 2, y * 2);
                                    using (Pen pen = new Pen(color))
                                    {
                                        gBmp.DrawLine(pen, x + xChunk, z + zChunk, x + xChunk + 1, z + zChunk);

                                        if (y < 65)
                                        {
                                            if (!_useCustomColor)
                                            {
                                                using (
                                                    Pen pen2 =
                                                        new Pen(Color.FromArgb(Convert.ToInt32(txtAlpha.Text),
                                                                               Color.FromName(
                                                                                   _colorList[(int)cmb].
                                                                                       Name))))
                                                    gBmp.DrawLine(pen2, x + xChunk, z + zChunk, x + xChunk + 1,
                                                                  z + zChunk);
                                            }
                                            else
                                            {
                                                using (
                                                    Pen pen2 =
                                                        new Pen(Color.FromArgb(_a, _r, _g, _b)))
                                                    gBmp.DrawLine(pen2, x + xChunk, z + zChunk, x + xChunk + 1,
                                                                  z + zChunk);

                                            }
                                        }
                                    }
                                }
                        }

                    }
                    catch
                    { }

                    InvokeIfRequired(pictureBox1, (MethodInvoker)(() => pictureBox1.Refresh()));
                }
            }
        }
        private void BackgroundWorker1RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSave.Enabled = true;
            btnGenerate.Enabled = true;
        }

        private void CmbWatercolorSelectedIndexChanged(object sender, EventArgs e)
        {
            txtA.Text = _colorList[cmbWatercolor.SelectedIndex].A.ToString();
            txtR.Text = _colorList[cmbWatercolor.SelectedIndex].R.ToString();
            txtG.Text = _colorList[cmbWatercolor.SelectedIndex].G.ToString();
            txtB.Text = _colorList[cmbWatercolor.SelectedIndex].B.ToString();

        }
        private void chkMinimalview_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.minimalView = chkMinimalview.Checked;
            Properties.Settings.Default.Save();

            Size = Properties.Settings.Default.minimalView ? new Size(185, Size.Height) : new Size(548, Size.Height);
        }
        private void ChkCustomColorCheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = chkCustomColor.Checked;
            _useCustomColor = chkCustomColor.Checked;
        }

        private void BtnSetRandomSeedClick(object sender, EventArgs e)
        {
            SetRandomSeed();
        }
        private void BtnFullscreenClick(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                btnFullscreen.Text = @"Fullscreen";
                WindowState = FormWindowState.Normal;
            }
            else
            {
                btnFullscreen.Text = @"Normal Mode";
                WindowState = FormWindowState.Maximized;
            }
            
        }
        private void BtnGenerateClick(object sender, EventArgs e)
        {
            _seed = Convert.ToInt32(txtSeed.Text);

            if (txtDimension.TextLength <= 1 || txtHeigth.TextLength <= 1)
                MessageBox.Show(@"Bitte die Felder mit Input füllen!!!", @"Hinweis!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            else
            {
                btnCancel.Enabled = true;


                if (!_useCustomColor)
                {
                    if (cmbWatercolor.SelectedIndex == 0) //Wenn keine Farbe ausgewählt, zufällig eine Wählen
                        cmbWatercolor.SelectedIndex = _rnd.Next(cmbWatercolor.Items.Count);
                    backgroundWorker1.RunWorkerAsync(cmbWatercolor.SelectedIndex);

                }
                else
                {
                    _a = string.IsNullOrWhiteSpace(txtA.Text) ? Convert.ToInt32(txtA.Text) : _rnd.Next(255);
                    _r = string.IsNullOrWhiteSpace(txtR.Text) ? Convert.ToInt32(txtR.Text) : _rnd.Next(255);
                    _g = string.IsNullOrWhiteSpace(txtG.Text) ? Convert.ToInt32(txtG.Text) : _rnd.Next(255);
                    _b = string.IsNullOrWhiteSpace(txtB.Text) ? Convert.ToInt32(txtB.Text) : _rnd.Next(255);
                    backgroundWorker1.RunWorkerAsync(cmbWatercolor.SelectedIndex);
                }

                
            }
        }
        private void btnBatch_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Visible = false;
            new BatchProcessing().ShowDialog();
        }
        private void BtnCancelClick(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            Application.Exit();
        }
        private void BtnAboutClick(object sender, EventArgs e)
        {
            AboutFrm aboutForm = new AboutFrm();
            aboutForm.ShowDialog();
        }
        private void BtnSaveClick(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                _bmp.Save(saveFileDialog1.FileName);
        }

        private void txtDimension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
        private void txtHeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
        private void txtAlpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
        private void txtSeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
        private void txtR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
        private void txtG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
        #endregion ---------------------------------------------------------------------------------------

        #region Methods ----------------------------------------------------------------------------------

        /// <summary>
        /// Get Systemcolors and fill the combobox
        /// </summary>
        private void GetComboBoxColors()
        {
            var colorProperties = _colors.GetType().GetProperties(BindingFlags.Static | BindingFlags.Public);
            var colors = colorProperties.Select(prop => (Color)prop.GetValue(null, null));

            foreach (Color myColor in colors)
            {
                _colorList.Add(myColor);
                cmbWatercolor.Items.Add(myColor.Name);
            }
        }

        /// <summary>
        /// Generate random seed and fill textbox
        /// </summary>
        private void SetRandomSeed()
        {
            _rnd = new Random();
            txtSeed.Text = _rnd.Next(Int32.MinValue, Int32.MaxValue).ToString();
        }

        /// <summary>
        /// Invoke if required, for thread safe gui changes
        /// </summary>
        /// <param name="target">Target control</param>
        /// <param name="methodToInvoke">Delegate Method to Invoke</param>
        private static void InvokeIfRequired(Control target, Delegate methodToInvoke)
        {
            /* Mit Hilfe von InvokeRequired wird geprüft ob der Aufruf direkt an die UI gehen kann oder
             * ob ein Invokeing hier von Nöten ist
             */
            if (target.InvokeRequired)
            {
                // Das Control muss per Invoke geändert werden, weil der aufruf aus einem Backgroundthread kommt
                target.Invoke(methodToInvoke);
            }
            else
            {
                // Die Änderung an der UI kann direkt aufgerufen werden.
                methodToInvoke.DynamicInvoke();


            }
        }

        #endregion ---------------------------------------------------------------------------------------

        

        
    }
}



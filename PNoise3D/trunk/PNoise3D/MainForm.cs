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
        private Bitmap _bmp;
        private Int32 _seed, _dimension, _height;

        private readonly List<Color> _colorList = new List<Color>();
        private Color _colors = Color.Empty;
        private Random _rnd;

        private int _overallzChunks;
        private bool _useCustomColor;
        private int _a, _r, _g, _b;
        #endregion ---------------------------------------------------------------------------------------

        #region Contructors ------------------------------------------------------------------------------

        public MainForm()
        {
            InitializeComponent();
            
            GetComboBoxColors();
            SetRandomSeed();

        }

        #endregion ---------------------------------------------------------------------------------------

        #region Events -----------------------------------------------------------------------------------
        
        private void BtnGenerateClick(object sender, EventArgs e)
        {
            _seed = Convert.ToInt32(txtSeed.Text);

            if (txtDimension.TextLength <= 1 || txtHeigth.TextLength <= 1)
                MessageBox.Show(@"Bitte die Felder mit Input füllen!!!", @"Hinweis!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            else
            {
                label10.Visible = false;
                btnCancel.Enabled = true;


                if (cmbWatercolor.SelectedIndex == 0) //Wenn keine Farbe ausgewählt, zufällig eine Wählen
                    cmbWatercolor.SelectedIndex = _rnd.Next(cmbWatercolor.Items.Count);
                else
                {
                    _a = txtA.Text != null ? Convert.ToInt32(txtA.Text) : 0;
                    _r = txtR.Text != null ? Convert.ToInt32(txtR.Text) : 0;
                    _g = txtG.Text != null ? Convert.ToInt32(txtG.Text) : 0;
                    _b = txtB.Text != null ? Convert.ToInt32(txtB.Text) : 0;
                }

                backgroundWorker1.RunWorkerAsync(cmbWatercolor.SelectedIndex);
            }
        }

        private void BtnSetRandomSeedClick(object sender, EventArgs e)
        {
            SetRandomSeed();
        }

        private void ChkCustomColorCheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = chkCustomColor.Checked;
            _useCustomColor = chkCustomColor.Checked;
        }

        private void CmbWatercolorSelectedIndexChanged(object sender, EventArgs e)
        {
            txtA.Text = _colorList[cmbWatercolor.SelectedIndex].A.ToString();
            txtR.Text = _colorList[cmbWatercolor.SelectedIndex].R.ToString();
            txtG.Text = _colorList[cmbWatercolor.SelectedIndex].G.ToString();
            txtB.Text = _colorList[cmbWatercolor.SelectedIndex].B.ToString();

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

        private void BtnFullscreenClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _bmp.Save(saveFileDialog1.FileName);
            }
        }

        #endregion ---------------------------------------------------------------------------------------

        #region Methods ----------------------------------------------------------------------------------

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

        private void SetRandomSeed()
        {
            _rnd = new Random();
            txtSeed.Text = _rnd.Next(Int32.MinValue, Int32.MaxValue).ToString();
        }

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

                InvokeIfRequired(lblxChunks, (MethodInvoker) delegate
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
                                                                                   _colorList[(int) cmb].
                                                                                       Name))))
                                                    gBmp.DrawLine(pen2, x + xChunk, z + zChunk, x + xChunk + 1,
                                                                  z + zChunk);
                                            }

                                            using (
                                                    Pen pen2 =
                                                        new Pen(Color.FromArgb(_a, _r, _g, _b)))
                                                gBmp.DrawLine(pen2, x + xChunk, z + zChunk, x + xChunk + 1, z + zChunk);

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

        #endregion ---------------------------------------------------------------------------------------

        
    }
}



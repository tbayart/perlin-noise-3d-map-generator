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
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PNoise3D
{
    public partial class BatchProcessing : Form
    {
        #region Member Data -----------------------------------------------------------------------

        private int[] _indexer = new int[2];

        /// <summary>
        /// Percentage holder for Progressbar
        /// </summary>
        private int prc;
        /// <summary>
        /// Output directory
        /// </summary>
        private string _oDir;
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
        /// Random generator
        /// </summary>
        private Random _rnd;
        /// <summary>
        /// ARGB color values
        /// </summary>
        private int _a, _r, _g, _b;
        /// <summary>
        /// The character list for char indexing
        /// </summary>
        private readonly List<char> characters = new List<char>()
                                                     {
                                                         'a',
                                                         'b',
                                                         'c',
                                                         'd',
                                                         'e',
                                                         'f',
                                                         'g',
                                                         'h',
                                                         'i',
                                                         'j',
                                                         'k',
                                                         'l',
                                                         'm',
                                                         'n',
                                                         'o',
                                                         'p',
                                                         'q',
                                                         'r',
                                                         's',
                                                         't',
                                                         'u',
                                                         'v',
                                                         'w',
                                                         'x',
                                                         'y',
                                                         'z'
                                                     };

        #endregion --------------------------------------------------------------------------------
        #region Constructors ----------------------------------------------------------------------

        public BatchProcessing()
        {
            InitializeComponent();
            SetRandomSeed();
        }

        #endregion --------------------------------------------------------------------------------
        #region Methods ---------------------------------------------------------------------------
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

        #endregion --------------------------------------------------------------------------------
        #region Events ----------------------------------------------------------------------------

        private void BatchProcessing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtDimension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtHeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtSeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("1234567890,\b".IndexOf(e.KeyChar.ToString()) >= 0) return;

            e.Handled = true;
            MessageBox.Show(@"This field only accept numbers!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnSetOutputdir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                _oDir = txtOutputDir.Text = folderBrowserDialog1.SelectedPath;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
                MessageBox.Show(@"Please fill in a output name!", @"Error!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            else
            {
                if (string.IsNullOrEmpty(_oDir))
                    MessageBox.Show(@"Please set the output directory!", @"Error!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                if (cmbExtension.SelectedText == "=select=")
                    MessageBox.Show(@"Please set file extension!", @"Error!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                else
                {
                    if (txtDimension.Text != null)
                        _dimension = Convert.ToInt32(txtDimension.Text);
                    else
                        MessageBox.Show(@"Please set the dimension!", @"Error!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    if (txtHeigth.Text != null)
                        _height = Convert.ToInt32(txtHeigth.Text);
                    else
                        MessageBox.Show(@"Please set the heigth!", @"Error!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                    if (txtSeed.Text != null)
                        _seed = Convert.ToInt32(txtSeed.Text);
                    else
                        MessageBox.Show(@"Please set seed!", @"Error!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                    _bmp = new Bitmap(_dimension, _dimension, PixelFormat.Format32bppArgb);

                    //If no Color used or textfield is null, empty or whitespace, generate some random data
                    _a = string.IsNullOrWhiteSpace(txtA.Text) ? Convert.ToInt32(txtA.Text) : _rnd.Next(255);
                    _r = string.IsNullOrWhiteSpace(txtR.Text) ? Convert.ToInt32(txtR.Text) : _rnd.Next(255);
                    _g = string.IsNullOrWhiteSpace(txtG.Text) ? Convert.ToInt32(txtG.Text) : _rnd.Next(255);
                    _b = string.IsNullOrWhiteSpace(txtB.Text) ? Convert.ToInt32(txtB.Text) : _rnd.Next(255);


                    backgroundWorker1.RunWorkerAsync();

                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            prc = 0;
            progressBar1.Value = 0;

            if (chkIndexInt.Checked)
            {
                _indexer[0] += 1;
                if (_indexer[0] == 9)
                {
                    _indexer[1] += 1;
                    _indexer[0] = 0;

                    _bmp.Save(_oDir + _indexer[1] + _indexer[0] + cmbExtension.SelectedItem);
                    lstLog.Items.Insert(0, txtName.Text + _indexer[1] + _indexer[0] + " saved @ " + _oDir);
                }
                else
                    _bmp.Save(Path.Combine(_oDir, txtName.Text + _indexer[1] + cmbExtension.SelectedItem));
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = Math.Min(e.ProgressPercentage, 100);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < nudCount.Value; i++)
            {
                PerlinNoise3D perlinNoise3D = new PerlinNoise3D(_seed);

                for (int xChunk = 0; xChunk < _dimension; xChunk += 16)
                {

                    for (int zChunk = 0; zChunk < _dimension; zChunk += 16)
                    {

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
                        catch
                        {
                        }
                        backgroundWorker1.ReportProgress(++prc);
                    }
                }
            }
        }

        #endregion --------------------------------------------------------------------------------

       

        

       

        

       

        
    }
}
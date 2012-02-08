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
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PNoise3D
{
    public partial class BatchProcessing : Form
    {
        #region Member Data -----------------------------------------------------------------------

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

       
        public BatchProcessing()
        {
            InitializeComponent();
        }
    }
}

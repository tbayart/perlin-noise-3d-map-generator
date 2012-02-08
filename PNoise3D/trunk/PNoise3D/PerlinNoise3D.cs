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

namespace PNoise3D
{
    public class PerlinNoise3D
    {
        #region Member Data------------------------------------------------------------------------

        Int32 seed;
        Int32 noiseDimension;
        Int32 noiseHeight;
        Single[, ,] noise;

        #endregion --------------------------------------------------------------------------------

        #region Constructors ----------------------------------------------------------------------

        public PerlinNoise3D(Int32 Seed) : this(Seed, 1024, 128) { }

        public PerlinNoise3D(Int32 Seed, Int32 NoiseDimension, Int32 NoiseHeight)
        {
            seed = Seed;
            noiseDimension = NoiseDimension;
            noiseHeight = NoiseHeight;

            generateNoise();
        }

        #endregion --------------------------------------------------------------------------------

        #region Methods ---------------------------------------------------------------------------

        private void generateNoise()
        {
            noise = new Single[noiseDimension, noiseHeight, noiseDimension];
            Random noiseRandom = new Random(seed);

            for (Int32 x = 0; x < noiseDimension; ++x)
                for (Int32 y = 0; y < noiseHeight; ++y)
                    for (Int32 z = 0; z < noiseDimension; ++z)
                        noise[x, y, z] = ((Single) (noiseRandom.NextDouble()) - 0.5f)*2.0f;
        }

        public Single GetValue(Single x, Single y, Single z, Single Frequency, Single Amplitude, Single Persistance, Int32 Octaves)
        {
            Single value = 0;

            for (Int32 i = 0; i < Octaves; ++i)
            {
                value += getSmoothNoise(x * Frequency, y * Frequency, z * Frequency) * Amplitude;
                Frequency *= 2.0f;
                Amplitude *= Persistance;
            }

            if (value < -1.0f) value = -1.0f;
            else if (value > 1.0f) value = 1.0f;

            return value;
        }

        public Single GetValue(Single x, Single y, Single z, Single Frequency, Single Amplitude)
        {
            Single value = getSmoothNoise(x * Frequency, y * Frequency, z * Frequency) * Amplitude;

            if (value < -1.0f) value = -1.0f;
            else if (value > 1.0f) value = 1.0f;

            return value;
        }

        private Single getSmoothNoise(Single x, Single y, Single z)
        {
            Single FractionX = x - (Int32)x;
            Single FractionY = y - (Int32)y;
            Single FractionZ = z - (Int32)z;

            Int32 X1 = ((Int32)x + noiseDimension) % noiseDimension;
            Int32 Z1 = ((Int32)z + noiseDimension) % noiseDimension;
            Int32 Y1 = ((Int32)y + noiseHeight) % noiseHeight;

            Int32 X2 = ((Int32)x + noiseDimension - 1) % noiseDimension;
            Int32 Z2 = ((Int32)z + noiseDimension - 1) % noiseDimension;
            Int32 Y2 = ((Int32)y + noiseHeight - 1) % noiseHeight;

            Single value = 0;

            value += FractionX * FractionY * FractionZ * noise[X1, Y1, Z1];
            value += FractionX * FractionY * (1 - FractionZ) * noise[X1, Y1, Z2];
            value += FractionX * (1 - FractionY) * FractionZ * noise[X1, Y2, Z1];
            value += FractionX * (1 - FractionY) * (1 - FractionZ) * noise[X1, Y2, Z2];
            value += (1 - FractionX) * FractionY * FractionZ * noise[X2, Y1, Z1];
            value += (1 - FractionX) * FractionY * (1 - FractionZ) * noise[X2, Y1, Z2];
            value += (1 - FractionX) * (1 - FractionY) * FractionZ * noise[X2, Y2, Z1];
            value += (1 - FractionX) * (1 - FractionY) * (1 - FractionZ) * noise[X2, Y2, Z2];

            return value;
        }

        #endregion ---------------------------------------------------------------------------------
    }
}

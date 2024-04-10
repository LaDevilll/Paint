﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class SprayBr : Brush //Распылитель.
    {
        public SprayBr(Color brushColor, int size) 
            : base(brushColor, size) 
        { 
        }
        public bool DrawEveryTick = true;
        public override void Draw(Bitmap image, int x, int y)
        {
            Random random = new Random();
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    if ((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y) <= Size * Size)
                    {
                        if (random.Next(100) == 1)
                            image.SetPixel(x0, y0, BrushColor);
                    }
                }
            }
        }
    }
}

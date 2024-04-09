using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class CircleBr : Brush 
    {
        public CircleBr(Color brushColor, int size)
            : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    if ((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y) <= Size * Size)
                    {
                        if (x0 >= 0 && x0 < image.Width && y0 >= 0 && y0 < image.Height)
                        {
                            image.SetPixel(x0, y0, BrushColor);
                        }
                    }
                }
            }
        }
    }
}

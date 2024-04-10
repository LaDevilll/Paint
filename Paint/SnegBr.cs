using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class SnegBr : Brush
    {
        public SnegBr(Color brushColor, int size)
            : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            int radius = Size;
            int centerX = x;
            int centerY = y;
            for (int i = -radius; i <= radius; i++) //горизонтальные
            {
                image.SetPixel(centerX + i, centerY, BrushColor);
            }
            for (int j = -radius; j <= radius; j++) //вертикальные
            {
                image.SetPixel(centerX, centerY + j, BrushColor);
            }
            for (int k = -radius; k <= radius; k++) //диагональные
            {
                image.SetPixel(centerX + k, centerY + k, BrushColor);
                image.SetPixel(centerX - k, centerY + k, BrushColor);
            }
        }
    }

}



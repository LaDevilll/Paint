using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
     class LastikBr : Brush
     {
        public LastikBr(int size)
            : base(Color.White, size) // Цвет ластика - белый, чтобы он закрашивал пиксели изображения
        { }



        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; y0++)
            {
                for (int x0 = x - Size; x0 < x + Size; x0++)
                {
                        image.SetPixel(x0, y0, BrushColor);
                }
            }
           
        }
     }

}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class SprayBr : Brush //распылитель
    {
        public SprayBr(Color brushColor, int size) 
            : base(brushColor, size) 
        { 
        }
        public bool DrawEveryTick = true;
        public override void Draw(Bitmap image, int x, int y)
        {
            Random random = new Random();

            //определение границ для обработки
            int startX = Math.Max(0, x - Size);
            int endX = Math.Min(image.Width - 1, x + Size);
            int startY = Math.Max(0, y - Size);
            int endY = Math.Min(image.Height - 1, y + Size);

            for (int y0 = startY; y0 <= endY; ++y0)
            {
                for (int x0 = startX; x0 <= endX; ++x0)
                {
                    //проверяем, что точка находится в пределах окружности
                    if ((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y) <= Size * Size)
                    {
                        if (random.Next(100) == 1)
                        {
                            image.SetPixel(x0, y0, BrushColor);
                        }
                    }
                }
            }
        }

    }
}

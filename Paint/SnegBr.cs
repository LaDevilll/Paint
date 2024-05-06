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

            for (int i = -radius; i <= radius; i++) // горизонтальные
            {
                int newX = centerX + i;
                if (newX >= 0 && newX < image.Width) // проверка на допустимые пределы ширины
                {
                    image.SetPixel(newX, centerY, BrushColor);
                }
            }

            for (int j = -radius; j <= radius; j++) // вертикальные
            {
                int newY = centerY + j;
                if (newY >= 0 && newY < image.Height) // проверка на допустимые пределы высоты
                {
                    image.SetPixel(centerX, newY, BrushColor);
                }
            }
            
            int z = (int)Math.Sqrt(radius * radius / 2);
            for (int k = -z; k <= z; k++)           
            {              
                int diagX1 = centerX + k;
                int diagY1 = centerY + k;
                int diagX2 = centerX - k;
                int diagY2 = centerY + k;
                image.SetPixel(diagX1, diagY1, BrushColor);
                image.SetPixel(diagX2, diagY2, BrushColor);
            }
        }
    }
}


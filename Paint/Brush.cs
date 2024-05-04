using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    abstract class Brush
    {
        public Color BrushColor { get; set; }
        public int Size { get; set; }
        public Brush(Color brushColor, int size)
        {
            BrushColor = brushColor;
            Size = size;
        }
        public abstract void Draw(Bitmap image, int x, int y);
    }







    class QuadBrush : Brush
    {
        public QuadBrush(Color brushColor, int size)
            : base(brushColor, size)
        {
        }

        public override void Draw(Bitmap image, int x, int y)
        {
            //проверяем, что точка рисования находится в пределах изображения
            if (x >= 0 && x < image.Width && y >= 0 && y < image.Height)
            {
                for (int y0 = Math.Max(0, y - Size); y0 < Math.Min(image.Height, y + Size); ++y0)
                {
                    for (int x0 = Math.Max(0, x - Size); x0 < Math.Min(image.Width, x + Size); ++x0)
                    {
                        image.SetPixel(x0, y0, BrushColor);
                    }
                }
            }
        }
    }


    //class Plus : Brush
    //{
    //    public Plus(Color brushColor, int size)
    //        : base(brushColor, size)
    //    {
    //    }

    //    public override void Draw(Bitmap image, int x, int y)
    //    {
    //        for (int i = -Size; i <= Size; i++) 
    //        {
    //            int newX = x + i;
    //            image.SetPixel(newX, y, BrushColor);
    //            int newY = y + j;
    //            image.SetPixel(x, newY, BrushColor);
    //        }

    //    }
    //}
}

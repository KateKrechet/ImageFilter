using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilter
{
    class GreenFilter : IFilter
    {
        public Bitmap Apply(Bitmap image)
        {
            int h = image.Height;
            int w = image.Width;
            Bitmap buffer = new Bitmap(w, h);//создали пустую картинку

            for (int i = 0; i < h; i++)//по высоте - Y
                for (int j = 0; j < w; j++)//по ширине - X
                {
                    Color pixel = image.GetPixel(j, i);
                    buffer.SetPixel(j, i, Color.FromArgb(0, pixel.G, 0));

                }
            return buffer;
        }

        public string GetName()
        {
            return "Зеленый";
        }
    }
}

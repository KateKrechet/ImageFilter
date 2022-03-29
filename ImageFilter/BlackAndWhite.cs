using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageFilter
{
    class BlackAndWhite:IFilter
    {
        public Bitmap Apply(Bitmap image)
        {
            int h = image.Height;
            int w = image.Width;
            Bitmap buffer = new Bitmap(w, h);//создали пустую картинку
           
            for(int i=0;i<h;i++)//по высоте - Y
                for(int j=0;j<w;j++)//по ширине - X
                {
                    Color pixel = image.GetPixel(j, i);
                    if((pixel.R+pixel.B+pixel.G)/3>100)
                            buffer.SetPixel(j,i,Color.Black);
            else
                buffer.SetPixel(j,i,Color.White);

                }
            return buffer;

        }
        public string GetName()
        {
            return "Черно-белый";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageFilter
{
    interface IFilter
    {
        Bitmap Apply(Bitmap image);
        string GetName();
    }
}

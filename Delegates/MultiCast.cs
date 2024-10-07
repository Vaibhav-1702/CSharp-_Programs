using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void RectDelegeate(int width, int height);
    public class MultiCast
    {
        public void RectArea(int width, int height)
        {
            Console.WriteLine("Area of Rectangle is : " + (width*height));
        }

        public void RectPeri(int width, int height)
        {
            Console.WriteLine("Perimeter of Rectangle is : " + 2*(width + height));
        }
        static void Main(string[] args)
        {
            MultiCast m1 = new MultiCast();
            //RectDelegeate rect = new RectDelegeate(multiCast.RectArea);
            //rect(10, 20);
            RectDelegeate rect = m1.RectArea;
            rect += m1.RectPeri;
            rect(10,20);
        }
    }
}

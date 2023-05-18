using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3_e_zadanie_go1x1noob
{
    internal class MyRectangle
    {
        private int x, y, width, height;
        public MyRectangle (int x, int y, int width, int height)
        {
            this.x = x; this.y = y; this.width = width; this.height = height;
        }
        public void NewRectangle(int x, int y, int width, int height)
        {
            this.x = x; this.y = y; this.width = width; this.height = height;
        }

        public void Visualize(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, x,y,width,height);
        }

    }
}

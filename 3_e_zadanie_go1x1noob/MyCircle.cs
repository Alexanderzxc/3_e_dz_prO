using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_e_zadanie_go1x1noob
{
    internal class MyCircle
    {
        private int x,y,R;


        public MyCircle(int x, int y, int R)
        {
            this.x = x;
            this.y = y;
            this.R = R;
        }

        public void NewCircle(int x, int y, int R)
        {
            this.x = x;
            this.y = y;
            this.R = R;
        }

        public void Visualize_Circle(Graphics g)
        {
            Pen pen = new Pen(Color.Blue, 3);
            g.DrawEllipse(pen, x-R, y-R, R*2, R*2);
        }
    }
}

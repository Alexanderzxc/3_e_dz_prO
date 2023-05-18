using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_e_zadanie_go1x1noob
{
    internal class MyVagonSand:MyVagon
    {
        public MyVagonSand(int x, int y, int dlina, int visota) : base(x,y,dlina,visota)
        {
            x_1 = x;
            y_1 = y;
            dlina_1 = dlina;
            visota_1 = visota;
        }
        public override void Visualize(Graphics g)
        {
            Point A = new Point(x_1+dlina_1/10,y_1);
            Point B = new Point(x_1+ 9*dlina_1/10,y_1);
            Point C = new Point(x_1 + dlina_1 / 2, y_1 - dlina_1 / 6);
            Point[] points = {A,B,C};
            g.FillPolygon(Brushes.Yellow,points);
            base.Visualize(g);
        }
    }
}

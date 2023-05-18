using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_e_zadanie_go1x1noob
{
    internal class MyVagonCoal : MyVagon
    {
        public MyVagonCoal(int x, int y, int dlina, int visota) : base(x,y, dlina, visota)
        {
            x_1 = x;
            y_1 = y;
            dlina_1 = dlina;
            visota_1 = visota;

        }
        public override void Visualize(Graphics g)
        {
            g.FillRectangle(Brushes.Black, x_1+dlina_1/4, y_1-dlina_1/6, dlina_1/2, visota_1/3);
            base.Visualize(g);
        }
    }
}

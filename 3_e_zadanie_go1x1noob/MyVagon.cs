using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_e_zadanie_go1x1noob
{
    internal class MyVagon
    {
        private int mass, x, y, dlina, visota;
        private MyCircle wheel_1, wheel_2;
        private MyRectangle karkas;

        public int MASS
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }
        public int x_1
        {
            get { return x; }
            set { x = value; }
        }
        public int y_1
        {
            get { return y; }
            set { y = value; }
        }
        public int dlina_1
        {
            get { return dlina; }
            set
            {
                dlina = value;
            }
        }
        public int visota_1
        {
            get { return visota; }
            set
            {
                visota = value;
            }
        }
        public MyVagon(int x, int y, int dlina, int visota)
        {
            this.mass = mass;
            this.x = x;
            this.y = y;
            this.dlina = dlina;
            wheel_1 = new(x + dlina / 6, y + 23 * dlina / 30, dlina / 6);
            wheel_2 = new(x + 5*dlina / 6, y + 23 * dlina / 30, dlina / 6);
            karkas = new(x, y, dlina, visota);
        }
        public virtual new void Visualize(Graphics g)
        {
            wheel_1.Visualize_Circle(g);
            wheel_2.Visualize_Circle(g);
            karkas.Visualize(g);
        }
    }
}

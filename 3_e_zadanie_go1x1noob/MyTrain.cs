using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_e_zadanie_go1x1noob
{
    internal class MyTrain
    {
        private int full_mas;
        private List<MyVagon> train = new();
        private int x, y;
        Random r = new Random();
        public MyTrain(int x, int y, int dlina,int visota, int num_of_vagons)
        {
            this.x = x;
            this.y = y;
            for (int i = 0; i < num_of_vagons; i++)
            {
                int random = r.Next(3);
                switch (random)
                {
                    case 0:
                        MyVagon vagon = new MyVagon(x*i+100, y, dlina, visota);
                        train.Add(vagon);
                        break;
                    case 1:
                        MyVagonCoal vagon_1 = new MyVagonCoal(x*i+100, y, dlina, visota);
                        train.Add(vagon_1);
                        break;
                    case 2:
                        MyVagonSand vagon_2 = new MyVagonSand(x*i+100, y, dlina, visota);
                        train.Add(vagon_2);
                        break;
                }
            }
        }

        public void Visualize(Graphics g)
        {
            for (int i = 0; i < train.Count; i++)
            {
                train[i].Visualize(g);
            }
        }

    }
}

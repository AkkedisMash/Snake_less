using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_less
{
    class Snake : Figure
    {
        public Snake(Point tail, int length, Direction dir)
        {
            plist = new List<Point>();

            for(int i=0; i<= length; i++)
            {
                Point t = new Point(tail);
                t.Move(i, dir);
                plist.Add(t);

            }
        }

    }
}

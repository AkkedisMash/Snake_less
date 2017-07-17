using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_less
{
    class Vline : Figure
    {
        //List<Point> plist;

        public Vline(int yUpper, int yLower, int x, char sym)
        {
            plist = new List<Point>();
            for (int i = yUpper; i <= yLower; i++)
            {
                plist.Add(new Point(x, i, sym));
            }
        }

     
    }
}

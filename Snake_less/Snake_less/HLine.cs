using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_less
{
    class HLine
    {
        List<Point> plist;
        
        public HLine(int xLeft, int xRight, int y, char sym)
        {
            plist = new List<Point>();
            for(int i = xLeft; i <= xRight; i++)
            {
                plist.Add( new Point(i, y, sym));
                              
            }

           /* Point p1 = new Point(9, 6, '*');
            Point p2 = new Point(10, 6, '*');
            Point p3 = new Point(11, 6, '*');
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);*/
            
        } 

        public void Draw()
        {
            foreach (Point i in plist)
            {
                i.Draw();
            }

        }
    }
}

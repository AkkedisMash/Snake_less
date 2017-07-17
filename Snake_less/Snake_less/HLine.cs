using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_less
{
    class HLine : Figure
    {
         
        public HLine(int xLeft, int xRight, int y, char sym)
        {
            plist = new List<Point>();
            for(int i = xLeft; i <= xRight; i++)
            {
                plist.Add( new Point(i, y, sym));
                              
            }

            
        } 


    }
}

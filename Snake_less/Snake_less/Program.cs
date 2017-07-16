using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_less
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(6, 12, 'h');
     
            p1.Draw();


          Point p2 = new Point(4,3,'#');

            p2.Draw();

          HLine up = new HLine(5,20,4,'#');
            up.Draw();
           
         /*   List<Point> NumList = new List<Point>();
            NumList.Add(new Point(4, 3, '*'));
            NumList.Add(new Point(2, 3, '*'));
            NumList.Add(new Point(3, 3, '*'));

            foreach(Point i in NumList)
            {
                i.Draw();
            }*/

            

            Console.ReadKey();
        }

    }
}

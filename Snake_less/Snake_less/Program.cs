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
            



            Console.ReadKey();
        }

    }
}

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
            //Отрисовка границ
            // Console.SetBufferSize(125,80);
            //Задаем две точки, определяющие границы поля
            Point UpperLeft = new Point(1, 1, '_');
            Point LowerDown = new Point(80, 30, '_');

            HLine up = new HLine(UpperLeft.x, LowerDown.x, UpperLeft.y, '#');
            HLine down = new HLine(UpperLeft.x, LowerDown.x, LowerDown.y, '#');
            Vline left = new Vline(UpperLeft.y, LowerDown.y, UpperLeft.x, '#');
            Vline right = new Vline(UpperLeft.y, LowerDown.y, LowerDown.x, '#');

            up.Draw();
            down.Draw();
            left.Draw();
            right.Draw();

            Point t = new Point(UpperLeft.x+5, UpperLeft.y+5, '*');
            Snake sn = new Snake(t, 4, Direction.RIGHT);
            sn.Draw();
           
           
            Console.ReadKey();
        }

    }
}

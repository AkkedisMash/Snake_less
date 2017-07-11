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
            int x1 = 3;
            int y1 = 6;
            char sym = '#';
            Draw(x1, y1, sym);
            Console.ReadKey();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}

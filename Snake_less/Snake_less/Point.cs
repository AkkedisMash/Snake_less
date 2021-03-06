﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_less
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction dir)
        {
            if(dir == Direction.RIGHT)
            {
                x = x + offset;
            }
            if(dir == Direction.LEFT)
            {
                x = x - offset;
            }
            if (dir == Direction.UP)
            {
                y = y - offset;
            }
            if(dir == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
      /*  public bool IsHit(Point fst, Point scnd)
        {

        }*/

        public void Clear()
        {
            //  Console.SetCursorPosition(x, y);
            //  Console.WriteLine(' ');
            sym = ' ';
            Draw();
        }
    }
}

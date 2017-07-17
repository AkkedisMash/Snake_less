using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_less
{
    class Snake : Figure
    {
        Direction direction;
        
        public Snake(Point tail, int length, Direction dir)
        {
            direction = dir;

            plist = new List<Point>();

            for(int i=0; i<= length; i++)
            {
                Point t = new Point(tail);
                t.Move(i, dir);
                plist.Add(t);

            }
        }

        internal void Move()
        {
            //   throw new NotImplementedException();
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);
            
            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow & (direction == Direction.UP || direction == Direction.DOWN))
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow & (direction == Direction.UP || direction == Direction.DOWN))
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow & (direction == Direction.LEFT || direction == Direction.RIGHT))
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow & (direction == Direction.LEFT || direction == Direction.RIGHT))
                direction = Direction.UP;
        }
    }
}

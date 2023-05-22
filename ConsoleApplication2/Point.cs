using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Point
    {
        private int x;
        private int y;
        public Point (int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        public void Move()
        {
            x = x - 5;
            y = y + 5;
            Console.WriteLine(  "The point Move"+"("+x +" ,"+ y+")");

        }
        public void Quadrant()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("first quarter");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("sconad quarter");
            }
            if (x <0 && y < 0)
            {
                Console.WriteLine("third quarter");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("fourth quarter");
            }

        }
        public void print()
        {
            Console.WriteLine("The print point"+"(" + x + "," + y + ")");
        }
        

    }


    }


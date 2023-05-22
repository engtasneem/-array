using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point r = new Point(9, 6);
            r.Move();
            r.print();
            r.Quadrant();

        }
    }
}

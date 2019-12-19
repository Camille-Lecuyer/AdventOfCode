using AdventCalendar.DAY2;
using AdventCalendar.DAY4;
using AdventCalendar.DAY8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new MarsRover();
            Console.WriteLine(x.solvePart1());
            Console.ReadKey();
            /*
             * Day 1 Main
            var x = new Text();
            Console.WriteLine(x.calculateTotal());
            Console.ReadKey();*/
        }
    }
}

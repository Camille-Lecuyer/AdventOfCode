using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventCalendar
{
    public class Text
    {
        List<string> lines;
        public Text()
        {
            string filePath = @"C:\Users\T-Developer\Documents\masses.txt";
            lines = File.ReadAllLines(filePath).ToList();
        }

        public int calculateTotal()
        {
            int sum = 0;
            var calculate = new FuelOperation();
            foreach(string line in lines)
            {
                int number = Int32.Parse(line);
                sum = sum + calculate.getFuelForMass(number);
            }
            return sum;
        }
    }
}

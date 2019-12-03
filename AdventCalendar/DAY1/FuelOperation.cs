using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendar
{
    public class FuelOperation
    {
        int fuelNeeded;
        public int getFuelForMass(int x)
        {
            int digit = x/3 - 2;
            int more = digit;
            while (more / 3 - 2 > 0)
            {
                digit = digit + (more / 3 - 2);
                more = more / 3 - 2;
                if (getFuelForMass(more) <= 0)
                {
                    break;
                }
            }
            fuelNeeded = digit;
            return fuelNeeded;
        }


}
}

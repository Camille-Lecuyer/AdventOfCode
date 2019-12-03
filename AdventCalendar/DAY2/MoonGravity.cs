using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendar.DAY2
{
    class MoonGravity
    {

        public void findAnswer()
        {
            var gravity = new GravityAssist();
            for (int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                    gravity.noun = i;
                    gravity.verb = j;

                    if (gravity.process() == 19690720)
                    {
                        Console.WriteLine("That's it!!!" + i + j);
                    }
                    else
                    {
                        gravity.reset();
                    }
                }
            }
        }
    }
}

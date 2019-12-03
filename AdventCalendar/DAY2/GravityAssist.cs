using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendar.DAY2
{
    public class GravityAssist
    {
        int[] programAlarm;
        public int noun;
        public int verb;

        public GravityAssist()
        {
            programAlarm = new[] { 1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 10, 19, 1, 9, 19, 23, 1, 13, 23, 27, 1, 5, 27, 31, 2, 31, 6, 35, 1, 35, 5, 39, 1, 9, 39, 43, 1, 43, 5, 47, 1, 47, 5, 51, 2, 10, 51, 55, 1, 5, 55, 59, 1, 59, 5, 63, 2, 63, 9, 67, 1, 67, 5, 71, 2, 9, 71, 75, 1, 75, 5, 79, 1, 10, 79, 83, 1, 83, 10, 87, 1, 10, 87, 91, 1, 6, 91, 95, 2, 95, 6, 99, 2, 99, 9, 103, 1, 103, 6, 107, 1, 13, 107, 111, 1, 13, 111, 115, 2, 115, 9, 119, 1, 119, 6, 123, 2, 9, 123, 127, 1, 127, 5, 131, 1, 131, 5, 135, 1, 135, 5, 139, 2, 10, 139, 143, 2, 143, 10, 147, 1, 147, 5, 151, 1, 151, 2, 155, 1, 155, 13, 0, 99, 2, 14, 0, 0 };
            verb = 2;
            noun = 12;
        }

        public int process()
        {
            programAlarm[1] = noun;
            programAlarm[2] = verb;
            int index = 0;
            while(index < programAlarm.Length && programAlarm[index] != 99)
            {
                if (programAlarm[index] == 1)
                {
                    programAlarm[programAlarm[index + 3]] = programAlarm[programAlarm[index + 1]] + programAlarm[programAlarm[index + 2]];
                    index = index + 4;
                }
                else if (programAlarm[index] == 2)
                {
                    programAlarm[programAlarm[index + 3]] = programAlarm[programAlarm[index + 1]] * programAlarm[programAlarm[index + 2]];
                    index = index + 4;
                }
            }
            return programAlarm[0];
        }

        public void reset()
        {
            int[] resetArray = new []{ 1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 10, 19, 1, 9, 19, 23, 1, 13, 23, 27, 1, 5, 27, 31, 2, 31, 6, 35, 1, 35, 5, 39, 1, 9, 39, 43, 1, 43, 5, 47, 1, 47, 5, 51, 2, 10, 51, 55, 1, 5, 55, 59, 1, 59, 5, 63, 2, 63, 9, 67, 1, 67, 5, 71, 2, 9, 71, 75, 1, 75, 5, 79, 1, 10, 79, 83, 1, 83, 10, 87, 1, 10, 87, 91, 1, 6, 91, 95, 2, 95, 6, 99, 2, 99, 9, 103, 1, 103, 6, 107, 1, 13, 107, 111, 1, 13, 111, 115, 2, 115, 9, 119, 1, 119, 6, 123, 2, 9, 123, 127, 1, 127, 5, 131, 1, 131, 5, 135, 1, 135, 5, 139, 2, 10, 139, 143, 2, 143, 10, 147, 1, 147, 5, 151, 1, 151, 2, 155, 1, 155, 13, 0, 99, 2, 14, 0, 0 };
            for(int index = 0; index < programAlarm.Length; index++)
            {
                programAlarm[index] = resetArray[index];
            }
        }
    }
}


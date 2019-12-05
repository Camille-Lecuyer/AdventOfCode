using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendar.DAY4
{
    public class SecureContainer
    {

        public int lowerLimit;
        public int upperLimit;
        public int count;

        public SecureContainer()
        {
            lowerLimit = 347312;
            upperLimit = 805915;
            count = 0;
        }

        public Boolean isItSecure(int password)
        {
            bool checkOne = false;
            bool checkTwo = false;
            bool checkThree = false;
            bool checkFour = false;
            char[] arrayPassword = password.ToString().ToCharArray();
            if(arrayPassword.Length == 6)
            {
                checkOne = true;
            }
            if(password >= lowerLimit && password <= upperLimit)
            {
                 checkTwo = true;
            }
            if(arrayPassword[0] == arrayPassword[1] || arrayPassword[1] == arrayPassword[2] || arrayPassword[2] == arrayPassword[3] || arrayPassword[3] == arrayPassword[4] || arrayPassword[4] == arrayPassword[5])
            {
                checkThree = true;
            }
            if(arrayPassword[0] <= arrayPassword[1] && arrayPassword[1] <= arrayPassword[2] && arrayPassword[2] <= arrayPassword[3] && arrayPassword[3] <= arrayPassword[4] && arrayPassword[4] <= arrayPassword[5])
            {
                checkFour = true;
            }

            if(checkOne && checkTwo && checkThree && checkFour)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int goThroughPassWord()
        {
            for(int i = lowerLimit; i<=upperLimit; i++)
            {
                if (isItSecure(i))
                {
                    count++;
                }
            }
            return count;
        }

    }
}

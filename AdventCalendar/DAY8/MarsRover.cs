using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendar.DAY8
{
    public class MarsRover
    {

        public string password;
        public int width = 25;
        public int height = 6;
        public int size = 25 * 6;
        public List<char> charList;

        public MarsRover()
        {
            password = System.IO.File.ReadAllText(@"C:\Users\T-Developer\Documents\password.txt");
            charList = password.ToList();
        }

        //Transform the input into a list of 100 strings (composed of 150 characters)
        public List<string> biosPassword()
        {

            List<String> listOfLayers = new List<String>();

            for (int y = 0; y < 100; y++)
            {
                string oneFiftyPixels = "";
                for (int i = 0; i < 150; i++)
                {                    
                    if (charList.Count == 0) { break; }
                    oneFiftyPixels += charList.ElementAt(0);
                    charList.RemoveAt(0);
                }
                listOfLayers.Add(oneFiftyPixels);
                oneFiftyPixels = "";
            }
            
            return listOfLayers;
        }

        //Find how many zeros each layers have
        public int howManyZeros(string list)
        {
            int zeros = 0;
            foreach (char c in list)
                {
                    if (c.Equals('0'))
                    {
                        zeros++;
                    }
              }            
            return zeros;
        }

        //find the layer with the least zeros
        public String layerWithLeastZero()
        {
            List<String> layers = biosPassword();
            string leastZeroL = layers[0];
            foreach(string s in layers)
            {
                if(howManyZeros(s) < howManyZeros(leastZeroL))
                {
                    leastZeroL = s;
                }
            }
            Console.WriteLine("Layer with least zeros: " + leastZeroL + " which has " + howManyZeros(leastZeroL));
            return leastZeroL;
        }

        //multiply the number of ones with the number of twos on the layer with the least zeros
        public int solvePart1()
        {
            string leastZeroLayer = layerWithLeastZero();
            int ones = 0;
            int twos = 0;
            foreach(char c in leastZeroLayer)
            {
                if (c.Equals('1'))
                {
                    ones++;
                }
                else if (c.Equals('2'))
                {
                    twos++;
                }
            }
            return ones * twos;
        }
    }
}


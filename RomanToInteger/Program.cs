using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanConvert("LVIII"));
            Console.ReadLine();
        }

        static int RomanConvert(string roman)
        {
            Dictionary<char, int> CharValues = new Dictionary<char, int>();

            CharValues.Add('I', 1);
            CharValues.Add('V', 5);
            CharValues.Add('X', 10);
            CharValues.Add('L', 50);
            CharValues.Add('C', 100);
            CharValues.Add('D', 500);
            CharValues.Add('M', 1000);

            int sum = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                if (i == roman.Length - 1)
                {
                    sum += CharValues[roman[i]];
                }
                else if (CharValues[roman[i]] < CharValues[roman[i+1]])
                {
                    sum += CharValues[roman[i + 1]] - CharValues[roman[i]];
                    i++;
                }
                else
                {
                    sum += CharValues[roman[i]];
                }
            }
            return sum;


        }
    }
}

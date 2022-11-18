using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCalc
{
    static public class Calc
    {

        public static void Unit(double size, int unit, ref double newSize, ref int newUnit)
        {
            newSize = size;

            if (unit == newUnit)
            {

            }
            else
            {
                if (unit == 1)
                {
                    unit = 2;
                    newSize = size / 8;
                }
                else if (newUnit == 1)
                {
                    unit -= 1;
                    newSize = size * 8;
                }

                if (unit > newUnit)
                {
                    while (unit > newUnit)
                    {
                        unit--;
                        newSize *= 1024;
                    }
                }
                else if (unit < newUnit)
                {
                    while (unit < newUnit)
                    {
                        unit++;
                        newSize /= 1024;
                        Console.WriteLine("podzielone");
                    }
                }
            }
        }

        public static string ReadUnit(int unit)
        {
            string stringUnit = "";

            switch (unit)
            {
                case 1:
                    stringUnit = "bitów";
                    break;
                case 2:
                    stringUnit = "bajtów";
                    break;
                case 3:
                    stringUnit = "kilobajtów";
                    break;
                case 4:
                    stringUnit = "megabajtów";
                    break;
                case 5:
                    stringUnit = "gigabajtów";
                    break;
                case 6:
                    stringUnit = "terabajtów";
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            return stringUnit;
        }

    }
}

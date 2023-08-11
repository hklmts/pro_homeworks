using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2.hw2._3
{
    public struct DecimalNumber
    {
        public int number;

        public DecimalNumber(int number)
        {
            this.number = number;
        }

        public void DecimalToBinary()
        {
            int n = number;
            var binaryNumber = string.Empty;
            while (n > 0)
            {
                binaryNumber = (n % 2) + binaryNumber;
                n /= 2;
            }
            Console.WriteLine(binaryNumber);
        }
        public void DecimalToOctal()
        {
            int n = number;
            var octalNumber = string.Empty;
            while (n > 0)
            {
                octalNumber = (n % 8) + octalNumber;
                n /= 8;
            }
            Console.WriteLine(octalNumber);
        }
        public void DecimalToHex()
        {
            int n = number;
            int i;
            string j = "";
            var hexNumber = string.Empty;
            while (n > 0)
            {
                i = n % 16;
                if (i > 9)
                {
                    switch (i)
                    {
                        case 10:
                            j = "a";
                            break;
                        case 11:
                            j = "b";
                            break;
                        case 12:
                            j = "c";
                            break;
                        case 13:
                            j = "d";
                            break;
                        case 14:
                            j = "e";
                            break;
                        case 15:
                            j = "f";
                            break;
                    }
                    hexNumber = j + hexNumber;
                }
                else
                {
                    hexNumber = i + hexNumber;
                }
                n /= 16;
            }
            Console.WriteLine(hexNumber);
        }
    }
 
}

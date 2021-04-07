using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperBowlNamer
{
    public class RomanNumeralTranslator
    {
        public string NumberToNumeral(int numberToConvert)
        {
            var result = "";

            while (numberToConvert > 0)
            {
                if (numberToConvert >= 1000)
                {
                    var numberOfThousands = numberToConvert / 1000;
                    result += new string('M', numberOfThousands);
                    numberToConvert %= 1000;
                }
                else if (numberToConvert >= 900)
                {
                    result += "CM";
                    numberToConvert -= 900;
                }
                else if (numberToConvert >= 500)
                {
                    result += "D";
                    numberToConvert -= 500;
                }
                else if (numberToConvert >= 400)
                {
                    result += "CD";
                    numberToConvert -= 400;
                }
                else if (numberToConvert >= 100)
                {
                    result += "C";
                    numberToConvert -= 100;
                }
                else if (numberToConvert >= 90)
                {
                    result += "XC";
                    numberToConvert -= 90;
                }
                else if (numberToConvert >= 50)
                {
                    result += "L";
                    numberToConvert -= 50;
                }
                else if (numberToConvert >= 40)
                {
                    result += "XL";
                    numberToConvert -= 40;
                }
                else if (numberToConvert >= 10)
                {
                    result += "X";
                    numberToConvert -= 10;
                }
                else if (numberToConvert == 9)
                {
                    result += "IX";
                    numberToConvert = 0;
                }
                else if (numberToConvert >= 5)
                {
                    result += "V";
                    numberToConvert -= 5;
                }
                else if (numberToConvert == 4)
                {
                    result += "IV";
                    numberToConvert = 0;
                }
                else if (numberToConvert <= 3)
                {
                    result += new string('I', numberToConvert);
                    numberToConvert = 0;
                }
            }

            return result;
        }
    }
}

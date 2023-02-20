using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EF.Orm.ValueGenarator
{
    public class Increment
    {
        public static string AlphaNumericValue(string value)
        {

            if (string.IsNullOrWhiteSpace(value))
            {
                return "";
            }

            if (Regex.IsMatch(value, "^[a-zA-Z0-9]+$") == false)
            {
                throw new Exception("Invalid Character: Must be a-Z or 0-9");
            }

            var characterArray = value.ToCharArray();

            for (var charIndex = characterArray.Length - 1; charIndex >= 0; charIndex--)
            {
                var charValue = Convert.ToInt32(characterArray[charIndex]);

                if (charValue != 57 && charValue != 90 && charValue != 122)
                {

                    characterArray[charIndex]++;

                    for (int myResetIndex = charIndex + 1; myResetIndex < characterArray.Length; myResetIndex++)
                    {

                        charValue = Convert.ToInt32(characterArray[myResetIndex]);
                        if (charValue >= 65 && charValue <= 90)
                        {
                            characterArray[myResetIndex] = 'A';
                        }
                        else if (charValue >= 97 && charValue <= 122)
                        {
                            characterArray[myResetIndex] = 'a';
                        }
                        else if (charValue >= 48 && charValue <= 57)
                        {
                            characterArray[myResetIndex] = '0';
                        }

                    }

                    return new string(characterArray);

                }

            }

                return null;

        }
    }
}

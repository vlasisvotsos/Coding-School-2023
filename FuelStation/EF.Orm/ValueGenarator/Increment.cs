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
            string? result = null;
            int num = 0;
            for(int i=1; i <= value.Length -1; i++)
            {
                result += value[i];
            }
            num = Convert.ToInt32(result);
            num++;
            result = "A" + num;
            return result;
        }
    }
}

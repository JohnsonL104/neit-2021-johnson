using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johnson_MT
{
    class Validation
    {
        public static bool ValidateFilled(String str)
        {
            if(str.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidateLength(String str, int len)
        {
            if (str.Length >= len)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateEmail(String str)
        {
            if (ValidateLength(str, 8))
            {
                if (str.Contains("@"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        

    }
}

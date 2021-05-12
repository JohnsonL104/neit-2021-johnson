using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4SampleCode
{
    class ValidationLibrary
    {
        public static bool GotBadWords(string temp)
        {
            bool result = false;

            string[] strBadWords = { "POOP", "HOMEWORK", "CACA" };

            foreach (string strBW in strBadWords)
            {
                if (temp.Contains(strBW))
                {
                    result = true;
                }
            }
            return result;
        }


        public static bool IsItFilledIn(string temp)
        {
            bool result = false;
            if (temp.Length > 0)
            {
                result = true;
            }
            return result;
        }
        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = false;
            if (temp.Length >= minlen)
            {
                result = true;
            }
            return result;
        }
        public static bool IsAFutureDate(DateTime temp)
        {
            bool result;
            if (temp <= DateTime.Now)
            {
                result = false;
            }
            else
            {
                result = true;

            }
            return result;
        }
        public static bool IsValidEmail(string temp)
        {
            bool result = true;

            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);

            int periodLocation = temp.LastIndexOf(".");

            if (temp.Length < 8)
            {
                result = false;
            }
            else if(atLocation < 2)
            {
                result = false;
            }
            else if(periodLocation +2 > (temp.Length))
            {
                result = false;
            }
            return result;
        }

        public static bool IsMinimumAmount(int temp, int min)
        {
            bool result;

            if (temp >= min)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public static bool IsMinimumAmount(double temp, double min)
        {
            bool result;

            if (temp >= min)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}

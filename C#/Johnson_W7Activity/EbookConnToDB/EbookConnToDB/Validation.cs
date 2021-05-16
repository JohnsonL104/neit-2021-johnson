using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClass
{
    class Validation
    {
        public static bool GotBadWords(String str)
        {
            bool result = false;

            String[] bws = { "POOP", "HOMEWORK", "CACA" };

            foreach (String bw in bws) {
                if (str.ToUpper().Contains("bw"))
                {
                    result = true;
                }
            }
            return result;
        }

        public static bool ValidateFilled(String str)
        {
            if (str.Length > 0)
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
            bool valid = false;
            if (ValidateLength(str, 8))
            {
                if (str.Contains("@"))
                {
                    if (!str[0].Equals("@"))
                    {
                        if (str.Split('@')[1].Contains("."))
                        {
                            if (str.Split('@')[1].Split('.').Length == 2)
                            {
                                valid = true;
                            }
                        }
                    }
                }
            }
            return valid;
        }

        public static bool ValidateInstagramURL(String str)
        {
            if (str.ToUpper().Contains("INSTAGRAM.COM/"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateState(String str)
        {
            bool valid = false;
            for (int i = 0; i < StateArray.States().Length; i++)
            {
                if (str.Equals(StateArray.Names()[i]) || str.Equals(StateArray.Abbreviations()[i]))
                {
                    valid = true;
                }
            }
            return valid;
        }

        public static bool ValidatePhone(String str)
        {
            String numWithoutDashes = str.Replace("-", "");
            bool valid = true;
            if(ValidateLength(numWithoutDashes, 7))
            for (int i = 0; i < numWithoutDashes.Length; i++)
            {
                    if (!Char.IsDigit(numWithoutDashes[i]))
                    {
                        valid = false;
                    }
            }
            return valid;
        }

        public static bool IsFutureDate(DateTime dt)
        {
            if(dt > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

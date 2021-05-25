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

            foreach (String bw in bws)
            {
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
            str = str.Trim();

            if(str.Contains("@") && str.Contains(".") && !str.Contains(" "))
            {
                if(str.Split('@')[0].Length > 0 && str.Split('@')[1].Contains("."))
                {
                    if (str.Split('@')[1].Split('.')[0].Length > 0 && str.Split('@')[1].Split('.')[1].Length > 1)
                    {
                        bool tempBool = true;
                        foreach(char c in str.Split('@')[1].Split('.')[1])
                        {
                            if ("0123456789".Contains(c))
                            {
                                tempBool = false;
                            }
                        }
                        valid = tempBool;
                    }
                }    
            }
            return valid;
        }

        public static bool ValidateInstagramURL(String str)
        {
            str = str.Trim();
            if (str.ToUpper().Contains("INSTAGRAM.COM/") && !str.Contains(" "))
            {
                if(str.ToUpper().Split(new string[] { "INSTAGRAM.COM/" }, StringSplitOptions.None)[1].Length > 0)
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
            if(ValidateLength(numWithoutDashes, 7)) { 
            for (int i = 0; i < numWithoutDashes.Length; i++)
            {
                    if (!Char.IsDigit(numWithoutDashes[i]))
                    {
                        valid = false;
                    }
            }
            }
            else
            {
                valid = false;
            }
            return valid;
        }
        public static bool IsFutureDate(DateTime dt)
        {
            if (dt > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateZip(String str)
        {
            
            if (str.Length < 5)
            {
                return false;
            }
            bool valid = true;
            String zipString = "0123456789-";
            foreach (char c in str){
                if (!zipString.Contains(c))
                {
                    valid = false;
                }
            }
            return valid;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class CheckGroupNo
    {
        public static bool CheckGroupNoo(this string groupNo) 
        {
            if (groupNo.Length == 4 && char.IsLetter(groupNo[0]) && char.IsDigit(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) )
            {
                return true;
            }
            return false;
        }

        public static bool CheckFullName(this string FullName) 
        {
            if (FullName.Split(" ").Length == 2 && FullName.Split(" ")[1] != "")
            {
                return true;
            }
            return false;
        }
    }
}

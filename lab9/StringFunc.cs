using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab9
{
    class StringFunc
    {
        public static string DeleteSpaces(ref string str)
        {
            while(str.Contains("  "))
            {
                str = str.Replace("  ", "");
            }

            return str;
        }  

        public static void DeletePointers(ref string str)
        {
            str = Regex.Replace(str,"[,.!)(;?]","");
        }

        //public static string GetUpperChars(string str)
        //{
        //    while
        //    return str;
        //}

    }
}

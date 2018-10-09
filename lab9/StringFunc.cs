using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab9
{
    static class StringFunc
    {

        public static void CharCount(string str)
        {
            Console.WriteLine("Строка содержит " + str.Count().ToString() + " символов");
        }

        public static string DeletePointers(string str)
        {
            return str = Regex.Replace(str, "[,.!)(;?]", "");            
        }

        
        //public static string GetUpperChars(ref string str, char c)
        //{
        //    foreach(var el in str)
        //    {
        //        if(el == c)
        //        {
        //            str = str.Insert(str.IndexOf(el), char.ToUpper(el).ToString());
        //            str = str.Remove(str.IndexOf(el),1);
        //        }
        //    }
        //    return str;
        //}

        public static string DeleteSpaces(string str)
        {
           
            while (str.Contains("  "))
            {
                str = str.Replace("  ", "");
            }

            return str;
        }

        public static void ValidateString(string str,  Action<string> op)
        {
            if (str != null && str != "")
            {
                op(str);
            }
            else
            {
                Console.WriteLine("Строка пуста");
            }
        }

        public static string ValidateString(string str, Func<string, string> op)
        {
            string str1 = op(str);
            return str1;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {

            public static string ReverseString(string s)
            {
                string tmp = string.Empty;

                for (int i = s.Length - 1; i >= 0; i--)
                {
                if(char.IsLetterOrDigit(s[i]))
                    tmp += s[i].ToString();
                }

                return tmp;
            }

            static void Main(string[] args)
            {
                Console.WriteLine(ReverseString("V!ncent"));
                Console.Read();
            }
        
    }
   
}

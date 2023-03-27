using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System .Threading .Tasks;

namespace _230327_new3
{
    public static class Extension
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static void PrintVar(string variable, string title)
        {
            Console .WriteLine ( "---------STRING---------------------" );
            Console .WriteLine($"{title} " + variable);
            Console .WriteLine ( "-----------------------------------------" );
        }

        public static void PrintVar ( string variable , int title )
        {
            Console .WriteLine ( "----------INTEGER------------------" );
            Console .WriteLine ( $"{title} " + variable );
            Console .WriteLine ( "-----------------------------------------" );
        }
    }
}

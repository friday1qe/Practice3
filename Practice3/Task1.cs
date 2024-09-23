using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Task1
    {
        public static void FirstTask()
        {
            Console.WriteLine("Type your number");
            string myStr = Console.ReadLine();
            char[] charArray = myStr.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);
            Console.WriteLine(reversedStr);
        }
    }
}

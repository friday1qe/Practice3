using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    internal class Task2
    {
        public static void SecondTask()
        {
            Console.WriteLine("Type any text");
            string anyText = Console.ReadLine();
            char[] charArr = anyText.ToCharArray();

            Console.WriteLine("Type your integer");
            string strX = Console.ReadLine();
            int x = int.Parse(strX);

            string result = "";
            foreach (char item in charArr)
            {
                result += item;
                if (item ==  ' ' && x != 0)
                {
                    result = "";
                    x--;
                }
            }
            Console.WriteLine(result);
        }
    }
}

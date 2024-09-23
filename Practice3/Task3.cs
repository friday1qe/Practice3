using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Task3
    {
        public static void ThirdTask()
        {
            Console.WriteLine("Write your figure");
            string x = Console.ReadLine();
            Console.WriteLine(x);

            if (x == "Квадрат")
            {
                Console.WriteLine("Write size of side");
                var size = Console.ReadLine();
                var i = int.Parse(size);
                Console.WriteLine(i * i);
            }
            else if (x == "Коло")
            {
                float pi = 3.14f;
                Console.WriteLine("Write size of radius");
                string size = Console.ReadLine();
                int i = int.Parse(size);
                Console.WriteLine(pi * (i * i));
            }
            else if (x == "Прямокутник")
            {
                Console.WriteLine("Write size of first side");
                string firstSide = Console.ReadLine();
                Console.WriteLine("Write size of second side");
                string secondSide = Console.ReadLine();
                int q = int.Parse(firstSide);
                int w = int.Parse(secondSide);
                Console.WriteLine(q * w);
            }
            else if (x == "Трикутник")
            {
                Console.WriteLine("Write size of first side");
                string firstSide = Console.ReadLine();
                Console.WriteLine("Write size of second side");
                string secondSide = Console.ReadLine();
                int q = int.Parse(firstSide);
                int w = int.Parse(secondSide);
                Console.WriteLine((q * w) / 2.0f);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}

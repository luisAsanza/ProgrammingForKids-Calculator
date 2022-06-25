using System;

namespace CodingBasic.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayTest = new int[] { 2, 1, 5, 5, 6, 3, 7, 4, 2, 4, 6, 2, 3, 99, 8 };

            Console.WriteLine($"This array has {arrayTest.Length} elements.");
            Console.WriteLine();

            //Console.WriteLine(arrayTest[0]);
            //Console.WriteLine(arrayTest[1]);
            //Console.WriteLine(arrayTest[2]);

            for(int i = 0; i < arrayTest.Length; i++)
            {
                Console.WriteLine($"arrayTest[{i}] = {arrayTest[i]}");
            }




            //Console.WriteLine("SUM Calculator program");
            //Console.WriteLine();
            //Console.WriteLine("Insert a:");
            //string a = Console.ReadLine();
            //Console.WriteLine("Insert b:");
            //string b = Console.ReadLine();

            //Console.WriteLine($"The values inserted are: {a} and {b}");

            //int aInt = int.Parse(a);
            //int bInt = int.Parse(b);
            //int result = aInt + bInt;

            //Console.WriteLine($"The sum of {aInt} + {bInt} = {result}.");
        }
    }
}

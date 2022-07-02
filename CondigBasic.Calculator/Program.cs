using System;

namespace CondigBasic.Calculator
{ 
    /// <summary>
     /// This is the class "Program"
     /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Print program name
            Console.WriteLine("Calculator Machine");
            //Print the menu
            Console.WriteLine("a:Sum");
            Console.WriteLine("b:Subtraction");
            Console.WriteLine("c:Division");
            Console.WriteLine("d:Multiplication");
            Console.WriteLine();

            //Select one option
            //x
            string option = Console.ReadLine();

            /*
             option == "a"
            option == "b"
             option == "c"
            option == "d"

            Si "limpias tu cuarto" O "bañas al perro" podrás ir al cine
            Si "limpias tu cuarto" Y "bañas al perro" podrás ir al cine

            O = OR
            Y = AND

             */

            if (option == "a" || option == "b" || option == "c" || option == "d")
            {
                Console.WriteLine($" Insert a value x: ");
                string x = Console.ReadLine();
                Console.WriteLine($" Insert a value z: ");
                string z = Console.ReadLine();

                //if the user pick the a option them sum
                if (option == "a")
                {
                    int xInt;
                    int zInt;
                    bool resultX = int.TryParse(x, out xInt);
                    bool resultZ = int.TryParse(z, out zInt);

                    /*
                     Si el parsing de x fue exitoso, entonces resultX será true
                    Si el parsing de z fue exitoso, entonces resultZ será true

                    "3"         > resultX = true
                    "ssss"      > resultZ = false
                     */

                    if (resultX && resultZ)
                    {
                        int resultSum = xInt + zInt;
                        Console.WriteLine($"{xInt} + {zInt} = {resultSum}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid format!");
                    }

                    /*
                        x   Z   result
                        ================
                        1   ss  false
                        ss  1   false
                        ss  ss  false
                        1   1   true    if
                     */
                }
                else if (option == "b")
                {
                    int aInt = int.Parse(x);
                    int bInt = int.Parse(z);
                    int result = aInt - bInt;
                    Console.WriteLine($"{aInt} - {bInt} = {result}");
                }
                else if (option == "c")
                {
                    decimal aDecimal = decimal.Parse(x);
                    decimal bDecimal = decimal.Parse(z);
                    decimal result = aDecimal / bDecimal;
                    Console.WriteLine($"{aDecimal} / {bDecimal} = {result}");
                }
                else if (option == "d")
                {
                    int aInt = int.Parse(x);
                    int bInt = int.Parse(z);
                    int result = aInt * bInt;
                    Console.WriteLine($"{aInt} x {bInt} = {result}");
                }
                else
                {
                    Console.WriteLine($"invalid option");
                }
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }

        }
    }
}
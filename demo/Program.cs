using System.Numerics;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine()!;


            Console.Clear();
            Console.WriteLine(" Welcome " + name);
            while (running)
            {


                Console.WriteLine();
                Console.WriteLine("Enter First Number");

                string textNumber1 = Console.ReadLine()!;

                double number1 = 0;

                bool isNumber1;
                do
                {
                    try
                    {
                        number1 = double.Parse(textNumber1);


                        isNumber1 = true;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Invialid input .......");

                        isNumber1 = false;


                        Console.WriteLine("Enter the first number:");

                        textNumber1 = Console.ReadLine()!;

                    }

                }
                while (!isNumber1);





                Console.WriteLine();
                Console.WriteLine("Enter Second Number");
                
                
                string textNumber2 = Console.ReadLine()!;
                double number2 = 0;
                bool isNumber2 = false;
                while (!isNumber2) 
                { 
                    try
                    {
                        number2 = double.Parse(textNumber2);
                        isNumber2 = true;
                         
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("invalid input....");
                       
                        isNumber2 = false;
                        Console.WriteLine("Enter Second Number:");
                        textNumber2 = Console.ReadLine()!;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(" Enter the opirator ( + - * /)");
                string op = Console.ReadLine()!;

                Console.Clear();



                Console.Write(number1 + " " + op + " " + number2 + " = ");

                if (op == "+")
                {
                    Console.Write(number1 + number2);
                }
                else if (op == "-")
                {
                    Console.Write(number1 - number2);
                }
                else if (op == "*")
                {
                    Console.Write(number1 * number2);
                }
                else if (op == "/")
                {
                    Console.Write(number1 / number2);
                }
                else
                {
                    Console.WriteLine("Error Opperator ....!");

                }

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("1 - New operation");
                Console.WriteLine("2 - exit");


                string input = Console.ReadLine()!;


                if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine(" Welcome back " + name);
                }
                else if (input == "2")
                {
                    running = false;

                    Console.Clear();

                    Console.WriteLine("Thank you ... goodbye");
                }
            }





        }
    }
}

using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //Console.WriteLine(input);
            Console.WriteLine(Calculate());
            Console.Read();
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;

            return result;
        }
        /*      
                other options----- int change to void

         static void Main(string[] args)
        {
            Calculate();
            Console.Read();
        }

        public static void Calculate() ///change to void
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;

            Console.WriteLine(result); ///change
        }*/
    }
}
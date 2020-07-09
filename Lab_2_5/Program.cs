using System;
using System.Transactions;

namespace Lab_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.WriteLine("Enter a value for the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            result = number1 - number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            result = number1 * number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            double results2 = (double)number1 / (double)number2;
            double results3 = number1 % number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(results2);
            Console.WriteLine(results3);

            Console.WriteLine("Second C# Program");
            string Yourname = Console.ReadLine();
            string Helloname = "Hello " + Yourname;
            Console.WriteLine(Helloname);

            Console.WriteLine("Third C# Program");
            int num1;
            int num2;
            int num3;
            Console.WriteLine("Enter First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result4 = num1 * num2 * num3;
            Console.WriteLine("The Answer is");
            Console.WriteLine(result4);

            Console.WriteLine("Fourth C# Program");
            int age;
            Console.WriteLine("Hello, How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            string result5;
            result5 = ("You look younger than ") + age;
            Console.WriteLine(result5);



            




        }
    }
}

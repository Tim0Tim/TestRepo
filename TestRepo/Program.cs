using System;

namespace TestRepo
{
    class Program
    {
        static void Main()
        {
            int num1;
            int num2;
            int sum;
            int mult;
            int sub;
            int div;
            int rem;




            Console.Write("Enter first integer: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {sum}");

            sub = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {sub}");

            mult = num1 * num2;
            Console.WriteLine($"{num1} x {num2} = {mult}");

            div = num1 / num2;
            rem = num1 % num2;
            Console.WriteLine($"{num1} divided by {num2} = {div} with {rem} remaining");
        }
    }
}

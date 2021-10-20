using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vali tehe ('+', '/', '-', '*'):");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch(userOperator)
            {
                case '+':
                    AddTwoNumbers(num1, num2);
                    break;
                case '/':
                    DivideTwoNumbers(num1, num2);
                    break;
                case '-':
                    SubtractTwoNumber(num1, num2);
                    break;
                case '*':
                    MultiplyTwoNumber(num1, num2);
                    break;
                default:
                    Console.WriteLine("Vale tehe");
                    break;
            }

        }
        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }
        private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }
        private static void SubtractTwoNumber(double x, double y)
        {
            double result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }
        private static void MultiplyTwoNumber(double x, double y)
        {
            double result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }
    }
}

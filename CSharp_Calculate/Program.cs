using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace Lesson
{
    public class Calculator
    {
        public void MathAction(string action, int firstNumber, int secondNumber)
        {

            switch (action)
            {
                case "+":
                    Console.WriteLine($"Your result: {firstNumber + secondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"Your result: {firstNumber - secondNumber}");
                    break;
                case "*":
                    Console.WriteLine($"Your result: {firstNumber * secondNumber}");
                    break;
                case "/":
                    Console.WriteLine($"Your result: {firstNumber / secondNumber}");
                    break;
                default:
                    Console.WriteLine($"You need enter only + - / *");
                    break;
            }

        }
    }

    public class Program
    {

        public static void Main()
        {

            try
            {
                Console.WriteLine("Enter the first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter math action:");
                string? mathAction = Convert.ToString(Console.ReadLine());


                Calculator result = new Calculator();
                result.MathAction(mathAction, firstNumber, secondNumber);
            }            
            catch (FormatException)
            {
                Console.WriteLine("Enter the numbers please");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You trying to divide by zero");
            }
            

        }
    }
}
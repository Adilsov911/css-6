using System;

namespace homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Addition addition = new Addition();
            
            
            Console.WriteLine(addition.Number());

            Substraction substraction = new Substraction();

            Console.WriteLine(substraction.Number());

            Multiplication multiplication = new Multiplication();
            Console.WriteLine(multiplication.Number());

            Division division = new Division();
            Console.WriteLine(division.Number());
        }

        
    }
}

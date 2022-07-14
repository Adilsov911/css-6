using System;

namespace homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Addition addition = new Addition();
            
            
            Console.WriteLine(addition.Number(5,5));

            Substraction substraction = new Substraction();

            Console.WriteLine(substraction.Number(7,6));

            Multiplication multiplication = new Multiplication();
            Console.WriteLine(multiplication.Number(3,5));

            Division division = new Division();
            Console.WriteLine(division.Number(100,20));
        }

        
    }
}

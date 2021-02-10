using System;
using System.Text;
using PrimeFactors;
using static System.Console;
 

namespace PrimeFactorsCA
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var isNumber = int.TryParse(input, out int number);
            var getPrimeFactors = new PrimeFactor();

            if(isNumber)
            {
                var result = getPrimeFactors.GetPrimeFactor(number);
                WriteLine(result);
            }  
            else
            {
                WriteLine($"'input' data: {input} is not valid number.");
            }    
        }
    }
}

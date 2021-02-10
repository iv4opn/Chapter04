using System;
using System.Text;
using static System.Console;

namespace PrimeFactors
{
    public class PrimeFactor
    {
        public string GetPrimeFactor(int number)
        {
            StringBuilder primeFactors = new StringBuilder();

             if(number == 1)
                return number.ToString();

            for (int i = 2; i <= 1000;)
            {
                

                if (number % i == 0)
                {
                    number = number / i;
                    primeFactors.Append(i + "x");
                }
                else
                {
                    i++;
                }
            }
            var result = primeFactors.ToString();
            return result;
        }
    }
}

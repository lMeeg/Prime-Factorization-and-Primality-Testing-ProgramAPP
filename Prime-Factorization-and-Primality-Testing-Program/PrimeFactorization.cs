using System;

public class PrimeFactorization
{
    public static string Factorize(int n)
    {
        int originalNumber = n;
        string result = "";
        int factor = 2;
        bool isPrime = true;

        if (n > 1)
        {
            while (factor <= (int)Math.Sqrt(n))
            {
                if (n % factor == 0)
                {
                    result += $"{factor} * ";
                    n = n / factor;
                    isPrime = false;
                }
                else
                {
                    factor++;
                }
            }

            if (n > 1)
            {
                result += n;
            }

            if (isPrime)
            {
                return $"{originalNumber} is a prime number.       {originalNumber} = {result}";
                
            }
            else
            {
                return $"{originalNumber} = {result}       {originalNumber} is not a prime number.";
            }
        }

        return "Enter a positive integer greater than 1.";
    }
}

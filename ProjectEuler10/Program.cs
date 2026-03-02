using System.Diagnostics.Metrics;

namespace ProjectEuler10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            long primeSum = 0; 
            for (long i = 2; i < 2000000; i++)
            {
                for (long j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        counter = 1;
                        break;
                    }
                }
                
                if (counter==0)
                {
                    primeSum += i;                   
                }
                counter = 0;
            }

            Console.WriteLine(primeSum);
        }
    }
}

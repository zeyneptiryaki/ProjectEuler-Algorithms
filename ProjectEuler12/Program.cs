using System.Security.Cryptography;

namespace ProjectEuler12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double triangularNumber = 0;
            int d = 1;
            int counter = 0;

            while (true)
            {
                triangularNumber = triangularNumber+d;  
                d= d + 1;
                for (int i = 1; i <= Math.Sqrt(triangularNumber); i++)
                {
                    if (triangularNumber%i==0)
                    {
                        counter++;

                        double root = Math.Sqrt(triangularNumber);
                        if ((long)root * (long)root == triangularNumber)
                        {
                            counter--;
                        }
                    }
                }
                if (counter > 250)
                {
                    Console.WriteLine(triangularNumber);
                    break;
                }
               counter = 0;
            }




        }
    }
}

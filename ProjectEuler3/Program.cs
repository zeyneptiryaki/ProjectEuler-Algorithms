namespace ProjectEuler3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double number = 600851475143;
            for (i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    number = (number / i);
                }
                if (number == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

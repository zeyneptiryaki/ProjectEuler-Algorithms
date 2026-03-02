namespace ProjectEuler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int k = 1;
            int number = 2;

            while (number < 4000000 && k < 4000000)
            {
                if (number % 2 == 0)
                {
                    total = total + number;
                }
                k = k + number;
                if (k % 2 == 0)
                {
                    total = total + k;
                }
                number = number + k;
            }
            Console.WriteLine("Total: " + total);
        }
    }
}

namespace ProjectEuler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                    total = total + i;
                }
            }
            Console.WriteLine("Sayıların toplamı: " + total);
        }
    }
}

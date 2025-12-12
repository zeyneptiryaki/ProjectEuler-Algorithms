namespace ProjectEuler6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int total2 = 0;
            for (int i = 1; i < 101; i++)
            {
                total = total + i;
            }

            for (int k = 1; k < 101; k++)
            {
                total2 = total2 + k * k;
            }
            Console.WriteLine((total * total) - total2);
        }
    }
}

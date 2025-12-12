namespace ProjectEuler5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int e = 0;
            int temp = 1;
            double product = 1;

            for (int i = 2; i < 21; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        e = e + 1;
                    }
                }
                if (e == 0)
                {
                    while (temp * i <= 20)
                    {
                        temp = temp * i;
                    }
                    product = temp * product;
                }
                temp = 1;
                e = 0;
            }
            Console.WriteLine(product);
        }
    }
}

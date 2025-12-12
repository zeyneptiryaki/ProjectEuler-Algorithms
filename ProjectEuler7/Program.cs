namespace ProjectEuler7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int e = 0;
            int counter = 0;
            while (counter<10001)
            {
                i = i + 1;
                for (int j = 2; j <i; j++)
                {
                    if (i%j==0)
                    {
                        e = e + 1;
                        j = i;
                    }
                }
                if (e==0)
                {
                    counter = counter + 1;
                }
                e = 0;
            }
            Console.WriteLine(i);
            
            
        }
    }
}

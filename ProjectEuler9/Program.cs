namespace ProjectEuler9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 999; a++) 
            {
                for (int b = 0; b < 999; b++)
                {
                    for (int c = 0; c < 999; c++)
                    {
                        if ((a+b+c==1000)&& (a*a) + (b*b) == (c*c)&&(a<b)&&(b<c))
                        {
                            Console.WriteLine(a*b*c);
                        }

                    }
                }
            }

        }
    }
}

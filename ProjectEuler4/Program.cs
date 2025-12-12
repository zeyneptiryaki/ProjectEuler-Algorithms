namespace ProjectEuler4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;

            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {

                    string number = Convert.ToString(i * j);
                    string c = "";

                    for (int m = 0; m < number.Length; m++)
                    {
                        c = number[m] + c;
                    }

                    if (c == number && Convert.ToInt32(i * j) > max)
                    {
                        max = Convert.ToInt32(i * j);
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}

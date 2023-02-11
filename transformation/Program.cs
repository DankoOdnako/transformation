namespace transformation
{
    internal class Program
    {
        public static void Main()
        {
            Sum s = new Sum();
            Console.WriteLine(s.GetSum(1, 2));

        }
        public class Sum
        {
            public int GetSum(int a, int b)
            {
                int sum = 0;
                if (a == b)
                    sum = b;
                else if (a > b)
                {
                    for (int i = b; i <= a; i++)
                        sum += i;

                }
                else if (a < b)
                {
                    for (int i = a; i <= b; i++)
                        sum += i;
                }
                return sum;

            }
        }

    }
}






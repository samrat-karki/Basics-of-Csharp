namespace Program
{
    class GCD
    {
        static void Main(string[] args)
        {
            string a,b;
            int gcd = 1;
            int smallest;
            Console.Write("input a: ");
            a = Console.ReadLine();
            Console.Write("input b: ");
            b = Console.ReadLine();
            Console.WriteLine("Selected numbers are {0} and {1}",a,b);
            int num1 = Int32.Parse(a);
            int num2 = Int32.Parse(b);
            if (num1 > num2)
            {
                smallest = num2;
            }
            else
            {
                smallest = num1;
            }
            for (int i = smallest; i > 1; i--)
            {
                if (num1%i == 0 && num2%i == 0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine("The Gcd of given number is {0},{1} is {2}",num1,num2,gcd);
        }
    }
}

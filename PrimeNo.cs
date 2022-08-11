using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter the number");
            int num = System.Convert.ToInt32(System.Console.ReadLine());
            int count = 0;
            for (int i = 1; i <=num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
                if (count == 2)
                    System.Console.WriteLine("Prime No");
                else
                    System.Console.WriteLine("Not Prime No");
            
             System.Console.ReadLine();
        }
    }
}

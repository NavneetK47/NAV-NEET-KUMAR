class Demo
{
    static void Main()
    {
        int a = 0, b = 1;
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
        int c;
        for(int i=2; i<=10; i++)
        {
            c = a + b;
            System.Console.WriteLine(c);
            a = b;
            b = c;
        }
        System.Console.ReadLine();
    }
}
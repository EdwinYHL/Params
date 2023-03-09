class Program
{
private static void increment(ref int x)
{
    x++;
}
private static void plus(int a, int b, out int c)
{
    c= a + b;
}
    private static void Main(string[] args)
    {
        int x = 10;
        increment(ref x);
        int y = 10;
        int result;
        plus(x,y,out result);
        Console.WriteLine(x);
        Console.WriteLine(result);
    }
}
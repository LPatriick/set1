namespace set1
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
     int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int d = a; a=b; b = d;
            Console.WriteLine(a+" "+b);
        }
    }
}

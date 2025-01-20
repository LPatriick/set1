namespace set1
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
     int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a= a-b;
            Console.WriteLine(a+" "+ b);
        }
    }
}

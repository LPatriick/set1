namespace set1
{
    internal class Program
    {
static int Nrdiv(int a,int b,int n)
        {
            int ctB = b / n;
            int ctA= a/ n;
            return ctB-ctA;
        }
            static void Main(string[] args)
        {
int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
     int n = int.Parse(Console.ReadLine());
            int nrd = Nrdiv(a,b,n);
            Console.WriteLine(nrd);
        }
    }
}

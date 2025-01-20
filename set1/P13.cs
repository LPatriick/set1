namespace set1
{
    internal class Program
    {
static int AnBis(int y1,int y2)
        {
            int numy2=NumBis(y2);
                int numy1= NumBis(y1-1);
            return numy2 - numy1;
        }
        static int NumBis(int y)
        {
            int num = 0;
            for (int i = 4; i <= y; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                {
                    num++;
                }
            }
            return num; 
        }
            static void Main(string[] args)
        {
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int anibis = AnBis(y1,y2);
            Console.WriteLine(anibis);
        }
    }
}

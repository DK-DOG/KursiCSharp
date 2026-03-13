namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 0, neg = 0, n;
            do
            {
                n = int.Parse(Console.ReadLine()!);
                if (n > 0) pos++;
                else if (n < 0) neg++;
            }
            while (n != 0);
            if (pos > neg) Console.WriteLine("Положительных больше");
            else if (neg > pos) Console.WriteLine("Отрицательных больше");
            else Console.WriteLine("Поровну");
        }
    }
}

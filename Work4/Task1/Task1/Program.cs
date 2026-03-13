namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += 2 * i - 1;
                Console.WriteLine(sum);
            }
        }
    }
}

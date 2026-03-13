namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine()!);
            int B = int.Parse(Console.ReadLine()!);
            int C = int.Parse(Console.ReadLine()!);
            int countA = 0, sum = 0;
            while (sum + C <= A)
            {
                sum += C;
                countA++;
            }
            int countB = 0;
            sum = 0;
            while (sum + C <= B)
            {
                sum += C;
                countB++;
            }
            int total = 0, i = 0;
            while (i < countA)
            {
                total += countB;
                i++;
            }
            Console.WriteLine(total);
        }
    }
}

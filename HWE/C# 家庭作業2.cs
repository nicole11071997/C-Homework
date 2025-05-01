namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入人數：");
            int g = int.Parse(Console.ReadLine()); //玩家輸入的數字
            Console.Write("   ID ");
            for (int i = 0; i <= g-1  ; i++)
            {
                Console.Write("{0,2}", i);
            }


            Console.WriteLine();

            Console.Write("接觸者");
            int[] a = new int[g];
            for (int i = 0; i < a.Length; i++) a[i] = i;

            Random rng = new Random();
            for (int i = 0; i < a.Length - 1; i++)
            {
                int j = rng.Next(i, a.Length);
                int tmp = a[i]; a[i] = a[j]; a[j] = tmp;
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0,2}", a[i]);
            }

            Console.WriteLine();

            Console.WriteLine("----------------");
            Console.WriteLine("輸入感染者ID：");

            Console.WriteLine("這些人將在接下來的14天內進行自我隔離：");
        }
    }
}

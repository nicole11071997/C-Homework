namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入人數：");
            int g = int.Parse(Console.ReadLine()); //使用者輸入總人數

            //ID = 感染者
            Console.Write("   ID ");

            // 建立 0 ~ N-1 的 ID 陣列(建立感染者的資料)
            int[] c = new int[g]; //新增陣列
            for (int i = 0; i < c.Length; i++) c[i] = i;

            //輸出感染者的資料(顯示感染者 ID)
            for (int i = 0; i <= g-1  ; i++)
            {
                Console.Write("{0,2}", i);
            }

            Console.WriteLine();

            Console.Write("接觸者");
            //建立接觸者洗牌前的資料
            int[] a = new int[g]; //新增陣列
            for (int i = 0; i < a.Length; i++) a[i] = i;

            //接觸者洗牌(洗牌，產生每個人的接觸者)
            Random rng = new Random();
            for (int i = 0; i < a.Length - 1; i++)
            {
                int j = rng.Next(i, a.Length);
                int tmp = a[i]; a[i] = a[j]; a[j] = tmp;
            }

            //輸出接觸者洗牌後的資料(顯示接觸者列表)
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0,2}", a[i]);
            }

            Console.WriteLine();

            Console.WriteLine("----------------");

            Console.WriteLine("輸入感染者ID：");
            int n = int.Parse(Console.ReadLine()); // 最初的感染者 ID

            bool[] visited = new bool[g];
            int current = n;

            Console.WriteLine("這些人將在接下來的14天內進行自我隔離：");

            while (!visited[current])
            {
                Console.Write("{0,1}", current); // 輸出當前感染者
                visited[current] = true;         // 標記為已感染
                current = a[current];            // 感染下一個人
            }

            Console.WriteLine();
        }
    }
}

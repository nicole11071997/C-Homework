namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int a = rng.Next(100); //電腦隨機的答案
            Console.WriteLine(a);
            int x = 0; //最小的
            int y = 99; //最大的

            Console.WriteLine("[{0},{1}]", x, y);

            Console.WriteLine("請猜數字?");
            int g = int.Parse(Console.ReadLine()); //玩家輸入的數字

            while (g !=a ) {
                if (g < x | g > y)
                {
                    Console.WriteLine("請玩家重新輸入");
                    g = int.Parse(Console.ReadLine());
                }
                if (g < a)
                {
                    x = g + 1;
                }
                if (g > a)
                {
                    y = g - 1;
                }
                Console.WriteLine("答錯了！，繼續猜數字");
                Console.WriteLine("[{0},{1}]", x, y);
                g = int.Parse(Console.ReadLine());

                if (y-x == 1)
                {
                    break;
                }
                if (g - a == 1 & a==x)
                {
                    break;
                }
                if (a - g == 1 & a == y)
                {
                    break;
                }
            }
               if (g == a)
            {
                Console.WriteLine("答對了！");
            }
            else
            {
                Console.WriteLine("你輸了！");
            }
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 不重複樂透
{
    class Program
    {
        static void Main(string[] args)
        {
            // 建立一個List，並放入 1~42
            List<int> number = new List<int>();

            for (int i = 1; i < 42; i++)
            {
                number.Add(i);
            }

            // 產生亂數 ( 重複6次 )
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                // 隨機挑選 "剩下的" 其中一個
                int r = rand.Next(1, number.Count);
                Console.Write(number[r] + " ");

                // 從List中刪除
                number.RemoveAt(r);
            }

            // 暫停畫面
            Console.Read();
        }
    }
}

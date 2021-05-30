using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //配列の使い方例
            /*
            int[] numbers = new int[2];
            numbers[0] = 1;
            numbers[1] = 3;
            int i = 0;
            Console.WriteLine(numbers[i]);
            */

            //リストの使い方例
            /*
            List<int> numbers = new List<int>();
            numbers.Add(1);//0番目に代入
            numbers.Add(3);//1番目に代入
            Console.WriteLine(numbers[0]);//使い方は配列と同じ
            numbers.Remove(1);//値（中身）を指定して削除
            numbers.RemoveAt(0);//場所を指定して削除
            */

            //switch文の使い方
            /*
            string job = "プログラマー";
            switch (job)
            {
                case "プログラマー"://←；ではなく：なのに注意
                    Console.WriteLine("よわそう");
                    break;
                case "データサイエンティスト":
                    Console.WriteLine("つよそう");
                    break;
                default://何にも当てはまらないとき
                    Console.WriteLine("そんな職業しらない");
                    break;
            }
            */

            //for文
            /*
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            */

            //配列との組み合わせ
            /*
            string[] items = new string[] { "a", "b", "c" };
            for(int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
            */

            //foreach文
            /*
            string[] items = new string[] { "a", "b", "c" };
            foreach(string item in items)
            {
                Console.WriteLine(item);
            }
            */

            //while文
            /*
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            */

            //最後のサンプルコード
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            int sum = 0;
            while(input != "END")
            {
                int num = int.Parse(input);
                numbers.Add(num);
                sum += num;
                input = Console.ReadLine();
            }

            Console.WriteLine("**********");

            double heikin = (double)sum / numbers.Count;
            //Console.WriteLine(heikin);
            foreach(int number in numbers)
            {
                if(number > heikin)
                {
                    Console.WriteLine(number);
                }
            }


            Console.ReadKey();
        }
    }
}

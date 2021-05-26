using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //変数と計算、型変換
            //string name;
            //Console.WriteLine("名前を入力してください");
            //name = Console.ReadLine();
            //string ageStr;
            //Console.WriteLine("年齢を入力してください");
            //ageStr = Console.ReadLine();
            //int age;
            //age = int.Parse(ageStr);
            //int limit = 40 - age;
            //Console.WriteLine("Hello"+name+"あなたはあと" + limit + "年後に40歳");

            //条件分岐
            string input = Console.ReadLine();
            int age = int.Parse(input);
            if(age >= 20)
            {
                Console.WriteLine("成年です");
            }
            else
            {
                Console.WriteLine("未成年です");
            }

            int i = 0;
            bool iIsZero;
            iIsZero = (i == 0);
            if (!iIsZero)
            {
                Console.WriteLine("iの中身は0じゃないです");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string output = ChangeToWareki(2021);
            Console.WriteLine(output);
            */
            /*List<Food> foods = new List<Food>();
            for(int i = 0; i < 3; i++)
            {
                string name = Console.ReadLine();
                string country = Console.ReadLine();
                Food food = new Food(name);
                foods.Add(food);
            }
            foreach(Food f in foods)
            {
                f.Intro();
            }*/
            /*bool run = true;
            List<Food> foods = new List<Food>();
            while (run)
            {
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "ADD":
                        Console.WriteLine("追加したい料理名");
                        string name = Console.ReadLine();
                        string country = Console.ReadLine();
                        Food food = new Food(name, country);
                        foods.Add(food);
                        break;
                    case "DELETE":
                        Console.WriteLine("削除したい料理名");
                        string deleteName = Console.ReadLine();
                        for(int i = 0; i < foods.Count; i++)
                        {
                            if(foods[i].name == deleteName)
                            {
                                foods.RemoveAt(i);
                                Console.WriteLine(deleteName + "を削除しました");
                                break;
                            }
                        }
                        break;
                    case "LIST":
                        foreach(Food f in foods)
                        {
                            f.Intro();
                        }
                        break;
                    case "END":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("無効なコマンドです");
                        break;
                        
                }
            }*/


            Console.ReadKey();
        }
        




        static string ChangeToWareki(int year)
        {
            string str = "";
            if (year <= 1988)
            {
                str = "昭和" + (year - 1925) + "年";
            }
            else if (year <= 2018)
            {
                str = "平成" + (year - 1988) + "年";
            }
            else
            {
                str = "令和" + (year - 2018) + "年";
            }
            return str;
        }
    }
    class CapNoodle : Food
    {
        public int buildTime;
        public CapNoodle(string name,string country,int buildTime) : base(name, country)
        {
            this.buildTime = buildTime;
        }
    }
    class Food
    {
        public string name;
        private string country;
        public int calorie;
        public Food(string name,string country)
        {
            this.name = name;
            this.country = country;
        }
        public Food(string name)
        {
            this.name = name;
            this.country = "日本";
        }
        public void Intro()
        {
            Console.WriteLine(name + "は" + country + "の料理です");
        }
        public void ToLowCalorie()
        {
            calorie /= 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS280_Homework_1._2;

namespace CS280_Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("請輸入寶可夢的編號:");
            try
            {
                int Poke_Number = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("編號輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
            }

            Console.Write("請輸入寶可夢的名稱:");
            try
            {
                string Poke_Name = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("名稱輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
            }

            Console.Write("請輸入寶可夢的身高:");
            try
            {
                float Poke_Height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("身高輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
            }

            Console.Write("請輸入寶可夢的體重:");
            try
            {
                float Poke_Weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("體重輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
            }

            Console.Write("請輸入寶可夢的種類:");
            try
            {
                string Poke_Category = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("種類輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
            }

            Console.Write("請輸入寶可夢的技能:");
            try
            {
                string Poke_Abilities = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("技能輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
            }

            Console.Write("請輸入寶可夢的性別:");
            try
            {
                string Poke_Gender = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("性別輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
            }
        }
    }
}

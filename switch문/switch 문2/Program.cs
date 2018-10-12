using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_문2
{
    class Program
    {
        static void Main(string[] args)
        {
            string color;
            Console.Write("영어로 색을 입력하세요\n");
            color = Console.ReadLine();
            switch (color.ToLower())
            {
                case "red":
                    Console.WriteLine("빨간색");
                    break;
                case "green":
                    Console.WriteLine("초록색");
                    break;
                case "blue":
                    Console.WriteLine("파란색");
                    break;
                default:
                    Console.WriteLine("모릅니다");
                    break;
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch문
{
    class Program
    {//열거형 자료 선언하기-상수들을 하나로 묶어서 사용한다.
        //값지정하지 않으면 0부터 시작되서 값들이 자동으로 부여
        enum MyColor
        {
            red,green,blue,magneta,yellow,black
        }
        static void Main(string[] args)
        {
            MyColor color;
            Console.Write("색 : ");
            color = (MyColor)int.Parse(Console.ReadLine());

            switch (color) {
                case MyColor.red:
                    Console.WriteLine("빨간색");
                    break;
                case MyColor.green:
                    Console.WriteLine("초록색");
                    break;
                case MyColor.blue:
                    Console.WriteLine("파란색");
                    break;
                case MyColor.magneta:
                    Console.WriteLine("분홍색");
                    break;
                case MyColor.yellow:
                    Console.WriteLine("노란색");
                    break;
                case MyColor.black:
                    Console.WriteLine("검은색");
                    break;
                default:
                    Console.WriteLine("그런 색은 없습니다");
                    break;
            }

        }
    }
}

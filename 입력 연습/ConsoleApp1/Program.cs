using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 입력연습
{
    class Program
    {
        static void Main(string[] args)
        {
            string 이름;
            int age;

            Console.Write("이름 : ");
            이름 = Console.ReadLine();

            Console.Write("나이 : ");
            age = int.Parse(Console.ReadLine());
            //int.Parse  데이터 타입을 int로 바꿔준다.

            Console.WriteLine("{0}님의 나이는 {1} 입니다", 이름, age);
        }
    }
}

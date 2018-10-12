using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if문_연습
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("알고 싶은 등급은?");
            string grade = Console.ReadLine();

            if (grade == "G")
                Console.WriteLine("연소자 관람가");
            else if (grade == "PG")
                Console.WriteLine("17세 미만 보호자 동반 권장");
            else if (grade == "R")
                Console.WriteLine("17세 미만 보호자 동반 필수");
            else if (grade == "X")
                Console.WriteLine("미성년자 관람불가");
            else if (grade == "XXX")
                Console.WriteLine("미성년자 절대 불가, 성인도 조금 위험");
            else
                Console.WriteLine("그런 등급은 없습니다.");
        }
    }
}

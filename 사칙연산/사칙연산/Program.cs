using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 사칙연산
{
    class Program
    {
        static void Main(string[] args)
        {
            //예외처리를 이용해서 파싱 오류 처리하기
            int x;
            int y;
            try
            {
                Console.Write("x = ");
                x = int.Parse(Console.ReadLine());

                Console.Write("y = ");
                y = int.Parse(Console.ReadLine());

                Console.WriteLine("결과: {0}", x + y);

            }catch(FormatException ex)
            {
                Console.WriteLine("error : {0}", ex.Message);
            }
        }
    }
}

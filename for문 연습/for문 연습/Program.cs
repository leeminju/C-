using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for문_연습
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, s = 0;

            for (i = 1; i <= 10; i++)
                Console.Write("i={0}\n", i);

            Console.WriteLine("구구단");

            for (i = 3; i <= 6; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i, j, i * j);
                }
            }

            //foreach구문
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int n in a)//앞에 타입은 배열의 요소의 타입
            {
                //a배열로 부터 데이터를 하나씩 꺼내서 n변수로 전달한다.
                Console.WriteLine(n);
            }

            String[] words = new String[]//힙, 참조변수, 포인터
             {
               "장미","백합","국화","수국","철쭉","진달래","개나리","아카시아","카라","벡일홍"
             };

            foreach(String item in words)
            {
                Console.WriteLine(item);
            }

            i = 1;
             while(i<=5)//반드시 조건식만 (true,false 구분가능해야함)
            {
                Console.WriteLine(i);
                i++;
            }

            i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);
        }
    }
}

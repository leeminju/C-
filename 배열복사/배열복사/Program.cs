using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열복사
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = { 10, 20, 30, 40, 50 };
            //할당안하면 복사안됨, 크기 달라도 안됨
            int[] source2 = { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
            //c#에서 배열은 참조변수
            //참조만 복사하고 원래 target이 갖고있는 데이터는 나중에 쓰레기 수집기(가비지 콜랙터)가 싹 거두어 간다.
            //얕은 복사
         //   target = source;//c는 에러,대입안됨

            Array.Copy(source, target, 2);//앞에 두개만 복사
            foreach (int n in target)
                Console.Write("{0,5}", n);
            Console.WriteLine();


            Array.Copy(source2, 2, target, 3, 2);
            //원본 2번 방부터 목적지 3번방에 2개만
            foreach (int n in target)
                Console.Write("{0,5}", n);
            Console.WriteLine();

        }
    }
}

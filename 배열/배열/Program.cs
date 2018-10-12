using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#에서의 배열은 참조타입이다.
            //힙에 동적 생성이 된다는 점에서 C++과 다르다.
            //그래서 , 프로그램 수행도중(실행시간)에 크기가 변할 수도 있다.
            //새로 할당이 가능하다.
            int[] arr;//배열 참조변수 선언하기
            arr = new int[10];//배열크기 확보하기
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("정수: ");
                String temp = Console.ReadLine();
                int n;

                if(int.TryParse(temp,out n))//정수라면 out에 정수 반환
                    arr[i] = n;
                else
                    arr[i] = 0;
                
              //  arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("합계 : {0}", sum);
        }
    }
}

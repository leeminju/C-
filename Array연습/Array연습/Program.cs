using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array연습
{
    class Program
    {
        static void WriteArray(int []arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0}\t", arr[i]);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] {
                4,5,1,9,8,7,6,9,2,10
            };

            int pos = Array.IndexOf(arr, 9);

            //검색-앞에서 검색하기
            while (pos != -1)
            {
                Console.WriteLine(pos);
                pos = Array.IndexOf(arr, 9,pos+1);
            }

            //정렬
            Array.Sort(arr);//객체 안만들고 호출-static
            WriteArray(arr);
            //뒤집기
            Array.Reverse(arr);
            WriteArray(arr);

            string[] words;
            words = new string[]
            {
                "오예스","초코파이","몽쉘통통","사브레","에이스","참크레커","뽀또","마이구미","카스터드",
                "크라운산도","빅파이","쿠크다스"
            };
            pos =Array.IndexOf(words, "빅파이");
            Console.WriteLine("빅파이 위치 : " + pos);

            //정렬하기
            Array.Sort(words);
            foreach (string item in words)
                Console.WriteLine(item);

            pos = Array.BinarySearch(words, "쿠크다스");
            Console.WriteLine("쿠크다스 위치 : " + pos);

            Console.WriteLine("-----뒤집기------");
            Array.Reverse(words);
            foreach (string item in words)
                Console.WriteLine(item);
         
        }
    }
}

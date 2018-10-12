using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 스트링_배열
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words;
            words = new string[]
            {
                "오예스","초코파이","몽쉘통통","사브레","에이스","참크레커","뽀또","마이구미","카스터드",
                "크라운산도","빅파이","쿠크다스"
            };
            foreach (string item in words)
                Console.WriteLine(item);

            int i;
            bool flag=false;
            string keyword;

            Console.Write("찾는 과자?");
            keyword = Console.ReadLine();
            for (i = 0; i < words.Length; i++)
            {
                if(words[i]==keyword)
                {
                    flag = true;
                    break;
                }
            }

            if (flag == true)
            {
                Console.WriteLine("{0}번쨰에 있음", i);
            }
            else
            {
                Console.WriteLine("{0} 못찾음", keyword);
            }
        }
    }
}

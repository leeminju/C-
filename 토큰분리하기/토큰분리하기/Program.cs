using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 토큰분리하기
{
    class Program
    {
        static void Main(string[] args)
        {
            String soruce = "대한민국 중국 일본 미국 독일 프랑스.영국";
            string[] elements;
            char[] del = new char[] { ' ', ',','.' };
            elements = soruce.Split(del);
            foreach(string item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}

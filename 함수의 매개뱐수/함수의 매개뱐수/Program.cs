using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 함수의_매개뱐수
{
    class Program
    {
        void Swap(int x,int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        void Swap(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        void Sigma(int limit, out int result)
        {//함수안에서 초기화
            int i;
            result = 0;
            for (i = 1; i <= limit; i++)
                result += i;
            
        }
        static void Main(string[] args)
        {
            int x = 10, y = 8;
            Program p = new Program();
            
            //call-by-value 값안바뀜
            p.Swap(x, y);
            Console.WriteLine("x = {0} y = {1}", x, y);

            p.Swap(ref x, ref y);//초기화 되있어야함
            Console.WriteLine("x = {0} y = {1}", x, y);

            int result;//초기화 안해도 됨
            p.Sigma(10, out result);
            Console.WriteLine("결과 {0}", result);
        }
    }
}

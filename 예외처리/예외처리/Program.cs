using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예외처리
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            try
            {
                Console.Write("x=");
                x = int.Parse(Console.ReadLine());
                Console.Write("y=");
                y = int.Parse(Console.ReadLine());
                if (y == 0)
                    throw new Exception("예외 던짐");//Exception이 받음,return의 역할을 한다,
                
                z = x / y;

                Console.WriteLine("z={0}", z);

                int[] a = new int[] { 1, 2, 3 };
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0,4}", a[i]);
                }
                Console.WriteLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("2" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("3" + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 다차원배열
{
    class Program
    {
        static void Main(string[] args)
        {
            //java 다차원배열과 가변배열이 같은
            //C#은 다차원배열과 가변배열이 다르다.
            int[,] a = new int[3, 4];//다차원배열
            a[0, 0] = 1;
            a[0, 1] = 2;
            a[0, 2] = 3;
            a[0, 3] = 4;

            a[1, 0] = 5;
            a[1, 1] = 6;
            a[1, 2] = 7;
            a[1, 3] = 8;

            a[2, 0] = 9;
            a[2, 1] = 10;
            a[2, 2] = 11;
            a[2, 3] = 12;

            foreach(int item in a)
            {
                Console.WriteLine(item);
            }

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                    Console.Write("{0,4}", a[i, j]);
                Console.WriteLine();
            }
            //가변배열
            int[][] b = new int[3][];
            b[0] = new int[3] { 1, 2, 3 };
            b[1] = new int[5] { 1, 2, 3, 4, 5 };
            b[2] = new int[4] { 10, 20, 30, 40 };

            for(int i = 0; i < b.Length; i++)
            {
                for(int j = 0; j < b[i].Length; j++)
                {
                    Console.Write("{0,4}", b[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

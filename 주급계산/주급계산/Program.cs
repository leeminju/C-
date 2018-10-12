using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 주급계산
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int work_time;
            int pay_per_time;
            int pay_per_week;

            Console.Write("이름 : ");
            name=Console.ReadLine();

            Console.Write("주간 근무시간: ");
            work_time = int.Parse(Console.ReadLine());

            Console.Write("시간당 급여: ");
            pay_per_time = int.Parse(Console.ReadLine());

            pay_per_week = work_time * pay_per_time;


            Console.WriteLine("{0}의 주당 급여: {1}원",name,pay_per_week);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 객관식성적처리
{
    class Student
    {

        public String name { set; get; } //이름
        public String dap { set; get; }  //답안
        public String ox { set; get; }   //ox저장용
        public int correct { private set; get; }  //맞은 개수
        public int score { private set; get; }   //점수 

        public Student()
        {
            correct = 0;
            score = 0;
        }
        public Student(String name,String answer)
        {
            this.name = name;
            this.dap = answer;
        }

        public void Process(string jungdap)
        {
            for (int i = 0; i < jungdap.Length; i++)
            {
                if (dap[i] == jungdap[i])
                {
                    ox += 'O';
                    correct++;
                }
                else
                {
                    ox += 'X';
                }
            }
            score = correct * (100/jungdap.Length);
        }
        public void Display()
        {

            Console.WriteLine("-----------------------");
            Console.WriteLine("이름:{0}", name);
            Console.WriteLine("답안:{0}", dap);
            Console.WriteLine("채점:{0}", ox);
            Console.WriteLine("맞은 갯수:{0},점수:{1}", correct, score);
        }

    }
}

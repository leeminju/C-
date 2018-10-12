using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스_연습
{
    class Person
    {
        //변수,property,함수
        //각 변수나 property, 함수 마다 접근 권한을 준다.
        //빼먹으면 무조건 private로 알아듣는다.
        private string name;
        private int age;

        public void SetName(String name)
        {
            this.name = name;
        }

        public String GetName()
        {
            return this.name;
        }

        //프라퍼티-파라미터가 없는 함수의 일종
        /*사용자 입장에서는 마치 변수 처럼 보이는데 만드는 사람입장에서는 함수와 유사
         특정변수의 값을 바꾸거나 값을 읽어가기 위해 사용한다.
         두 개 이상의 변수는 불가능, 딱 한개의 변수값만 접근 가능
         set{} get{}이 있는데
         set에는 value라는 변수가 제공되고 이 변수를 통해 외부로부터 값을 받아온다.
         get은 외부로 값을 보낼 때 사용한다.
         set 이나 get 하나만 설정할 수도 있다.
             */
        public int Age
        {
            set
            {
                if (value < 0 || value > 150)
                    age = 1;
                else
                    age = value;
            }//값을 놓을때 호출,value이름 못바꿈
            get { return age; }//가져갈 때 호출
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //객체변수는 무조건 참조다
            Person person;//참조변수, 객체 안만들어 졌음

            person = new Person();
            person.SetName("홍길동");
            person.Age = 20;//메모리 없음

            Console.WriteLine("{0}의 나이는 {1}세입니다.", person.GetName(), person.Age);
        }
    }
}

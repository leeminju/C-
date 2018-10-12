using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 클래스상속
{
    class Parent
    {
        private int x;
        protected int y;
        public int z;

        public int X { set { x = value; } get { return x; } }
        public int Y { set { y = value; } get { return y; } }
        public int Z { set { z = value; } get { return z; } }

        public Parent()
        {
            Console.WriteLine("default Parent constructor");
            x = 0;
            y = 0;
            z = 0;
        }
        public Parent(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Console.WriteLine("parameter Parent constructor");
        }
        public void Display()
        {
            Console.WriteLine("x={0} y={1} z={2}", x, y, z);
        }
        public void Display(int n)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("x={0} y={1} z={2}", x, y, z);
            Console.WriteLine("---------------------------");
        }

        public override string ToString()
        {
            //return base.ToString();
            //base는 부모 클래스에서 정의된 함수 호출
            //함수를 오버라이딩 했을 떄 원래 부모 클래스에서 기본적으로 하는 일을
            //계속 하길 원한다면 base. 함수를 호출하면 된다.
            //현재 우리는 이 기능이 필요업으므로 주석처리한다.
            return "x=" + x + ",y=" + y+",z="+z;
        }
    }
    class Child : Parent
    {
        int a;
        public int A { set { a = value; } get { return a; } }

        public Child()
        {
            a = 0;
            Console.WriteLine("default child constructor");
        }
        public Child(int x, int y, int z, int a):base(x,y,z)
        {
            //this.x = x;//private 멤버라서 직접접근 불가
            //간접적으로 property나 함수를 통해서
            this.X = x;
            this.y = y;//protected는 자유롭게 접근 가능(부모자식간에만)
            A = a;
            Console.WriteLine("parameter child constructor");
        }

        public override string ToString()
        {
            String result;
            result = String.Format("x={0} y={1} z={2} a={3}", X, y, z, a);
            return result;
            /*String Format 메서드는 다양한 데이터타입을 하나로 묶어서 
            String객체를 만들어 주는 함수
            사용법은  Console.writeLine과 동일하다
            Console.WriteLine은 데이터를 화면에 출력\
            String.Format은 String 객체로 만든다.
            */

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child;//자식 객체 참조 변수

            child = new Child(1, 2, 3, 4);

            Parent parent; //부모 참조 변수 선언

            //upcasting
            parent = child;

            parent.X = 15;

            parent.Display();
            parent.Display(1);

            //downcasting 강제 형전환
            child = (Child)parent;//부모->자식

            //c#은 Object라는 클래스를 무조건 상속 받는다.
            //예외 없음

            Object obj = parent;//자식->부모 업캐스팅
            obj = child;
            
            ArrayList list = new ArrayList();
            list.Add(1);//int->object
            list.Add("test");//String -> object
            list.Add(new Child());//Child->object
            list.Add(new Parent());//Parent ->object
            list.Add(new Child(1, 3, 5, 7));//child->object

            Console.WriteLine(list[0].ToString());
            Console.WriteLine(list[1].ToString());
            Console.WriteLine(list[2].ToString());
            Console.WriteLine(list[3].ToString());
            Console.WriteLine(list[4].ToString());
            /*toString()  오버라이딩안하면 클래스명 출력*/

            for(int i = 0; i < list.Count; i++)
            {
                Type type = list[i].GetType();
                Console.WriteLine(type);
                if (list[i] is Parent)
                {//강제 형전환 다운캐스팅
                    Parent p = (Parent)list[i]; ;
                    p.Display(1);
                }
            }
        }
    }
}

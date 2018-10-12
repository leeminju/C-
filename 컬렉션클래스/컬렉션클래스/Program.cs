using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 컬렉션클래스
{
    class Person:IComparable
    {
        public String Name { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }

        public Person() { }
        public Person(String name,String phone, String email)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        }

        public override string ToString()
        {
            return Name+" "+Phone+" "+Email;
        }

        public override bool Equals(object obj)
        {
            //var 타입-새로만든 데이터 타입
            //대충 아무거나 varient 의 약자

            var person = obj as Person;
            //as -안전하게 다운캐스팅을 해주는 연산자
            //Person per =(Person)obj; 만일 obj 변수가 원래 Person객체가 아니더라도 형전환이
            //되기 떄문에 위험함. as는 다운캐스팅이 가능한 경우에만 다운캐스팅을 해주고
            //다운캐스팅을 할 수 없다면, null 값을 준다.
            //c#은  NULL 안씀,소문자 null 사용
            return person != null &&
                   Name == person.Name &&
                   Phone == person.Phone &&
                   Email == person.Email;
        }

        public override int GetHashCode()
        {
            var hashCode = 1085064052;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Phone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            return hashCode;
        }

        int IComparable.CompareTo(object obj)
        {
            var person = obj as Person;
            return this.Name.CompareTo(person.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(new Person("서은광", "010-0321-1121", "silverlight@naver.com"));
            list.Add(new Person("이민혁", "010-0321-1129", "hutazone@naver.com"));
            list.Add(new Person("이창섭", "010-0321-0226", "leecs@naver.com"));
            list.Add(new Person("임현식", "010-0321-0310", "hyunsik@naver.com"));
            list.Add(new Person("프니엘", "010-0321-0307", "peneil@naver.com"));
            list.Add(new Person("정일훈", "010-0321-1004", "jungill@naver.com"));
            list.Add( new Person("육성재", "010-0321-0503", "6sungjae@naver.com"));

         

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("-------- 중간에 데이터 껴넣은 후");
            list.Insert(3, new Person("차은우", "010-1234-5678", "enwoo@naver.com"));

            Console.WriteLine("-------- 중간에 데이터 껴넣은 후");
            int pos= list.IndexOf(new Person("육성재", "010-0321-0503", "6sungjae@naver.com"));
            Console.WriteLine("위치값 : " + pos);
            //indexof는  int같은 원래 있는 자료형만 찾아짐
            //Equal랑 getHashCodegk함수 override함.

            Console.WriteLine("--------정열 후");
            list.Sort();
            foreach (Person item in list)
                Console.WriteLine(item);

            Stack s = new Stack();
            s.Push('A');
            s.Push('B');
            s.Push('C');
            s.Push('D');
            s.Push('E');

            while (s.Count > 0)
            {
                Console.WriteLine(s.Pop());
            }

            Queue q = new Queue();

            q.Enqueue('A');
            q.Enqueue('B');
            q.Enqueue('C');
            q.Enqueue('D');
            q.Enqueue('E');

            while (q.Count < 0)
                Console.WriteLine(q.Dequeue());
            //해쉬테이블-검색속도 최적
            //데이터를 키와 값 쌍으로 저장, 키 값으로 검색하면
            //이론상 한번에 데이터를 가져올 수 있다.
            //메모리는 많이 차지함
            Hashtable ht = new Hashtable();
            ht.Add("apple", "사과");
            //키,값 쌍으로 구성되는데 이미 존재하는 키일 경우에는 덮어씀
            ht.Add("orange", "오렌지");
            ht.Add("banana", "바나나");
            ht.Add("lemon", "레몬");
            ht.Add("mango", "망고");
            ht.Add("peach", "복숭아");

            
            ht["apple"] = "부사";//있으면 덮어쓰기,키값 하나당 값 하나
            Console.WriteLine(ht["apple"]);

            ht["pineapple"] = "파인애플";//Add랑 같음
            Console.WriteLine(ht["pineapple"]);

            Console.WriteLine("해쉬테이블 데이터 차례대로 출력하기");
            foreach(String key in ht.Keys)
            {
                Console.WriteLine("키:{0} 값:{1}", key, ht[key]);
            }

            Console.WriteLine("검색");
            String mykey=Console.ReadLine();
            if (ht.Contains(mykey))
                Console.WriteLine(ht[mykey]);
            else
                Console.WriteLine(mykey + "는 존재하지 않습니다");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 일반화함수
{
    class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public Person() { }
        public Person(String name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    class PersonComparer
    {
        public int Compare(Object ob1, Object ob2)
        {
            Person p1 = (Person)ob1;
            Person p2 = (Person)ob2;

            return p1.Name.CompareTo(p2.Name);
        }
    }

    class Program
    {
        //대리자 -c언어에서의 함수 포인터에 대응되는 개념
        //함수의 주소를 저장할 타입임, 대리자 선언
        //Compare 타입 선언 이 함수는 object 두개를 매개변수로
        //받아가서, int  값을 반환하는 함수의 형태 주소를 지정할 수 있다.

        delegate int Compare(object a, object b);//함수의 주소를 저장할 수있는 타입

        void CopyArray<T>(T[] dest, T[] source)
        {
            for (int i = 0; i < source.Length;i++)
                dest[i] = source[i];
        }
        void Sort<any>(any [] source,Compare comp)
        {
            int i, j;
            for (i = 0; i < source.Length - 1; i++)
            {
                for (j = i + 1; j < source.Length; j++)
                {
                    if (comp(source[i] ,source[j])>0)
                    {
                        any temp;
                        temp = source[i];
                        source[i] = source[j];
                        source[j] =temp;
                    }
                }
            }
        }

        int compare(Object ob1, Object ob2)
        {
            String s1 = (String)ob1;
            String s2 = (String)ob2;

            return s1.CompareTo(s2);
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] a = new int[] { 1, 3, 5, 7, 9 };
            int[] b = new int[] { 0, 0, 0, 0, 0 };

            program.CopyArray<int>(b, a);
            
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write("{0, 5}",b[i]);
            }
            Console.WriteLine();

            String[] s = { "school", "apple", "rain", "cloud", "blue", "desk", "president", "suspend", "delete", "thread" };
            //대리자를 통헤 함수를 전달함
            program.Sort<String>(s, program.compare);

            
            foreach(String temp in s)
            {
                Console.WriteLine(temp);
            }

            Person[] data = new Person[] {
                new Person("이민주",20),
               new Person("차은우", 20),
             new Person("이민혁", 20),
             new Person("서은광", 20),
        };

            PersonComparer comp = new PersonComparer();
            program.Sort<Person>(data, comp.Compare);

            foreach(Person temp in data)
            {
                Console.WriteLine("{0}{1}", temp.Name, temp.Age);
            }

        }
    }
}

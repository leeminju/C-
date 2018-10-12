using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 내가만든클래스정렬하기
{   //IComparable 인터페이스 상속(추상클래스 중에서 순수가상함수로만 된것)
    class Person:IComparable
    {
        public static int flag=1;
        String name;
        int age;

        public Person()
        {
            name = "";
            age = 0;
        }
        public Person(String name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine("{0} {1}", name, age);
        }

        int IComparable.CompareTo(object obj)
        {
            //Person은 Object로 업캐스팅 되서
            //다시 Person으로 다운케스팅 해야함
            Person temp = (Person)obj;
            if (flag == 1)
                return this.name.CompareTo(temp.name);
            else
                return this.age-temp.age;//크면 + 같으면0 작으면-
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] data = new Person[10];
            data[0] = new Person("서은광", 29);
            data[1] = new Person("이민혁", 29);
            data[2] = new Person("이창섭", 28);
            data[3] = new Person("임현식", 27);
            data[4] = new Person("프니엘", 26);
            data[5] = new Person("정일훈", 25);
            data[6] = new Person("육성재", 24);
            data[7] = new Person("우진영", 22);
            data[8] = new Person("이마크", 20);
            data[9] = new Person("차은우", 22);

            Person.flag = 2;
            Array.Sort(data);

            for(int i = 0; i < data.Length; i++)
            {
                data[i].Display();
            }
        }
    }
}

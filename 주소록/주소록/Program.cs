using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 주소록
{ 
    class Person : IComparable
    {
        public String Name { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }

        public Person() { }
        public Person(String name, String phone, String address)
        {
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
        }

        public override string ToString()
        {
            return Name + "\t" + Phone + "\t " + Address;
        }


        int IComparable.CompareTo(object obj)
        {
            var person = obj as Person;
            return this.Name.CompareTo(person.Name);
        }

        public override bool Equals(object obj)
        {
            var person = obj as Person;
            return person != null &&
                   Name == person.Name &&
                   Phone == person.Phone &&
                   Address == person.Address;
        }

        public override int GetHashCode()
        {
            var hashCode = 1836909312;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Phone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            return hashCode;
        }

    }
    class AddressList
    {
        Hashtable ht;
        public AddressList() {
            ht= new Hashtable();
            ht.Add("나건우", new Person("나건우", "010-7557-7656", "서울시 광운대역"));
            ht.Add("이민주", new Person("이민주", "010-5029-4090", "서울시 상도동"));
        }
        
        public void Menu()
        {
            Console.WriteLine("----------");
            Console.WriteLine("1.추가");
            Console.WriteLine("2.삭제");
            Console.WriteLine("3.검색");
            Console.WriteLine("4.전체출력");
            Console.WriteLine("5.수정");
            Console.WriteLine("0.종료");
            Console.WriteLine("----------");
            Console.WriteLine("선택:");
        }
        public void Start()
        {
            int op;
            while (true)
            {
                Menu();
                op=int.Parse(Console.ReadLine());
                switch (op) {
                    case 0:
                        return;
                    case 1:
                        input();
                        break;
                   case 2:
                        delete();
                        break;
                    case 3:
                        search();
                        break;
                    case 4:
                        output();
                        break;
                    case 5:
                        modify();
                        break;
                    default:
                        Console.WriteLine("잘못입력하셨습니다.");
                        break;
                }

            }
        }
        void output()
        {
            if (ht.Count == 0)
            {
                Console.WriteLine("주소록에 정보가 없습니다.");
                return;
            }
            
            foreach (String key in ht.Keys)
            {
                Console.WriteLine("{0}", ht[key]);
            }

        }
        void input()
        {
            String again;
            do
            {
                String temp;
                Person p = new Person();

                Console.Write("이름:");
                temp = Console.ReadLine();

                do {
                    if (ht.Contains(temp))
                    {
                        temp += "*";
                    }
                    else
                        break;
                } while (true);
                p.Name = temp;

                Console.Write("번호:");
                p.Phone = Console.ReadLine();

                Console.Write("주소:");
                p.Address = Console.ReadLine();

                ht.Add(p.Name, p);
                
                Console.WriteLine("계속하시겠습니까?(y/n)");
                again = Console.ReadLine();
            } while (again == "y");
        }

        void delete()
        {

            String again;
            do
            {
                String name;
                Console.Write("이름:");
                name = Console.ReadLine();

                if (ht.Contains(name))
               {
                    ht.Remove(name);
               }
               else
               {
                    Console.WriteLine("{0}은 없습니다");
               }
                
                Console.WriteLine("계속하시겠습니까?(y/n)");
                again = Console.ReadLine();
            } while (again == "y");
        }

        void search()
        {

            String again;
            do
            {

                String name;
                Console.Write("이름:");
                name = Console.ReadLine();

                if (ht.Contains(name))
                {
                    Console.WriteLine(ht[name]);
                }
                else
                {
                    Console.WriteLine("{0}은 없습니다",name);
                }
                Console.WriteLine("계속하시겠습니까?(y/n)");
                again = Console.ReadLine();
            } while (again == "y");
        }
        void modify()
        {

            String again;
            do
            {

                String name;
                Console.Write("이름:");
                name = Console.ReadLine();

                if (ht.Contains(name))
                {
                    Person p = new Person();
                    
                    p.Name = name;

                    Console.Write("번호:");
                    p.Phone = Console.ReadLine();

                    Console.Write("주소:");
                    p.Address = Console.ReadLine();

                    ht[name]= p;

                }
                else
                {
                    Console.WriteLine("{0}은 없습니다", name);
                }
                Console.WriteLine("계속하시겠습니까?(y/n)");
                again = Console.ReadLine();
            } while (again == "y");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            AddressList al = new AddressList();
            al.Start();
        }
    }
   
}

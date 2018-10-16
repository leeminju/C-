using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 자격증
{
    class Person
    {
        public String num;
        public String name;
        int writing;
        int word;
        int ppt;
        int excel;
        public int sum;
        String grade;

        public int Writing {
            set
            {
                if (value < 0 || value > 400)
                    value = 0;
                writing = value;
            }
            get { return writing; }
        }

        public int Word
        {
            set
            {
                if (value < 0 || value > 200)
                    value = 0;
                word = value;
            }
            get { return word; }
        }
        public int Ppt
        {
            set
            {
                if (value < 0 || value > 200)
                    value = 0;
                ppt = value;
            }
            get { return ppt; }
        }
        public int Excel
        {
            set
            {
                if (value < 0 || value > 200)
                    value = 0;
                excel = value;
            }
            get { return excel; }
        }

        public Person()
        {
            sum = 0;
        }

        public Person(String num, String name, int writing, int word, int ppt, int excel)
        {
            sum = 0;
            this.num = num;
            this.name = name;
            Writing = writing;
            Word = word;
            Ppt = ppt;
            Excel = excel;

            Plus();
            Process(sum);
        }
        public void Plus()
        {
            sum=Writing + Word + Ppt + Excel;
        }

        public void Process(int sum)
        {
            if(sum >= 800)
            {
                grade = "A등급";
            }else if(sum >= 600 && sum < 800)
            {
                grade = "B등급";
            }
            else if (sum >= 400 && sum < 600)
            {
                grade = "C등급";
            }
            else 
            {
                grade = "D등급,재시험 요망";
            }

        }
        public override string ToString()
        {
            return num+" "+name+" "+Writing+" "+Word+" "+Ppt+" "+Excel+"총점:"+ sum+"등급:"+grade;
        }

        public override bool Equals(object obj)
        {
            var person = obj as Person;
            return person != null &&
                   num == person.num &&
                   name == person.name &&
                   writing == person.writing &&
                   word == person.word &&
                   ppt == person.ppt &&
                   excel == person.excel &&
                   Writing == person.Writing &&
                   Word == person.Word &&
                   Ppt == person.Ppt &&
                   Excel == person.Excel;
        }
        //객체를 식별하기 위한 HashCode값을 생성
        public override int GetHashCode()
        {
            var hashCode = 127838271;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(num);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + writing.GetHashCode();
            hashCode = hashCode * -1521134295 + word.GetHashCode();
            hashCode = hashCode * -1521134295 + ppt.GetHashCode();
            hashCode = hashCode * -1521134295 + excel.GetHashCode();
            hashCode = hashCode * -1521134295 + Writing.GetHashCode();
            hashCode = hashCode * -1521134295 + Word.GetHashCode();
            hashCode = hashCode * -1521134295 + Ppt.GetHashCode();
            hashCode = hashCode * -1521134295 + Excel.GetHashCode();
            return hashCode;
        }
    }
    class GradeMananger{
        Dictionary<String, Person> m;

        public GradeMananger()
        {
            m = new Dictionary<String, Person>();
            m.Add("12345-54321", new Person("12345-54321", "이민주", 150, 30, 60,30));
        }
        public void Start()
        {
            int op;
            while (true)
            {
                Menu();
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Input();
                        break;
                    case 2:
                        Output();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
            }
        } 
        void Menu()
        {
            Console.WriteLine("-----메뉴-----");
            Console.WriteLine("1.성적 입력");
            Console.WriteLine("2.전체 성적 출력");
            Console.WriteLine("3.수험번호로 성적 검색");
            Console.WriteLine("--------------");
            Console.WriteLine("선택:");
        }

        void Input()
        {
            Person temp = new Person();
            String temp_num;

            Console.Write("수험번호:");
            temp_num = Console.ReadLine();

            foreach(String key in m.Keys)
            {
                if (temp_num == key)
                {
                    Console.WriteLine("같은 수험번호가 존재 합니다.");
                    return;
                }
            }
            Console.Write("이름:");
            temp.name = temp_num;

            Console.Write("필기:");
            temp.Writing = int.Parse(Console.ReadLine());

            Console.Write("워드:");
            temp.Word = int.Parse(Console.ReadLine());

            Console.Write("파워포인트:");
            temp.Ppt = int.Parse(Console.ReadLine());

            Console.Write("엑셀:");
            temp.Excel = int.Parse(Console.ReadLine());

            temp.Plus();
            temp.Process(temp.sum);

            m.Add(temp.num, temp);

        }
        void Output()
        {
            foreach(String key in m.Keys)
            {
                Console.WriteLine(m[key]);
            }
        }
     }

    class Program
    {
        static void Main(string[] args)
        {
            GradeMananger g = new GradeMananger();
            g.Start();
        }
    }
}

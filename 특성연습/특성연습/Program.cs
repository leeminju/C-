using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 특성연습
{
    class Score
    {
        String name;
        int kor;
        int eng;
        int math;
        int total;
        String[] grade=new String[3];
        /*
        public String Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Total
        {
            set
            {
                total = value;
            }
            get { return total; }
        }*/

        public String Name { set; get; }
        public int Total { set; get; }

        public int Kor
        {
            set
            {
                if (value < 0 || value > 100)
                    kor = 0;
                else
                    kor = value;
            }
            get { return kor; }
        }
        public int Eng
        {
            set
            {

                if (value < 0 || value > 100)
                    eng = 0;
                else
                    eng = value;
            }
            get { return eng; }
        }
        public int Math
        {
            set
            {
                if (value < 0 || value > 100)
                    math = 0;
                else
                    math = value;
            }
            get { return math; }
        }
        //생성자만있음 소멸자없음
        //디폴트생성자 그밖의 생성자로 나뉜다
        //생성자는 public 접근권한으로 만들어야 한다.
        public Score()
        {
            Name = "차은우";
            Kor = 100;
            Eng = 100;
            Math = 100;
            Process();
            
        }

        public Score(String name, int kor, int eng, int math)
        {
            Name = name;
            Kor = kor;
            Eng = eng;
            Math = math;
            Process();
        }
        public void Process()
        {
            grade[0] = Cal(kor);
            grade[1] = Cal(Eng);
            grade[2] = Cal(Math);

            Total = kor + eng + math;
        }

        public String Cal(int subject)
        {
            if(subject>=90)
            {
                return "수";
            }
            else if (subject >= 80 && subject < 90)
            {
                return "우";
            }
            else if (subject >= 70 && subject < 80)
            {
                return "미";
            }
            else if (subject >= 60 && subject < 70)
            {
                return "양";
            }
            else
            {
                return "가";
            }
        }
        public void Display()
        {
            Console.WriteLine("{0}\t{1}({2})\t{3}({4})\t{5}({6})\t{7}", Name, Kor, grade[0], Eng, grade[1], Math, grade[2], Total);
        }
    }

    class Grade
    {
        int cnt;
        const int MAX = 100;
        Score[] s = new Score[MAX];

        public void Menu()
        {
            Console.WriteLine("---MENU----");
            Console.WriteLine("1.성적입력");
            Console.WriteLine("2.전체보기");
            Console.WriteLine("3.검색");
            Console.WriteLine("4.삭제");
            Console.WriteLine("5.수정");
            Console.WriteLine("0.종료");
            Console.WriteLine("-----------");
            Console.Write("선택:");
        }
        public Grade()
        {
            cnt = 0;
            
        }
        public void Input()
        {
            string again;
            do
            {
                if (cnt >= s.Length)//
                {
                    Console.WriteLine("메모리 부족\n");
                    return;
                }
                s[cnt] = new Score();
                Console.Write("이름:");
                s[cnt].Name = Console.ReadLine();

                Console.Write("국어 점수:");
                s[cnt].Kor = int.Parse(Console.ReadLine());

                Console.Write("영어 점수:");
                s[cnt].Eng = int.Parse(Console.ReadLine());

                Console.Write("수학 점수:");
                s[cnt].Math = int.Parse(Console.ReadLine());

                s[cnt].Process();

                cnt++;
                Console.Write("계속하시겠습니까?(y/n)");
                again = Console.ReadLine();
            } while (again == "y" || again=="Y");
        }

        public void Output()
        {
            if (cnt == 0)
            {
                Console.WriteLine("성적이 없습니다.");
                return;
            }

            Console.WriteLine("이름\t국어\t영어\t수학\t총점");
            for(int i = 0; i < cnt; i++)
            {
                s[i].Display();
            }
        }

        public void Search()
        {
            string again;
            do
            {
                Console.Write("검색할 이름:");
                string n = Console.ReadLine();
                int pos = Find(n);

                if (pos == -1)
                { 
                    Console.WriteLine("찾는 이름이 없습니다");
                }
                else
                {
                    Console.WriteLine("이름\t국어\t영어\t수학\t총점");
                    s[pos].Display();
                }

                Console.Write("계속하시겠습니까?(y/n)");
                again = Console.ReadLine();
            } while (again == "y" || again == "Y");
        }

        public void Delete()
        {
            string again;
            do
            {
                Console.Write("삭제할 이름:");
                string n = Console.ReadLine();
                int pos = Find(n);

                if (pos == -1)
                {
                    Console.WriteLine("찾는 이름이 없습니다");
                }
                else
                {
                    for (int i = pos; i < cnt - 1; i++)
                    {
                        s[i] = s[i + 1];
                    }
                    cnt--;
                }

                Console.Write("계속하시겠습니까?(y/n)");
                again = Console.ReadLine();
            } while (again == "y" || again == "Y");

        }
        public void Modify()
        {
            string again;
            do
            {
                Console.Write("수정할 이름:");
                string n = Console.ReadLine();
                int pos = Find(n);

                if (pos == -1)
                {
                    Console.WriteLine("찾는 이름이 없습니다");
                }
                else
                {
                    s[pos] = new Score();
                    Console.Write("이름:");
                    s[pos].Name = Console.ReadLine();

                    Console.Write("국어 점수:");
                    s[pos].Kor = int.Parse(Console.ReadLine());

                    Console.Write("영어 점수:");
                    s[pos].Eng = int.Parse(Console.ReadLine());

                    Console.Write("수학 점수:");
                    s[pos].Math = int.Parse(Console.ReadLine());

                    s[pos].Process();

                }

                Console.Write("계속하시겠습니까?(y/n)");
                again = Console.ReadLine();
            } while (again == "y" || again == "Y");
        }
        public int Find(string name)
        {
            for(int i = 0; i < cnt; i++)
            {
                if (s[i].Name == name)
                    return i;
            }
            return -1;
        }
    }
    class Program
    {
        public enum MENU
        {
            exit,input, output, search, delete, modify 
        };

        static void Main(string[] args)
        {
            Grade g = new Grade();
            MENU op;
            while (true)
            {
                g.Menu();
                op = (MENU)int.Parse(Console.ReadLine());
                switch (op)
                {
                    case MENU.exit:
                        return;
                    case MENU.input:
                        g.Input();
                        break;
                    case MENU.output:
                        g.Output();
                        break;
                    case MENU.search:
                        g.Search();
                        break;
                    case MENU.delete:
                        g.Delete();
                        break;
                    case MENU.modify:
                        g.Modify();
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다");
                        break;
                }
            }
            /*
            Score score = new Score();
            score.Display();

            score.Name = "우진영";
            score.Kor = 900;
            score.Eng = 100;
            score.Math = 65;
            score.Process();
            score.Display();

            Score score2=new Score("이민혁", 50, 70, 150);
            score2.Display();

            score = score2;//주소 복사
            score.Display();

            //객체 배열에에 대해서
            //객체->참조변수, 배열->참조변수
            //객체 배열->참조의 참조

            // 객체 참조를 저장할 변수 5개 만들고 끝, 객체를 만들지 않는다.
            Score[] s = new Score[5];//생성자 호출 안함

            // s[0].Name = "이민주";//에러
            s[0] = new Score();
            s[1] = new Score();
            s[2] = new Score();
            s[3] = new Score();
            s[4] = new Score();

            s[0].Name = "서은광";
            s[0].Kor = 90;
            s[0].Math = 100;
            s[0].Eng = 20;
            s[0].Process();
            s[0].Display();

            s = new Score[5]
            {
                new Score("이민혁", 50, 70, 150),
                new Score("서은광", 20, 70, 60),
                new Score("이창섭", 30, 70, 150),
                new Score("임현식", 50, 60, 150),
                new Score("프니엘", 50, 70, 250)
            };

            for (int i = 0; i < s.Length; i++)
            {
                s[i].Display();
            }
            */

        }
    }
}

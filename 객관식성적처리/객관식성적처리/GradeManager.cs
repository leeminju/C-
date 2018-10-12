using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 객관식성적처리
{
    class GradeManager
    {
        static String jungdap;
        const int MAX = 100;
        Student[] s = new Student[MAX];
        int cnt;

        public GradeManager()
        {
            jungdap = "12345123451234512345";
            s[0] = new Student("서은광", "541236578412365478121");
            s[1] = new Student("이민혁", "132456123541212541211");
            s[2] = new Student("이창섭", "154213548548412354512");

            cnt = 3;
            Process();
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
                    case 3:
                        Modify();
                        break;
                    case 4:
                        Search();
                        break;
                    case 5:
                        Delete();
                        break;
                    case 6:
                        Jungdap();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }

            }
        }

        public void Menu()
        {
            Console.WriteLine("----Menu----");
            Console.WriteLine("1.답안 입력");
            Console.WriteLine("2.결과 보기");
            Console.WriteLine("3.답안 수정");
            Console.WriteLine("4.검색");
            Console.WriteLine("5.삭제");
            Console.WriteLine("6.정답입력");
            Console.WriteLine("0.종료");
            Console.WriteLine("-------------");
            Console.Write("선택:");

        }

        public void Input()
        {
            string again;
            do
            {
                if(cnt>=s.Length)
                {
                    Console.WriteLine("메모리 부족");
                    return;
                }
                //새로운 객체 생성
                s[cnt] = new Student();

                Console.Write("이름:");
                s[cnt].name = Console.ReadLine();

                Console.WriteLine("답안 : ....|....|....|....|");
                Console.Write("       ");
                s[cnt].dap = Console.ReadLine();

                Process();

                cnt++;

                Console.WriteLine("계속 하시겠습니까?(y/n)");
                again = Console.ReadLine();
            } while (again == "y");
        }
        void Output()
        {
            for (int i = 0; i < cnt; i++)
            {
                s[i].Display();
            }
        }

       void Modify()
        {

            string again;
            do
            {
                Console.Write("수정할 이름:");
                string n = Console.ReadLine();
                int pos = Find(n);

                if (pos == -1)
                {
                    Console.WriteLine("{0}이 없습니다",n);
                }
                else
                {
                    s[pos] = new Student();

                    Console.WriteLine("답안 : ....|....|....|....|");
                    Console.Write("       ");
                    s[pos].dap = Console.ReadLine();


                    Process();
                }

                Console.Write("계속하시겠습니까?(y/n)");
                again = Console.ReadLine();
            } while (again == "y" || again == "Y");
        }

        void Search()
        {
            string again;
            do
            {
                Console.Write("검색할 이름:");
                string n = Console.ReadLine();
                int pos = Find(n);

                if (pos == -1)
                {
                    Console.WriteLine("{0}이 없습니다", n);
                }
                else
                {
                    s[pos].Display();
                }

                Console.Write("계속하시겠습니까?(y/n)");
                again = Console.ReadLine();
            } while (again == "y" || again == "Y");
        }

        void Jungdap()
        {
            Console.WriteLine("정답 : ....|....|....|....|");
            Console.Write("       ");
            jungdap = Console.ReadLine();
            Process();
        }

        void Process()
        {
            for (int i = 0; i < cnt; i++)
            {
                s[i].ox = "";
            }

            for (int i = 0; i < cnt; i++)
            {
                s[i].Process(jungdap);
            }
        }

        void Delete()
        {

            string again;
            do
            {
                Console.Write("삭제할 이름:");
                string n = Console.ReadLine();
                int pos = Find(n);

                if (pos == -1)
                {
                    Console.WriteLine("{0}이 없습니다", n);
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

        int Find(string name)
        {
            for (int i = 0; i < cnt; i++)
            {
                if (s[i].name == name)
                    return i;
            }
            return -1;
        }
    }
}


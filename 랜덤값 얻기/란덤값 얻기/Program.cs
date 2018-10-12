using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 랜덤값_얻기
{
    class Data
    {
        public int computer { set; get; }
        public int user { set; get; }
        public int result { set; get; }

        public Data()
        {

            Random rand = new Random();
            computer = rand.Next(1, 4);//1:가위 2:바위 3:보
        }

        public void Process()
        {
            if (user == computer)
            {
                result = 1;//비김
                return;
            }

            if ((user == 1 && computer == 3) || (user == 2 && computer == 1) || (user == 3 && computer == 2))
            {
                result = 2;//승리
                return;
            }

            if ((user == 3 && computer == 1) || (user == 1 && computer == 2) || (user == 2 && computer == 3))
            {
                result = 3;//짐
                return;
            }
        }
    }

    class Game
    {
        const int MAX = 10;
        int[] result = new int[3] { 0, 0, 0 };

        Data[] data = new Data[MAX];
        int cnt = 0;

        public Game()
        {
            cnt = 0;
        }
        public void Start()
        {
            String again;
            do {
                if(cnt >= data.Length)
                {
                    break;
                }
                Console.WriteLine("------------------ROUND {0}-------------------",cnt+1);
                Input(cnt);
                ComputerResult(cnt);
                Result(cnt);
                cnt++;

                Console.Write("계속?(y,n):");
                again = Console.ReadLine();
            } while (again=="y");

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("GAME OVER");
            Console.WriteLine("비긴횟수:{0} 이긴횟수:{1} 진횟수:{2}", result[0], result[1], result[2]);
        }

        void Input(int cnt)
        {
            data[cnt] = new Data();
            Console.Write("입력(1:가위 2:바위 3:보):");
            data[cnt].user = int.Parse(Console.ReadLine());
            data[cnt].Process();
        }
        

        void ComputerResult(int cnt)
        {
            switch (data[cnt].computer)
            {
                case 1:
                    Console.WriteLine("컴퓨터는 가위를 냈습니다.");
                    break;
                case 2:
                    Console.WriteLine("컴퓨터는 바위를 냈습니다.");
                    break;
                case 3:
                    Console.WriteLine("컴퓨터는 보를 냈습니다.");
                    break;
            }
        }

        void Result(int cnt)
        {
            switch (data[cnt].result)
            {
                case 1:
                    Console.WriteLine("DRAW");
                    result[0]++;
                    break;
                case 2:
                    Console.WriteLine("WIN");
                    result[1]++;
                    break;
                case 3:
                    Console.WriteLine("LOSE");
                    result[2]++;
                    break;

            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            g.Start();
        }
    }
}

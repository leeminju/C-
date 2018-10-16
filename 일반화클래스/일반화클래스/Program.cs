using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 일반화클래스
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> wordList = new List<String>();
            wordList.Add("1");
            // wordList.Add(1);error
            wordList.Add("이");
            wordList.Add("삼");
            wordList.Add("사");
            wordList.Add("오");
            wordList.Add("육");
            //컬렛견류 클래스들은 다들 IEnumerable인터페이스를 상속 받는다. 이 인터페이스는 2개의 메서드와 하나의 property가 있음
            //reset():맨처음 데이터 우치로 이동
            //moveNext():이동할 데이터가 있으면 true 없으면 false 반환
            //Currnet:guswo epdlxj
            //IEnumerable 인터페이스와 더블어 GetEnumerator 반환

            //IEnumurator 인터페이스를 제공해야 foreach 구문 가능
            IEnumerator<String> e = wordList.GetEnumerator();
            while (e.MoveNext())//다음번 요소가 있으면 true
            {
                Console.WriteLine(e.Current);
                //현재 데이터 출력
            }

            e.Reset();//처음으로 이동

            while (e.MoveNext())//다음번 요소가 있으면 true
            {
                Console.WriteLine(e.Current);
                //현재 데이터 출력
            }

            foreach (String item in wordList)
            {
                Console.WriteLine(item);
            }

            //List 클래스만
            for (int i = 0; i < wordList.Count; i++)
                Console.WriteLine(wordList[i]);

            //정렬하기
            wordList.Sort();
            Console.WriteLine("---- 정렬후");
            for (int i = 0; i < wordList.Count; i++)
                Console.WriteLine(wordList[i]);

            Console.WriteLine("----특정 데이터 위치 찾기");
            int a = wordList.IndexOf("오");
            Console.WriteLine("{0}에 있음", a);

            //앞에가 키,값
            Dictionary<String, String> mydic
                = new Dictionary<String, String>();
            mydic["red"] = "빨강";
            mydic["green"] = "초록";
            mydic["blue"] = "파랑";
            mydic["white"] = "흰색";
            mydic["black"] = "검정";
            mydic["pink"] = "분홍";
            mydic["brown"] = "갈색";
            mydic["violet"] = "보라";
            mydic["grey"] = "회색";
            mydic["yellow"] = "노란색";

            IEnumerator<String> keys = mydic.Keys.GetEnumerator();

            while (keys.MoveNext())
            {
                Console.WriteLine("{0} {1}", keys.Current, mydic[keys.Current]);
            }

            foreach(String key in mydic.Keys)
            {
                Console.WriteLine("{0} {1}", key, mydic[key]);//key로 value 추적가능
            }


            foreach (String value in mydic.Values)
            {
                Console.WriteLine("{0}", value);//value로 키를 추적 못함
            }
        }
    }
}

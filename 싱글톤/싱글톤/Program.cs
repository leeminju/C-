using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 싱글톤
{
    /*
    1.생성자를 private로 만든다.
        이유:클래스 외부에서 객체 생성 못하도록

     Singleton s = new Singleton()
     이게 가능하면 객체 생성을 하나만 하는게 불가능함
     이걸 막아야 함. 막는 방법이 생성자를 private로

    2.객체 생성을 static함수 내에서 한다
      왜냐면 객체 생성 안하고도 호출될 함수가 있어야하므로
      이 함수는 자신과 같은 객체를 반환해야 한다.

    3.생성된 객체 주소를 저장할 static 멤버 변수가 있어야 한다.

    */
    class Singleton
    {
        private Singleton()
        {
            //생성자, 객체 생성
        }

        //자기 참조형 변수-객체 생성후 생성된 객체 주소를 여기에 저장해 놓으라고
        static Singleton instance = null;

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        //공유 메모리
        int[] numbers = new int[5] { 0,0,0,0,0 };
        
        public int GetValue()
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public void SetValue(int n,int value)
        { 
            numbers[n] = value;
        }

        public void Release(int value)
        {
            numbers[value] = 0;
            Console.WriteLine("{0}번 반환", value);
        }
    }
  
   
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.getInstance();
            int n = s1.GetValue();//n=0
            s1.SetValue(n, 10);//0번째에 10을 넣는다.
            Console.WriteLine(n);

            Singleton s2 = Singleton.getInstance();
            int n2 = s2.GetValue();//n=1
            s2.SetValue(n2, 20);//1번째에 20을 넣는다.
            Console.WriteLine(n2);

            s1.Release(n);//0째 방 반납=0

            Singleton s3 = Singleton.getInstance();
            int n3 = s3.GetValue();//0
            Console.WriteLine(n3);//0
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 메소드에개체전달하기
{
    class MyClass
    {
        public int x;//멤버,변수,필드
        public int y;
        
        public MyClass(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        //함수,메서드
        public MyClass Copy()
        {   
            //레퍼런스로 반환 안해도 됨
            MyClass temp = new MyClass(x, y);
            return temp;
        }

        public void SetValue(MyClass obj,int x, int y)
        {
            obj.x = x;
            obj.y = y;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass(1, 2);
            MyClass mc2 = mc.Copy();
            mc.SetValue(mc2, 10, 15);
            Console.WriteLine("{0} {1}", mc2.x, mc2.y);
        }
    }
}

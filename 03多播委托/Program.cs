using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03多播委托
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //sum += 1;
            //sum += 1;
            //sum += 1;

            //sum = 0;
            //Console.WriteLine(sum);


            ////一个委托变量同时指向了多个方法，就是多播委托
            //Delegate1 md = M1;
            //md += M2;
            //md += M3;
            //md += M4;
            //md += M5;
            //md += M6; //如果使用等号为委托赋值，最后会将前面的所有的绑定的委托都覆盖掉。

            //md -= M3;
            //md -= M5;
            //md();//当调用委托变量的时候，绑定到该委托上的所有方法都会被执行。
            //Console.Read();


            //Delegate1 md = M1;
            //md = (Delegate1)Delegate.Combine(md, new Delegate1(M2));
            //md = (Delegate1)Delegate.Combine(md, new Delegate1(M3));
            //md = (Delegate1)Delegate.Remove(md, new Delegate1(M2));

            AddDelegate md = T1;
            md += T2;
            md += T3;

            //多播委托如果方法有返回值的化，这里只能获取到最后一个方法的返回值。
            //int n = md(100, 200);
            //Console.WriteLine(n);


            //获取每个方法被调用后的返回值
            Delegate[] mds = md.GetInvocationList();
            //循环遍历mds,获取每个委托对象并调用
            for (int i = 0; i < mds.Length; i++)
            {
                Delegate mm = mds[i];

                int n = ((AddDelegate)mm)(100, 200);
                Console.WriteLine(n);
            }

            Console.Read();

        }

        static int T1(int x, int y)
        {
            return 10;
        }
        static int T2(int x, int y)
        {
            return 20;
        }
        static int T3(int x, int y)
        {
            return 30;
        }

        static void M1()
        {
            Console.WriteLine("M1");
        }
        static void M2()
        {
            Console.WriteLine("M2");
        }
        static void M3()
        {
            Console.WriteLine("M3");
        }
        static void M4()
        {
            Console.WriteLine("M4");
        }
        static void M5()
        {
            Console.WriteLine("M5");
        }

        static void M6()
        {
            Console.WriteLine("M6");
        }

    }

    public delegate int AddDelegate(int n1, int n2);


    //定义一个委托、
    public delegate void Delegate1();
}

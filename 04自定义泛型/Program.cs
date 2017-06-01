using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04自定义泛型
{


    public delegate void M1Delegate(string msg);

    //泛型委托
    public delegate void MGenericDelegate<T>(T arg);
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            ////List<int> list = new List<int>();

            //ListInt list = new ListInt();

            //List<int> li;
            //li.

            //泛型是代码重用也是算法重用。

            //泛型类
            //泛型接口
            //泛型方法
            //泛型委托

            ////MyClass mc = new MyClass(new string[] { "A", "B", "C" });
            ////MyClass<int> mc = new MyClass<int>(new int[] { 10, 20, 30 });
            //MyClass<string> mc = new MyClass<string>(new string[] { "A", "B", "C" });
            //mc.Show();
            //Console.Read();


            //Person p = new Person();
            ////p.Show<string>("aaaaaa");

            ////p.Show<int>(123);
            ////对于泛型方法下面的两种调用方式都是正确的。
            //p.Show("aaaaaa");
            //p.Show<string>("fdsfds");

            //Console.Read();

            //SpiderMan<string> sm = new SpiderMan<string>();
            //sm.Fly(
            #endregion

            #region 泛型委托
            //M1Delegate md = M1;
            //md("aaaaaaaa");
            //Console.Read();

            //M1Delegate md = M2;

            //Console.Read();
            //MGenericDelegate<string> md = M1;
            //md("aaaa");

            //MGenericDelegate<int> md = M2;
            //md(1000);

            //MGenericDelegate<double> md = M3;
            //md(993.5);
            //Console.Read();


            #endregion


            #region 系统内置的泛型委托
            //只要是Action委托都是无返回值的。

            ////1.存储无参数无返回值的方法
            //Action md = () => { Console.WriteLine("无参数无返回值。"); };
            //md();
            //Console.Read();


            ////2.有一个参数没有返回值
            //Action<string, int> md = (s, i) => { Console.WriteLine(s + "   " + i); };
            //md("aaaaaaa", 10);
            //Console.Read();



            //当需要存储带返回值的方法的时候,就需要使用另外一个泛型委托Func


            //Func<string> fn = T1;

            //string ss = fn();
            //Console.WriteLine(ss);
            //Console.Read();


            ////返回值是string类型，参数是一个int类型
            //Func<int, string> fn = n => n.ToString();
            //Console.WriteLine(fn(10));
            //Console.Read();

            //Func<int, int, string> fn = T2;
            //Console.WriteLine(fn(12, 5));
            //Console.Read();

            //Action<string>
            #endregion


            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ////List<int> listResult = list.FindAll(MyFilter);
            //List<int> listResult = list.FindAll(element => element > 5);
            //list.Where(x => x > 5);
            //for (int i = 0; i < listResult.Count; i++)
            //{
            //    Console.WriteLine(listResult[i]);
            //}
            //Console.Read();




        }
        static bool MyFilter(int element)
        {
            return element > 5;
        }

        static string T2(int n1, int n2)
        {
            return (n1 * n2).ToString();
        }
        static string T1()
        {
            return "aaa";
        }

        static void M1(string msg)
        {
            Console.WriteLine(msg);
        }
        static void M2(int msg)
        {
            Console.WriteLine(msg);
        }
        static void M3(double msg)
        {
            Console.WriteLine(msg);
        }
        static void M4(float msg)
        {
            Console.WriteLine(msg);
        }
        static void M5(Person msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Person
    {

    }



    //泛型接口
    public interface IFlyable<T>
    {
        void Fly(T msg);

        T GetTValue(T msg);
    }


    //实现泛型接口的时候必须指定对应的泛型类型。 

    ////编写一个类来实现泛型接口
    ////一个普通类实现了泛型接口
    //public class SupperMan : IFlyable<string>
    //{

    //    #region IFlyable<string> 成员

    //    public void Fly(string msg)
    //    {
    //        Console.WriteLine(msg);
    //    }

    //    #endregion
    //}

    ////泛型类实现泛型接口
    //public class SpiderMan<YZK, W> : IFlyable<YZK> where YZK : new()
    //{

    //    #region IFlyable<YZK> 成员

    //    public void Fly(YZK msg)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    #endregion

    //    #region IFlyable<YZK> 成员


    //    public YZK GetTValue(W msg)
    //    {
    //        return new YZK();
    //    }

    //    #endregion
    //}




    ////泛型方法
    //public class Person
    //{
    //    //方法后直接写<T>就表示是一个泛型方法
    //    public void Show<T>(T msg)
    //    {
    //        Console.WriteLine(msg);
    //    }
    //}



    //T Type
    //泛型类
    class MyClass<T>
    {

        private T _val;

        public T Val
        {
            get { return _val; }
            set { _val = value; }
        }

        public MyClass(T[] _names)
        {
            this.names = _names;
        }

        private T[] names = null;


        public void Show()
        {
            foreach (T item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
    //===================================================================

    //class MyClass1
    //{
    //    public MyClass1(int[] _names)
    //    {
    //        this.names = _names;
    //    }

    //    private int[] names = null;


    //    public void Show()
    //    {
    //        foreach (int item in names)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //class MyClass
    //{
    //    public MyClass(string[] _names)
    //    {
    //        this.names = _names;
    //    }

    //    private string[] names = null;


    //    public void Show()
    //    {
    //        foreach (string item in names)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
}

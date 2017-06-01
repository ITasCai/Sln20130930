using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05泛型约束
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //List<int> list = new List<int>();
            //list.Sort();

            //List<Person> list = new List<Person>();
            #endregion

            #region 泛型约束
            //MyClass<string> mc = new MyClass<string>();
            //MyClass<int> mc1 = new MyClass<int>();

            //MyClass<int> mc = new MyClass<int>();
           // MyClass<Person> mc = new MyClass<Person>();
            #endregion



        }
    }

    class MyTestClass : IComparable
    {

        #region IComparable 成员

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    //class AscByAge:IComparer<Person>
    //{

    //    #region IComparer<Person> 成员

    //    public int Compare(Person x, Person y)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    #endregion
    //}
    class Person : IComparable<Person>
    {
        //public Person(string s)
        //{

        //}
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }



        #region IComparable<Person> 成员

        public int CompareTo(Person other)
        {
            throw new NotImplementedException();
        }

        #endregion
    }


    ////使用泛型约束，约束了T只能是值类型
    //class MyClass<T> where T : struct
    //{

    //}


    ////使用泛型约束，约束了T只能是引用类型不能是值类型
    //class MyClass<T> where T : class
    //{

    //}

    ////限制T必须是实现了某个接口的类型,要求T必须是实现了IComparable接口的子类型对象或者就是该接口类型对象 
    //class MyClass<T> where T : IComparable
    //{
    //}


    ////要求T必须是Person类型，或者是Person类的子类
    //class MyClass<T> where T : Person
    //{
    //}

    //要求T必须是Person类型，或者是Person类的子类
    //class MyClass<T, V>
    //    where T : Person
    //    where T : new() //要求将来传递进来的类型必须具有一个无参数的构造函数
    //    where V : T
    //{
    //}


    //对T没有要求，但是V必须是T类型或者T类型的子类型
    class MyClass<T, V>
        where V : T
    {
    }
}

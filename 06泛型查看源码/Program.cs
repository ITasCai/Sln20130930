using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06泛型查看源码
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<string> mc = new MyClass<string>();

            MyClass<int> mcc = new MyClass<int>();

            YourClass<int, double> yc = new YourClass<int, double>();
        }
    }

    class YourClass<T, V>
    {

    }

    class MyClass<T>
    {

    }
}

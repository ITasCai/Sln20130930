using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07扩展方法
{
    class Program
    {
        static void Main(string[] args)
        {
            ////List<int> list = new List<int>();
            ////list.Where


            //Person p = new Person();
            //p.Name = "盂兰盆";
            //p.SayHi();

            ////扩展方法
            //p.SayHello();
            //Console.Read();

            string msg = "zxh@itcast.cn";

            bool b = msg.IsEmail();
            Console.WriteLine(b);
            Console.Read();
        }
    }

    //Person类型
    public class Person
    {
        public string Name { get; set; }
        public void SayHi()
        {
            Console.WriteLine("Hi~~~");
        }
    }
}

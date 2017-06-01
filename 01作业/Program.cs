using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delegate1 md = M1;
            //md(10, 20, 30);



            //Delegate1 md = delegate(int[] arr)
            //{
            //    Console.WriteLine(arr.Length);
            //};
            //md(2, 3, 4, 5);


            //Delegate1 md = arr => Console.WriteLine(arr.Length);
            //md(1, 1);

            //Console.Read();
        }

        static void M1(params int[] arr)
        {
            Console.WriteLine(arr.Length);
        }
    }

    public delegate void Delegate1(params int[] array);
}

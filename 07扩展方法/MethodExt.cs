using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07扩展方法
{
    /// <summary>
    /// 1.增加扩展方法第一步，增加一个静态类，类名随便起
    /// 该静态类应该与将来要用扩展方法的地方在一个命名空间下。即便命名空间不一样，用的时候也必须导入该命名空间否则不能使用
    /// </summary>
    public static class MethodExt
    {
        //2.向静态类中增加一个静态方法
        //该静态方法的第一个参数就表示要给哪个类型增加该扩展方法
        //第一个修饰符this是必须的，这里的obj就表示将来调用该方法的那个对象
        public static void SayHello(this Person obj)
        {
            Console.WriteLine("Hello ^_~" + obj.Name);
        }
    }
}

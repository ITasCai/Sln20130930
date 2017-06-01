using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12事件练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用之前先为事件指定处理程序。
            Mp3Player mp3 = new Mp3Player();
            //注册事件处理程序
            mp3.BeforePlay += new BeforePlayDelegate(mp3_BeforePlay);
            //编写测试代码
            mp3.Start();
            Console.Read();
        }

        static void mp3_BeforePlay()
        {
            Console.WriteLine("播放前加载歌词。。。。");
        }
    }
    class Mp3Player
    {

        //定义一个事件
        public event BeforePlayDelegate BeforePlay;

        public void Start()
        {
            if (BeforePlay != null)
            {
                BeforePlay();
            }
            Console.WriteLine("开始播放......");
        }
    }


    public delegate void BeforePlayDelegate();
}

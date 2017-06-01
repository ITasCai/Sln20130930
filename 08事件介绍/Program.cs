using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08事件介绍
{
    class Program
    {
        static void Main(string[] args)
        {
            Mp3Player mp3 = new Mp3Player();

            mp3.BeforeMusicPlaying += new Action(mp3_BeforeMusicPlaying);
            mp3.BeforeMusicStopping += new Action(mp3_BeforeMusicStopping);

            //mp3.BeforeMusicPlaying = () =>
            //{
            //    Console.WriteLine("音乐播放前加载歌词。。。。。");
            //};

            //mp3.BeforeMusicStopping = () =>
            //{
            //    Console.WriteLine("音乐结束之前，保存播放进度.....");
            //};

            //mp3.BeforeMusicStopping();
            //mp3.BeforeMusicPlaying();


            mp3.Start();
            mp3.PowerOff();
            Console.Read();
        }

        static void mp3_BeforeMusicStopping()
        {
            Console.WriteLine("音乐停止之前保存进度。");
        }

        static void mp3_BeforeMusicPlaying()
        {
            Console.WriteLine("音乐播放之前加载歌词。。。");
        }
    }

    /// <summary>
    /// Mp3播放器
    /// </summary>
    public class Mp3Player
    {

        //希望在音乐开始播放之前插入一段代码，这段代码是有将来调用者来指定的。
        public event Action BeforeMusicPlaying;



        //希望在音乐停止播放之前，也插入一段代码，这段代码也是由将来调用者来指定的。
        public event Action BeforeMusicStopping;




        //启动Mp3
        public void Start()
        {
            Console.WriteLine("启动...");
            //.....
            if (BeforeMusicPlaying != null)
            {
                //在音乐正是播放之前调用该委托
                //在这里触发了事件
                BeforeMusicPlaying();
            }
            //调用PlayMusic()方法开始播放音乐
            PlayMusic();
        }


        private void PlayMusic()
        {
            Console.WriteLine("音乐开始播放....");
        }


        //关机
        public void PowerOff()
        {
            if (BeforeMusicStopping != null)
            {
                //在这里触发了事件
                //音乐结束之前调用该委托
                BeforeMusicStopping();
            }
            //,......
            //调用停止播放音乐的方法
            Stop();
        }


        private void Stop()
        {
            //停止播放音乐
            Console.WriteLine("音乐停止播放...");
        }
    }
}

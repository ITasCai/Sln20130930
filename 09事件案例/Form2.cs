using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _09事件案例
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //ucTripleButton1.TripleClick = Click3;

            //委托可以直接赋值，但是事件不能直接赋值。
            //事件只能使用+=或-=来赋值，这样就避免了通过=将之前的注册的事件都覆盖掉。
            ucTripleButton1.TripleClick += new Action(ucTripleButton1_TripleClick);
        }

        //这个就是按钮点击3次后的事件处理程序
        void ucTripleButton1_TripleClick()
        {
            Console.WriteLine("事件的处理程序3连击了。。。");
        }

        public void Click3()
        {
            MessageBox.Show("哇塞！！！被电击了3次哦。。。");
        }
    }
}

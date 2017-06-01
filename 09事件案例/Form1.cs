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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //这里是按钮的单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你好");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // ucTripleButton1.TripleClick = ClickThree;


            ucTripleButton1.TripleClick += new Action(ucTripleButton1_TripleClick);
        }

        void ucTripleButton1_TripleClick()
        {
            Console.WriteLine("事件处理程序3连击！！");
            
        }

        private void ClickThree()
        {
            MessageBox.Show("click 3 times!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //直接调用委托
            //委托可以直接通过调用的方式来触发，但是事件不行
            //ucTripleButton1.TripleClick();

            //在声明事件变量的类外部，只能为事件+=或-=,不能再外部触发该事件
            //从而避免了事件在外部被随便触发。
            //ucTripleButton1.TripleClick();
            //ucTripleButton1.TripleClick+=
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ucTripleButton1.TripleClick = null;
        }
    }
}

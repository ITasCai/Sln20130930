using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _13三连击按钮练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //窗体加载的时候设置三连击的事件处理程序\]
            ucButton1.TripleClick += new TripleClickDelegate(ucButton1_TripleClick);

            ucButton2.TripleClick += new TripleClickDelegate(ucButton2_TripleClick);
        }

        void ucButton2_TripleClick()
        {
            MessageBox.Show("另外一个按钮的三连击1！！！");
        }

        void ucButton1_TripleClick()
        {
            MessageBox.Show("点击了3次1！");
        }
    }
}

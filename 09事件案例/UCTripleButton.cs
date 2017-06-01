using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _09事件案例
{
    public partial class UCTripleButton : UserControl
    {
        public UCTripleButton()
        {
            InitializeComponent();
        }

        //当在声明委托变量前加了event关键字后，则委托变量就不是委托变量了，就立刻变成了事件
        public event Action TripleClick;

        int count = 0;
        //这个是按钮的单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            //每次单击一次统计一下
            count++;
            if (count >= 3)
            {
                //MessageBox.Show("点了3次！");
                if (TripleClick != null)
                {
                    //调用一下委托 
                    //这里的代码就可以理解成是触发3连击事件的代码

                    //事件只能在定义事件的类的内部触发。
                    TripleClick();
                    
                }
                count = 0;
            }
        }
    }
}

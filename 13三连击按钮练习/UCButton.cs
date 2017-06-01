using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _13三连击按钮练习
{
    public partial class UCButton : UserControl
    {
        public UCButton()
        {
            InitializeComponent();
        }

        public event TripleClickDelegate TripleClick;

        int count = 0;

        //按钮的单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count >= 3)
            {
                //点击够了3次要触发该事件
                if (TripleClick!=null)
                {
                    TripleClick();//触发事件
                }
                count = 0;
            }
        }
    }

    public delegate void TripleClickDelegate();
}

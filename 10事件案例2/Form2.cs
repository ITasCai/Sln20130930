using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10事件案例2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ucLoginControl1.ValidUserLogin += new Func<string, string, bool>(ucLoginControl1_ValidUserLogin);
        }


        //不同的用户可以指定不同的验证程序。
        bool ucLoginControl1_ValidUserLogin(string arg1, string arg2)
        {
            throw new NotImplementedException();
        }
    }
}

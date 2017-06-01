using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _14登录验证事件案例_练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucLogin1.LoginValidating += new CheckUserLoginDelegate(ucLogin1_LoginValidating);
        }

        void ucLogin1_LoginValidating(object sender, MyEventArgs e)
        {
            if (e.LoginId == "admin" && e.LoginPassword == "8")
            {
                e.IsValid = true;
            }
        }
    }
}

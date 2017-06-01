using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _11事件案例3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucLogin1.LoginValidating += new LoginDelegate(ucLogin1_LoginValidating);
        }

        void ucLogin1_LoginValidating(object sender, LoginEventArgs e)
        {
            if (e.LoginId == "admin" && e.LoginPwd == "8")
            {
                e.IsValidOk = true;
            }
            else
            {
                e.IsValidOk = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

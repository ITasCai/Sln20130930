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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ucLoginControl1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucLoginControl1.ValidUserLogin += new Func<string, string, bool>(ucLoginControl1_ValidUserLogin);
        }

        //在这里验证用户登录的事件
        bool ucLoginControl1_ValidUserLogin(string loginId, string pwd)
        {
            if (loginId == "a" && pwd == "b")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

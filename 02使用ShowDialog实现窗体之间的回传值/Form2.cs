using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _02使用ShowDialog实现窗体之间的回传值
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string userMsg;

        private void button1_Click(object sender, EventArgs e)
        {
            this.userMsg = this.textBox1.Text;
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10事件案例2
{
    public partial class UCLoginControl : UserControl
    {
        public UCLoginControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 验证用户登录的事件
        /// </summary>
        public event Func<string, string, bool> ValidUserLogin;
        private void button1_Click(object sender, EventArgs e)
        {
            //1.获取用户的输入
            string uid = txtUserName.Text.Trim();
            string pwd = txtUserPassword.Text.Trim();
            if (ValidUserLogin != null)
            {
                bool b = ValidUserLogin(uid, pwd); //这句代码触发了验证事件了
                if (b)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }

            }


            //根据登录成功还是失败修改窗体背景颜色




            #region old
            //if (uid == "admin" && pwd == "8888")
            //{
            //    this.BackColor = Color.Green;
            //}
            //else
            //{
            //    this.BackColor = Color.Red;
            //}
            #endregion

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _11事件案例3
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        public event LoginDelegate LoginValidating;

        //点击登录按钮触发的事件
        private void button1_Click(object sender, EventArgs e)
        {
            //1.采集用户的输入
            string uid = txtUserName.Text.Trim();
            string pwd = txtUserPassword.Text;

            //2.触发验证事件
            if (LoginValidating != null)
            {
                LoginEventArgs evt = new LoginEventArgs();
                evt.LoginId = uid;
                evt.LoginPwd = pwd;
                evt.IsValidOk = false;
                //在这里触发验证事件
                LoginValidating(this, evt);

                if (evt.IsValidOk)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }



            //3.根据验证事件的验证结果来设置窗体的颜色
        }
    }




    //定义一个委托

    public delegate void LoginDelegate(object sender, LoginEventArgs e);


    public class LoginEventArgs : EventArgs
    {
        private string _loginId;

        public string LoginId
        {
            get { return _loginId; }
            set { _loginId = value; }
        }

        private string _loginPwd;

        public string LoginPwd
        {
            get { return _loginPwd; }
            set { _loginPwd = value; }
        }

        private bool _isValidOk;

        public bool IsValidOk
        {
            get { return _isValidOk; }
            set { _isValidOk = value; }
        }
    }
}

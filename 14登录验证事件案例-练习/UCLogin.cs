using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _14登录验证事件案例_练习
{



    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        public event CheckUserLoginDelegate LoginValidating;

        private void button1_Click(object sender, EventArgs e)
        {
            //1.采集数据
            string loginId = txtUid.Text.Trim();
            string loginPwd = txtPwd.Text;
            //2.定义委托类型，在类外部。
            //3.，在该类中声明事件,（委托应该有参数，一个object sender和一个自定义的MyEventArgs）
            if (LoginValidating != null)
            {
                MyEventArgs evt = new MyEventArgs();
                evt.LoginId = loginId;
                evt.LoginPassword = loginPwd;
                evt.IsValid = false;

                //触发了事件
                LoginValidating(this, evt);
                if (evt.IsValid)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }
        }
    }
    public class MyEventArgs : EventArgs
    {
        //用户名
        public string LoginId { get; set; }


        //密码
        public string LoginPassword { get; set; }
        //是否登录成功
        public bool IsValid
        { get; set; }
    }
    //定义委托类型
    public delegate void CheckUserLoginDelegate(object sender, MyEventArgs e);
}

﻿namespace _13三连击按钮练习
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ucButton1 = new _13三连击按钮练习.UCButton();
            this.ucButton2 = new _13三连击按钮练习.UCButton();
            this.SuspendLayout();
            // 
            // ucButton1
            // 
            this.ucButton1.Location = new System.Drawing.Point(48, 34);
            this.ucButton1.Name = "ucButton1";
            this.ucButton1.Size = new System.Drawing.Size(86, 56);
            this.ucButton1.TabIndex = 0;
            // 
            // ucButton2
            // 
            this.ucButton2.Location = new System.Drawing.Point(36, 130);
            this.ucButton2.Name = "ucButton2";
            this.ucButton2.Size = new System.Drawing.Size(86, 56);
            this.ucButton2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.ucButton2);
            this.Controls.Add(this.ucButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCButton ucButton1;
        private UCButton ucButton2;

    }
}


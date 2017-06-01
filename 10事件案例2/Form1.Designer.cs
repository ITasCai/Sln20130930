namespace _10事件案例2
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
            this.ucLoginControl1 = new _10事件案例2.UCLoginControl();
            this.SuspendLayout();
            // 
            // ucLoginControl1
            // 
            this.ucLoginControl1.Location = new System.Drawing.Point(35, 29);
            this.ucLoginControl1.Name = "ucLoginControl1";
            this.ucLoginControl1.Size = new System.Drawing.Size(176, 138);
            this.ucLoginControl1.TabIndex = 0;
            this.ucLoginControl1.Load += new System.EventHandler(this.ucLoginControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 204);
            this.Controls.Add(this.ucLoginControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCLoginControl ucLoginControl1;

    }
}


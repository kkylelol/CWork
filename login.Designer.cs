namespace CWork
{
    partial class login
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginID_tbx = new System.Windows.Forms.TextBox();
            this.LoginPWD_tbx = new System.Windows.Forms.TextBox();
            this.LoginID_lab = new System.Windows.Forms.Label();
            this.LoginPWD_lab = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginID_tbx
            // 
            this.LoginID_tbx.Location = new System.Drawing.Point(138, 78);
            this.LoginID_tbx.Name = "LoginID_tbx";
            this.LoginID_tbx.Size = new System.Drawing.Size(100, 21);
            this.LoginID_tbx.TabIndex = 0;
            // 
            // LoginPWD_tbx
            // 
            this.LoginPWD_tbx.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LoginPWD_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPWD_tbx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoginPWD_tbx.Location = new System.Drawing.Point(138, 120);
            this.LoginPWD_tbx.Name = "LoginPWD_tbx";
            this.LoginPWD_tbx.Size = new System.Drawing.Size(100, 21);
            this.LoginPWD_tbx.TabIndex = 1;
            this.LoginPWD_tbx.UseSystemPasswordChar = true;
            // 
            // LoginID_lab
            // 
            this.LoginID_lab.AutoSize = true;
            this.LoginID_lab.Location = new System.Drawing.Point(91, 81);
            this.LoginID_lab.Name = "LoginID_lab";
            this.LoginID_lab.Size = new System.Drawing.Size(41, 12);
            this.LoginID_lab.TabIndex = 2;
            this.LoginID_lab.Text = "账号：";
            // 
            // LoginPWD_lab
            // 
            this.LoginPWD_lab.AutoSize = true;
            this.LoginPWD_lab.Location = new System.Drawing.Point(91, 129);
            this.LoginPWD_lab.Name = "LoginPWD_lab";
            this.LoginPWD_lab.Size = new System.Drawing.Size(41, 12);
            this.LoginPWD_lab.TabIndex = 3;
            this.LoginPWD_lab.Text = "密码：";
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(212, 238);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(75, 23);
            this.Login_btn.TabIndex = 4;
            this.Login_btn.Text = "登陆";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.LoginPWD_lab);
            this.Controls.Add(this.LoginID_lab);
            this.Controls.Add(this.LoginPWD_tbx);
            this.Controls.Add(this.LoginID_tbx);
            this.Name = "login";
            this.Text = "登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginID_tbx;
        private System.Windows.Forms.Label LoginID_lab;
        private System.Windows.Forms.Label LoginPWD_lab;
        private System.Windows.Forms.Button Login_btn;
        public System.Windows.Forms.TextBox LoginPWD_tbx;
    }
}


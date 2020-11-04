using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWork
{
    public partial class login : Form
    {                //连接数据库语句
        SqlConnection cWork = new SqlConnection("Data Source=.;Initial Catalog=C#WORK;Integrated Security=True");
        public login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            //获取输入内容
            String loginid = LoginID_tbx.Text;
            String loginpwd = LoginPWD_tbx.Text;
            try
            {
                if (loginid.Trim() == "")
                {
                    MessageBox.Show("账号不能为空！");
                    return;
                }
                else
                {
                    if (loginpwd.Trim() == "")

                    {
                        MessageBox.Show("密码不能为空！");
                        return;
                    }

                }
                //打开数据库
                cWork.Open();
                string loginSql = "select Sno from Student where Sno = " + loginid.Trim();
                SqlCommand login = new SqlCommand(loginSql, cWork);
                SqlDataReader loginred = login.ExecuteReader();

                if (!loginred.Read())
                {
                    MessageBox.Show("账号或密码输入错误！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("登录成功！");
                    this.Close();
                    
                }

            }
            finally 
            {//关闭数据库
                cWork.Close();
            }


        }
    }
}

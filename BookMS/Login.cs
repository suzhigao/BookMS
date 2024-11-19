using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text!="")
            {
                login();
            }
            else
            {
                MessageBox.Show("用户名或密码为空，请检查！");
            }
        }

        //登录验证
        public void login()
        {
            if(radioButtonUser.Checked==true)
            {
                Dao dao = new Dao();

                string sql = $"select * from t_user where id='{textBox1.Text}' and psw='{textBox2.Text}'";
                //MessageBox.Show(sql);

                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    Data.UID = dc["id"].ToString();
                    Data.UName = dc["name"].ToString();

                    MessageBox.Show("登录成功！");
                    UserMain user = new UserMain();

                    this.Hide();//隐藏旧窗体
                    user.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }

                dao.DaoClose();
                //try
                //{
                //    MessageBox.Show(dc[0].ToString() + dc["name"].ToString() + dc["sex"].ToString());
                //}
                //catch(Exception e)
                //{
                //    MessageBox.Show(e.ToString());
                //}
            }

            if(radioButtonAdmin.Checked==true)
            {
                Dao dao = new Dao();

                string sql = $"select * from t_admin where id='{textBox1.Text}' and psw='{textBox2.Text}'";
                //MessageBox.Show(sql);

                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("登录成功！");

                    AdminHome admin = new AdminHome();
                    this.Hide();
                    admin.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
                dao.DaoClose();
            }
            //MessageBox.Show("请先选中单选框！");
        }
    }
}

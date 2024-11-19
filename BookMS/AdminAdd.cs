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
    public partial class AdminAdd : Form
    {
        public AdminAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if(textBoxBookID.Text!=""&&textBoxBookName.Text!=""&&textBoxAuthor.Text!=""&&textBoxNumber.Text!=""&&textBoxPress.Text!="")
            {
                //改善：判断textbox非空下才执行下述

                Dao dao = new Dao();
                string sql = $"insert into t_book values('{textBoxBookID.Text}','{textBoxBookName.Text}','{textBoxPress.Text}','{textBoxNumber.Text}','{textBoxAuthor.Text}');";

                if (dao.Execute(sql) > 0)
                {
                    MessageBox.Show("新增图书成功了！");
                }
                else
                {
                    MessageBox.Show("新增图书失败！");
                }

                //清空textbox

            }
            else
            {
                MessageBox.Show("输入项不能为空！");
            }
        }
    }
}

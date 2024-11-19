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
    public partial class AdminAlter : Form
    {
        string ID = "";//主键
        public AdminAlter()
        {
            InitializeComponent();
        }

        public AdminAlter(string id,string name,string press,string number,string author)
        {
            InitializeComponent();

            ID = id;

            textBoxBookID.Text = id;
            textBoxBookName.Text = name;
            textBoxPress.Text = press;
            textBoxNumber.Text = number;
            textBoxAuthor.Text = author;
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            string sql = $"update t_book set " +
                $"id='{textBoxBookID.Text}'," +
                $"name='{textBoxBookName.Text}'," +
                $"press='{textBoxPress.Text}'," +
                $"number='{textBoxNumber.Text}'," +
                $"author='{textBoxAuthor.Text}' " +
                $"where id ='{ID}' ";

            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }

            dao.DaoClose();
        }
    }
}

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
    public partial class AdminBookMS : Form
    {
        public AdminBookMS()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Label_SelectedBook.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//获取书名
        }

        private void Admin2_Load(object sender, EventArgs e)
        {
            ViewBookTable();
            Label_SelectedBook.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//获取书名
        }

        //显示图书信息
        public void ViewBookTable()
        {
            dataGridView1.Rows.Clear();//清空原有显示

            string sql = "select * from t_book;";

            Dao dao = new Dao();
            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                //MessageBox.Show(dc.Read().ToString());
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());

                //other
                //for (int i = 0; dc.Read().Equals(true); i++)
                //{
                //    dataGridView1.Rows.Add(dc[i].ToString());
                //    continue;
                //}
            }

            dc.Close();
            dao.DaoClose();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            AdminAdd add = new AdminAdd();
            add.Show();
        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取书号
                //Label_SelectedBook.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？","信息提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

                if(dr==DialogResult.OK)
                {
                    string sql = $"delete from t_book where id = '{id}' ";

                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功！");
                        ViewBookTable();
                    }
                    else
                    {
                        MessageBox.Show("删除失败：" + sql);
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先选中要删除的图书!","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AlterBook_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string press = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string number = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string author = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                AdminAlter alter = new AdminAlter(id, name, press, number, author);
                alter.Show();

                ViewBookTable();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:"+ ex);
            }
        }

        private void buttonFindByID_Click(object sender, EventArgs e)
        {
            FindById();
        }

        private void buttonFindByName_Click(object sender, EventArgs e)
        {
            FindByName();
        }

        public void FindById()
        {
            dataGridView1.Rows.Clear();//清空原有显示

            string sql = $"select * from t_book where id='{textBoxFindByID.Text}' ";

            Dao dao = new Dao();

            //if (dao.Execute(sql) > 0)
            //{
            //    MessageBox.Show("{textBoxFindByID.Text}对应的书名是:{}");
            //}
            //else
            //{
            //    MessageBox.Show("无法查找……");
            //}


            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                //MessageBox.Show(dc.Read().ToString());
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());

                //other
                //for (int i = 0; dc.Read().Equals(true); i++)
                //{
                //    dataGridView1.Rows.Add(dc[i].ToString());
                //    continue;
                //}
            }

            dc.Close();
            dao.DaoClose();
        }

        public void FindByName()
        {
            dataGridView1.Rows.Clear();//清空原有显示

            string sql = $"select * from t_book where name like '%{textBoxFindByName.Text}%' ";

            Dao dao = new Dao();


            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                //MessageBox.Show(dc.Read().ToString());
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }

            dc.Close();
            dao.DaoClose();
        }
    }
}

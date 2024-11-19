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
    public partial class UserReturnInfo : Form
    {
        public UserReturnInfo()
        {
            InitializeComponent();
            ViewBookTable();
        }

        //从数据库中读取数据并显示在表格控件中
        public void ViewBookTable()
        {
            dataGridView1.Rows.Clear();//清空原有显示

            string sql = $"select no,bid,datetime from t_lend where [uid]='{Data.UID}' ";

            Dao dao = new Dao();
            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                //MessageBox.Show(dc.Read().ToString());
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());

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

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取编号
            string id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//获取书号

            string sql = $"Delete from t_lend where no='{no}'; " +
                    $"update t_book set number=number+1 where id='{id}' ";

            Dao dao = new Dao();

            if (dao.Execute(sql) > 1)//执行两条SQL所以执行成功要大于1
            {
                MessageBox.Show($"用户：{Data.UID} 归还了图书：{id}");
                ViewBookTable();
            }
            else
            {
                MessageBox.Show("Error");
            }
            dao.DaoClose();
        }
    }
}

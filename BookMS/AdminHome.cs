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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by ZhiGao");
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminBookMS admin = new AdminBookMS();
            //this.Hide();
            admin.ShowDialog();

        }

        private void Admin1_Load(object sender, EventArgs e)
        {

        }
    }
}

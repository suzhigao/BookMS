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
    public partial class UserMain : Form
    {
        public UserMain()
        {
            InitializeComponent();
            labelWelcome.Text = $"欢迎你，{Data.UName}";
        }

        private void UserLend_Click(object sender, EventArgs e)
        {
            UserLendInfo ulend = new UserLendInfo();
            ulend.Show();
        }

        private void UserReturn_Click(object sender, EventArgs e)
        {
            UserReturnInfo uReturn = new UserReturnInfo();
            uReturn.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by ZhiGao");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

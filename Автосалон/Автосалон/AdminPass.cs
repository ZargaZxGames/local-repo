using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Автосалон
{
    public partial class AdminPass : Form
    {
        public AdminPass()
        {
            InitializeComponent();
        }

        private void btn_ext_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin")
            {
                Admin A = new Admin();
                A.Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }
    }
}

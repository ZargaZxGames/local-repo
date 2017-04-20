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
    public partial class ROKPass : Form
    {
        public ROKPass()
        {
            InitializeComponent();
        }

        private void btn_ROK_go_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ROK")
            {
                ROK ROK = new ROK();
                ROK.Show();
            }
            if(textBox1.Text == "Admin")
            {
                ROK ROK = new ROK();
                ROK.Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }

        private void btn_ext_ROK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class KladPass : Form
    {
        public KladPass()
        {
            InitializeComponent();
        }

        private void btn_ext_Klad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_kladGo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Klad")
            {
                Klad K = new Klad();
                K.Show();
            }
            if (textBox1.Text == "Admin")
            {
                Klad K = new Klad();
                K.Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }
    }
}

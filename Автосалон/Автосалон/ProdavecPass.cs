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
    public partial class ProdavecPass : Form
    {
        public ProdavecPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Prodavec")
            {
                Prodavec P = new Prodavec();
                P.Show();
            }
            if (textBox1.Text == "Admin")
            {
                Prodavec P = new Prodavec();
                P.Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }


        private void btn_ext_Prodav_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

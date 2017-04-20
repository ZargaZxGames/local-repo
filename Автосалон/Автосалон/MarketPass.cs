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
    public partial class MarketPass : Form
    {
        public MarketPass()
        {
            InitializeComponent();
        }

        private void btn_go_market_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Market")
            {
                Market M = new Market();
                M.Show();
            }
            if (textBox1.Text == "Admin")
            {
                Market M = new Market();
                M.Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }

        private void btn_ext_Market_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

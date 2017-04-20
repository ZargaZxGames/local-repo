using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Автосалон
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_Adm_Click(object sender, RoutedEventArgs e)
        {
            AdminPass AP = new AdminPass();
            AP.Show();
        }

        private void btn_Buhg_Click(object sender, RoutedEventArgs e)
        {
            BuhgPass BP = new BuhgPass();
            BP.Show();
        }

        private void btn_Prodav_Click(object sender, RoutedEventArgs e)
        {
            ProdavecPass PP = new ProdavecPass();
            PP.Show();
        }

        private void btn_ROK_Click(object sender, RoutedEventArgs e)
        {
            ROKPass ROKP= new ROKPass();
            ROKP.Show();
        }

        private void btn_Market_Click(object sender, RoutedEventArgs e)
        {
            MarketPass MP = new MarketPass();
            MP.Show();

        }

        private void btn_Klad_Click(object sender, RoutedEventArgs e)
        {
            KladPass KP = new KladPass();
            KP.Show();
        }
    }
}

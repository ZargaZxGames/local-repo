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
using System.Windows.Shapes;

namespace Автосалон
{
    /// <summary>
    /// Логика взаимодействия для ROK.xaml
    /// </summary>
    public partial class ROK : Window
    {
        public ROK()
        {
            InitializeComponent();
        }

        private void btn_ext_ROK_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

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
using System.Threading;
using System.Windows.Threading;

namespace Автосалон
{
    /// <summary> 
    /// Логика взаимодействия для Zastavka.xaml 
    /// </summary> 
    public partial class Zastavka : Window
    {

        public Zastavka()
        {
            InitializeComponent();
        }

        

        DispatcherTimer ds = new DispatcherTimer();
       

        private void Window_Closed(object sender, EventArgs e)
        {
    
        }


        private void ds_Tick(object sender, EventArgs e)
        {
            ds.Stop();
            this.Close();
            MainWindow MW = new MainWindow();
            MW.Show();
        }
           
            

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ds.Tick += new EventHandler(ds_Tick);
            ds.Interval = new TimeSpan(0, 0, 5);
            ds.Start();
        }
    }
}


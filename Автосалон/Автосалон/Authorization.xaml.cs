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
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Автосалон
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SASHA;Initial Catalog=Avtosalon_2;Integrated Security=True"); 
                SqlCommand com = new SqlCommand(@"SELECT * FROM Login WHERE LoginUser=@LoginUser and PasswordUser=@PasswordUser", con);
                con.Open();
                com.Parameters.AddWithValue("@LoginUser", textBLogin.Text);
                com.Parameters.AddWithValue("@PasswordUser", passwordBox.Password);
                SqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows == true)
                {
                    this.Hide();
                    Zastavka Z = new Zastavka();
                    Z.Show();
                }
                else
                {
                    MessageBox.Show("Имя пользователя и/или пароль неверные"); //выводим сообщение
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK);
               
            }
           

        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            Registration rg = new Registration();
            rg.Show();
        }
    }
}

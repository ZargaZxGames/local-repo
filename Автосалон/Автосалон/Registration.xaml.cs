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
using Microsoft.Win32;
using System.Data.SqlClient;

namespace Автосалон
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (textBPassword1.Text == textBPassword2.Text)
            {
                Registration rg = new Registration();
                SqlConnection con = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК\SASHA;Initial Catalog=Avtosalon_2;Integrated Security=True");
                String str = "insert into Login(LoginUser, PasswordUser, Role) values ('" + textBLogin.Text + "', '" + textBPassword1.Text + "','" + textBPassword2.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Регистрация прошла успешно");
                this.Close();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
        }
    }


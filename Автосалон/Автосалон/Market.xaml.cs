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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Автосалон
{
    /// <summary>
    /// Логика взаимодействия для Market.xaml
    /// </summary>
    public partial class Market : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable otdel_markTable;
        public Market()
        {
            InitializeComponent();
            // получаем строку подключения из app.config
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_izmen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ext_Admn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Otdel_mark";
            otdel_markTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                // установка команды на добавление для вызова хранимой процедуры
                adapter.InsertCommand = new SqlCommand("sp_InsertPhone", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar, 50, "Title"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@company", SqlDbType.NVarChar, 50, "Company"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.Int, 0, "Price"));
                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                connection.Open();
                adapter.Fill(otdel_markTable);
                AdminGrid.ItemsSource = otdel_markTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

    }
}


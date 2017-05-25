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

namespace WpfApplication2
{
    /// <summary>
    /// Логика взаимодействия для Regist.xaml
    /// </summary>
    public partial class Regist : Window
    {
        public Regist()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alexey\Documents\Visual Studio 2015\Projects\WpfApplication2\WpfApplication2\UsersDB.mdf;Integrated Security=True";
            SqlConnection sql = new SqlConnection(connect);
            sql.Open();
            string user = "INSERT INTO Users(Login , Password) VALUES('" + Login.Text + "','" + Pass.Text + "')";
            SqlCommand cmd = new SqlCommand(user, sql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Вы зарегистрированы");
            sql.Close();
        }

        private void Connect(object sender, RoutedEventArgs e)
        {

        }
    }
}

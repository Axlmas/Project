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
using System.Data.SqlClient;

namespace WpfApplication2
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

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Regist a = new Regist();
            a.Show();
            //Form2 frm = new Form2();
            //frm.Show();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alexey\Documents\Visual Studio 2015\Projects\WpfApplication2\WpfApplication2\UsersDB.mdf;Integrated Security=True";
            SqlConnection sql = new SqlConnection(connect);
            sql.Open();
            string user = "INSERT INTO Users(Name , Surname) VALUES('" + Login.Text + "','" + Pass.Text + "')";
            SqlCommand cmd = new SqlCommand(user, sql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Вход выполнен");
            sql.Close();
            Window1 win = new Window1();
            win.Show();
            this.Close();
            

        }
    }
}

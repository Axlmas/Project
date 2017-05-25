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

namespace WpfApplication2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void mask_Click(object sender, RoutedEventArgs e)
        {
            Mask opn = new Mask();
            opn.Show();
            this.Close();
        }

        private void address_Click(object sender, RoutedEventArgs e)
        {
            Address opn = new Address();
            opn.Show();
            this.Close();
        }

        private void firstip_Click(object sender, RoutedEventArgs e)
        {
            firstip opn = new firstip();
            opn.Show();
            this.Close();
        }

        private void all_Click(object sender, RoutedEventArgs e)
        {
            all opn = new all();
            opn.Show();
            this.Close();
        }

        private void twoplus_Click(object sender, RoutedEventArgs e)
        {
            twoplus opn = new twoplus();
            opn.Show();
            this.Close();
        }

        private void twoin_Click(object sender, RoutedEventArgs e)
        {
            twoin opn = new twoin();
            opn.Show();
            this.Close();
        }

        private void twofrom_Click(object sender, RoutedEventArgs e)
        {
            twofrom opn = new twofrom();
            opn.Show();
            this.Close();
        }

        private void twominus_Click(object sender, RoutedEventArgs e)
        {
            twominus opn = new twominus();
            opn.Show();
            this.Close();
        }

        private void twomult_Click(object sender, RoutedEventArgs e)
        {
            twomult opn = new twomult();
            opn.Show();
            this.Close();
        }

        private void twodiv_Click(object sender, RoutedEventArgs e)
        {
            twodiv opn = new twodiv();
            opn.Show();
            this.Close();
        }


        private void twoall_Click(object sender, RoutedEventArgs e)
        {
            twoall opn = new twoall();
            opn.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Networks opn = new Networks();
            opn.Show();
            this.Close();
        }
    }
}

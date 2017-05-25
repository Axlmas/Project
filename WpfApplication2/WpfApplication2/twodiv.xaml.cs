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
    /// Логика взаимодействия для twodiv.xaml
    /// </summary>
    public partial class twodiv : Window
    {
        Int32 mistakes, z10_1, z10_2, z10_3, z43, z;
        Double result, d1, d2;
        String a1, a2, a3;
        static Double DecToBin(Double dtb1)
        {
            Double dtb2;
            String dtb3 = "";
            while (dtb1 > 1)
            {
                dtb2 = dtb1 - ((Math.Floor(dtb1 / 2)) * 2);
                dtb3 = dtb3 + Convert.ToString(dtb2);
                dtb1 = Math.Floor(dtb1 / 2);
            }
            dtb3 = dtb3 + Convert.ToString(dtb1);

            char[] arr = dtb3.ToCharArray();
            Array.Reverse(arr);
            dtb3 = new String(arr);
            return Convert.ToDouble(dtb3);

        }

        public twodiv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }


            z = 0;
            if (textBox.Text == a1)
            {
                z = z + 1;
                textBox.Background = Brushes.Green;
            }
            else
            {
                textBox.Background = Brushes.Red;
            }
            //числитель
            if ((Convert.ToSingle(textBox1.Text)) / (Convert.ToSingle(textBox2.Text)) == (Convert.ToSingle(a2)) / (Convert.ToSingle(a3)))
            {
                z = z + 1;
                textBox1.Background = Brushes.Green;
                textBox2.Background = Brushes.Green;
            }
            else
            {
                textBox1.Background = Brushes.Red;
                textBox2.Background = Brushes.Red;
            }

            if (z == 2)
            {
                MessageBox.Show("Верно!");
                textBox.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                task.Content = Convert.ToString(Convert.ToInt32(task.Content) + 1);
                right.Content = Convert.ToString(Convert.ToInt32(right.Content) + 1);
                Random random = new Random();
                z10_1 = random.Next(11, 33);
                z10_2 = random.Next(0, 2);
                z10_3 = random.Next(0, 2);
                z43 = 1;
                label1.Content = Convert.ToString(DecToBin(z10_1)) + "," + Convert.ToString(z10_2) + Convert.ToString(z10_3) + Convert.ToString(z43);
                a1 = Convert.ToString(z10_1);
                a2 = Convert.ToString(z10_2 * 4 + z10_3 * 2 + z43);
                a3 = Convert.ToString(8);
                textBox.Background = Brushes.White;
                textBox1.Background = Brushes.White;
                textBox2.Background = Brushes.White;

            }
            else
            {
                MessageBox.Show("Ответ неверный, попробуйте еще раз");
                wrong.Content = Convert.ToString(Convert.ToInt32(wrong.Content) + 1);
                mistakes = mistakes + 1;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(task.Content) == 1)
            {
                result = 0;
                MessageBox.Show("Количество выполненных заданий - " + Convert.ToString(Convert.ToInt32(task.Content) - 1) + " Допущено ошибок - " + Convert.ToString(mistakes) + " Ваш результат - " + result + "%");

                Window1 opn = new Window1();
                opn.Show();
                this.Close();
            }
            else
            {
                result = 100 - ((Convert.ToDouble(mistakes) / Convert.ToDouble((mistakes + (Convert.ToInt32(task.Content) - 1)))) * 100);
                MessageBox.Show("Количество выполненных заданий - " + Convert.ToString(Convert.ToInt32(task.Content) - 1) + " Допущено ошибок - " + Convert.ToString(mistakes) + " Ваш результат - " + result + "%");

                Window1 opn = new Window1();
                opn.Show();
                this.Close();
            }
        }

        private void go(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            z10_1 = random.Next(100, 1000);//4
            z10_2 = random.Next(0, 2);//41
            z10_3 = random.Next(0, 2);//42
            z43 = 1;//43
            number.Content = Convert.ToString(DecToBin(z10_1)) + "," + Convert.ToString(z10_2) + Convert.ToString(z10_3) + Convert.ToString(z43);
            a1 = Convert.ToString(z10_1);
            a2 = Convert.ToString(z10_2 * 4 + z10_3 * 2 + z43);
            a3 = Convert.ToString(8);
        }
    }
}

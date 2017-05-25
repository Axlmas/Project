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
    /// Логика взаимодействия для twominus.xaml
    /// </summary>
    public partial class twominus : Window
    {

        Int32 mistakes, zadanie10_1, zadanie10_2;
        Double result;
        static Double DecToBin(Double dtb1)//А это прога для перевода чисел из десятичной системы счисления в двоичную.
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

        }//а тут она заканчивается

        public twominus()
        {
            InitializeComponent();
        }

        private void go(object sender, RoutedEventArgs e)
        {
            while (zadanie10_2 >= zadanie10_1)
            {
                Random random = new Random();
                zadanie10_1 = random.Next(111, 1195);
                zadanie10_2 = random.Next(111, 1195);
            }
            number1.Content = Convert.ToString(DecToBin(zadanie10_1));
            number2.Content = Convert.ToString(DecToBin(zadanie10_2));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == Convert.ToString(DecToBin(zadanie10_1 - zadanie10_2)))
            {
                MessageBox.Show("Верно!");
                textBox.Text = "";
                task.Content = Convert.ToString(Convert.ToInt32(task.Content) + 1);
                right.Content = Convert.ToString(Convert.ToInt32(right.Content) + 1);

                zadanie10_1 = 1;
                zadanie10_2 = 2;
                while (zadanie10_2 >= zadanie10_1)
                {
                    Random random = new Random();
                    zadanie10_1 = random.Next(111, 1195);
                    zadanie10_2 = random.Next(111, 1195);
                }

                number1.Content = Convert.ToString(DecToBin(zadanie10_1));
                number2.Content = Convert.ToString(DecToBin(zadanie10_2));

            }
            else
            {
                textBox.Text = "";
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
    }
}

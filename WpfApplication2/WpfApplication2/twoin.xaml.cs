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
    /// Логика взаимодействия для twoin.xaml
    /// </summary>
    public partial class twoin : Window
    {
        public twoin()
        {
            InitializeComponent();
        }

        Int32 mistakes, zadanie10;
        Double result;
        static String BinToDec(String btd1)//Это программа для перевода чисел из двоичной системы счисления в десятичную
        {
            Int32 x;
            Double btd2 = 0;
            Double y = 0;

            for (x = (btd1.Length - 1); x >= 0; x = x - 1)
            {
                btd2 = btd2 + (Convert.ToDouble(btd1.Substring(x, 1)) * (Math.Pow(2, y)));


                y = y + 1;
            }
            return Convert.ToString(btd2);
        }//а тут она заканчивается
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == Convert.ToString(DecToBin(zadanie10)))
            {
                MessageBox.Show("Верно!");
                textBox.Text = "";
                task.Content = Convert.ToString(Convert.ToInt32(task.Content) + 1);
                right.Content = Convert.ToString(Convert.ToInt32(right.Content) + 1);
                Random random = new Random();
                zadanie10 = random.Next(111, 1195);
                number.Content = Convert.ToString(zadanie10);

            }
            else
            {
                MessageBox.Show("Ответ неверный, попробуйте еще раз");
                wrong.Content = Convert.ToString(Convert.ToInt32(wrong.Content) + 1);
                mistakes = mistakes + 1;
            }
        }

        private void go(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            zadanie10 = random.Next(111, 1195);
            number.Content = Convert.ToString(zadanie10);
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

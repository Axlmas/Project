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
    /// Логика взаимодействия для twoall.xaml
    /// </summary>
    public partial class twoall : Window
    {
        Int32 z11;
        Int32 z12;
        Int32 z21;
        Int32 z22;
        Int32 z31a;
        Int32 z31b;
        Int32 z32a;
        Int32 z32b;
        Int32 z41a;
        Int32 z41b;
        Int32 z42a;
        Int32 z42b;
        Int32 z51a;
        Int32 z51b;
        Int32 z52a;
        Int32 z52b;
        Int32 i;
        Int32 calci;
        Single calca;

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

        public twoall()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Завершить работу?", "Сообщение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                an11.Visibility = Visibility.Visible;
                an12.Visibility = Visibility.Visible;
                an21.Visibility = Visibility.Visible;
                an22.Visibility = Visibility.Visible;
                an31.Visibility = Visibility.Visible;
                an32.Visibility = Visibility.Visible;
                an41.Visibility = Visibility.Visible;
                an42.Visibility = Visibility.Visible;
                an51.Visibility = Visibility.Visible;
                an52.Visibility = Visibility.Visible;
                if (tb11.Text == Convert.ToString(an11.Content))
                {
                    i = i + 1;
                    tb11.Background = Brushes.Green;
                }
                else tb11.Background = Brushes.Red;

                if (tb12.Text == Convert.ToString(an12.Content))
                {
                    i = i + 1;
                    tb12.Background = Brushes.Green;
                }
                else tb12.Background = Brushes.Red;
                //это была оценка первого задания

                if (tb21.Text == Convert.ToString(an21.Content))
                {
                    i = i + 1;
                    tb21.Background = Brushes.Green;
                }
                else tb21.Background = Brushes.Red;

                if (tb22.Text == Convert.ToString(an22.Content))
                {
                    i = i + 1;
                    tb22.Background = Brushes.Green;
                }
                else tb22.Background = Brushes.Red;
                //это была оценка второго задания

                if (tb31.Text == Convert.ToString(an31.Content))
                {
                    i = i + 1;
                    tb31.Background = Brushes.Green;
                }
                else tb31.Background = Brushes.Red;

                if (tb32.Text == Convert.ToString(an32.Content))
                {
                    i = i + 1;
                    tb32.Background = Brushes.Green;
                }
                else tb32.Background = Brushes.Red;
                //это была оценка третьего задания

                if (tb41.Text == Convert.ToString(an41.Content))
                {
                    i = i + 1;
                    tb41.Background = Brushes.Green;
                }
                else tb41.Background = Brushes.Red;

                if (tb42.Text == Convert.ToString(an42.Content))
                {
                    i = i + 1;
                    tb42.Background = Brushes.Green;
                }
                else tb42.Background = Brushes.Red;
                //это была оценка четвертого задания

                if (tb51.Text == Convert.ToString(an51.Content))
                {
                    i = i + 1;
                    tb51.Background = Brushes.Green;
                }
                else tb51.Background = Brushes.Red;

                if (tb52.Text == Convert.ToString(an52.Content))
                {
                    i = i + 1;
                    tb52.Background = Brushes.Green;
                }
                else tb52.Background = Brushes.Red;
                //это была оценка пятого задания
                if (i == 10)
                {
                    ocenka2.Content = "5";
                    ocenka2.Background = Brushes.Green;
                    ocenka3.Content = "Так держать!";
                }
                else
                {
                    if (i > 7)
                    {
                        ocenka2.Content = "4";
                        ocenka2.Background = Brushes.Green;
                        ocenka3.Content = "Неплохо!";
                    }
                    else
                    {
                        if (i > 5)
                        {
                            ocenka2.Content = "3";
                            ocenka2.Background = Brushes.Yellow;
                            ocenka3.Content = "Ну такое";
                        }
                        else
                        {
                            ocenka2.Content = "2";
                            ocenka2.Background = Brushes.Red;
                            ocenka3.Content = "На донышке";
                        }
                    }
                }
                ocenka1.Visibility = Visibility.Visible;
                ocenka2.Visibility = Visibility.Visible;
                ocenka3.Visibility = Visibility.Visible;
                button2.Visibility = Visibility.Hidden;
                button1.Visibility = Visibility.Visible;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("А может, останетесь?", "Сообщение", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                Window1 opn = new Window1();
                opn.Show();
                this.Close();
            }
        }

        private void go(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            z11 = random.Next(100, 501);
            task11.Content = Convert.ToString(z11);
            an11.Content = Convert.ToString(DecToBin(z11));
            z12 = random.Next(100, 501);
            if (z12 == z11) z12 = z12 + 13;
            task12.Content = Convert.ToString(z12);
            an12.Content = Convert.ToString(DecToBin(z12));//конец первого задания

            z21 = random.Next(100, 501);
            an21.Content = Convert.ToString(z21);
            task21.Content = Convert.ToString(DecToBin(z21));
            z22 = random.Next(100, 501);
            if (z22 == z21) z22 = z22 + 13;
            an22.Content = Convert.ToString(z22);
            task22.Content = Convert.ToString(DecToBin(z22));//конец второго задания

            z31a = random.Next(100, 501);
            z31b = random.Next(100, 501);
            task31a.Content = Convert.ToString(DecToBin(z31a));
            task31b.Content = Convert.ToString(DecToBin(z31b));
            an31.Content = Convert.ToString(DecToBin(z31a + z31b));
            z32a = random.Next(100, 501);
            z32b = random.Next(100, 501);
            if (z31a + z31b == z32a + z32b) z32a = z32a + 13;
            task32a.Content = Convert.ToString(DecToBin(z32a));
            task32b.Content = Convert.ToString(DecToBin(z32b));
            an32.Content = Convert.ToString(DecToBin(z32a + z32b));//конец третьего задания

            z41a = random.Next(100, 501);
            z41b = random.Next(100, 501);
            if (z41b >= z41a) z41a = z41a + (z41b - z41a) + 13;
            task41a.Content = Convert.ToString(DecToBin(z41a));
            task41b.Content = Convert.ToString(DecToBin(z41b));
            an41.Content = Convert.ToString(DecToBin(z41a - z41b));
            z42a = random.Next(100, 501);
            z42b = random.Next(100, 501);
            if (z42b >= z42a) z42a = z42a + (z42b - z42a) + 13;
            if (z42a == z41a) z42a = z41a + 13;
            task42a.Content = Convert.ToString(DecToBin(z42a));
            task42b.Content = Convert.ToString(DecToBin(z42b));
            an42.Content = Convert.ToString(DecToBin(z42a - z42b));//конец третьего задания

            z51a = random.Next(100, 256);
            z51b = random.Next(2, 4);
            task51a.Content = Convert.ToString(DecToBin(z51a));
            task51b.Content = Convert.ToString(DecToBin(z51b));
            an51.Content = Convert.ToString(DecToBin(z51a * z51b));
            z52a = random.Next(100, 256);
            z52b = random.Next(2, 4);
            if (z52a == z51a) z52a = z51a + 13;
            task52a.Content = Convert.ToString(DecToBin(z52a));
            task52b.Content = Convert.ToString(DecToBin(z52b));
            an52.Content = Convert.ToString(DecToBin(z52a * z52b));
        }
    }
}

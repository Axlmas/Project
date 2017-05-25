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
    /// Логика взаимодействия для Mask.xaml
    /// </summary>
    public partial class Mask : Window
    {
        public Mask()
        {
            InitializeComponent();
        }
        Int32 i, mistakes;
        Int32 nomer = 0;
        Int32 opt = 0;
        String otvet;
        Double result;
        Random random = new Random();
        static String MaskGenerator(Int32 a)
        {
            String mask2 = "";
            switch (a)
            {
                case 1:
                    mask2 = "/1";
                    break;
                case 2:
                    mask2 = "/2";
                    break;
                case 3:
                    mask2 = "/3";
                    break;
                case 4:
                    mask2 = "/4";
                    break;
                case 5:
                    mask2 = "/5";
                    break;
                case 6:
                    mask2 = "/6";
                    break;
                case 7:
                    mask2 = "/7";
                    break;
                case 8:
                    mask2 = "/8";
                    break;
                case 9:
                    mask2 = "/9";
                    break;
                case 10:
                    mask2 = "/10";
                    break;
                case 11:
                    mask2 = "/11";
                    break;
                case 12:
                    mask2 = "/12";
                    break;
                case 13:
                    mask2 = "/13";
                    break;
                case 14:
                    mask2 = "/14";
                    break;
                case 15:
                    mask2 = "/15";
                    break;
                case 16:
                    mask2 = "/16";
                    break;
                case 17:
                    mask2 = "/17";
                    break;
                case 18:
                    mask2 = "/18";
                    break;
                case 19:
                    mask2 = "/19";
                    break;
                case 20:
                    mask2 = "/20";
                    break;
                case 21:
                    mask2 = "/21";
                    break;
                case 22:
                    mask2 = "/22";
                    break;
                case 23:
                    mask2 = "/23";
                    break;
                case 24:
                    mask2 = "/24";
                    break;
                case 25:
                    mask2 = "/25";
                    break;
                case 26:
                    mask2 = "/26";
                    break;
                case 27:
                    mask2 = "/27";
                    break;
                case 28:
                    mask2 = "/28";
                    break;
                case 29:
                    mask2 = "/29";
                    break;
                case 30:
                    mask2 = "/30";
                    break;
                case 31:
                    mask2 = "/31";
                    break;
                case 32:
                    mask2 = "/32";
                    break;


            }

            return mask2;


        }
        static String MaskTransformator(String a)
        {
            String mask10 = "";
            switch (a)
            {
                case "/1":
                    mask10 = "128.0.0.0";
                    break;
                case "/2":
                    mask10 = "192.0.0.0";
                    break;
                case "/3":
                    mask10 = "224.0.0.0";
                    break;
                case "/4":
                    mask10 = "240.0.0.0";
                    break;
                case "/5":
                    mask10 = "248.0.0.0";
                    break;
                case "/6":
                    mask10 = "252.0.0.0";
                    break;
                case "/7":
                    mask10 = "254.0.0.0";
                    break;
                case "/8":
                    mask10 = "255.0.0.0";
                    break;
                case "/9":
                    mask10 = "255.128.0.0";
                    break;
                case "/10":
                    mask10 = "255.192.0.0";
                    break;
                case "/11":
                    mask10 = "255.224.0.0";
                    break;
                case "/12":
                    mask10 = "255.240.0.0";
                    break;
                case "/13":
                    mask10 = "255.248.0.0";
                    break;
                case "/14":
                    mask10 = "255.252.0.0";
                    break;
                case "/15":
                    mask10 = "255.254.0.0";
                    break;
                case "/16":
                    mask10 = "255.255.0.0";
                    break;
                case "/17":
                    mask10 = "255.255.128.0";
                    break;
                case "/18":
                    mask10 = "255.255.192.0";
                    break;
                case "/19":
                    mask10 = "255.255.224.0";
                    break;
                case "/20":
                    mask10 = "255.255.240.0";
                    break;
                case "/21":
                    mask10 = "255.255.248.0";
                    break;
                case "/22":
                    mask10 = "255.255.252.0";
                    break;
                case "/23":
                    mask10 = "255.255.254.0";
                    break;
                case "/24":
                    mask10 = "255.255.255.0";
                    break;
                case "/25":
                    mask10 = "255.255.255.128";
                    break;
                case "/26":
                    mask10 = "255.255.255.192";
                    break;
                case "/27":
                    mask10 = "255.255.255.224";
                    break;
                case "/28":
                    mask10 = "255.255.255.240";
                    break;
                case "/29":
                    mask10 = "255.255.255.248";
                    break;
                case "/30":
                    mask10 = "255.255.255.252";
                    break;
                case "/31":
                    mask10 = "255.255.255.254";
                    break;
                case "/32":
                    mask10 = "255.255.255.255";
                    break;


            }

            return mask10;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (nomer == 1)
            {
                result = 0;
                MessageBox.Show("Количество выполненных заданий - " + Convert.ToString(nomer - 1) + " Допущено ошибок - " + Convert.ToString(mistakes) + " Ваш результат - " + result + "%");

                Window1 opn = new Window1();
                opn.Show();
                this.Close();

            }
            else
            {
                result = 100 - ((Convert.ToDouble(mistakes) / Convert.ToDouble((mistakes + (nomer - 1)))) * 100);
                MessageBox.Show("Количество выполненных заданий - " + Convert.ToString(nomer - 1) + " Допущено ошибок - " + Convert.ToString(mistakes) + " Ваш результат - " + result + "%");

                Window1 opn = new Window1();
                opn.Show();
                this.Close();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true) opt = opt + 1;
            if (checkBox2.IsChecked == true) opt = opt + 2;
            if (opt == 0)
            {
                MessageBox.Show("Параметры заданий не выбраны! Для начала тренировки необходимо выбрать хотя бы один тип заданий.");
            }
            else
            {
                TaskLabel.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                label.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                button.Visibility = Visibility.Visible;
                textBox.Visibility = Visibility.Visible;
                button1.Visibility = Visibility.Visible;
                button2.Visibility = Visibility.Visible;
                Label1.Visibility = Visibility.Visible;
                Label2.Visibility = Visibility.Visible;
                Label3.Visibility = Visibility.Visible;
                Label4.Visibility = Visibility.Visible;
                Label5.Visibility = Visibility.Visible;
                Label6.Visibility = Visibility.Visible;

                switch (opt)
                {
                    case 1:
                        i = 1;
                        break;
                    case 2:
                        i = 2;
                        break;
                    case 3:
                        i = random.Next(1, 3);
                        break;
                }
                switch (i)
                {
                    case 1:
                        TaskLabel.Content = "Запишите маску подсети в полном виде";
                        label.Content = MaskGenerator(random.Next(1, 33));
                        otvet = MaskTransformator(Convert.ToString(label.Content));
                        break;
                    case 2:
                        TaskLabel.Content = "Запишите маску подсети в сокращенном виде";
                        otvet = MaskGenerator(random.Next(1, 33));
                        label.Content = MaskTransformator(otvet);
                        break;
                }


                groupBox1.Visibility = Visibility.Hidden;
                Label6.Content = Convert.ToString(Convert.ToInt32(Label6.Content) + 1);
                nomer = nomer + 1;

            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == otvet)
            {
                Label4.Content = Convert.ToString(Convert.ToInt32(Label4.Content) + 1);
                Label6.Content = Convert.ToString(Convert.ToInt32(Label6.Content) + 1);
                nomer = nomer + 1;
                MessageBox.Show("Верно!");
                switch (opt)
                {
                    case 1:
                        i = 1;
                        break;
                    case 2:
                        i = 2;
                        break;
                    case 3:
                        i = random.Next(1, 3);
                        break;
                }
                switch (i)
                {
                    case 1:
                        TaskLabel.Content = "Запишите маску подсети в полном виде";
                        label.Content = MaskGenerator(random.Next(1, 33));
                        otvet = MaskTransformator(Convert.ToString(label.Content));
                        break;
                    case 2:
                        TaskLabel.Content = "Запишите маску подсети в сокращенном виде";
                        otvet = MaskGenerator(random.Next(1, 33));
                        label.Content = MaskTransformator(otvet);
                        break;
                }
            }
            else
            {
                mistakes = mistakes + 1;
                Label5.Content = Convert.ToString(Convert.ToInt32(Label5.Content) + 1);
                MessageBox.Show("Ответ неверный, попробуйте еще раз");
            }
        }
    }
}

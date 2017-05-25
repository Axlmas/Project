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
    /// Логика взаимодействия для Address.xaml
    /// </summary>
    public partial class Address : Window
    {
        public Address()
        {
            InitializeComponent();
        }
        Int32 a, nomer = 1, mistakes;
        Double result;
        String ip2, Na;
        String mask10, mask2 = "";
        Int32 x;
        static String NetworkAdress(String ip2, String mask2)
        {
            Int32 x;
            String Na = "";
            for (x = 0; x < 32; x = x + 1)//Вычисляем адрес сети в двоичной системе счисления
            {
                Na = Na + Convert.ToString(Convert.ToInt32(mask2.Substring(x, 1)) * Convert.ToInt32(ip2.Substring(x, 1)));
            }
            return Na;
        }

        private void go(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            for (x = 0; x < 32; x = x + 1)
            {
                ip2 = ip2 + Convert.ToString(random.Next(0, 2));//Генерируем айпишник в двоичной системе счисления.
            }
            ip.Content = BinToDec(ip2.Substring(0, 8)) + "." + BinToDec(ip2.Substring(8, 8)) + "." + BinToDec(ip2.Substring(16, 8)) + "." + BinToDec(ip2.Substring(24, 8));

            //генерируем маску подсети.
            a = random.Next(1, 32);

            switch (Convert.ToString(a))
            {
                case "1":
                    mask2 = "10000000000000000000000000000000";
                    mask10 = "128.0.0.0";
                    break;
                case "2":
                    mask2 = "11000000000000000000000000000000";
                    mask10 = "192.0.0.0";
                    break;
                case "3":
                    mask2 = "11100000000000000000000000000000";
                    mask10 = "224.0.0.0";
                    break;
                case "4":
                    mask2 = "11110000000000000000000000000000";
                    mask10 = "240.0.0.0";
                    break;
                case "5":
                    mask2 = "11111000000000000000000000000000";
                    mask10 = "248.0.0.0";
                    break;
                case "6":
                    mask2 = "11111100000000000000000000000000";
                    mask10 = "252.0.0.0";
                    break;
                case "7":
                    mask2 = "11111110000000000000000000000000";
                    mask10 = "254.0.0.0";
                    break;
                case "8":
                    mask2 = "11111111000000000000000000000000";
                    mask10 = "255.0.0.0";
                    break;
                case "9":
                    mask2 = "11111111100000000000000000000000";
                    mask10 = "255.128.0.0";
                    break;
                case "10":
                    mask2 = "11111111110000000000000000000000";
                    mask10 = "255.192.0.0";
                    break;
                case "11":
                    mask2 = "11111111111000000000000000000000";
                    mask10 = "255.224.0.0";
                    break;
                case "12":
                    mask2 = "11111111111100000000000000000000";
                    mask10 = "255.240.0.0";
                    break;
                case "13":
                    mask2 = "11111111111110000000000000000000";
                    mask10 = "255.248.0.0";
                    break;
                case "14":
                    mask2 = "11111111111111000000000000000000";
                    mask10 = "255.252.0.0";
                    break;
                case "15":
                    mask2 = "11111111111111100000000000000000";
                    mask10 = "255.254.0.0";
                    break;
                case "16":
                    mask2 = "11111111111111110000000000000000";
                    mask10 = "255.255.0.0";
                    break;
                case "17":
                    mask2 = "11111111111111111000000000000000";
                    mask10 = "255.255.128.0";
                    break;
                case "18":
                    mask2 = "11111111111111111100000000000000";
                    mask10 = "255.255.192.0";
                    break;
                case "19":
                    mask2 = "11111111111111111110000000000000";
                    mask10 = "255.255.224.0";
                    break;
                case "20":
                    mask2 = "11111111111111111111000000000000";
                    mask10 = "255.255.240.0";
                    break;
                case "21":
                    mask2 = "11111111111111111111100000000000";
                    mask10 = "255.255.248.0";
                    break;
                case "22":
                    mask2 = "11111111111111111111110000000000";
                    mask10 = "255.255.252.0";
                    break;
                case "23":
                    mask2 = "11111111111111111111111000000000";
                    mask10 = "255.255.254.0";
                    break;
                case "24":
                    mask2 = "11111111111111111111111100000000";
                    mask10 = "255.255.255.0";
                    break;
                case "25":
                    mask2 = "11111111111111111111111110000000";
                    mask10 = "255.255.255.128";
                    break;
                case "26":
                    mask2 = "11111111111111111111111111000000";
                    mask10 = "255.255.255.192";
                    break;
                case "27":
                    mask2 = "11111111111111111111111111100000";
                    mask10 = "255.255.255.224";
                    break;
                case "28":
                    mask2 = "11111111111111111111111111110000";
                    mask10 = "255.255.255.240";
                    break;
                case "29":
                    mask2 = "11111111111111111111111111111000";
                    mask10 = "255.255.255.248";
                    break;
                case "30":
                    mask2 = "11111111111111111111111111111100";
                    mask10 = "255.255.255.252";
                    break;
                case "31":
                    mask2 = "11111111111111111111111111111110";
                    mask10 = "255.255.255.254";
                    break;
                case "32":
                    mask2 = "11111111111111111111111111111111";
                    mask10 = "255.255.255.255";
                    break;

            }
            mask.Content = mask10;//выводим отображение маски в задание
        }

        static String BinToDec(String btd1)
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
        }
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Na = NetworkAdress(ip2, mask2);
            if (BinToDec(Na.Substring(0, 8)) + "." + BinToDec(Na.Substring(8, 8)) + "." + BinToDec(Na.Substring(16, 8)) + "." + BinToDec(Na.Substring(24, 8)) == textBox.Text)
            {
                MessageBox.Show("Верно!");
                textBox.Text = "";
                right.Content = Convert.ToString(Convert.ToInt32(right.Content) + 1);
                task.Content = Convert.ToString(Convert.ToInt32(task.Content) + 1);
                nomer = nomer + 1;
                ip2 = "";
                Random random = new Random();
                for (x = 0; x < 32; x = x + 1)
                {
                    ip2 = ip2 + Convert.ToString(random.Next(0, 2));//Генерируем айпишник в двоичной системе счисления.
                }
                ip.Content = BinToDec(ip2.Substring(0, 8)) + "." + BinToDec(ip2.Substring(8, 8)) + "." + BinToDec(ip2.Substring(16, 8)) + "." + BinToDec(ip2.Substring(24, 8));




                //генерируем маску подсети.
                a = random.Next(1, 32);

                switch (Convert.ToString(a))
                {
                    case "1":
                        mask2 = "10000000000000000000000000000000";
                        mask10 = "128.0.0.0";
                        break;
                    case "2":
                        mask2 = "11000000000000000000000000000000";
                        mask10 = "192.0.0.0";
                        break;
                    case "3":
                        mask2 = "11100000000000000000000000000000";
                        mask10 = "224.0.0.0";
                        break;
                    case "4":
                        mask2 = "11110000000000000000000000000000";
                        mask10 = "240.0.0.0";
                        break;
                    case "5":
                        mask2 = "11111000000000000000000000000000";
                        mask10 = "248.0.0.0";
                        break;
                    case "6":
                        mask2 = "11111100000000000000000000000000";
                        mask10 = "252.0.0.0";
                        break;
                    case "7":
                        mask2 = "11111110000000000000000000000000";
                        mask10 = "254.0.0.0";
                        break;
                    case "8":
                        mask2 = "11111111000000000000000000000000";
                        mask10 = "255.0.0.0";
                        break;
                    case "9":
                        mask2 = "11111111100000000000000000000000";
                        mask10 = "255.128.0.0";
                        break;
                    case "10":
                        mask2 = "11111111110000000000000000000000";
                        mask10 = "255.192.0.0";
                        break;
                    case "11":
                        mask2 = "11111111111000000000000000000000";
                        mask10 = "255.224.0.0";
                        break;
                    case "12":
                        mask2 = "11111111111100000000000000000000";
                        mask10 = "255.240.0.0";
                        break;
                    case "13":
                        mask2 = "11111111111110000000000000000000";
                        mask10 = "255.248.0.0";
                        break;
                    case "14":
                        mask2 = "11111111111111000000000000000000";
                        mask10 = "255.252.0.0";
                        break;
                    case "15":
                        mask2 = "11111111111111100000000000000000";
                        mask10 = "255.254.0.0";
                        break;
                    case "16":
                        mask2 = "11111111111111110000000000000000";
                        mask10 = "255.255.0.0";
                        break;
                    case "17":
                        mask2 = "11111111111111111000000000000000";
                        mask10 = "255.255.128.0";
                        break;
                    case "18":
                        mask2 = "11111111111111111100000000000000";
                        mask10 = "255.255.192.0";
                        break;
                    case "19":
                        mask2 = "11111111111111111110000000000000";
                        mask10 = "255.255.224.0";
                        break;
                    case "20":
                        mask2 = "11111111111111111111000000000000";
                        mask10 = "255.255.240.0";
                        break;
                    case "21":
                        mask2 = "11111111111111111111100000000000";
                        mask10 = "255.255.248.0";
                        break;
                    case "22":
                        mask2 = "11111111111111111111110000000000";
                        mask10 = "255.255.252.0";
                        break;
                    case "23":
                        mask2 = "11111111111111111111111000000000";
                        mask10 = "255.255.254.0";
                        break;
                    case "24":
                        mask2 = "11111111111111111111111100000000";
                        mask10 = "255.255.255.0";
                        break;
                    case "25":
                        mask2 = "11111111111111111111111110000000";
                        mask10 = "255.255.255.128";
                        break;
                    case "26":
                        mask2 = "11111111111111111111111111000000";
                        mask10 = "255.255.255.192";
                        break;
                    case "27":
                        mask2 = "11111111111111111111111111100000";
                        mask10 = "255.255.255.224";
                        break;
                    case "28":
                        mask2 = "11111111111111111111111111110000";
                        mask10 = "255.255.255.240";
                        break;
                    case "29":
                        mask2 = "11111111111111111111111111111000";
                        mask10 = "255.255.255.248";
                        break;
                    case "30":
                        mask2 = "11111111111111111111111111111100";
                        mask10 = "255.255.255.252";
                        break;
                    case "31":
                        mask2 = "11111111111111111111111111111110";
                        mask10 = "255.255.255.254";
                        break;
                    case "32":
                        mask2 = "11111111111111111111111111111111";
                        mask10 = "255.255.255.255";
                        break;

                }
                mask.Content = mask10;//выводим отображение маски в задание
            }
            else
            {

                mistakes = mistakes + 1;
                wrong.Content = Convert.ToString(Convert.ToInt32(wrong.Content) + 1);
                MessageBox.Show("Ответ неверный, попробуйте еще раз");

            }
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
    }
}

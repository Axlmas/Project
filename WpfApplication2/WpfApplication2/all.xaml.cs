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
    /// Логика взаимодействия для all.xaml
    /// </summary>
    public partial class all : Window
    {
        Int32 mistakes, i;
        Double result;
        String ip2, Na, fIP, NN, BC, lIP;
        String mask2 = "";
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
        static String MaskGenerator()
        {
            Int32 vkr;
            String mask2 = "";
            Random random = new Random();
            vkr = random.Next(1, 32);
            switch (vkr) //переводим его в строковый вид(хз зачем, почему-то мне так показалось удобнее) и в зависимости от него выбираем вариант действий
            {//маска генерируется в двух вариантах: маск2 - для вычислений, маск10 - для отображения в задании.
                case 1:
                    mask2 = "10000000000000000000000000000000";
                    break;
                case 2:
                    mask2 = "11000000000000000000000000000000";
                    break;
                case 3:
                    mask2 = "11100000000000000000000000000000";
                    break;
                case 4:
                    mask2 = "11110000000000000000000000000000";
                    break;
                case 5:
                    mask2 = "11111000000000000000000000000000";
                    break;
                case 6:
                    mask2 = "11111100000000000000000000000000";
                    break;
                case 7:
                    mask2 = "11111110000000000000000000000000";
                    break;
                case 8:
                    mask2 = "11111111000000000000000000000000";
                    break;
                case 9:
                    mask2 = "11111111100000000000000000000000";
                    break;
                case 10:
                    mask2 = "11111111110000000000000000000000";
                    break;
                case 11:
                    mask2 = "11111111111000000000000000000000";
                    break;
                case 12:
                    mask2 = "11111111111100000000000000000000";
                    break;
                case 13:
                    mask2 = "11111111111110000000000000000000";
                    break;
                case 14:
                    mask2 = "11111111111111000000000000000000";
                    break;
                case 15:
                    mask2 = "11111111111111100000000000000000";
                    break;
                case 16:
                    mask2 = "11111111111111110000000000000000";
                    break;
                case 17:
                    mask2 = "11111111111111111000000000000000";
                    break;
                case 18:
                    mask2 = "11111111111111111100000000000000";
                    break;
                case 19:
                    mask2 = "11111111111111111110000000000000";
                    break;
                case 20:
                    mask2 = "11111111111111111111000000000000";
                    break;
                case 21:
                    mask2 = "11111111111111111111100000000000";
                    break;
                case 22:
                    mask2 = "11111111111111111111110000000000";
                    break;
                case 23:
                    mask2 = "11111111111111111111111000000000";
                    break;
                case 24:
                    mask2 = "11111111111111111111111100000000";
                    break;
                case 25:
                    mask2 = "11111111111111111111111110000000";
                    break;
                case 26:
                    mask2 = "11111111111111111111111111000000";
                    break;
                case 27:
                    mask2 = "11111111111111111111111111100000";
                    break;
                case 28:
                    mask2 = "11111111111111111111111111110000";
                    break;
                case 29:
                    mask2 = "11111111111111111111111111111000";
                    break;
                case 30:
                    mask2 = "11111111111111111111111111111100";
                    break;
                case 31:
                    mask2 = "11111111111111111111111111111110";
                    break;
                case 32:
                    mask2 = "11111111111111111111111111111111";
                    break;

            }
            return mask2;
        }
        static String IP2to10(String vkr1)
        {
            String ip10 = "";
            ip10 = BinToDec(vkr1.Substring(0, 8)) + "." + BinToDec(vkr1.Substring(8, 8)) + "." + BinToDec(vkr1.Substring(16, 8)) + "." + BinToDec(vkr1.Substring(24, 8));
            return ip10;
        }
        static String ipGenerator()
        {
            String ip2 = "";
            Int32 x;
            Random random = new Random();
            for (x = 0; x < 32; x = x + 1)
            {
                ip2 = ip2 + Convert.ToString(random.Next(0, 2));//Генерируем айпишник в двоичной системе счисления путем случайной выборки 32х чисел от 0 до 1.
            }
            return ip2;
        }
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

        

        static String FirstIP(String Na)
        {
            Int32 N = 31;

            N = Na.LastIndexOf("0");
            Na = Na.Remove(N) + "1";
            while (Na.Length != 32)
            {
                Na = Na + "0";
            }

            return Na;
        }

        private void go(object sender, RoutedEventArgs e)
        {
            Random random = new Random();


            ip2 = ipGenerator();//Генерим айпишник.
            ip.Content = IP2to10(ip2);//Выводим в лейбл 
            mask2 = MaskGenerator();//С помощью статической функции генерим по этому число маску подсети в двоичной записи.
            mask.Content = IP2to10(mask2);//Выводим в лейбл десятичное отображение айпишника с помощью одной из статических функций.
            Na = NetworkAdress(ip2, mask2);//С помощью статической функции вычисляем адрес сети по айпишнику и маске.
            fIP = FirstIP(Na);//Вычисляем First IP, прибавляя единичку к адресу сети.
            NN = NextNetwork(Na, mask2);
            BC = Broadcast(Na, mask2);
            lIP = LastIP(Na, mask2);
        }

        static String NextNetwork(String Na, String mask2)
        {
            Int32 N;
            String NN = "";
            N = mask2.LastIndexOf("1");
            //MessageBox.Show(Convert.ToString(N));
            NN = Na.Substring(0, N + 1);
            //MessageBox.Show(NN);
            while (NN.Length < (32))
            {
                NN = NN + "1";

            }//если вывести результат на этом шаге - получим бродкаст
            N = NN.LastIndexOf("0");
            if (N == -1)
            {
                NN = "нет";
            }
            else
            {
                NN = NN.Substring(0, N);
                NN = NN + "1";
                while (NN.Length < (32))
                {
                    NN = NN + "0";

                }
            }
            return NN;
        }

        static String Broadcast(String Na, String mask2)
        {
            Int32 N;
            String BC = "";
            N = mask2.LastIndexOf("1");
            //MessageBox.Show(Convert.ToString(N));
            BC = Na.Substring(0, N + 1);
            //MessageBox.Show(NN);
            while (BC.Length < (32))
            {
                BC = BC + "1";

            }
            return BC;//если вывести результат на этом шаге - получим бродкаст
        }
        static String LastIP(String Na, String mask2)
        {
            Int32 N;
            String lIP = "";
            N = mask2.LastIndexOf("1");
            //MessageBox.Show(Convert.ToString(N));
            lIP = Na.Substring(0, N + 1);
            //MessageBox.Show(NN);
            while (lIP.Length < (31))
            {
                lIP = lIP + "1";

            }
            lIP = lIP + "0";
            return lIP;
        }
        public all()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            if (textBox.Text == IP2to10(Na))
            {
                textBox.Background = Brushes.Green;
                i = i + 1;
            }
            else
            {
                textBox.Background = Brushes.Red;
            }
            //Проверка адреса сети завершена


            if (textBox1.Text == IP2to10(fIP))
            {
                textBox1.Background = Brushes.Green;
                i = i + 1;
            }
            else
            {
                textBox1.Background = Brushes.Red;
            }
            //Проверка первого айпишника завершена


            if (textBox2.Text == IP2to10(NN))
            {
                textBox2.Background = Brushes.Green;
                i = i + 1;
            }
            else
            {
                textBox2.Background = Brushes.Red;
            }
            //Проверка адреса следующей сети завершена


            if (textBox3.Text == IP2to10(BC))
            {
                textBox3.Background = Brushes.Green;
                i = i + 1;
            }
            else
            {
                textBox3.Background = Brushes.Red;
            }
            //Проверка бродкаста завершена


            if (textBox4.Text == IP2to10(lIP))
            {
                textBox4.Background = Brushes.Green;
                i = i + 1;
            }
            else
            {
                textBox4.Background = Brushes.Red;
            }
            //Проверка последнего адреса сети завершена
            //Завершена проверка всех ответов
            if (i != 5)
            {

                mistakes = mistakes + 1;
                wrong.Content = Convert.ToString(Convert.ToInt32(wrong.Content) + 1);

                MessageBox.Show("Ответ неверный, попробуйте еще раз");
            }
            else
            {
                MessageBox.Show("Верно!");
                task.Content = Convert.ToString(Convert.ToInt32(task.Content) + 1);
                right.Content = Convert.ToString(Convert.ToInt32(right.Content) + 1);
                textBox.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox1.Text = "";
                textBox.Background = Brushes.White;
                textBox2.Background = Brushes.White;
                textBox3.Background = Brushes.White;
                textBox4.Background = Brushes.White;
                textBox1.Background = Brushes.White;

                Random random = new Random();


                ip2 = ipGenerator();//Генерим айпишник.
                ip.Content = IP2to10(ip2);//Выводим в лейбл 
                mask2 = MaskGenerator();//С помощью статической функции генерим по этому число маску подсети в двоичной записи.
                mask.Content = IP2to10(mask2);//Выводим в лейбл десятичное отображение айпишника с помощью одной из статических функций.
                Na = NetworkAdress(ip2, mask2);//С помощью статической функции вычисляем адрес сети по айпишнику и маске.
                fIP = FirstIP(Na);//Вычисляем First IP, прибавляя единичку к адресу сети.
                NN = NextNetwork(Na, mask2);
                BC = Broadcast(Na, mask2);
                lIP = LastIP(Na, mask2);
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

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
    /// Логика взаимодействия для Networks.xaml
    /// </summary>
    public partial class Networks : Window
    {
        Int32 i, a, b;
        //Int32 result;

        String ip2_2, ip2_3, ip2_4, ip2_5, Na_2, Na_3, Na_4, Na_5, fIP_2, NN_2, BC_2, lIP_2, fIP_3, NN_3, BC_3, lIP_3, fIP_4, NN_4, BC_4, lIP_4, fIP_5, NN_5, BC_5, lIP_5;
        String mask2_1 = "";
        String mask2_2 = "";
        String mask2_3 = "";
        String mask2_4 = "";
        String mask2_5 = "";
        Int32 fff;
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
        static String MaskGenerator2(Int32 vkr)
        {

            String mask2 = "";


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

        public Networks()
        {
            InitializeComponent();
        }

        private void go(object sender, RoutedEventArgs e)
        {
            //Генерим первое задание
            Random random = new Random();
            a = random.Next(1, 3);
            switch (a)
            {
                case 1:
                    mask2_1 = MaskGenerator();
                    label1.Content = "Записать маску подсети в сокращенном виде:";
                    label6.Content = IP2to10(mask2_1);
                    fff = 1;
                    break;
                case 2:
                    mask2_1 = MaskGenerator();
                    label1.Content = "Записать маску подсети в полном виде:";
                    label6.Content = "/" + Convert.ToString((mask2_1.LastIndexOf("1")) + 1);
                    fff = 2;
                    break;
            }//Конец генерации первого задания

            //Генерим второе задание
            ip2_2 = ipGenerator();//Генерим айпишник.
            label7.Content = IP2to10(ip2_2);//Выводим в лейбл айпишник в двоичной системе счисления
            b = random.Next(1, 9);//создаем случайное число для генерации маски подсети
            mask2_2 = MaskGenerator2(b);//С помощью статической функции генерим по этому число маску подсети в двоичной записи.
            label2.Content = IP2to10(mask2_2);//Выводим в лейбл десятичное отображение айпишника с помощью одной из статических функций.
            Na_2 = NetworkAdress(ip2_2, mask2_2);//С помощью статической функции вычисляем адрес сети по айпишнику и маске.
            fIP_2 = FirstIP(Na_2);//Вычисляем First IP, прибавляя единичку к адресу сети.
            NN_2 = NextNetwork(Na_2, mask2_2);//Вычисляем адрес следующей сети.
            BC_2 = Broadcast(Na_2, mask2_2);//Вычисляем адрес широковещательной рассылки.
            lIP_2 = LastIP(Na_2, mask2_2);//Вычисляем последний адрес, допустимый к назначению устройству.
            //Конец генерации второго задания

            //Генерим третье задание
            ip2_3 = ipGenerator();//Генерим айпишник.
            label21.Content = IP2to10(ip2_3);//Выводим в лейбл айпишник в двоичной системе счисления
            b = random.Next(9, 17);//создаем случайное число для генерации маски подсети
            mask2_3 = MaskGenerator2(b);//С помощью статической функции генерим по этому число маску подсети в двоичной записи.
            label20.Content = IP2to10(mask2_3);//Выводим в лейбл десятичное отображение айпишника с помощью одной из статических функций.
            Na_3 = NetworkAdress(ip2_2, mask2_3);//С помощью статической функции вычисляем адрес сети по айпишнику и маске.
            fIP_3 = FirstIP(Na_3);//Вычисляем First IP, прибавляя единичку к адресу сети.
            NN_3 = NextNetwork(Na_3, mask2_3);//Вычисляем адрес следующей сети.
            BC_3 = Broadcast(Na_3, mask2_3);//Вычисляем адрес широковещательной рассылки.
            lIP_3 = LastIP(Na_3, mask2_3);//Вычисляем последний адрес, допустимый к назначению устройству.
            //Конец генерации третьего задания

            //Генерим четвертое задание
            ip2_4 = ipGenerator();//Генерим айпишник.
            label30.Content = IP2to10(ip2_4);//Выводим в лейбл айпишник в двоичной системе счисления
            b = random.Next(17, 25);//создаем случайное число для генерации маски подсети
            mask2_4 = MaskGenerator2(b);//С помощью статической функции генерим по этому число маску подсети в двоичной записи.
            label29.Content = IP2to10(mask2_4);//Выводим в лейбл десятичное отображение айпишника с помощью одной из статических функций.
            Na_4 = NetworkAdress(ip2_4, mask2_4);//С помощью статической функции вычисляем адрес сети по айпишнику и маске.
            fIP_4 = FirstIP(Na_4);//Вычисляем First IP, прибавляя единичку к адресу сети.
            NN_4 = NextNetwork(Na_4, mask2_4);//Вычисляем адрес следующей сети.
            BC_4 = Broadcast(Na_4, mask2_4);//Вычисляем адрес широковещательной рассылки.
            lIP_4 = LastIP(Na_4, mask2_4);//Вычисляем последний адрес, допустимый к назначению устройству.
            //Конец генерации четвертого задания

            //Генерим пятое задание
            ip2_5 = ipGenerator();//Генерим айпишник.
            label39.Content = IP2to10(ip2_5);//Выводим в лейбл айпишник в двоичной системе счисления
            b = random.Next(25, 33);//создаем случайное число для генерации маски подсети
            mask2_5 = MaskGenerator2(b);//С помощью статической функции генерим по этому число маску подсети в двоичной записи.
            label38.Content = IP2to10(mask2_5);//Выводим в лейбл десятичное отображение айпишника с помощью одной из статических функций.
            Na_5 = NetworkAdress(ip2_5, mask2_5);//С помощью статической функции вычисляем адрес сети по айпишнику и маске.
            fIP_5 = FirstIP(Na_5);//Вычисляем First IP, прибавляя единичку к адресу сети.
            NN_5 = NextNetwork(Na_5, mask2_5);//Вычисляем адрес следующей сети.
            BC_5 = Broadcast(Na_5, mask2_5);//Вычисляем адрес широковещательной рассылки.
            lIP_5 = LastIP(Na_5, mask2_5);//Вычисляем последний адрес, допустимый к назначению устройству.
                                          //Конец генерации пятого задания

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Начинаем обрабатывать ответы учеников
            //Обработка ответов первого задания
            if (textBox1.Text == IP2to10(Na_2))
                switch (fff)
                {
                    case 1:
                        if (textBox1.Text == mask2_1)
                        {
                            i = i + 1;
                        }
                        break;
                    case 2:
                        if (textBox1.Text == IP2to10(mask2_1))
                        {
                            i = i + 1;
                        }
                        break;
                }
            {
                i = i + 1;//НЕ ГОТОВО, НАПИСАТЬ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }

            //обработка ответов второго задания
            if (textBox2.Text == IP2to10(Na_2))
            {
                i = i + 1;
            }
            if (textBox3.Text == IP2to10(fIP_2))
            {
                i = i + 1;
            }
            if (textBox4.Text == IP2to10(NN_2))
            {
                i = i + 1;
            }
            if (textBox5.Text == IP2to10(lIP_2))
            {
                i = i + 1;
            }
            if (textBox6.Text == IP2to10(BC_2))
            {
                i = i + 1;
            }


            //Обработка ответов третьего задания
            if (textBox7.Text == IP2to10(Na_3))
            {
                i = i + 1;
            }
            if (textBox8.Text == IP2to10(fIP_3))
            {
                i = i + 1;
            }
            if (textBox9.Text == IP2to10(NN_3))
            {
                i = i + 1;
            }
            if (textBox10.Text == IP2to10(lIP_3))
            {
                i = i + 1;
            }
            if (textBox11.Text == IP2to10(BC_3))
            {
                i = i + 1;
            }

            //Обработка ответов четвертого задания
            if (textBox12.Text == IP2to10(Na_4))
            {
                i = i + 1;
            }
            if (textBox13.Text == IP2to10(fIP_4))
            {
                i = i + 1;
            }
            if (textBox14.Text == IP2to10(NN_4))
            {
                i = i + 1;
            }
            if (textBox15.Text == IP2to10(lIP_4))
            {
                i = i + 1;
            }
            if (textBox16.Text == IP2to10(BC_4))
            {
                i = i + 1;
            }

            //Обработка ответов пятого задания
            if (textBox17.Text == IP2to10(Na_5))
            {
                i = i + 1;
            }
            if (textBox18.Text == IP2to10(fIP_5))
            {
                i = i + 1;
            }
            if (textBox19.Text == IP2to10(NN_5))
            {
                i = i + 1;
            }
            if (textBox20.Text == IP2to10(lIP_5))
            {
                i = i + 1;
            }
            if (textBox21.Text == IP2to10(BC_5))
            {
                i = i + 1;
            }
            //Обработка ответов завершена, в переменной i содержится количество правильно решенных заданий.
            //Начинаем вычисление оценки
            if (i == 21)//Если ученик сделал правильно все задания - ставим ему 5
            {
                //result = 5;
                label40.Content = "5";
                button2.Visibility = Visibility.Visible;
                label40.Visibility = Visibility.Visible;
                button1.Visibility = Visibility.Hidden;
            }
            else
            {
                if (i > 16)//Если больше 16 - ставим 4
                {
                    //result = 4;
                    label40.Content = "4";
                    button2.Visibility = Visibility.Visible;
                    label40.Visibility = Visibility.Visible;
                    button1.Visibility = Visibility.Hidden;
                }
                else
                {
                    if (i > 10)//Если 11-15 - тройка
                    {
                        //result = 3;
                        label40.Content = "3";
                        button2.Visibility = Visibility.Visible;
                        label40.Visibility = Visibility.Visible;
                        button1.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        //result = 2;//Ну и двойка, однако :)
                        label40.Content = "2";
                        button2.Visibility = Visibility.Visible;
                        label40.Visibility = Visibility.Visible;
                        button1.Visibility = Visibility.Hidden;
                    }
                }
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window1 opn = new Window1();
            opn.Show();
            this.Close();
        }
    }
}

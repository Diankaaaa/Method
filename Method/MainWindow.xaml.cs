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

namespace Method
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

        static string Sum(string d1, string d2) 
        {
            int j = Convert.ToInt32(d1, 2); //Конвертируем строку в тип int
            int j2 = Convert.ToInt32(d2, 2); //Конвертируем строку в тип int
            int j3 = j + j2; //Складываем два числа
            string res = Convert.ToString(j3, 2); //Обратно конвертируем в строку
            return res; //Возвращаем результат
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string numP = v1.Text; //Получаем положительное двоичное число от пользователя
                string numO = v2.Text; //Получаем отрицательное двоичное число от пользователя

                //Вывод результата и вызов метода
                Result.Text = Sum(numP, numO);
            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

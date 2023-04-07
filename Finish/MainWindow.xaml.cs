using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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

namespace Finish
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            // Отслеживание нажатий на кнопки

            foreach (UIElement el in Root.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }
        // Обработка событий нажатия

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string str = (string)((Button)e.OriginalSource).Content;

                if (str == "AC")
                {
                    summ.Text = " ";
                }
                else if (str == "=")
                {
                    string value = new DataTable().Compute(summ.Text, null).ToString();
                    summ.Text = value;
                }
                else
                {
                    summ.Text += str;
                }
            }

            catch (Exception ex) // обработка исключений
            {
                string str = null;
            }
            
        }
    }
}

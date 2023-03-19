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

namespace dz1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if(Name.Text!=String.Empty && Age.Text != String.Empty && Hobby.Text != String.Empty)
            {
                info.Content = $"Привіт! Мене звати {Name.Text}. Мені {Age.Text} років. Моє улюблене хоббі - {Hobby.Text}";
            }
        }

        private void Age_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }
        private bool IsTextAllowed(string text)
        {
            return Array.TrueForAll(text.ToCharArray(), c => Char.IsDigit(c));
        }
    }
}

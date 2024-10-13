using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Ink;
using System.Windows.Shapes;
using System;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Меня зовут: я прихожу, 
Если не зовут, не прихожу", "О разработчике", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ColorItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                if (menuItem.Header.ToString() == "Black")
                {
                    Ivan.Foreground = new SolidColorBrush(Colors.White);
                }
                else
                {

                    Ivan.Foreground = new SolidColorBrush(Colors.Black);
                }

                Menuu.Background = (Brush)new BrushConverter().ConvertFromString(menuItem.Header.ToString());
            }
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void MenuItem_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                StatusText.Text = $"Выберите {menuItem.Header}";
            }
        }

        private void MenuItem_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            StatusText.Text = "Тут интересно"; // или пустую строку, если хотите
        }
    }
}
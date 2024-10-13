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
        private Point startPoint;
        private bool isSelecting;
        private Rectangle selectionRectangle;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ink.Strokes.Clear();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                Color selectedColor = ((SolidColorBrush)selectedItem.Background).Color;
                Ink.DefaultDrawingAttributes.Color = selectedColor;
            }
        }

        private void SliderMoi_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Propper.Height = e.NewValue * 2;
            Propper.Width = e.NewValue * 2;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioDraw.IsChecked == true)
            {
                Ink.EditingMode = InkCanvasEditingMode.Ink;
            }
            else if (RadioEdit.IsChecked == true)
            {
                Ink.EditingMode = InkCanvasEditingMode.Select;
            }
            else if (RadioDelete.IsChecked == true)
            {
                Ink.EditingMode = InkCanvasEditingMode.EraseByStroke;
            }
        }

     


    }
}

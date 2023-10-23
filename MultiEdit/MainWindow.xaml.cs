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

namespace MultiEdit
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

        private void ChangeStyleButton_Click(object sender, RoutedEventArgs e)
        {
            // Применяем стиль к большому текстовому полю
            largeTextBox.Style = (Style)Resources["NewStyle"];

            // Применяем стиль к другим текстовым полям по аналогии
            smallTextBox1.Style = (Style)Resources["NewStyle"];
            smallTextBox2.Style = (Style)Resources["NewStyle"];
            // ...
        }
    }
}

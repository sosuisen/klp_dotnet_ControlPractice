using System.Windows;
using System.Windows.Controls;

namespace ControlPractice
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tb = this.FindName("MyTextBox") as TextBox;
            var label = this.FindName("MyLabel") as Label;
            label!.Content = $"Hello,{tb!.Text}!";
        }
    }
}
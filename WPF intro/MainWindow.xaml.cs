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

namespace WPF_intro
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

        InitializeComponent();
            //TextBlock myTb = new TextBlock();
            //myTb.Text = "Hello David";
            //myTb.Inlines.Add(" this is added using Inlines!");
            //myTb.Inlines.Add(new Run(" Run text")
            //{
            //    Foreground = Brushes.Red,
            //    TextDecorations = TextDecorations.Underline,
            //});
            //myTb.TextWrapping = TextWrapping.Wrap;
            //myTb.Foreground = Brushes.Aqua;
            //this.Content = myTb;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myLabel.FontSize += 1;
        }

        private void myBotton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            myLabel.Foreground = Brushes.Peru;
            myLabel.FontSize -= 3;
        }

        private void myBotton_MouseEnter(object sender, MouseEventArgs e)
        {
            myLabel.Foreground = Brushes.Red;
        }

        private void myBotton_MouseLeave(object sender, MouseEventArgs e)
        {
            myLabel.Foreground = Brushes.Blue;

        }
    }
}

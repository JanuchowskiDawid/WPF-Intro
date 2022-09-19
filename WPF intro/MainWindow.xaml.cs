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
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            myTextBox.Text = "";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox Cb1 = (ComboBox)sender;
            ComboBoxItem cbItem = (ComboBoxItem)Cb1.SelectedItem;
            string newFontsize = (string)cbItem.Content;

            int temp;
            if(Int32.TryParse(newFontsize, out temp))
            {
                if (myTextBox!= null)
                {
                    myTextBox.FontSize = temp;
                }
            }
        }
    }
}

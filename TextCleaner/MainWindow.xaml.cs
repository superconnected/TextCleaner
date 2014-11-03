using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextCleaner
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

        private string _acceptable = "<>/\\|;=\r\n\"' ()";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var input = tbText.Text;
            if (String.IsNullOrEmpty(input))
                return;

            var output = new String(input.Where(c => Char.IsLetterOrDigit(c) || Char.IsPunctuation(c) || _acceptable.Contains(c)).ToArray());
            tbText.Text = output;

            MessageBox.Show("Cleaned!");
        }
    }
}

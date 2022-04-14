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

namespace Example
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
            var inputText = InputBox.Text;
            var encodeValue = EncodeTo64(inputText);
            OutputBox.Text = encodeValue;
        }

        static public string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);
            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);

            return returnValue;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var inputValue = OutputBox.Text;
            var decodeValue = DecodeTo64(inputValue);

            InputBox.Text = decodeValue;
        }

        static public string DecodeTo64(string toDecode)
        {
            var returnBytes = System.Convert.FromBase64String(toDecode);
            string returnValue = System.Text.ASCIIEncoding.ASCII.GetString(returnBytes);

            return returnValue;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var window = new Window1();
            window.Show();
        }
    }
}

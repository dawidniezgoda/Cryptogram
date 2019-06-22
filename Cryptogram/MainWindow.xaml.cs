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

namespace Cryptogram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string message;
        private int key;
        private string key2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Encrypt_Click(object sender, RoutedEventArgs e)
        {
            message = Message.Text;
            Rot13_TextBox.Text = Rot13.Transform(message);
            TextLength.Content = message.Length.ToString();
            CipherLength.Content = Rot13_TextBox.Text.Length; 
        }

        private void Encrypt2_Click(object sender, RoutedEventArgs e)
        {
            message = Message2.Text;
            key = Convert.ToInt32(Keycaesar_TextBox.Text);
            Caesarcipher_TextBox.Text = Caesar_cipher.Transform(key,message);
            TextLength2.Content = message.Length.ToString();
            CipherLength2.Content = Caesarcipher_TextBox.Text.Length;
        }

        private void Encrypt3_Click(object sender, RoutedEventArgs e)
        {
            message = Message3.Text;
            key2 = Keyplayfair_TextBox.Text;
            PlayFaircipher_TextBox.Text = PlayFair_cipher.Transform(message, key2);
            TextLength3.Content = message.Length.ToString();
            CipherLength3.Content = PlayFaircipher_TextBox.Text.Length;
        }

        private void Encrypt4_Click(object sender, RoutedEventArgs e)
        {
            message = Message4.Text;
            Decimalcipher_TextBox.Text = Decimal.Transform(message);
            TextLength4.Content = message.Length.ToString();
            CipherLength4.Content = Decimalcipher_TextBox.Text.Length;
        }

        private void Encrypt5_Click(object sender, RoutedEventArgs e)
        {
            message = Message5.Text;
            Octalcipher_TextBox.Text = Octal.Transform(message);
            TextLength5.Content = message.Length.ToString();
            CipherLength5.Content = Octalcipher_TextBox.Text.Length;
        }

        private void Encrypt6_Click(object sender, RoutedEventArgs e)
        {
            message = Message6.Text;
            Hexadecimalcipher_TextBox.Text = Hexadecimal.Transform(message);
            TextLength6.Content = message.Length.ToString();
            CipherLength6.Content = Hexadecimalcipher_TextBox.Text.Length;
        }

        private void Encrypt7_Click(object sender, RoutedEventArgs e)
        {
            message = Message7.Text;
            Binarycipher_TextBox.Text = Binary.Transform(message);
            TextLength7.Content = message.Length.ToString();
            CipherLength7.Content = Binarycipher_TextBox.Text.Length;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            message = "";
            Message.Text = "";
            Rot13_TextBox.Text = "";
            TextLength.Content = "0";
            CipherLength.Content = "0";
        }

        private void Clear2_Click(object sender, RoutedEventArgs e)
        {
            message = "";
            Message2.Text = "";
            Caesarcipher_TextBox.Text = "";
            TextLength2.Content = "0";
            CipherLength2.Content = "0";
        }

        private void Clear3_Click(object sender, RoutedEventArgs e)
        {
            message = "";
            Message3.Text = "";
            PlayFaircipher_TextBox.Text = "";
            TextLength3.Content = "0";
            CipherLength3.Content = "0";
        }

        private void Clear4_Click(object sender, RoutedEventArgs e)
        {
            message = "";
            Message4.Text = "";
            Decimalcipher_TextBox.Text = "";
            TextLength4.Content = "0";
            CipherLength4.Content = "0";
        }

        private void Clear5_Click(object sender, RoutedEventArgs e)
        {
            message = "";
            Message5.Text = "";
            Octalcipher_TextBox.Text = "";
            TextLength5.Content = "0";
            CipherLength5.Content = "0";
        }

        private void Clear6_Click(object sender, RoutedEventArgs e)
        {
            message = "";
            Message6.Text = "";
            Hexadecimalcipher_TextBox.Text = "";
            TextLength6.Content = "0";
            CipherLength6.Content = "0";
        }

        private void Clear7_Click(object sender, RoutedEventArgs e)
        {
            message = "";
            Message7.Text = "";
            Binarycipher_TextBox.Text = "";
            TextLength7.Content = "0";
            CipherLength7.Content = "0";
        }
    }
}

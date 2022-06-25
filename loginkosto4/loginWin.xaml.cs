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
using System.Windows.Shapes;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
//using System.Windows.Forms;
using MySqlConnector;

namespace loginkosto4
{
    /// <summary>
    /// Логика взаимодействия для loginWin.xaml
    /// </summary>
    public partial class loginWin : Window
    {
        

        public loginWin()
        {
            SplashScreen splash = new SplashScreen("load_screen.jpg");
            splash.Show(true);
            Thread.Sleep(2000);

            InitializeComponent();
            

        }


       
        
        private void VisiblePass_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
                visiblePass.Text = passBox.Password;
                visiblePass.Visibility = Visibility.Visible;
                passBox.Visibility = Visibility.Hidden;
        }
        private void checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            passBox.Password = visiblePass.Text;
            visiblePass.Visibility = Visibility.Hidden;
            passBox.Visibility = Visibility.Visible;
        }
        private void LogBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Passbtn_Click(object sender, RoutedEventArgs e)
        {
            var passrod = checkbox.IsChecked.Value ? visiblePass.Text : passBox.Password;
            System.Windows.MessageBox.Show(passrod);
        }



        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (logBox.Text == "vad" || logBox.Text == "admin")
            {
                if (passBox.Password == "000" || visiblePass.Text == "000")
                {

                    winZakaz main = new winZakaz();
                    main.Show();
                    this.Hide();
                }
                else if (passBox.Password != "000")
                {
                    MessageBox.Show("Error: wrong or empty password.");
                    winCaptcha wCap = new winCaptcha();
                    wCap.Show();
                    this.Hide();

                }
            }
            else if (logBox.Text != "vad")
            {
                MessageBox.Show("Error: wrong or empty login.");
                winCaptcha wCap = new winCaptcha();
                wCap.Show();
                this.Hide();
            }

        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void logBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

      
    }
}

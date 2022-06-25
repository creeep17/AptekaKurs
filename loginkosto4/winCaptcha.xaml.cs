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

namespace loginkosto4
{
    /// <summary>
    /// Логика взаимодействия для winCaptcha.xaml
    /// </summary>
    public partial class winCaptcha : Window
    {
        string captcha = "";
        public winCaptcha()
        {
            InitializeComponent();

        }

        void loadcap()
        {
            captcha = "";
            string ABC = "1,2,3,4,5,6,7,8,9,0,Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Z,X,C,V,B,N,M," +
                "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,z,x,c,v,b,n,m";
            char[] a = { ',' };
            string[] ar = ABC.Split(a);
            string temp = " ";
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                temp = ar[rnd.Next(0, ar.Length)];
                captcha += temp;

            }

            capbox.Text = captcha;

            if (vvodBox == null)
            {
                MessageBox.Show("0!");
            }

        }





        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void RefreshBtn(object sender, RoutedEventArgs e)
        {

            loadcap();

        }

        private void EnterBtn(object sender, RoutedEventArgs e)
        {
            if (vvodBox.Text == "")
            {
                MessageBox.Show("Поле не может быть пустым");

            }
            else if (vvodBox.Text == captcha)
            {
                MessageBox.Show("Верно!");
                loginWin w = new loginWin();
                w.Show();
                this.Hide();
            }
            else
            {
                winBlock block = new winBlock();
                block.Show();
                this.Hide();
            }
        }



        private void vvodBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void message_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}



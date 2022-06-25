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
using System.Windows.Threading;


namespace loginkosto4
{
    /// <summary>
    /// Логика взаимодействия для winBlock.xaml
    /// </summary>
    public partial class winBlock : Window
    {
        public winBlock()
        {
            InitializeComponent();
            secondmer();

        }

        // Секундомер сеанса
        private void secondmer()
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Start();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
        }

        private int increment = 10;

        private void dtTicker(object sender, EventArgs e)
        {
            ltimer.Content = increment.ToString();
            increment--;
            if (increment == 0)
            {
                loginWin w = new loginWin();
                w.Show();
                this.Close();
            }
        }


    }
}


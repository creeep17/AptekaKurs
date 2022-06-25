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
using System.Data;
using System.Data.SqlClient;

namespace loginkosto4
{
    /// <summary>
    /// Логика взаимодействия для winZakaz.xaml
    /// </summary>
    public partial class winZakaz : Window
    {
        public winZakaz()
        {
            InitializeComponent();
            ListApteka.Visibility = Visibility.Hidden;

        }

        public class lekarstvaS
        {
            public string codc { get; set; }
            public string name { get; set; }
            public string country { get; set; }
            public string price { get; set; }
            public string basic { get; set; }


        }

        public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении
                                                                            // подключаемся к базе данных
            SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-A9E1RP6\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=apteka;");
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = selectSQL;                             // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable);                                 // возращаем таблицу с результатом
            return dataTable;
        }


        
        private void btnAvans_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ListLekarstva_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // КНОПКА ЛЕКАРСТВА
        private void btnLekarstva_Click(object sender, RoutedEventArgs e)
        {
            ListApteka.Items.Clear();
            //ListKrasota.Visibility = Visibility.Hidden;
            ListApteka.Visibility = Visibility.Visible;
            LoadLekarstva();
        }
        void LoadLekarstva()
        {
            DataTable dt_lekarstva = Select("SELECT * FROM [dbo].[table_lekarstva0]");
            for (int i = 0; i < dt_lekarstva.Rows.Count; i++) // перебираем данные
            {
                lekarstvaS dataUser = new lekarstvaS() // создаём экземпляр класса
                {
                    codc = dt_lekarstva.Rows[i][0].ToString(),
                    name = dt_lekarstva.Rows[i][1].ToString(),
                    country = dt_lekarstva.Rows[i][2].ToString(),
                    price = dt_lekarstva.Rows[i][3].ToString(),
                    basic = dt_lekarstva.Rows[i][4].ToString(),

                };
                ListApteka.Items.Add(dataUser); // выводим строку в список 
            }
        }

        // КНОПКА КРАСОТА
        private void btnLekarstva_Krasota_Click(object sender, RoutedEventArgs e)
        {
            ListApteka.Items.Clear();
            //ListLekarstva.Visibility = Visibility.Hidden;
            //ListKrasota.Visibility = Visibility.Visible;
            ListApteka.Visibility = Visibility.Visible;
            LoadKrasota();
        }
        void LoadKrasota()
        {
            DataTable dt_krasota = Select("SELECT * FROM [dbo].[table_krasota]");
            for (int i = 0; i < dt_krasota.Rows.Count; i++) // перебираем данные
            {
                lekarstvaS dataUser = new lekarstvaS() // создаём экземпляр класса
                {
                    codc = dt_krasota.Rows[i][0].ToString(),
                    name = dt_krasota.Rows[i][1].ToString(),
                    country = dt_krasota.Rows[i][2].ToString(),
                    price = dt_krasota.Rows[i][3].ToString(),
                    basic = dt_krasota.Rows[i][4].ToString(),

                };
                ListApteka.Items.Add(dataUser); // выводим строку в список 
            }
        }

        // КНОПКА ГИГИЕНА
        private void btnGigiena_Click(object sender, RoutedEventArgs e)
        {
            ListApteka.Items.Clear();
            //ListLekarstva.Visibility = Visibility.Hidden;
            //ListKrasota.Visibility = Visibility.Visible;
            ListApteka.Visibility = Visibility.Visible;
            LoadGigiena();
        }
        void LoadGigiena()
        {
            DataTable dt_gigiena = Select("SELECT * FROM [dbo].[table_gigiena]");
            for (int i = 0; i < dt_gigiena.Rows.Count; i++) // перебираем данные
            {
                lekarstvaS dataUser = new lekarstvaS() // создаём экземпляр класса
                {
                    codc = dt_gigiena.Rows[i][0].ToString(),
                    name = dt_gigiena.Rows[i][1].ToString(),
                    country = dt_gigiena.Rows[i][2].ToString(),
                    price = dt_gigiena.Rows[i][3].ToString(),
                    basic = dt_gigiena.Rows[i][4].ToString(),

                };
                ListApteka.Items.Add(dataUser); // выводим строку в список 
            }
        }

        // КНОПКА ВИТАМИНЫ
        private void btnVitamins_Click(object sender, RoutedEventArgs e)
        {
            ListApteka.Items.Clear();
            //ListLekarstva.Visibility = Visibility.Hidden;
            //ListKrasota.Visibility = Visibility.Visible;
            ListApteka.Visibility = Visibility.Visible;
            LoadVitamins();
        }
        void LoadVitamins()
        {
            DataTable dt_vitamins = Select("SELECT * FROM [dbo].[table_vitamins]");
            for (int i = 0; i < dt_vitamins.Rows.Count; i++) // перебираем данные
            {
                lekarstvaS dataUser = new lekarstvaS() // создаём экземпляр класса
                {
                    codc = dt_vitamins.Rows[i][0].ToString(),
                    name = dt_vitamins.Rows[i][1].ToString(),
                    country = dt_vitamins.Rows[i][2].ToString(),
                    price = dt_vitamins.Rows[i][3].ToString(),
                    basic = dt_vitamins.Rows[i][4].ToString(),

                };
                ListApteka.Items.Add(dataUser); // выводим строку в список 
            }
        }

        // КНОПКА МЕДТЕХНИКА
        private void btnMedtech_Click(object sender, RoutedEventArgs e)
        {
            ListApteka.Items.Clear();
            //ListLekarstva.Visibility = Visibility.Hidden;
            //ListKrasota.Visibility = Visibility.Visible;
            ListApteka.Visibility = Visibility.Visible;
            LoadMedtech();
        }
        void LoadMedtech()
        {
            DataTable dt_medtech = Select("SELECT * FROM [dbo].[table_medtech]");
            for (int i = 0; i < dt_medtech.Rows.Count; i++) // перебираем данные
            {
                lekarstvaS dataUser = new lekarstvaS() // создаём экземпляр класса
                {
                    codc = dt_medtech.Rows[i][0].ToString(),
                    name = dt_medtech.Rows[i][1].ToString(),
                    country = dt_medtech.Rows[i][2].ToString(),
                    price = dt_medtech.Rows[i][3].ToString(),
                    basic = dt_medtech.Rows[i][4].ToString(),

                };
                ListApteka.Items.Add(dataUser); // выводим строку в список 
            }
        }

        // КНОПКА ЗАКРЫТИЯ
        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // КНОПКА НАЗАД
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            loginWin logwin = new loginWin();
            logwin.Show();
            this.Hide();
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rental
{
    public partial class FLogIn : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\79181\source\repos\Rental\DatabaseRental.mdf;Integrated Security=True;Connect Timeout=30");
        public FLogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox2_password.Text;

            // Открываем соединение с базой данных
            connection.Open();

            // Формируем SQL-запрос для получения данных из таблицы Register
            string query = $"SELECT post FROM Register WHERE login='{login}' AND password='{password}'";

            // Создаем команду для выполнения запроса
            SqlCommand command = new SqlCommand(query, connection);

            // Выполняем запрос и получаем результат
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string post = reader.GetString(0);

                // Закрываем соединение с базой данных
                connection.Close();

                // Проверяем значение столбца post и открываем соответствующую форму
                if (post == "Director")
                {
                    this.Hide();
                    var Fdir = new FDir();
                    Fdir.Closed += (s, args) => this.Close();
                    Fdir.Show();
                   
                }
                else if (post == "Cassir")
                {
                    this.Hide();
                    var Fcass = new FCASS();
                    Fcass.Closed += (s, args) => this.Close();
                    Fcass.Show();
                }

            }
            else
            {
                // Закрываем соединение с базой данных
                connection.Close();
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void FLogIn_Load(object sender, EventArgs e)
        {
            textBox2_password.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

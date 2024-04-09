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

namespace Rental
{
    public partial class Disks : Form
    {
        public Disks()
        {
            InitializeComponent();
            resultDataGridView.Visible = false;
        }
     
        private void Disks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseRentalSet.Disks". При необходимости она может быть перемещена или удалена.
            this.disksTableAdapter.Fill(this.databaseRentalSet.Disks);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FLog = new FLogIn();
            FLog.Closed += (s, args) => this.Close();
            FLog.Show();
        }

        private void disksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseRentalSet);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            resultDataGridView.Visible = true;
            disksDataGridView.Visible = false;
            string searchText = searchTextBox.Text.ToLower();
            DataTable searchResult = new DataTable();

            // Создаем колонки в DataTable для хранения результатов поиска
            for (int i = 0; i < disksDataGridView.Columns.Count; i++)
            {
                searchResult.Columns.Add(disksDataGridView.Columns[i].HeaderText, typeof(string));
            }

            // Ищем совпадения в каждой строке и каждой ячейке DataGridView
            foreach (DataGridViewRow row in disksDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        // Копируем совпавшую строку в DataTable searchResult
                        object[] cells = new object[disksDataGridView.Columns.Count];
                        for (int i = 0; i < disksDataGridView.Columns.Count; i++)
                        {
                            cells[i] = row.Cells[i].Value;
                        }
                        searchResult.Rows.Add(cells);
                        break; // Прерываем внутренний цикл после первого совпадения
                    }
                }
            }

            // Выводим результаты поиска в отдельный DataGridView
            resultDataGridView.DataSource = searchResult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FGenres = new Genres();
            FGenres.Closed += (s, args) => this.Close();
            FGenres.Show();
        }
        private void ButRental_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ren = new Orders();
            ren.Closed += (s, args) => this.Close();
            ren.Show();
        }

        private void ButCustomers_Click(object sender, EventArgs e)
        {

            this.Hide();
            var Cus = new Customers();
            Cus.Closed += (s, args) => this.Close();
            Cus.Show();

        }
    }
}

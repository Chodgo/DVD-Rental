using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental
{
    public partial class Customers : Form
    {

        public Customers()
        {
            InitializeComponent();
            resultDataGridView.Visible = false;
        }
        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseRentalSet);

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseRentalSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.databaseRentalSet.Customers);

        }
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            resultDataGridView.Visible = true;
            customersDataGridView.Visible = false;
            string searchText = searchTextBox.Text.ToLower();
            DataTable searchResult = new DataTable();

            // Создаем колонки в DataTable для хранения результатов поиска
            for (int i = 0; i < customersDataGridView.Columns.Count; i++)
            {
                searchResult.Columns.Add(customersDataGridView.Columns[i].HeaderText, typeof(string));
            }

            // Ищем совпадения в каждой строке и каждой ячейке DataGridView
            foreach (DataGridViewRow row in customersDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        // Копируем совпавшую строку в DataTable searchResult
                        object[] cells = new object[customersDataGridView.Columns.Count];
                        for (int i = 0; i < customersDataGridView.Columns.Count; i++)
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

        private void ButDisks_Click(object sender, EventArgs e)
        {
            this.Hide();
            var disks = new Disks();
            disks.Closed += (s, args) => this.Close();
            disks.Show();
        }

        private void ButRental_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ren = new Orders();
            ren.Closed += (s, args) => this.Close();
            ren.Show();
        }
    }
}
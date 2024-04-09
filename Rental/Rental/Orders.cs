using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            resultDataGridView.Visible = false;
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

        private void rentalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rentalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseRentalSet);

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseRentalSet.Rental". При необходимости она может быть перемещена или удалена.
            this.rentalTableAdapter.Fill(this.databaseRentalSet.Rental);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            resultDataGridView.Visible = true;
            rentalDataGridView.Visible = false;
            string searchText = searchTextBox.Text.ToLower();
            DataTable searchResult = new DataTable();

            // Создаем колонки в DataTable для хранения результатов поиска
            for (int i = 0; i < rentalDataGridView.Columns.Count; i++)
            {
                searchResult.Columns.Add(rentalDataGridView.Columns[i].HeaderText, typeof(string));
            }

            // Ищем совпадения в каждой строке и каждой ячейке DataGridView
            foreach (DataGridViewRow row in rentalDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        // Копируем совпавшую строку в DataTable searchResult
                        object[] cells = new object[rentalDataGridView.Columns.Count];
                        for (int i = 0; i < rentalDataGridView.Columns.Count; i++)
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

        private void ButDisks_Click(object sender, EventArgs e)
        {
            this.Hide();
            var disks = new Disks();
            disks.Closed += (s, args) => this.Close();
            disks.Show();
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

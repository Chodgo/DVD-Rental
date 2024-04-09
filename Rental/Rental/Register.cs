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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseRentalSet);
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseRentalSet.Register". При необходимости она может быть перемещена или удалена.
            this.registerTableAdapter.Fill(this.databaseRentalSet.Register);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Fdir = new FDir();
            Fdir.Closed += (s, args) => this.Close();
            Fdir.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

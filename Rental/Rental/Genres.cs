﻿using System;
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
    public partial class Genres : Form
    {
        public Genres()
        {
            InitializeComponent();
        }

        private void genresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.genresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseRentalSet);
        }

        private void Genres_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseRentalSet.Genres". При необходимости она может быть перемещена или удалена.
            this.genresTableAdapter.Fill(this.databaseRentalSet.Genres);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Disk = new Disks();
            Disk.Closed += (s, args) => this.Close();
            Disk.Show();
        }
    }
}

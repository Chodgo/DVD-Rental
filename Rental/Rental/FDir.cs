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
    public partial class FDir : Form
    {
        public FDir()
        {
            InitializeComponent();
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
        private void ButCustomers_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            var Cus = new Customers();
            Cus.Closed += (s, args) => this.Close();
            Cus.Show(); 
        }
        private void butWorkers_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FReg = new Register();
            FReg.Closed += (s, args) => this.Close();
            FReg.Show();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FLog = new FLogIn();
            FLog.Closed += (s, args) => this.Close();
            FLog.Show();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

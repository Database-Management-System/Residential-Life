using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResidentialLife
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Resident_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resident resident = new Resident();
            resident.Show();
        }
        private void GuestLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestLog guestlog = new GuestLog();
            guestlog.Show();
        }

        private void Package_Click(object sender, EventArgs e)
        {
            this.Hide();
            Package package = new Package();
            package.Show();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock stock = new Stock();
            stock.Show();
        }

        private void Equipment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equipment equipment = new Equipment();
            equipment.Show();
        }

        private void Cafe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cafe cafe = new Cafe();
            cafe.Show();
        }
    }
}

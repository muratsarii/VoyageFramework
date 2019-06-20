using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoyageFramework.UI
{
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        private void frmAnaMenu_Load(object sender, EventArgs e)
        {

        }
        private void BusMenuItem_Click(object sender, EventArgs e)
        {
            frmBusInformatin frmbusInformatin = new frmBusInformatin();
            frmbusInformatin.ShowDialog();
        }
        private void DriverMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivers frmdrivers = new frmDrivers();
            frmdrivers.ShowDialog();
        }
        private void HostMenuItem_Click(object sender, EventArgs e)
        {
            frmHosts frmhosts = new frmHosts();
            frmhosts.ShowDialog();
        }
        private void CustomerItem_Click(object sender, EventArgs e)
        {
            frmCustomer frmcustomer = new frmCustomer();
            frmcustomer.ShowDialog();
        }

        private void rOUTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoute frmroute = new frmRoute();
            frmroute.ShowDialog();
        }

        private void sEATINFORMATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeatInformatıon frmseatInformatıon = new frmSeatInformatıon();
            frmseatInformatıon.ShowDialog();
        }

        private void tICKETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTicketSales frmticketSales = new frmTicketSales();
            frmticketSales.ShowDialog();
        }
    }
}

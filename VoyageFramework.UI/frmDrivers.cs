using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoyageFramework.DAL.Entities;

namespace VoyageFramework.UI
{
    public partial class frmDrivers : Form
    {
        public frmDrivers()
        {
            InitializeComponent();
        }

        public event EventHandler DriverHandler;
        private Driver driver;

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {

        }
    }
}

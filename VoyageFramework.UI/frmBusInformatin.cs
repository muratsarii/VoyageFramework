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
    public partial class frmBusInformatin : Form
    {
        public frmBusInformatin()
        {
            InitializeComponent();
        }

        public event EventHandler busInformationHandler;

        private void frmBusInformatin_Load(object sender, EventArgs e)
        {
            grbSeatInformation.Enabled = false;
        }

        private void chkStandart_CheckedChanged(object sender, EventArgs e)
        {
            for (int satir = 0; satir < 10; satir++)
            {
                for (int sutun = 0; sutun < 3; sutun++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(46, 53);
                    btn.Location = new Point(105 * sutun + 15, 105 * satir + 15);
                    btn.Tag = 3 * satir + sutun;
                    //btn.Click += Btn_Click;
                    this.grbSeatInformation.Controls.Add(btn);
                }
            }
        }

        private void chbLuxury_CheckedChanged(object sender, EventArgs e)
        {
            for (int satir = 0; satir < 10; satir++)
            {
                for (int sutun = 0; sutun < 2; sutun++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(53, 53);
                    btn.Location = new Point(105 * sutun + 15, 105 * satir + 15);
                    btn.Tag = 2 * satir + sutun;
                    //btn.Click += Btn_Click;
                    this.grbSeatInformation.Controls.Add(btn);
                }
            }
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

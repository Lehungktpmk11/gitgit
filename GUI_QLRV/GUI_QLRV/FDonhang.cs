using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLRV
{
    public partial class FDonhang : Form
    {
        public FDonhang()
        {
            InitializeComponent();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fsanpham fsp = new Fsanpham();
            this.Hide();
            fsp.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fkhachhang fkh = new Fkhachhang();
            this.Hide();
            fkh.ShowDialog();
            this.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FChitietdonhang fctdh = new FChitietdonhang();
            this.Hide();
            fctdh.ShowDialog();
            this.Show();
        }
    }
}

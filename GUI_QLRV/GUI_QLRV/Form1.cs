using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLRV;
using DTO_QLRV;


namespace GUI_QLRV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BUS_Dangnhap busDn = new BUS_Dangnhap();
        private void btndangnhap_Click(object sender, EventArgs e)
        {

            try
            {
                if (txttk.Text == "" || txtmk.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ tài khoản và mật khẩu !!!");
                }
                else
                {
                    string tk = txttk.Text;
                    string mk = txtmk.Text;
                    DTO_Dangnhap dn = new DTO_Dangnhap(tk, mk);


                    if (busDn.Dangnhap(dn))
                    {
                        FDonhang fdh = new FDonhang();
                        this.Hide();
                        fdh.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu. ");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đăng nhập không thành công.");
            }
        }
    }
}

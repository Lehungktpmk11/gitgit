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
    public partial class Fkhachhang : Form
    {
        public Fkhachhang()
        {
            InitializeComponent();
        }

        private void Fkhachhang_Load(object sender, EventArgs e)
        {
            txtkhid.Enabled = false;
            dgvkhachhang.DataSource = busKh.Getkh();
        }
        BUS_Khachhang busKh = new BUS_Khachhang();
        int vitri;
        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            
            if (vitri >= 0)
            {
                try
                {


                    txtkhid.Text = dgvkhachhang.Rows[vitri].Cells[0].Value.ToString();
                    txthoten.Text = dgvkhachhang.Rows[vitri].Cells[1].Value.ToString();
                    txtsdt.Text = dgvkhachhang.Rows[vitri].Cells[2].Value.ToString();
                    txtdiachi.Text = dgvkhachhang.Rows[vitri].Cells[3].Value.ToString();
                    Boolean gt = Convert.ToBoolean(dgvkhachhang.Rows[vitri].Cells[4].Value);
                    if (gt == true)
                    {
                        rdonam.Checked = true;
                    }
                    else
                    {
                        rdonu.Checked = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vị trí không có dữ liệu");
            }
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txthoten.Text == "" || txtsdt.Text == ""||txtdiachi.Text==""||(rdonam.Checked==false&&rdonu.Checked==false))
            {
                MessageBox.Show(" Nhập đủ thông tin khách hàng!!!");
            }
            else
            {
                Boolean gt;
                if(rdonam.Checked == true)
                {
                    gt = true;
                }
                else
                {
                    gt = false;
                }
                DTO_Khachhang kh = new DTO_Khachhang(busKh.TaoMa(),txthoten.Text,Convert.ToInt32(txtsdt.Text),txtdiachi.Text,gt);
                if (busKh.Them(kh))
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                }


            }
            dgvkhachhang.DataSource = busKh.Getkh();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (vitri >= 0 && txtkhid.Text != "")
            {
                if(txthoten.Text == "" || txtsdt.Text == "" || txtdiachi.Text == "" || (rdonam.Checked == false && rdonu.Checked == false))
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    Boolean gt;
                    if (rdonam.Checked == true)
                    {
                        gt = true;
                    }
                    else
                    {
                        gt = false;
                    }
                    DTO_Khachhang kh = new DTO_Khachhang(txtkhid.Text,txthoten.Text,Convert.ToInt32(txtsdt.Text),txtdiachi.Text,gt);
                    if (busKh.Sua(kh))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo");
                    }
                }
                   
            }
            else
            {
                MessageBox.Show("Chọn vị trí muốn sửa");
            }
            dgvkhachhang.DataSource = busKh.Getkh();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (vitri >= 0 && txtkhid.Text != "")
            {
                string xoa = txtkhid.Text;
                if (busKh.Xoa(xoa))
                {
                    MessageBox.Show("Xóa thành công!!!", "Thông báo");
                }
                else
                {
                    MessageBox.Show(" Xóa không thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Chọn vị trí muốn xóa!!");
            }
            dgvkhachhang.DataSource = busKh.Getkh();
        }

        private void txttimkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                dgvkhachhang.DataSource = busKh.Timkiem(txttimkh.Text);
            }
        }
    }
}

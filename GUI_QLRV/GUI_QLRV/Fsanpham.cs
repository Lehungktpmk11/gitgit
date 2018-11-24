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
    public partial class Fsanpham : Form
    {
        public Fsanpham()
        {
            InitializeComponent();
        }
        BUS_Sanpham busSP = new BUS_Sanpham();
        private void Fsanpham_Load(object sender, EventArgs e)
        {
            txtspid.Enabled = false;
            dgvsanpham.DataSource = busSP.GetSP();
        }
        int vitri;
        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
           if(vitri>=0)
            {
                txtspid.Text = dgvsanpham.Rows[vitri].Cells[0].Value.ToString();
                txttensp.Text = dgvsanpham.Rows[vitri].Cells[1].Value.ToString();
                txtgiasp.Text = dgvsanpham.Rows[vitri].Cells[2].Value.ToString();

            }
            else
            {
                MessageBox.Show("Vị trí không có dữ liệu");
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if(txttensp.Text==""||txtgiasp.Text=="")
            {
                MessageBox.Show(" Nhập đủ thông tin sản phẩm!!!");
            }
            else
            {
                DTO_Sanpham sp = new DTO_Sanpham(busSP.TaoMa(),txttensp.Text,Convert.ToSingle(txtgiasp.Text));
                if(busSP.Them(sp))
                {
                    MessageBox.Show("Thêm thành công!!","Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công","Thông báo");
                }


            }
            dgvsanpham.DataSource = busSP.GetSP();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if(vitri>=0&&txtspid.Text!="")
            {
               if(txttensp.Text==""|| txtgiasp.Text=="")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin sản phẩm");
                }
                else
                {
                    DTO_Sanpham sp = new DTO_Sanpham(txtspid.Text, txttensp.Text, Convert.ToSingle(txtgiasp.Text));
                    if (busSP.Sua(sp))
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
            dgvsanpham.DataSource = busSP.GetSP();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(vitri>=0&& txtspid.Text!="")
            {
                string xoa = txtspid.Text;
                if(busSP.Xoa(xoa))
                {
                    MessageBox.Show("Xóa thành công!!!", "Thông báo");
                }
                else
                {
                    MessageBox.Show(" Xóa không thành công.","Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Chọn vị trí muốn xóa!!");
            }
            dgvsanpham.DataSource = busSP.GetSP();
        }
        
        
        private void txttimsanpham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                dgvsanpham.DataSource = busSP.Timkiem(txttimsanpham.Text);
            }
        }
    }
}

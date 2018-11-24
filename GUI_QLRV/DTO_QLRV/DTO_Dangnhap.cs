using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLRV
{
    public class DTO_Dangnhap
    {
        private string taikhoan;
        private string matkhau;
       

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string Taikhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
        public DTO_Dangnhap()
        {

        }
        public DTO_Dangnhap(string tk,string mk)
        {
            this.Taikhoan = tk;
            this.Matkhau = mk;
        }
    }
}

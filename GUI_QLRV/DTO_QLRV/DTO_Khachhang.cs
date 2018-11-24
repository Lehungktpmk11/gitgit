using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLRV
{
    public class DTO_Khachhang
    {
        private string khid;
        private Int32 soDienThoai;
        private string diaChi;
        private bool gioiTinh;

        public bool GT
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string DC
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public Int32 SDT
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        public string KHID
        {
            get { return khid; }
            set { khid = value; }
        }
        private string hoTen;

        public string HT
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public DTO_Khachhang()
        {

        }
        public DTO_Khachhang(string kh,string ht,Int32 sdt,string dc, bool gt)
        {
            this.KHID = kh;
            this.HT = ht;
            this.SDT = sdt;
            this.DC = dc;
            this.GT = gt;

        }
    }
}

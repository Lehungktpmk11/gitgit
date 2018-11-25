using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLRV
{
    public class DTO_Donhang
    {
       
        private string dHID;
        private string kHID;
        private DateTime ngayMua;
        private Single tongGia;

        public Single Tonggia
        {
            get { return tongGia; }
            set { tongGia = value; }
        }

        public DateTime Ngaymua
        {
            get { return ngayMua; }
            set { ngayMua = value; }
        }

        public string Khid
        {
            get { return kHID; }
            set { kHID = value; }
        }

        public string Dhid
        {
            get { return dHID; }
            set { dHID = value; }
        }

       
        
        public DTO_Donhang()
        {

        }
        public DTO_Donhang( string dhid, string khid, DateTime d, Single g)
        {
           
            this.Dhid = dhid;
            this.Khid = khid;
            this.Ngaymua = d;
            this.Tonggia = g;
        }
    }
}

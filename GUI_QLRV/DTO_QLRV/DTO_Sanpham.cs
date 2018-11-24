using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLRV
{
    public class DTO_Sanpham
    {
        private string spid;
        private string name;
        private Single giaHT;

        public Single GiaHt
        {
            get { return giaHT; }
            set { giaHT = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string SPID
        {
            get { return spid; }
            set { spid = value; }
        }
        public DTO_Sanpham()
        {

        }
        public DTO_Sanpham(string sp, string ten, Single gia)
        {
            this.SPID = sp;
            this.Name = ten;
            this.GiaHt = gia;
        }

    }
}

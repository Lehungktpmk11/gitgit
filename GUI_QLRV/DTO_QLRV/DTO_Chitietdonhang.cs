using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLRV
{
    public class DTO_Chitietdonhang
    {
        private int stt;
        private string dHid;
        private string sPID;
        private Single giaMua;
        private int sl;

        public int SL
        {
            get { return sl; }
            set { sl = value; }
        }

        public Single Giamua
        {
            get { return giaMua; }
            set { giaMua = value; }
        }

        public string Spid
        {
            get { return sPID; }
            set { sPID = value; }
        }

        public string DHID
        {
            get { return dHid; }
            set { dHid = value; }
        }

        public int STT
        {
            get { return stt; }
            set { stt = value; }
        }
        public DTO_Chitietdonhang()
        {

        }
        public DTO_Chitietdonhang(int s, string d, string sp, Single g, int sl)
        {
            this.STT = s;
            this.DHID = d;
            this.Spid = sp;
            this.Giamua = g;
            this.SL = sl;

        }
    }
}

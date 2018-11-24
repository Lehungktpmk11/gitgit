using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QLRV;
using DAO_QLRV;


namespace BUS_QLRV
{
    public class BUS_Dangnhap
    {
        DAO_ThanhVien daotv = new DAO_ThanhVien();
        public bool Dangnhap(DTO_Dangnhap dn)
        {

            DataTable dt = new DataTable();
           string sql = "select * from TKDANGNHAP where taikhoan='" + dn.Taikhoan + "' and matkhau='" + dn.Matkhau + "'";
            dt = daotv.getTable(sql);

            if(dt.Rows.Count>0)
            {
                return true;
            }

            return false;
        }
    }
}

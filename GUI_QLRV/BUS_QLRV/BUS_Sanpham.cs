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
    public class BUS_Sanpham
    {
        DAO_ThanhVien daotv = new DAO_ThanhVien();
        public DataTable GetSP()
        {
           
             DataTable dt = new DataTable();
             string sql = "select * from SANPHAM";
            dt = daotv.getTable(sql);
           
            return dt;
        }
        public bool Them(DTO_Sanpham sp)
        {
            string insert = string.Format("insert into SANPHAM(SPID,tenSanPham,giaHienTai) values ('{0}',N'{1}','{2}')", sp.SPID,sp.Name , sp.GiaHt);

            if(daotv.ExcuteNonQuery(insert))
            {
                return true;
            }
            return false;
        }
        public bool Sua(DTO_Sanpham sp)
        {
            string queryupdate = "update SANPHAM set tenSanPham=N'" + sp.Name + "',giaHienTai='" + sp.GiaHt + "' where SPID ='" + sp.SPID + "' ";
            if (daotv.ExcuteNonQuery(queryupdate))
            {
                return true;
            }

            return false;
        }
        public bool Xoa(string spid)
        {
            string querydelete = "delete from SANPHAM where SPID ='" + spid + "'";

            if(daotv.ExcuteNonQuery(querydelete))
            {
                return true;
            }

            return false;
        }
        public DataTable Timkiem(string ma)
        {
            DataTable dt = new DataTable();
            string query = string.Format(" select * from SANPHAM where SPID like '%{0}%'", ma);
            dt = daotv.getTable(query);

            return dt;
        }
        public string TaoMa()
        {
            
            string sql = "select * from SANPHAM";
            
            DataTable dt = new DataTable();
            dt = daotv.getTable(sql);

            int coso = 0;
            if (dt.Rows.Count == 0)
            {
                coso = 1;
            }
            else
            {
                if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) == 1)
                {
                    coso = 2;
                }
                else
                {
                    if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) != 1)
                    {
                        coso = 1;
                    }
                    else
                    {
                        if (int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) > 1)
                        {
                            coso = 1;

                        }
                        else
                        {
                            int flag = 0;
                            for (int i = 0; i < dt.Rows.Count - 1; i++)
                            {

                                if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(2, 3)) - int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) > 1)
                                {
                                    coso = int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) + 1;
                                    flag = 1;
                                    break;
                                }
                            }
                            if (flag == 0)
                            {
                                coso = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3)) + 1;
                            }
                        }
                    }
                }
            }
            string ma = "";
            if (coso < 10)
                ma = "SP00" + coso;
            else if (coso < 100)
                ma = "SP0" + coso;
            else
                ma = "SP" + coso;

            return ma;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_01
{
    internal class GiangVien_DAO
    {
        public GiangVien_DAO() { }

        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM GiangVien");
            DBconnection db = new DBconnection(sqlStr);
            return db.Load();
        }
        public void thucThi (string sqlStr)
        {
            DBconnection db = new DBconnection(sqlStr);
            db.thucThi();
        }
        public void Them(GiangVien gv)
        {
            string sqlStr = string.Format("INSERT INTO GiangVien(Ten , Diachi, Cmnd, NgaySinh, Email, Id, Sdt, GioiTinh) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", 
                gv.Ten, gv.DiaChi, gv.Cmnd, gv.NgaySinh, gv.Email, gv.Id, gv.Sdt, gv.GioiTinh);
            thucThi(sqlStr);
        }
        public void Xoa(GiangVien gv)
        {
            string sqlStr = string.Format("DELETE FROM GiangVien WHERE Cmnd = ('{0}')", gv.Cmnd);
            thucThi(sqlStr);
        }
        public void Sua(GiangVien gv)
        {
            string sqlStr = string.Format("UPDATE GiangVien SET Ten = '{0}', DiaChi ='{1}', Cmnd = '{2}', NgaySinh = '{3}', Email = '{4}', Id = '{5}', Sdt = '{6}', GioiTinh = '{7}' WHERE Cmnd = {2}", 
                gv.Ten, gv.DiaChi, gv.Cmnd, gv.NgaySinh, gv.Email, gv.Id, gv.Sdt, gv.GioiTinh);
            thucThi(sqlStr);
        }
    }
}

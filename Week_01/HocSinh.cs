using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_01
{
    internal class HocSinh : KeThua_DoiTuong
    {

        public HocSinh(string ten, string diaChi, string cmnd, string ngaySinh, string email, string id, string sdt, string gioiTinh) 
            : base(ten, diaChi, cmnd, ngaySinh, email, id, sdt, gioiTinh)
        {
            
        }
        public HocSinh(string cmnd) : base(cmnd)
        {

        }

    }
}

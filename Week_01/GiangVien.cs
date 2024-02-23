using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_01
{
    internal class GiangVien : KeThua_DoiTuong
    {
        public GiangVien(string ten, string diaChi, string cmnd, string ngaySinh, string email, string id, string sdt, string gioiTinh) 
            : base(ten, diaChi, cmnd, ngaySinh, email, id, sdt, gioiTinh)
        {

        }
        public GiangVien(string cmnd) : base(cmnd)
        {

        }
    }
}

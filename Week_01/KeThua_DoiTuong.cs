using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_01
{
    internal class KeThua_DoiTuong
    {
        private string ten;
        private string diaChi;
        private string cmnd;
        private string ngaySinh;
        private string email;
        private string id;
        private string sdt;
        private string gioiTinh;
        public KeThua_DoiTuong(string ten, string diaChi, string cmnd, string ngaySinh, string email, string id, string sdt, string gioiTinh)
        {
            Ten = ten;
            DiaChi = diaChi;
            Cmnd = cmnd;
            NgaySinh = ngaySinh;
            Email = email;
            Id = id;
            Sdt = sdt;
            GioiTinh = gioiTinh;
        }
        public KeThua_DoiTuong(string cmnd)
        {
            Cmnd = cmnd;
        }
        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Email { get => email; set => email = value; }
        public string Id { get => id; set => id = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}

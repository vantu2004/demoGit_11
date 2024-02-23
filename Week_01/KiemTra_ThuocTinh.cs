using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Week_01
{
    internal class KiemTra_ThuocTinh
    {
        private string ngaySinh;
        private string email;
        private string id;
        private string sdt;
        private string gioiTinh;

        public KiemTra_ThuocTinh(string ngaySinh, string email, string id, string sdt, string gioiTinh)
        {
            this.ngaySinh = ngaySinh;
            this.email = email;
            this.sdt = sdt;
            this.id = id;
            this.gioiTinh = gioiTinh;
        }
 
        public string email_null()
        {
            if (string.IsNullOrEmpty(email))
                return "null";
            return dinhDangEmail();
        }
        public string id_null()
        {
            if (string.IsNullOrEmpty(id))
                return "null";
            return id;
        }
        public string sdt_null()
        {
            if (string.IsNullOrEmpty(sdt))
                return "null";
            return dinhDangSdt();
        }
        public string gioiTinh_null()
        {
            if (string.IsNullOrEmpty(gioiTinh))
                return "null";
            return gioiTinh;
        }
        public string dinhDangEmail()
        {
            // Biểu thức chính quy cho định dạng email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Kiểm tra sự phù hợp của email với biểu thức chính quy
            if (Regex.IsMatch(email, pattern))
                return email;
            else
                return "false";
        }
        public string dinhDangSdt()
        {
            //  biểu thức chính quy định dạng sdt XXX-XXXX-XXX
            string pattern = @"^\d{3}-\d{4}-\d{3}$";

            // Kiểm tra sự phù hợp của số điện thoại với biểu thức chính quy
            if (Regex.IsMatch(sdt, pattern))
                return sdt;
            else
                return "false";
        }
        public string dinhDangNgaySinh()
        {
            TimeSpan ts = DateTime.Now - Convert.ToDateTime(ngaySinh);
            if ((ts.TotalDays / 365.25) >= 18) // So sánh với 18 năm (hoặc một giá trị cụ thể khác)
                return ngaySinh;
            return "false";
        }
    }

}
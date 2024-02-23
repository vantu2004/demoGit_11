using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Week_01
{
    public partial class FGiangVien : Form
    {
        GiangVien_DAO gvDao = new GiangVien_DAO();
        public FGiangVien()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = gvDao.Load();
            dgvwGiangVien.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KiemTra_ThuocTinh null_notNull = new KiemTra_ThuocTinh(dtpkrNgaySinh.Value.ToShortDateString(), tbxEmail.Text, tbxId.Text, tbxSdt.Text, tbxGioiTinh.Text);
            GiangVien gv = new GiangVien(tbxHoVaTen.Text, tbxDiaChi.Text, tbxCMND.Text, null_notNull.dinhDangNgaySinh(),
                null_notNull.email_null(), null_notNull.id_null(), null_notNull.sdt_null(), null_notNull.gioiTinh_null());
            gvDao.Them(gv);
            Form2_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(tbxCMND.Text);
            gvDao.Xoa(gv);
            Form2_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KiemTra_ThuocTinh null_notNull = new KiemTra_ThuocTinh(dtpkrNgaySinh.Value.ToShortDateString(), tbxEmail.Text, tbxId.Text, tbxSdt.Text, tbxGioiTinh.Text);
            GiangVien gv = new GiangVien(tbxHoVaTen.Text, tbxDiaChi.Text, tbxCMND.Text, null_notNull.dinhDangNgaySinh(),
                null_notNull.email_null(), null_notNull.id_null(), null_notNull.sdt_null(), null_notNull.gioiTinh_null());
            gvDao.Sua(gv);
            Form2_Load(sender, e);
        }

        private void dgvwGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvwGiangVien.Rows[rowIndex];

                tbxHoVaTen.Text = row.Cells[0].Value.ToString();
                tbxDiaChi.Text = row.Cells[1].Value.ToString();
                tbxCMND.Text = row.Cells[2].Value.ToString();
                dtpkrNgaySinh.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                tbxEmail.Text = row.Cells[4].Value.ToString();
                tbxId.Text = row.Cells[5].Value.ToString();
                tbxSdt.Text = row.Cells[6].Value.ToString();
                tbxGioiTinh.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}

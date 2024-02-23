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
            ucThongTin.dgvw.DataSource = dt;

            // đây là form giangVien nên ẩn nút GiangVien
            ucThongTin.btnGiangVien.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KiemTra_ThuocTinh null_notNull = new KiemTra_ThuocTinh(ucThongTin.dtpkrNgaySinh.Value.ToShortDateString(), ucThongTin.tbxEmail.Text, ucThongTin.tbxId.Text, ucThongTin.tbxSdt.Text, ucThongTin.tbxGioiTinh.Text);
            GiangVien gv = new GiangVien(ucThongTin.tbxHoVaTen.Text, ucThongTin.tbxDiaChi.Text, ucThongTin.tbxCMND.Text, null_notNull.dinhDangNgaySinh(),
                null_notNull.email_null(), null_notNull.id_null(), null_notNull.sdt_null(), null_notNull.gioiTinh_null());
            gvDao.Them(gv);
            Form2_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(ucThongTin.tbxId.Text);
            gvDao.Xoa(gv);
            Form2_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            KiemTra_ThuocTinh null_notNull = new KiemTra_ThuocTinh(ucThongTin.dtpkrNgaySinh.Value.ToShortDateString(), ucThongTin.tbxEmail.Text, ucThongTin.tbxId.Text, ucThongTin.tbxSdt.Text, ucThongTin.tbxGioiTinh.Text);
            GiangVien gv = new GiangVien(ucThongTin.tbxHoVaTen.Text, ucThongTin.tbxDiaChi.Text, ucThongTin.tbxCMND.Text, null_notNull.dinhDangNgaySinh(),
                null_notNull.email_null(), null_notNull.id_null(), null_notNull.sdt_null(), null_notNull.gioiTinh_null());
            gvDao.Sua(gv);
            Form2_Load(sender, e);
        }

        private void dgvwGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = ucThongTin.dgvw.Rows[rowIndex];

                ucThongTin.tbxHoVaTen.Text = row.Cells[0].Value.ToString();
                ucThongTin.tbxDiaChi.Text = row.Cells[1].Value.ToString();
                ucThongTin.tbxCMND.Text = row.Cells[2].Value.ToString();
                ucThongTin.dtpkrNgaySinh.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                ucThongTin.tbxEmail.Text = row.Cells[4].Value.ToString();
                ucThongTin.tbxId.Text = row.Cells[5].Value.ToString();
                ucThongTin.tbxSdt.Text = row.Cells[6].Value.ToString();
                ucThongTin.tbxGioiTinh.Text = row.Cells[7].Value.ToString();
            }
        }

        private void ucThongTin1_Load(object sender, EventArgs e)
        {
            ucThongTin.btnThem.Click += (btnThem_Click);
            ucThongTin.btnSua.Click += (btnSua_Click);
            ucThongTin.btnXoa.Click += (btnXoa_Click);
        }
    }
}

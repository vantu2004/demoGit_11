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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Week_01
{
    public partial class FHocSinh : Form
    {
        HocSinh_DAO hsDao = new HocSinh_DAO();
        public FHocSinh()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {            
            DataTable dt = hsDao.Load();
            ucThongTin.dgvw.DataSource = dt;
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            KiemTra_ThuocTinh null_notNull = new KiemTra_ThuocTinh(ucThongTin.dtpkrNgaySinh.Value.ToShortDateString(), ucThongTin.tbxEmail.Text, ucThongTin.tbxId.Text, ucThongTin.tbxSdt.Text, ucThongTin.tbxGioiTinh.Text);
            HocSinh hs = new HocSinh(ucThongTin.tbxHoVaTen.Text, ucThongTin.tbxDiaChi.Text, ucThongTin.tbxCMND.Text, null_notNull.dinhDangNgaySinh(),
                null_notNull.email_null(), null_notNull.id_null(), null_notNull.sdt_null(), null_notNull.gioiTinh_null());
            hsDao.Them(hs);
            Form1_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(ucThongTin.tbxId.Text);
            hsDao.Xoa(hs);
            Form1_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KiemTra_ThuocTinh null_notNull = new KiemTra_ThuocTinh(ucThongTin.dtpkrNgaySinh.Value.ToShortDateString(), ucThongTin.tbxEmail.Text, ucThongTin.tbxId.Text, ucThongTin.tbxSdt.Text, ucThongTin.tbxGioiTinh.Text);
            HocSinh hs = new HocSinh(ucThongTin.tbxHoVaTen.Text, ucThongTin.tbxDiaChi.Text, ucThongTin.tbxCMND.Text, null_notNull.dinhDangNgaySinh(),
                null_notNull.email_null(), null_notNull.id_null(), null_notNull.sdt_null(), null_notNull.gioiTinh_null());
            hsDao.Sua(hs);
            Form1_Load(sender, e);
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            FGiangVien f2 = new FGiangVien();
            f2.ShowDialog();
        }

        private void dgvwHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void ucThongTin_Load(object sender, EventArgs e)
        {
            ucThongTin.btnThem.Click += (btnThem_Click);
            ucThongTin.btnSua.Click += (btnSua_Click);
            ucThongTin.btnXoa.Click += (btnXoa_Click);
            ucThongTin.dgvw.CellClick += (dgvwHocSinh_CellClick);
            ucThongTin.btnGiangVien.Click += (btnGiangVien_Click);
        }
    }
}

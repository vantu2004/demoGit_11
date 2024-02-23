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
            dgvwHocSinh.DataSource = dt;
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            KiemTra_ThuocTinh null_notNull = new KiemTra_ThuocTinh(dtpkrNgaySinh.Value.ToShortDateString(), tbxEmail.Text, tbxId.Text, tbxSdt.Text, tbxGioiTinh.Text);
            HocSinh hs = new HocSinh(tbxHoVaTen.Text, tbxDiaChi.Text, tbxCMND.Text, null_notNull.dinhDangNgaySinh(),
                null_notNull.email_null(), null_notNull.id_null(), null_notNull.sdt_null(), null_notNull.gioiTinh_null());
            hsDao.Them(hs);
            Form1_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(tbxCMND.Text);
            hsDao.Xoa(hs);
            Form1_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KiemTra_ThuocTinh null_notNull = new KiemTra_ThuocTinh(dtpkrNgaySinh.Value.ToShortDateString(), tbxEmail.Text, tbxId.Text, tbxSdt.Text, tbxGioiTinh.Text);
            HocSinh hs = new HocSinh(tbxHoVaTen.Text, tbxDiaChi.Text, tbxCMND.Text, null_notNull.dinhDangNgaySinh(),
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
                DataGridViewRow row = dgvwHocSinh.Rows[rowIndex];

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

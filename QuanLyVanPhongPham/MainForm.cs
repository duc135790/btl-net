using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyVanPhongPham
{
    public partial class MainForm : Form
    {
        private int _idSanPham = 0;
        private int _idDanhMuc = 0;
        private SanPhamManager spManager = new SanPhamManager();
        private DanhMucManager dmManager = new DanhMucManager();
        private GiaoDichManager gdManager = new GiaoDichManager();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            HienThiPanel(panelSanPham);
            LoadDanhSachSanPham();
            LoadComboDanhMuc();
            LoadDanhSachDanhMuc();
        }
        private void menuSanPham_Click(object sender, EventArgs e)
        {
            HienThiPanel(panelSanPham);
            LoadDanhSachSanPham();
            LoadComboDanhMuc();
        }
        private void menuDanhMuc_Click(object sender, EventArgs e)
        {
            HienThiPanel(panelDanhMuc);
            LoadDanhSachDanhMuc();
        }
        private void menuGiaoDich_Click(object sender, EventArgs e)
        {
            HienThiPanel(panelGiaoDich);
            LoadDanhSachGiaoDich();
            LoadComboSanPhamGD();
        }
        private void menuThongKe_Click(object sender, EventArgs e)
        {
            HienThiPanel(panelThongKe);
            LoadThongKe();
        }
        private void HienThiPanel(Panel panel)
        {
            panelSanPham.Visible = false;
            panelDanhMuc.Visible = false;
            panelGiaoDich.Visible = false;
            panelThongKe.Visible = false;
            panel.Visible = true;
        }
        private void LoadDanhSachSanPham()
        {
            dgvSanPham.DataSource = spManager.GetDanhSach();
        }
        private void LoadComboDanhMuc()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.GetConnStr()))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "select MaDanhMuc, TenDanhMuc from DanhMuc order by MaDanhMuc desc", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                List<DanhMuc> listDM = new List<DanhMuc>();
                int i = 0;
                int intSelectedIndex = 0;

                foreach (DataRow row in dt.Rows)
                {
                    listDM.Add(new DanhMuc(
                        Convert.ToInt32(row["MaDanhMuc"]),
                        row["TenDanhMuc"].ToString()));
                    if (_idDanhMuc == Convert.ToInt32(row["MaDanhMuc"]))
                        intSelectedIndex = i;
                    else
                        i++;
                }

                cboDanhMuc.DataSource = listDM;
                cboDanhMuc.SelectedIndex = intSelectedIndex;
            }
        }
        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.Rows.Count > 0)
            {
                _idSanPham = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["MaSanPham"].Value);

                using (SqlConnection conn = new SqlConnection(DatabaseConnection.GetConnStr()))
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "select MaSanPham, MaDanhMuc, TenSanPham, GiaBan, SoLuong " +
                        "from SanPham where MaSanPham=" + _idSanPham, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        txtTenSP.Text = dt.Rows[0]["TenSanPham"].ToString();
                        txtGiaBan.Text = dt.Rows[0]["GiaBan"].ToString();
                        txtSoLuong.Text = dt.Rows[0]["SoLuong"].ToString();
                        _idDanhMuc = Convert.ToInt32(dt.Rows[0]["MaDanhMuc"]);
                        LoadComboDanhMuc();
                    }
                }
            }
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (!KiemTraSanPham()) return;

            var item = cboDanhMuc.SelectedItem as DanhMuc;
            spManager.Them(txtTenSP.Text, int.Parse(txtGiaBan.Text),
                           int.Parse(txtSoLuong.Text), item.MaDanhMuc);
            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiSanPham();
        }
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (_idSanPham == 0)
            { MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!"); return; }
            if (!KiemTraSanPham()) return;
            var item = cboDanhMuc.SelectedItem as DanhMuc;
            spManager.Sua(_idSanPham, txtTenSP.Text, int.Parse(txtGiaBan.Text),
                          int.Parse(txtSoLuong.Text), item.MaDanhMuc);
            MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiSanPham();
        }
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (_idSanPham == 0)
            { MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!"); return; }
            var confirm = MessageBox.Show("Bạn có chắc chắn xóa sản phẩm này không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                spManager.Xoa(_idSanPham);
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiSanPham();
            }
        }
        private void btnLamMoiSP_Click(object sender, EventArgs e)
        {
            LamMoiSanPham();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenSP = txtTimKiemTen.Text.Trim();
            string tenDM = txtTimKiemDanhMuc.Text.Trim();
            dgvSanPham.DataSource = spManager.TimKiem(tenSP, tenDM);
        }
        private void LamMoiSanPham()
        {
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            txtSoLuong.Text = "";
            txtTimKiemTen.Text = "";
            txtTimKiemDanhMuc.Text = "";
            _idSanPham = 0;
            _idDanhMuc = 0;
            LoadDanhSachSanPham();
            LoadComboDanhMuc();
        }
        private bool KiemTraSanPham()
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            { MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (!int.TryParse(txtGiaBan.Text, out _) || int.Parse(txtGiaBan.Text) < 0)
            { MessageBox.Show("Giá bán phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (!int.TryParse(txtSoLuong.Text, out _) || int.Parse(txtSoLuong.Text) < 0)
            { MessageBox.Show("Số lượng phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }
        private void LoadDanhSachDanhMuc()
        {
            dgvDanhMuc.DataSource = dmManager.GetDanhSach();
        }
        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhMuc.Rows.Count > 0)
            {
                _idDanhMuc = Convert.ToInt32(dgvDanhMuc.CurrentRow.Cells["MaDanhMuc"].Value);
                txtTenDM.Text = dgvDanhMuc.CurrentRow.Cells["TenDanhMuc"].Value.ToString();
            }
        }
        private void btnThemDM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDM.Text))
            { MessageBox.Show("Vui lòng nhập tên danh mục!"); return; }
            dmManager.Them(txtTenDM.Text);
            MessageBox.Show("Thêm danh mục thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiDanhMuc();
        }
        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            if (_idDanhMuc == 0) { MessageBox.Show("Vui lòng chọn danh mục cần sửa!"); return; }
            if (string.IsNullOrWhiteSpace(txtTenDM.Text))
            { MessageBox.Show("Vui lòng nhập tên danh mục!"); return; }

            dmManager.Sua(_idDanhMuc, txtTenDM.Text);
            MessageBox.Show("Sửa danh mục thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiDanhMuc();
        }
        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            if (_idDanhMuc == 0) { MessageBox.Show("Vui lòng chọn danh mục cần xóa!"); return; }
            var confirm = MessageBox.Show("Xóa danh mục này sẽ ảnh hưởng đến sản phẩm liên quan. Tiếp tục?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                dmManager.Xoa(_idDanhMuc);
                MessageBox.Show("Xóa danh mục thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiDanhMuc();
            }
        }
        private void btnLamMoiDM_Click(object sender, EventArgs e)
        {
            LamMoiDanhMuc();
        }
        private void LamMoiDanhMuc()
        {
            txtTenDM.Text = "";
            _idDanhMuc = 0;
            LoadDanhSachDanhMuc();
        }
        private void LoadDanhSachGiaoDich()
        {
            dgvGiaoDich.DataSource = gdManager.GetDanhSach();
        }
        private void LoadComboSanPhamGD()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.GetConnStr()))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "select MaSanPham, TenSanPham, GiaBan from SanPham order by TenSanPham", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                List<SanPham> listSP = new List<SanPham>();
                foreach (DataRow row in dt.Rows)
                {
                    listSP.Add(new SanPham(
                        Convert.ToInt32(row["MaSanPham"]),
                        row["TenSanPham"].ToString(),
                        Convert.ToInt32(row["GiaBan"]),
                        0, 0));
                }
                cboSanPhamGD.DataSource = listSP;
            }
        }
        private void cboSanPhamGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }
        private void txtSoLuongBan_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }
        private void TinhTongTien()
        {
            var item = cboSanPhamGD.SelectedItem as SanPham;
            if (item == null) return;
            int sl;
            if (int.TryParse(txtSoLuongBan.Text, out sl))
                txtTongTien.Text = (item.GiaBan * sl).ToString();
        }
        private void btnTaoGiaoDich_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNguoiThucHien.Text))
            { MessageBox.Show("Vui lòng nhập tên người thực hiện!"); return; }
            if (!int.TryParse(txtSoLuongBan.Text, out _) || int.Parse(txtSoLuongBan.Text) <= 0)
            { MessageBox.Show("Số lượng bán phải là số nguyên dương!"); return; }

            var item = cboSanPhamGD.SelectedItem as SanPham;
            int soLuong = int.Parse(txtSoLuongBan.Text);
            int tongTien = int.Parse(txtTongTien.Text);
            var confirm = MessageBox.Show(
                $"Xác nhận bán {soLuong} '{item.TenSanPham}' với tổng tiền {tongTien:N0} đ?",
                "Xác nhận giao dịch", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                gdManager.Them(txtNguoiThucHien.Text, item.TenSanPham, soLuong, tongTien);
                MessageBox.Show("Tạo giao dịch thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNguoiThucHien.Text = "";
                txtSoLuongBan.Text = "";
                txtTongTien.Text = "";
                LoadDanhSachGiaoDich();
            }
        }
        private void LoadThongKe()
        {
            dgvThongKe.DataSource = gdManager.ThongKeDoanhThu();
            DataTable dt = DatabaseConnection.ExecuteQuery(
                "select ISNULL(SUM(TongTien), 0) as TongDoanhThu from GiaoDich");
            if (dt.Rows.Count > 0)
                lblTongDoanhThu.Text = "Tổng doanh thu: " +
                    string.Format("{0:N0}", dt.Rows[0]["TongDoanhThu"]) + " đồng";
            DataTable dt2 = DatabaseConnection.ExecuteQuery(
                "select COUNT(*) as TongSP from SanPham");
            if (dt2.Rows.Count > 0)
                lblTongSanPham.Text = "Tổng số sản phẩm: " + dt2.Rows[0]["TongSP"].ToString();
            DataTable dt3 = DatabaseConnection.ExecuteQuery(
                "select COUNT(*) as TongGD from GiaoDich");
            if (dt3.Rows.Count > 0)
                lblTongGiaoDich.Text = "Tổng số giao dịch: " + dt3.Rows[0]["TongGD"].ToString();
        }
        private void btnLamMoiTK_Click(object sender, EventArgs e)
        {
            LoadThongKe();
        }
        private void grpTimKiem_Enter(object sender, EventArgs e)
        {
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
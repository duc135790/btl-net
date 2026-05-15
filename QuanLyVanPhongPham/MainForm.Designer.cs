namespace QuanLyVanPhongPham
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGiaoDich = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSanPham = new System.Windows.Forms.Panel();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTimKiemTen = new System.Windows.Forms.Label();
            this.txtTimKiemTen = new System.Windows.Forms.TextBox();
            this.lblTimKiemDanhMuc = new System.Windows.Forms.Label();
            this.txtTimKiemDanhMuc = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpInputSP = new System.Windows.Forms.GroupBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnLamMoiSP = new System.Windows.Forms.Button();
            this.grpDanhSachSP = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.panelDanhMuc = new System.Windows.Forms.Panel();
            this.grpInputDM = new System.Windows.Forms.GroupBox();
            this.lblTenDM = new System.Windows.Forms.Label();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnLamMoiDM = new System.Windows.Forms.Button();
            this.grpDanhSachDM = new System.Windows.Forms.GroupBox();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.panelGiaoDich = new System.Windows.Forms.Panel();
            this.grpInputGD = new System.Windows.Forms.GroupBox();
            this.lblNguoiThucHien = new System.Windows.Forms.Label();
            this.txtNguoiThucHien = new System.Windows.Forms.TextBox();
            this.lblSanPhamGD = new System.Windows.Forms.Label();
            this.cboSanPhamGD = new System.Windows.Forms.ComboBox();
            this.lblSoLuongBan = new System.Windows.Forms.Label();
            this.txtSoLuongBan = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnTaoGiaoDich = new System.Windows.Forms.Button();
            this.grpDanhSachGD = new System.Windows.Forms.GroupBox();
            this.dgvGiaoDich = new System.Windows.Forms.DataGridView();
            this.panelThongKe = new System.Windows.Forms.Panel();
            this.grpSoLieu = new System.Windows.Forms.GroupBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTongSanPham = new System.Windows.Forms.Label();
            this.lblTongGiaoDich = new System.Windows.Forms.Label();
            this.btnLamMoiTK = new System.Windows.Forms.Button();
            this.grpBangThongKe = new System.Windows.Forms.GroupBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panelSanPham.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.grpInputSP.SuspendLayout();
            this.grpDanhSachSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panelDanhMuc.SuspendLayout();
            this.grpInputDM.SuspendLayout();
            this.grpDanhSachDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.panelGiaoDich.SuspendLayout();
            this.grpInputGD.SuspendLayout();
            this.grpDanhSachGD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).BeginInit();
            this.panelThongKe.SuspendLayout();
            this.grpSoLieu.SuspendLayout();
            this.grpBangThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSanPham,
            this.menuDanhMuc,
            this.menuGiaoDich,
            this.menuThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1012, 33);
            this.menuStrip1.TabIndex = 0;
            // 
            // menuSanPham
            // 
            this.menuSanPham.ForeColor = System.Drawing.Color.White;
            this.menuSanPham.Name = "menuSanPham";
            this.menuSanPham.Size = new System.Drawing.Size(173, 29);
            this.menuSanPham.Text = "Quản lý Sản Phẩm";
            this.menuSanPham.Click += new System.EventHandler(this.menuSanPham_Click);
            // 
            // menuDanhMuc
            // 
            this.menuDanhMuc.ForeColor = System.Drawing.Color.White;
            this.menuDanhMuc.Name = "menuDanhMuc";
            this.menuDanhMuc.Size = new System.Drawing.Size(175, 29);
            this.menuDanhMuc.Text = "Quản lý Danh Mục";
            this.menuDanhMuc.Click += new System.EventHandler(this.menuDanhMuc_Click);
            // 
            // menuGiaoDich
            // 
            this.menuGiaoDich.ForeColor = System.Drawing.Color.White;
            this.menuGiaoDich.Name = "menuGiaoDich";
            this.menuGiaoDich.Size = new System.Drawing.Size(186, 29);
            this.menuGiaoDich.Text = "Giao Dịch Bán Hàng";
            this.menuGiaoDich.Click += new System.EventHandler(this.menuGiaoDich_Click);
            // 
            // menuThongKe
            // 
            this.menuThongKe.ForeColor = System.Drawing.Color.White;
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Size = new System.Drawing.Size(103, 29);
            this.menuThongKe.Text = "Thống Kê";
            this.menuThongKe.Click += new System.EventHandler(this.menuThongKe_Click);
            // 
            // panelSanPham
            // 
            this.panelSanPham.Controls.Add(this.grpTimKiem);
            this.panelSanPham.Controls.Add(this.grpInputSP);
            this.panelSanPham.Controls.Add(this.grpDanhSachSP);
            this.panelSanPham.Location = new System.Drawing.Point(0, 35);
            this.panelSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSanPham.Name = "panelSanPham";
            this.panelSanPham.Size = new System.Drawing.Size(1012, 700);
            this.panelSanPham.TabIndex = 1;
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.lblTimKiemTen);
            this.grpTimKiem.Controls.Add(this.txtTimKiemTen);
            this.grpTimKiem.Controls.Add(this.lblTimKiemDanhMuc);
            this.grpTimKiem.Controls.Add(this.txtTimKiemDanhMuc);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Location = new System.Drawing.Point(11, 6);
            this.grpTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTimKiem.Size = new System.Drawing.Size(979, 69);
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm nâng cao";
            // 
            // lblTimKiemTen
            // 
            this.lblTimKiemTen.Location = new System.Drawing.Point(11, 28);
            this.lblTimKiemTen.Name = "lblTimKiemTen";
            this.lblTimKiemTen.Size = new System.Drawing.Size(101, 25);
            this.lblTimKiemTen.TabIndex = 0;
            this.lblTimKiemTen.Text = "Tên sản phẩm:";
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.Location = new System.Drawing.Point(118, 24);
            this.txtTimKiemTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(224, 26);
            this.txtTimKiemTen.TabIndex = 1;
            // 
            // lblTimKiemDanhMuc
            // 
            this.lblTimKiemDanhMuc.Location = new System.Drawing.Point(360, 28);
            this.lblTimKiemDanhMuc.Name = "lblTimKiemDanhMuc";
            this.lblTimKiemDanhMuc.Size = new System.Drawing.Size(73, 25);
            this.lblTimKiemDanhMuc.TabIndex = 2;
            this.lblTimKiemDanhMuc.Text = "Danh mục:";
            // 
            // txtTimKiemDanhMuc
            // 
            this.txtTimKiemDanhMuc.Location = new System.Drawing.Point(439, 24);
            this.txtTimKiemDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemDanhMuc.Name = "txtTimKiemDanhMuc";
            this.txtTimKiemDanhMuc.Size = new System.Drawing.Size(224, 26);
            this.txtTimKiemDanhMuc.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(681, 21);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 31);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // grpInputSP
            // 
            this.grpInputSP.Controls.Add(this.lblDanhMuc);
            this.grpInputSP.Controls.Add(this.cboDanhMuc);
            this.grpInputSP.Controls.Add(this.lblTenSP);
            this.grpInputSP.Controls.Add(this.txtTenSP);
            this.grpInputSP.Controls.Add(this.lblGiaBan);
            this.grpInputSP.Controls.Add(this.txtGiaBan);
            this.grpInputSP.Controls.Add(this.lblSoLuong);
            this.grpInputSP.Controls.Add(this.txtSoLuong);
            this.grpInputSP.Controls.Add(this.btnThemSP);
            this.grpInputSP.Controls.Add(this.btnSuaSP);
            this.grpInputSP.Controls.Add(this.btnXoaSP);
            this.grpInputSP.Controls.Add(this.btnLamMoiSP);
            this.grpInputSP.Location = new System.Drawing.Point(11, 85);
            this.grpInputSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInputSP.Name = "grpInputSP";
            this.grpInputSP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInputSP.Size = new System.Drawing.Size(979, 169);
            this.grpInputSP.TabIndex = 1;
            this.grpInputSP.TabStop = false;
            this.grpInputSP.Text = "Thông tin Sản phẩm";
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.Location = new System.Drawing.Point(11, 35);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(90, 25);
            this.lblDanhMuc.TabIndex = 0;
            this.lblDanhMuc.Text = "Danh mục:";
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.Location = new System.Drawing.Point(107, 31);
            this.cboDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(224, 28);
            this.cboDanhMuc.TabIndex = 1;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Location = new System.Drawing.Point(349, 35);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(101, 25);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(439, 32);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(494, 26);
            this.txtTenSP.TabIndex = 3;
            this.txtTenSP.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Location = new System.Drawing.Point(11, 75);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(90, 25);
            this.lblGiaBan.TabIndex = 4;
            this.lblGiaBan.Text = "Giá bán (đ):";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(107, 71);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(224, 26);
            this.txtGiaBan.TabIndex = 5;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(349, 75);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(101, 25);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(439, 67);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(224, 26);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.LightGreen;
            this.btnThemSP.Location = new System.Drawing.Point(107, 119);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(90, 35);
            this.btnThemSP.TabIndex = 8;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.BackColor = System.Drawing.Color.LightBlue;
            this.btnSuaSP.Location = new System.Drawing.Point(214, 119);
            this.btnSuaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(90, 35);
            this.btnSuaSP.TabIndex = 9;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = false;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoaSP.Location = new System.Drawing.Point(321, 119);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(90, 35);
            this.btnXoaSP.TabIndex = 10;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnLamMoiSP
            // 
            this.btnLamMoiSP.Location = new System.Drawing.Point(428, 119);
            this.btnLamMoiSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoiSP.Name = "btnLamMoiSP";
            this.btnLamMoiSP.Size = new System.Drawing.Size(90, 35);
            this.btnLamMoiSP.TabIndex = 11;
            this.btnLamMoiSP.Text = "Làm mới";
            this.btnLamMoiSP.Click += new System.EventHandler(this.btnLamMoiSP_Click);
            // 
            // grpDanhSachSP
            // 
            this.grpDanhSachSP.Controls.Add(this.dgvSanPham);
            this.grpDanhSachSP.Location = new System.Drawing.Point(11, 262);
            this.grpDanhSachSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDanhSachSP.Name = "grpDanhSachSP";
            this.grpDanhSachSP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDanhSachSP.Size = new System.Drawing.Size(979, 412);
            this.grpDanhSachSP.TabIndex = 2;
            this.grpDanhSachSP.TabStop = false;
            this.grpDanhSachSP.Text = "Danh sách Sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeight = 34;
            this.dgvSanPham.Location = new System.Drawing.Point(14, 25);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(951, 369);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.Controls.Add(this.grpInputDM);
            this.panelDanhMuc.Controls.Add(this.grpDanhSachDM);
            this.panelDanhMuc.Location = new System.Drawing.Point(0, 35);
            this.panelDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(1012, 700);
            this.panelDanhMuc.TabIndex = 2;
            this.panelDanhMuc.Visible = false;
            // 
            // grpInputDM
            // 
            this.grpInputDM.Controls.Add(this.lblTenDM);
            this.grpInputDM.Controls.Add(this.txtTenDM);
            this.grpInputDM.Controls.Add(this.btnThemDM);
            this.grpInputDM.Controls.Add(this.btnSuaDM);
            this.grpInputDM.Controls.Add(this.btnXoaDM);
            this.grpInputDM.Controls.Add(this.btnLamMoiDM);
            this.grpInputDM.Location = new System.Drawing.Point(11, 12);
            this.grpInputDM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInputDM.Name = "grpInputDM";
            this.grpInputDM.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInputDM.Size = new System.Drawing.Size(979, 112);
            this.grpInputDM.TabIndex = 0;
            this.grpInputDM.TabStop = false;
            this.grpInputDM.Text = "Thông tin Danh mục";
            // 
            // lblTenDM
            // 
            this.lblTenDM.Location = new System.Drawing.Point(11, 38);
            this.lblTenDM.Name = "lblTenDM";
            this.lblTenDM.Size = new System.Drawing.Size(101, 25);
            this.lblTenDM.TabIndex = 0;
            this.lblTenDM.Text = "Tên danh mục:";
            // 
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(118, 34);
            this.txtTenDM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(337, 26);
            this.txtTenDM.TabIndex = 1;
            // 
            // btnThemDM
            // 
            this.btnThemDM.BackColor = System.Drawing.Color.LightGreen;
            this.btnThemDM.Location = new System.Drawing.Point(118, 75);
            this.btnThemDM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(90, 31);
            this.btnThemDM.TabIndex = 2;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = false;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.BackColor = System.Drawing.Color.LightBlue;
            this.btnSuaDM.Location = new System.Drawing.Point(225, 75);
            this.btnSuaDM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(90, 31);
            this.btnSuaDM.TabIndex = 3;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.UseVisualStyleBackColor = false;
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click);
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoaDM.Location = new System.Drawing.Point(332, 75);
            this.btnXoaDM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(90, 31);
            this.btnXoaDM.TabIndex = 4;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.UseVisualStyleBackColor = false;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnLamMoiDM
            // 
            this.btnLamMoiDM.Location = new System.Drawing.Point(439, 75);
            this.btnLamMoiDM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoiDM.Name = "btnLamMoiDM";
            this.btnLamMoiDM.Size = new System.Drawing.Size(90, 31);
            this.btnLamMoiDM.TabIndex = 5;
            this.btnLamMoiDM.Text = "Làm mới";
            this.btnLamMoiDM.Click += new System.EventHandler(this.btnLamMoiDM_Click);
            // 
            // grpDanhSachDM
            // 
            this.grpDanhSachDM.Controls.Add(this.dgvDanhMuc);
            this.grpDanhSachDM.Location = new System.Drawing.Point(11, 138);
            this.grpDanhSachDM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDanhSachDM.Name = "grpDanhSachDM";
            this.grpDanhSachDM.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDanhSachDM.Size = new System.Drawing.Size(979, 525);
            this.grpDanhSachDM.TabIndex = 1;
            this.grpDanhSachDM.TabStop = false;
            this.grpDanhSachDM.Text = "Danh sách Danh mục";
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.ColumnHeadersHeight = 34;
            this.dgvDanhMuc.Location = new System.Drawing.Point(11, 25);
            this.dgvDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersWidth = 62;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(951, 481);
            this.dgvDanhMuc.TabIndex = 0;
            this.dgvDanhMuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellContentClick);
            // 
            // panelGiaoDich
            // 
            this.panelGiaoDich.Controls.Add(this.grpInputGD);
            this.panelGiaoDich.Controls.Add(this.grpDanhSachGD);
            this.panelGiaoDich.Location = new System.Drawing.Point(0, 35);
            this.panelGiaoDich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGiaoDich.Name = "panelGiaoDich";
            this.panelGiaoDich.Size = new System.Drawing.Size(1012, 700);
            this.panelGiaoDich.TabIndex = 3;
            this.panelGiaoDich.Visible = false;
            // 
            // grpInputGD
            // 
            this.grpInputGD.Controls.Add(this.lblNguoiThucHien);
            this.grpInputGD.Controls.Add(this.txtNguoiThucHien);
            this.grpInputGD.Controls.Add(this.lblSanPhamGD);
            this.grpInputGD.Controls.Add(this.cboSanPhamGD);
            this.grpInputGD.Controls.Add(this.lblSoLuongBan);
            this.grpInputGD.Controls.Add(this.txtSoLuongBan);
            this.grpInputGD.Controls.Add(this.lblTongTien);
            this.grpInputGD.Controls.Add(this.txtTongTien);
            this.grpInputGD.Controls.Add(this.btnTaoGiaoDich);
            this.grpInputGD.Location = new System.Drawing.Point(11, 12);
            this.grpInputGD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInputGD.Name = "grpInputGD";
            this.grpInputGD.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInputGD.Size = new System.Drawing.Size(979, 162);
            this.grpInputGD.TabIndex = 0;
            this.grpInputGD.TabStop = false;
            this.grpInputGD.Text = "Tạo giao dịch bán hàng";
            // 
            // lblNguoiThucHien
            // 
            this.lblNguoiThucHien.Location = new System.Drawing.Point(11, 35);
            this.lblNguoiThucHien.Name = "lblNguoiThucHien";
            this.lblNguoiThucHien.Size = new System.Drawing.Size(90, 25);
            this.lblNguoiThucHien.TabIndex = 0;
            this.lblNguoiThucHien.Text = "Người bán:";
            // 
            // txtNguoiThucHien
            // 
            this.txtNguoiThucHien.Location = new System.Drawing.Point(107, 31);
            this.txtNguoiThucHien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNguoiThucHien.Name = "txtNguoiThucHien";
            this.txtNguoiThucHien.Size = new System.Drawing.Size(224, 26);
            this.txtNguoiThucHien.TabIndex = 1;
            // 
            // lblSanPhamGD
            // 
            this.lblSanPhamGD.Location = new System.Drawing.Point(349, 35);
            this.lblSanPhamGD.Name = "lblSanPhamGD";
            this.lblSanPhamGD.Size = new System.Drawing.Size(79, 25);
            this.lblSanPhamGD.TabIndex = 2;
            this.lblSanPhamGD.Text = "Sản phẩm:";
            // 
            // cboSanPhamGD
            // 
            this.cboSanPhamGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPhamGD.Location = new System.Drawing.Point(433, 31);
            this.cboSanPhamGD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSanPhamGD.Name = "cboSanPhamGD";
            this.cboSanPhamGD.Size = new System.Drawing.Size(337, 28);
            this.cboSanPhamGD.TabIndex = 3;
            this.cboSanPhamGD.SelectedIndexChanged += new System.EventHandler(this.cboSanPhamGD_SelectedIndexChanged);
            // 
            // lblSoLuongBan
            // 
            this.lblSoLuongBan.Location = new System.Drawing.Point(11, 78);
            this.lblSoLuongBan.Name = "lblSoLuongBan";
            this.lblSoLuongBan.Size = new System.Drawing.Size(90, 25);
            this.lblSoLuongBan.TabIndex = 4;
            this.lblSoLuongBan.Text = "Số lượng bán:";
            // 
            // txtSoLuongBan
            // 
            this.txtSoLuongBan.Location = new System.Drawing.Point(107, 74);
            this.txtSoLuongBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.Size = new System.Drawing.Size(112, 26);
            this.txtSoLuongBan.TabIndex = 5;
            this.txtSoLuongBan.TextChanged += new System.EventHandler(this.txtSoLuongBan_TextChanged);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(236, 78);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(96, 25);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Tổng tiền (đ):";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.LightYellow;
            this.txtTongTien.Location = new System.Drawing.Point(338, 74);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(168, 26);
            this.txtTongTien.TabIndex = 7;
            // 
            // btnTaoGiaoDich
            // 
            this.btnTaoGiaoDich.BackColor = System.Drawing.Color.LightGreen;
            this.btnTaoGiaoDich.Location = new System.Drawing.Point(107, 119);
            this.btnTaoGiaoDich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoGiaoDich.Name = "btnTaoGiaoDich";
            this.btnTaoGiaoDich.Size = new System.Drawing.Size(158, 35);
            this.btnTaoGiaoDich.TabIndex = 8;
            this.btnTaoGiaoDich.Text = "Xác nhận bán hàng";
            this.btnTaoGiaoDich.UseVisualStyleBackColor = false;
            this.btnTaoGiaoDich.Click += new System.EventHandler(this.btnTaoGiaoDich_Click);
            // 
            // grpDanhSachGD
            // 
            this.grpDanhSachGD.Controls.Add(this.dgvGiaoDich);
            this.grpDanhSachGD.Location = new System.Drawing.Point(11, 188);
            this.grpDanhSachGD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDanhSachGD.Name = "grpDanhSachGD";
            this.grpDanhSachGD.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDanhSachGD.Size = new System.Drawing.Size(979, 488);
            this.grpDanhSachGD.TabIndex = 1;
            this.grpDanhSachGD.TabStop = false;
            this.grpDanhSachGD.Text = "Lịch sử giao dịch";
            // 
            // dgvGiaoDich
            // 
            this.dgvGiaoDich.AllowUserToAddRows = false;
            this.dgvGiaoDich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoDich.ColumnHeadersHeight = 34;
            this.dgvGiaoDich.Location = new System.Drawing.Point(11, 25);
            this.dgvGiaoDich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvGiaoDich.Name = "dgvGiaoDich";
            this.dgvGiaoDich.ReadOnly = true;
            this.dgvGiaoDich.RowHeadersWidth = 62;
            this.dgvGiaoDich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoDich.Size = new System.Drawing.Size(951, 444);
            this.dgvGiaoDich.TabIndex = 0;
            // 
            // panelThongKe
            // 
            this.panelThongKe.Controls.Add(this.grpSoLieu);
            this.panelThongKe.Controls.Add(this.grpBangThongKe);
            this.panelThongKe.Location = new System.Drawing.Point(0, 35);
            this.panelThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelThongKe.Name = "panelThongKe";
            this.panelThongKe.Size = new System.Drawing.Size(1012, 700);
            this.panelThongKe.TabIndex = 4;
            this.panelThongKe.Visible = false;
            // 
            // grpSoLieu
            // 
            this.grpSoLieu.Controls.Add(this.lblTongDoanhThu);
            this.grpSoLieu.Controls.Add(this.lblTongSanPham);
            this.grpSoLieu.Controls.Add(this.lblTongGiaoDich);
            this.grpSoLieu.Controls.Add(this.btnLamMoiTK);
            this.grpSoLieu.Location = new System.Drawing.Point(11, 12);
            this.grpSoLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSoLieu.Name = "grpSoLieu";
            this.grpSoLieu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSoLieu.Size = new System.Drawing.Size(979, 100);
            this.grpSoLieu.TabIndex = 0;
            this.grpSoLieu.TabStop = false;
            this.grpSoLieu.Text = "Tổng quan";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(17, 31);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(281, 25);
            this.lblTongDoanhThu.TabIndex = 0;
            this.lblTongDoanhThu.Text = "Tổng doanh thu: ...";
            // 
            // lblTongSanPham
            // 
            this.lblTongSanPham.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongSanPham.Location = new System.Drawing.Point(326, 31);
            this.lblTongSanPham.Name = "lblTongSanPham";
            this.lblTongSanPham.Size = new System.Drawing.Size(225, 25);
            this.lblTongSanPham.TabIndex = 1;
            this.lblTongSanPham.Text = "Tổng số sản phẩm: ...";
            // 
            // lblTongGiaoDich
            // 
            this.lblTongGiaoDich.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongGiaoDich.Location = new System.Drawing.Point(574, 31);
            this.lblTongGiaoDich.Name = "lblTongGiaoDich";
            this.lblTongGiaoDich.Size = new System.Drawing.Size(225, 25);
            this.lblTongGiaoDich.TabIndex = 2;
            this.lblTongGiaoDich.Text = "Tổng số giao dịch: ...";
            // 
            // btnLamMoiTK
            // 
            this.btnLamMoiTK.Location = new System.Drawing.Point(821, 25);
            this.btnLamMoiTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoiTK.Name = "btnLamMoiTK";
            this.btnLamMoiTK.Size = new System.Drawing.Size(90, 35);
            this.btnLamMoiTK.TabIndex = 3;
            this.btnLamMoiTK.Text = "Làm mới";
            this.btnLamMoiTK.Click += new System.EventHandler(this.btnLamMoiTK_Click);
            // 
            // grpBangThongKe
            // 
            this.grpBangThongKe.Controls.Add(this.dgvThongKe);
            this.grpBangThongKe.Location = new System.Drawing.Point(11, 125);
            this.grpBangThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBangThongKe.Name = "grpBangThongKe";
            this.grpBangThongKe.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBangThongKe.Size = new System.Drawing.Size(979, 550);
            this.grpBangThongKe.TabIndex = 1;
            this.grpBangThongKe.TabStop = false;
            this.grpBangThongKe.Text = "Doanh thu theo sản phẩm";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeight = 34;
            this.dgvThongKe.Location = new System.Drawing.Point(11, 25);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersWidth = 62;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(951, 506);
            this.dgvThongKe.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 738);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelSanPham);
            this.Controls.Add(this.panelDanhMuc);
            this.Controls.Add(this.panelGiaoDich);
            this.Controls.Add(this.panelThongKe);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Quản Lý Cửa Hàng Văn Phòng Phẩm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSanPham.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.grpInputSP.ResumeLayout(false);
            this.grpInputSP.PerformLayout();
            this.grpDanhSachSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panelDanhMuc.ResumeLayout(false);
            this.grpInputDM.ResumeLayout(false);
            this.grpInputDM.PerformLayout();
            this.grpDanhSachDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.panelGiaoDich.ResumeLayout(false);
            this.grpInputGD.ResumeLayout(false);
            this.grpInputGD.PerformLayout();
            this.grpDanhSachGD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).EndInit();
            this.panelThongKe.ResumeLayout(false);
            this.grpSoLieu.ResumeLayout(false);
            this.grpBangThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        // Menu
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSanPham;
        private System.Windows.Forms.ToolStripMenuItem menuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuGiaoDich;
        private System.Windows.Forms.ToolStripMenuItem menuThongKe;
        // Panels
        private System.Windows.Forms.Panel panelSanPham;
        private System.Windows.Forms.Panel panelDanhMuc;
        private System.Windows.Forms.Panel panelGiaoDich;
        private System.Windows.Forms.Panel panelThongKe;
        // Panel Sản Phẩm
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblTimKiemTen;
        private System.Windows.Forms.TextBox txtTimKiemTen;
        private System.Windows.Forms.Label lblTimKiemDanhMuc;
        private System.Windows.Forms.TextBox txtTimKiemDanhMuc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grpInputSP;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnLamMoiSP;
        private System.Windows.Forms.GroupBox grpDanhSachSP;
        private System.Windows.Forms.DataGridView dgvSanPham;
        // Panel Danh Mục
        private System.Windows.Forms.GroupBox grpInputDM;
        private System.Windows.Forms.Label lblTenDM;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnLamMoiDM;
        private System.Windows.Forms.GroupBox grpDanhSachDM;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        // Panel Giao Dịch
        private System.Windows.Forms.GroupBox grpInputGD;
        private System.Windows.Forms.Label lblNguoiThucHien;
        private System.Windows.Forms.TextBox txtNguoiThucHien;
        private System.Windows.Forms.Label lblSanPhamGD;
        private System.Windows.Forms.ComboBox cboSanPhamGD;
        private System.Windows.Forms.Label lblSoLuongBan;
        private System.Windows.Forms.TextBox txtSoLuongBan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTaoGiaoDich;
        private System.Windows.Forms.GroupBox grpDanhSachGD;
        private System.Windows.Forms.DataGridView dgvGiaoDich;
        // Panel Thống Kê
        private System.Windows.Forms.GroupBox grpSoLieu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTongSanPham;
        private System.Windows.Forms.Label lblTongGiaoDich;
        private System.Windows.Forms.Button btnLamMoiTK;
        private System.Windows.Forms.GroupBox grpBangThongKe;
        private System.Windows.Forms.DataGridView dgvThongKe;
    }
}
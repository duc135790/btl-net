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
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSanPham,
            this.menuDanhMuc,
            this.menuGiaoDich,
            this.menuThongKe,
            this.aToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuSanPham
            // 
            this.menuSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem1,
            this.aToolStripMenuItem2});
            this.menuSanPham.ForeColor = System.Drawing.Color.White;
            this.menuSanPham.Name = "menuSanPham";
            this.menuSanPham.Size = new System.Drawing.Size(39, 24);
            this.menuSanPham.Text = "aa";
            this.menuSanPham.Click += new System.EventHandler(this.menuSanPham_Click);
            // 
            // menuDanhMuc
            // 
            this.menuDanhMuc.ForeColor = System.Drawing.Color.White;
            this.menuDanhMuc.Name = "menuDanhMuc";
            this.menuDanhMuc.Size = new System.Drawing.Size(144, 24);
            this.menuDanhMuc.Text = "Quản lý Danh Mục";
            this.menuDanhMuc.Click += new System.EventHandler(this.menuDanhMuc_Click);
            // 
            // menuGiaoDich
            // 
            this.menuGiaoDich.ForeColor = System.Drawing.Color.White;
            this.menuGiaoDich.Name = "menuGiaoDich";
            this.menuGiaoDich.Size = new System.Drawing.Size(157, 24);
            this.menuGiaoDich.Text = "Giao Dịch Bán Hàng";
            this.menuGiaoDich.Click += new System.EventHandler(this.menuGiaoDich_Click);
            // 
            // menuThongKe
            // 
            this.menuThongKe.ForeColor = System.Drawing.Color.White;
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Size = new System.Drawing.Size(86, 24);
            this.menuThongKe.Text = "Thống Kê";
            this.menuThongKe.Click += new System.EventHandler(this.menuThongKe_Click);
            // 
            // panelSanPham
            // 
            this.panelSanPham.Controls.Add(this.grpTimKiem);
            this.panelSanPham.Controls.Add(this.grpInputSP);
            this.panelSanPham.Controls.Add(this.grpDanhSachSP);
            this.panelSanPham.Location = new System.Drawing.Point(0, 28);
            this.panelSanPham.Name = "panelSanPham";
            this.panelSanPham.Size = new System.Drawing.Size(897, 560);
            this.panelSanPham.TabIndex = 1;
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.lblTimKiemTen);
            this.grpTimKiem.Controls.Add(this.txtTimKiemTen);
            this.grpTimKiem.Controls.Add(this.lblTimKiemDanhMuc);
            this.grpTimKiem.Controls.Add(this.txtTimKiemDanhMuc);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Location = new System.Drawing.Point(10, 5);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(870, 55);
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm nâng cao";
            // 
            // lblTimKiemTen
            // 
            this.lblTimKiemTen.Location = new System.Drawing.Point(10, 22);
            this.lblTimKiemTen.Name = "lblTimKiemTen";
            this.lblTimKiemTen.Size = new System.Drawing.Size(90, 20);
            this.lblTimKiemTen.TabIndex = 0;
            this.lblTimKiemTen.Text = "Tên sản phẩm:";
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.Location = new System.Drawing.Point(105, 19);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(200, 22);
            this.txtTimKiemTen.TabIndex = 1;
            this.txtTimKiemTen.TextChanged += new System.EventHandler(this.txtTimKiemTen_TextChanged);
            // 
            // lblTimKiemDanhMuc
            // 
            this.lblTimKiemDanhMuc.Location = new System.Drawing.Point(320, 22);
            this.lblTimKiemDanhMuc.Name = "lblTimKiemDanhMuc";
            this.lblTimKiemDanhMuc.Size = new System.Drawing.Size(65, 20);
            this.lblTimKiemDanhMuc.TabIndex = 2;
            this.lblTimKiemDanhMuc.Text = "Danh mục:";
            // 
            // txtTimKiemDanhMuc
            // 
            this.txtTimKiemDanhMuc.Location = new System.Drawing.Point(390, 19);
            this.txtTimKiemDanhMuc.Name = "txtTimKiemDanhMuc";
            this.txtTimKiemDanhMuc.Size = new System.Drawing.Size(200, 22);
            this.txtTimKiemDanhMuc.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(605, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 25);
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
            this.grpInputSP.Location = new System.Drawing.Point(10, 68);
            this.grpInputSP.Name = "grpInputSP";
            this.grpInputSP.Size = new System.Drawing.Size(870, 135);
            this.grpInputSP.TabIndex = 1;
            this.grpInputSP.TabStop = false;
            this.grpInputSP.Text = "Thông tin Sản phẩm";
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.Location = new System.Drawing.Point(10, 28);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(80, 20);
            this.lblDanhMuc.TabIndex = 0;
            this.lblDanhMuc.Text = "Danh mục:";
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.Location = new System.Drawing.Point(95, 25);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(200, 24);
            this.cboDanhMuc.TabIndex = 1;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Location = new System.Drawing.Point(310, 28);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(90, 20);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(405, 25);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(440, 22);
            this.txtTenSP.TabIndex = 3;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Location = new System.Drawing.Point(10, 60);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(80, 20);
            this.lblGiaBan.TabIndex = 4;
            this.lblGiaBan.Text = "Giá bán (đ):";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(95, 57);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(200, 22);
            this.txtGiaBan.TabIndex = 5;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(310, 60);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(90, 20);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(405, 57);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(200, 22);
            this.txtSoLuong.TabIndex = 7;
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.LightGreen;
            this.btnThemSP.Location = new System.Drawing.Point(95, 95);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(80, 28);
            this.btnThemSP.TabIndex = 8;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.BackColor = System.Drawing.Color.LightBlue;
            this.btnSuaSP.Location = new System.Drawing.Point(190, 95);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(80, 28);
            this.btnSuaSP.TabIndex = 9;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = false;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoaSP.Location = new System.Drawing.Point(285, 95);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(80, 28);
            this.btnXoaSP.TabIndex = 10;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnLamMoiSP
            // 
            this.btnLamMoiSP.Location = new System.Drawing.Point(380, 95);
            this.btnLamMoiSP.Name = "btnLamMoiSP";
            this.btnLamMoiSP.Size = new System.Drawing.Size(80, 28);
            this.btnLamMoiSP.TabIndex = 11;
            this.btnLamMoiSP.Text = "Làm mới";
            this.btnLamMoiSP.Click += new System.EventHandler(this.btnLamMoiSP_Click);
            // 
            // grpDanhSachSP
            // 
            this.grpDanhSachSP.Controls.Add(this.dgvSanPham);
            this.grpDanhSachSP.Location = new System.Drawing.Point(10, 210);
            this.grpDanhSachSP.Name = "grpDanhSachSP";
            this.grpDanhSachSP.Size = new System.Drawing.Size(870, 330);
            this.grpDanhSachSP.TabIndex = 2;
            this.grpDanhSachSP.TabStop = false;
            this.grpDanhSachSP.Text = "Danh sách Sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeight = 29;
            this.dgvSanPham.Location = new System.Drawing.Point(10, 20);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(845, 295);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.Controls.Add(this.grpInputDM);
            this.panelDanhMuc.Controls.Add(this.grpDanhSachDM);
            this.panelDanhMuc.Location = new System.Drawing.Point(0, 28);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(900, 560);
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
            this.grpInputDM.Location = new System.Drawing.Point(10, 10);
            this.grpInputDM.Name = "grpInputDM";
            this.grpInputDM.Size = new System.Drawing.Size(870, 90);
            this.grpInputDM.TabIndex = 0;
            this.grpInputDM.TabStop = false;
            this.grpInputDM.Text = "Thông tin Danh mục";
            // 
            // lblTenDM
            // 
            this.lblTenDM.Location = new System.Drawing.Point(10, 30);
            this.lblTenDM.Name = "lblTenDM";
            this.lblTenDM.Size = new System.Drawing.Size(90, 20);
            this.lblTenDM.TabIndex = 0;
            this.lblTenDM.Text = "Tên danh mục:";
            // 
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(105, 27);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(300, 22);
            this.txtTenDM.TabIndex = 1;
            // 
            // btnThemDM
            // 
            this.btnThemDM.BackColor = System.Drawing.Color.LightGreen;
            this.btnThemDM.Location = new System.Drawing.Point(105, 60);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(80, 25);
            this.btnThemDM.TabIndex = 2;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = false;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.BackColor = System.Drawing.Color.LightBlue;
            this.btnSuaDM.Location = new System.Drawing.Point(200, 60);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(80, 25);
            this.btnSuaDM.TabIndex = 3;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.UseVisualStyleBackColor = false;
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click);
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoaDM.Location = new System.Drawing.Point(295, 60);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(80, 25);
            this.btnXoaDM.TabIndex = 4;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.UseVisualStyleBackColor = false;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnLamMoiDM
            // 
            this.btnLamMoiDM.Location = new System.Drawing.Point(390, 60);
            this.btnLamMoiDM.Name = "btnLamMoiDM";
            this.btnLamMoiDM.Size = new System.Drawing.Size(80, 25);
            this.btnLamMoiDM.TabIndex = 5;
            this.btnLamMoiDM.Text = "Làm mới";
            this.btnLamMoiDM.Click += new System.EventHandler(this.btnLamMoiDM_Click);
            // 
            // grpDanhSachDM
            // 
            this.grpDanhSachDM.Controls.Add(this.dgvDanhMuc);
            this.grpDanhSachDM.Location = new System.Drawing.Point(10, 110);
            this.grpDanhSachDM.Name = "grpDanhSachDM";
            this.grpDanhSachDM.Size = new System.Drawing.Size(870, 420);
            this.grpDanhSachDM.TabIndex = 1;
            this.grpDanhSachDM.TabStop = false;
            this.grpDanhSachDM.Text = "Danh sách Danh mục";
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.ColumnHeadersHeight = 29;
            this.dgvDanhMuc.Location = new System.Drawing.Point(10, 20);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(845, 385);
            this.dgvDanhMuc.TabIndex = 0;
            this.dgvDanhMuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellContentClick);
            // 
            // panelGiaoDich
            // 
            this.panelGiaoDich.Controls.Add(this.grpInputGD);
            this.panelGiaoDich.Controls.Add(this.grpDanhSachGD);
            this.panelGiaoDich.Location = new System.Drawing.Point(0, 28);
            this.panelGiaoDich.Name = "panelGiaoDich";
            this.panelGiaoDich.Size = new System.Drawing.Size(900, 560);
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
            this.grpInputGD.Location = new System.Drawing.Point(10, 10);
            this.grpInputGD.Name = "grpInputGD";
            this.grpInputGD.Size = new System.Drawing.Size(870, 130);
            this.grpInputGD.TabIndex = 0;
            this.grpInputGD.TabStop = false;
            this.grpInputGD.Text = "Tạo giao dịch bán hàng";
            // 
            // lblNguoiThucHien
            // 
            this.lblNguoiThucHien.Location = new System.Drawing.Point(10, 28);
            this.lblNguoiThucHien.Name = "lblNguoiThucHien";
            this.lblNguoiThucHien.Size = new System.Drawing.Size(80, 20);
            this.lblNguoiThucHien.TabIndex = 0;
            this.lblNguoiThucHien.Text = "Người bán:";
            // 
            // txtNguoiThucHien
            // 
            this.txtNguoiThucHien.Location = new System.Drawing.Point(95, 25);
            this.txtNguoiThucHien.Name = "txtNguoiThucHien";
            this.txtNguoiThucHien.Size = new System.Drawing.Size(200, 22);
            this.txtNguoiThucHien.TabIndex = 1;
            // 
            // lblSanPhamGD
            // 
            this.lblSanPhamGD.Location = new System.Drawing.Point(310, 28);
            this.lblSanPhamGD.Name = "lblSanPhamGD";
            this.lblSanPhamGD.Size = new System.Drawing.Size(70, 20);
            this.lblSanPhamGD.TabIndex = 2;
            this.lblSanPhamGD.Text = "Sản phẩm:";
            // 
            // cboSanPhamGD
            // 
            this.cboSanPhamGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPhamGD.Location = new System.Drawing.Point(385, 25);
            this.cboSanPhamGD.Name = "cboSanPhamGD";
            this.cboSanPhamGD.Size = new System.Drawing.Size(300, 24);
            this.cboSanPhamGD.TabIndex = 3;
            this.cboSanPhamGD.SelectedIndexChanged += new System.EventHandler(this.cboSanPhamGD_SelectedIndexChanged);
            // 
            // lblSoLuongBan
            // 
            this.lblSoLuongBan.Location = new System.Drawing.Point(10, 62);
            this.lblSoLuongBan.Name = "lblSoLuongBan";
            this.lblSoLuongBan.Size = new System.Drawing.Size(80, 20);
            this.lblSoLuongBan.TabIndex = 4;
            this.lblSoLuongBan.Text = "Số lượng bán:";
            // 
            // txtSoLuongBan
            // 
            this.txtSoLuongBan.Location = new System.Drawing.Point(95, 59);
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuongBan.TabIndex = 5;
            this.txtSoLuongBan.TextChanged += new System.EventHandler(this.txtSoLuongBan_TextChanged);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(210, 62);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(85, 20);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Tổng tiền (đ):";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.LightYellow;
            this.txtTongTien.Location = new System.Drawing.Point(300, 59);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(150, 22);
            this.txtTongTien.TabIndex = 7;
            // 
            // btnTaoGiaoDich
            // 
            this.btnTaoGiaoDich.BackColor = System.Drawing.Color.LightGreen;
            this.btnTaoGiaoDich.Location = new System.Drawing.Point(95, 95);
            this.btnTaoGiaoDich.Name = "btnTaoGiaoDich";
            this.btnTaoGiaoDich.Size = new System.Drawing.Size(140, 28);
            this.btnTaoGiaoDich.TabIndex = 8;
            this.btnTaoGiaoDich.Text = "Xác nhận bán hàng";
            this.btnTaoGiaoDich.UseVisualStyleBackColor = false;
            this.btnTaoGiaoDich.Click += new System.EventHandler(this.btnTaoGiaoDich_Click);
            // 
            // grpDanhSachGD
            // 
            this.grpDanhSachGD.Controls.Add(this.dgvGiaoDich);
            this.grpDanhSachGD.Location = new System.Drawing.Point(10, 150);
            this.grpDanhSachGD.Name = "grpDanhSachGD";
            this.grpDanhSachGD.Size = new System.Drawing.Size(870, 390);
            this.grpDanhSachGD.TabIndex = 1;
            this.grpDanhSachGD.TabStop = false;
            this.grpDanhSachGD.Text = "Lịch sử giao dịch";
            // 
            // dgvGiaoDich
            // 
            this.dgvGiaoDich.AllowUserToAddRows = false;
            this.dgvGiaoDich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoDich.ColumnHeadersHeight = 29;
            this.dgvGiaoDich.Location = new System.Drawing.Point(10, 20);
            this.dgvGiaoDich.Name = "dgvGiaoDich";
            this.dgvGiaoDich.ReadOnly = true;
            this.dgvGiaoDich.RowHeadersWidth = 51;
            this.dgvGiaoDich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoDich.Size = new System.Drawing.Size(845, 355);
            this.dgvGiaoDich.TabIndex = 0;
            // 
            // panelThongKe
            // 
            this.panelThongKe.Controls.Add(this.grpSoLieu);
            this.panelThongKe.Controls.Add(this.grpBangThongKe);
            this.panelThongKe.Location = new System.Drawing.Point(0, 28);
            this.panelThongKe.Name = "panelThongKe";
            this.panelThongKe.Size = new System.Drawing.Size(900, 560);
            this.panelThongKe.TabIndex = 4;
            this.panelThongKe.Visible = false;
            // 
            // grpSoLieu
            // 
            this.grpSoLieu.Controls.Add(this.lblTongDoanhThu);
            this.grpSoLieu.Controls.Add(this.lblTongSanPham);
            this.grpSoLieu.Controls.Add(this.lblTongGiaoDich);
            this.grpSoLieu.Controls.Add(this.btnLamMoiTK);
            this.grpSoLieu.Location = new System.Drawing.Point(10, 10);
            this.grpSoLieu.Name = "grpSoLieu";
            this.grpSoLieu.Size = new System.Drawing.Size(870, 80);
            this.grpSoLieu.TabIndex = 0;
            this.grpSoLieu.TabStop = false;
            this.grpSoLieu.Text = "Tổng quan";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(15, 25);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(250, 20);
            this.lblTongDoanhThu.TabIndex = 0;
            this.lblTongDoanhThu.Text = "Tổng doanh thu: ...";
            // 
            // lblTongSanPham
            // 
            this.lblTongSanPham.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongSanPham.Location = new System.Drawing.Point(290, 25);
            this.lblTongSanPham.Name = "lblTongSanPham";
            this.lblTongSanPham.Size = new System.Drawing.Size(200, 20);
            this.lblTongSanPham.TabIndex = 1;
            this.lblTongSanPham.Text = "Tổng số sản phẩm: ...";
            // 
            // lblTongGiaoDich
            // 
            this.lblTongGiaoDich.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongGiaoDich.Location = new System.Drawing.Point(510, 25);
            this.lblTongGiaoDich.Name = "lblTongGiaoDich";
            this.lblTongGiaoDich.Size = new System.Drawing.Size(200, 20);
            this.lblTongGiaoDich.TabIndex = 2;
            this.lblTongGiaoDich.Text = "Tổng số giao dịch: ...";
            // 
            // btnLamMoiTK
            // 
            this.btnLamMoiTK.Location = new System.Drawing.Point(730, 20);
            this.btnLamMoiTK.Name = "btnLamMoiTK";
            this.btnLamMoiTK.Size = new System.Drawing.Size(80, 28);
            this.btnLamMoiTK.TabIndex = 3;
            this.btnLamMoiTK.Text = "Làm mới";
            this.btnLamMoiTK.Click += new System.EventHandler(this.btnLamMoiTK_Click);
            // 
            // grpBangThongKe
            // 
            this.grpBangThongKe.Controls.Add(this.dgvThongKe);
            this.grpBangThongKe.Location = new System.Drawing.Point(10, 100);
            this.grpBangThongKe.Name = "grpBangThongKe";
            this.grpBangThongKe.Size = new System.Drawing.Size(870, 440);
            this.grpBangThongKe.TabIndex = 1;
            this.grpBangThongKe.TabStop = false;
            this.grpBangThongKe.Text = "Doanh thu theo sản phẩm";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeight = 29;
            this.dgvThongKe.Location = new System.Drawing.Point(10, 20);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(845, 405);
            this.dgvThongKe.TabIndex = 0;
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(31, 24);
            this.aToolStripMenuItem.Text = "a";
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.aToolStripMenuItem1.Text = "a";
            this.aToolStripMenuItem1.Click += new System.EventHandler(this.aToolStripMenuItem1_Click);
            // 
            // aToolStripMenuItem2
            // 
            this.aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            this.aToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.aToolStripMenuItem2.Text = "a";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 590);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelSanPham);
            this.Controls.Add(this.panelDanhMuc);
            this.Controls.Add(this.panelGiaoDich);
            this.Controls.Add(this.panelThongKe);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
    }
}
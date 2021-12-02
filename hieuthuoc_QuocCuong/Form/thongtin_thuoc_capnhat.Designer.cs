
namespace hieuthuoc_QuocCuong
{
    partial class thongtin_thuoc_capnhat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thongtin_thuoc_capnhat));
            this.datathuoc = new System.Windows.Forms.DataGridView();
            this.mathuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congdungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhphanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuatxuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giabanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hieu_thuocDataSet1 = new hieuthuoc_QuocCuong.hieu_thuocDataSet1();
            this.thuocTableAdapter = new hieuthuoc_QuocCuong.hieu_thuocDataSet1TableAdapters.thuocTableAdapter();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
            this.txtMAt = new System.Windows.Forms.TextBox();
            this.txtMAn = new System.Windows.Forms.TextBox();
            this.txtTent = new System.Windows.Forms.TextBox();
            this.txtCd = new System.Windows.Forms.TextBox();
            this.txtTp = new System.Windows.Forms.TextBox();
            this.txtDvt = new System.Windows.Forms.TextBox();
            this.txtXx = new System.Windows.Forms.TextBox();
            this.txtGb = new System.Windows.Forms.TextBox();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnEX = new System.Windows.Forms.Button();
            this.hIeuThuoc_QuocCuongDataSet6 = new hieuthuoc_QuocCuong.HIeuThuoc_QuocCuongDataSet6();
            this.thuocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.thuocTableAdapter1 = new hieuthuoc_QuocCuong.HIeuThuoc_QuocCuongDataSet6TableAdapters.thuocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datathuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hieu_thuocDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hIeuThuoc_QuocCuongDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // datathuoc
            // 
            this.datathuoc.AutoGenerateColumns = false;
            this.datathuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datathuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathuocDataGridViewTextBoxColumn,
            this.manhomDataGridViewTextBoxColumn,
            this.tenthuocDataGridViewTextBoxColumn,
            this.congdungDataGridViewTextBoxColumn,
            this.thanhphanDataGridViewTextBoxColumn,
            this.donvitinhDataGridViewTextBoxColumn,
            this.xuatxuDataGridViewTextBoxColumn,
            this.giabanDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn});
            this.datathuoc.DataSource = this.thuocBindingSource1;
            this.datathuoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datathuoc.Location = new System.Drawing.Point(0, 448);
            this.datathuoc.Name = "datathuoc";
            this.datathuoc.Size = new System.Drawing.Size(1350, 281);
            this.datathuoc.TabIndex = 0;
            this.datathuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datathuoc_CellContentClick);
            // 
            // mathuocDataGridViewTextBoxColumn
            // 
            this.mathuocDataGridViewTextBoxColumn.DataPropertyName = "ma_thuoc";
            this.mathuocDataGridViewTextBoxColumn.HeaderText = "ma_thuoc";
            this.mathuocDataGridViewTextBoxColumn.Name = "mathuocDataGridViewTextBoxColumn";
            // 
            // manhomDataGridViewTextBoxColumn
            // 
            this.manhomDataGridViewTextBoxColumn.DataPropertyName = "ma_nhom";
            this.manhomDataGridViewTextBoxColumn.HeaderText = "ma_nhom";
            this.manhomDataGridViewTextBoxColumn.Name = "manhomDataGridViewTextBoxColumn";
            // 
            // tenthuocDataGridViewTextBoxColumn
            // 
            this.tenthuocDataGridViewTextBoxColumn.DataPropertyName = "ten_thuoc";
            this.tenthuocDataGridViewTextBoxColumn.HeaderText = "ten_thuoc";
            this.tenthuocDataGridViewTextBoxColumn.Name = "tenthuocDataGridViewTextBoxColumn";
            // 
            // congdungDataGridViewTextBoxColumn
            // 
            this.congdungDataGridViewTextBoxColumn.DataPropertyName = "cong_dung";
            this.congdungDataGridViewTextBoxColumn.HeaderText = "cong_dung";
            this.congdungDataGridViewTextBoxColumn.Name = "congdungDataGridViewTextBoxColumn";
            this.congdungDataGridViewTextBoxColumn.Width = 200;
            // 
            // thanhphanDataGridViewTextBoxColumn
            // 
            this.thanhphanDataGridViewTextBoxColumn.DataPropertyName = "thanh_phan";
            this.thanhphanDataGridViewTextBoxColumn.HeaderText = "thanh_phan";
            this.thanhphanDataGridViewTextBoxColumn.Name = "thanhphanDataGridViewTextBoxColumn";
            this.thanhphanDataGridViewTextBoxColumn.Width = 200;
            // 
            // donvitinhDataGridViewTextBoxColumn
            // 
            this.donvitinhDataGridViewTextBoxColumn.DataPropertyName = "don_vi_tinh";
            this.donvitinhDataGridViewTextBoxColumn.HeaderText = "don_vi_tinh";
            this.donvitinhDataGridViewTextBoxColumn.Name = "donvitinhDataGridViewTextBoxColumn";
            // 
            // xuatxuDataGridViewTextBoxColumn
            // 
            this.xuatxuDataGridViewTextBoxColumn.DataPropertyName = "xuat_xu";
            this.xuatxuDataGridViewTextBoxColumn.HeaderText = "xuat_xu";
            this.xuatxuDataGridViewTextBoxColumn.Name = "xuatxuDataGridViewTextBoxColumn";
            // 
            // giabanDataGridViewTextBoxColumn
            // 
            this.giabanDataGridViewTextBoxColumn.DataPropertyName = "gia_ban";
            this.giabanDataGridViewTextBoxColumn.HeaderText = "gia_ban";
            this.giabanDataGridViewTextBoxColumn.Name = "giabanDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "so_luong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "so_luong";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // thuocBindingSource
            // 
            this.thuocBindingSource.DataMember = "thuoc";
            this.thuocBindingSource.DataSource = this.hieu_thuocDataSet1;
            // 
            // hieu_thuocDataSet1
            // 
            this.hieu_thuocDataSet1.DataSetName = "hieu_thuocDataSet1";
            this.hieu_thuocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thuocTableAdapter
            // 
            this.thuocTableAdapter.ClearBeforeFill = true;
            // 
            // btnADD
            // 
            this.btnADD.AutoSize = true;
            this.btnADD.Location = new System.Drawing.Point(100, 97);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(93, 42);
            this.btnADD.TabIndex = 1;
            this.btnADD.Text = "Thêm";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnDEL
            // 
            this.btnDEL.AutoSize = true;
            this.btnDEL.Location = new System.Drawing.Point(100, 171);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(93, 42);
            this.btnDEL.TabIndex = 1;
            this.btnDEL.Text = "Xóa";
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // txtMAt
            // 
            this.txtMAt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMAt.Location = new System.Drawing.Point(413, 119);
            this.txtMAt.Name = "txtMAt";
            this.txtMAt.Size = new System.Drawing.Size(312, 20);
            this.txtMAt.TabIndex = 2;
            // 
            // txtMAn
            // 
            this.txtMAn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMAn.Location = new System.Drawing.Point(413, 171);
            this.txtMAn.Name = "txtMAn";
            this.txtMAn.Size = new System.Drawing.Size(312, 20);
            this.txtMAn.TabIndex = 2;
            // 
            // txtTent
            // 
            this.txtTent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTent.Location = new System.Drawing.Point(413, 212);
            this.txtTent.Name = "txtTent";
            this.txtTent.Size = new System.Drawing.Size(312, 20);
            this.txtTent.TabIndex = 2;
            // 
            // txtCd
            // 
            this.txtCd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCd.Location = new System.Drawing.Point(413, 254);
            this.txtCd.Name = "txtCd";
            this.txtCd.Size = new System.Drawing.Size(312, 20);
            this.txtCd.TabIndex = 2;
            // 
            // txtTp
            // 
            this.txtTp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTp.Location = new System.Drawing.Point(413, 298);
            this.txtTp.Name = "txtTp";
            this.txtTp.Size = new System.Drawing.Size(312, 20);
            this.txtTp.TabIndex = 2;
            // 
            // txtDvt
            // 
            this.txtDvt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDvt.Location = new System.Drawing.Point(850, 131);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(299, 20);
            this.txtDvt.TabIndex = 2;
            // 
            // txtXx
            // 
            this.txtXx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtXx.Location = new System.Drawing.Point(850, 223);
            this.txtXx.Name = "txtXx";
            this.txtXx.Size = new System.Drawing.Size(299, 20);
            this.txtXx.TabIndex = 2;
            // 
            // txtGb
            // 
            this.txtGb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtGb.Location = new System.Drawing.Point(850, 276);
            this.txtGb.Name = "txtGb";
            this.txtGb.Size = new System.Drawing.Size(299, 20);
            this.txtGb.TabIndex = 2;
            this.txtGb.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtSl
            // 
            this.txtSl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSl.Location = new System.Drawing.Point(850, 183);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(299, 20);
            this.txtSl.TabIndex = 2;
            this.txtSl.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã thuốc";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã nhóm";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên thuốc";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Công dụng";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thành phần";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(767, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Đơn vị tính";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(767, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Xuất xứ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(767, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giá bán";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(767, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số lượng";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(1050, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1256, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.thuốcToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.lậpHóaĐơnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // thuốcToolStripMenuItem
            // 
            this.thuốcToolStripMenuItem.Name = "thuốcToolStripMenuItem";
            this.thuốcToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thuốcToolStripMenuItem.Text = "Thuốc";
            this.thuốcToolStripMenuItem.Click += new System.EventHandler(this.thuốcToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // lậpHóaĐơnToolStripMenuItem
            // 
            this.lậpHóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpToolStripMenuItem,
            this.xuấtToolStripMenuItem});
            this.lậpHóaĐơnToolStripMenuItem.Name = "lậpHóaĐơnToolStripMenuItem";
            this.lậpHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.lậpHóaĐơnToolStripMenuItem.Text = "Lập hóa đơn";
            this.lậpHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.lậpHóaĐơnToolStripMenuItem_Click);
            // 
            // nhậpToolStripMenuItem
            // 
            this.nhậpToolStripMenuItem.Name = "nhậpToolStripMenuItem";
            this.nhậpToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.nhậpToolStripMenuItem.Text = "Nhập";
            this.nhậpToolStripMenuItem.Click += new System.EventHandler(this.nhậpToolStripMenuItem_Click);
            // 
            // xuấtToolStripMenuItem
            // 
            this.xuấtToolStripMenuItem.Name = "xuấtToolStripMenuItem";
            this.xuấtToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.xuấtToolStripMenuItem.Text = "Xuất";
            this.xuấtToolStripMenuItem.Click += new System.EventHandler(this.xuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(100, 254);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(93, 44);
            this.btnFix.TabIndex = 8;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnEX
            // 
            this.btnEX.Location = new System.Drawing.Point(850, 359);
            this.btnEX.Name = "btnEX";
            this.btnEX.Size = new System.Drawing.Size(101, 42);
            this.btnEX.TabIndex = 9;
            this.btnEX.Text = "Xuất file Excel";
            this.btnEX.UseVisualStyleBackColor = true;
            this.btnEX.Click += new System.EventHandler(this.btnEX_Click);
            // 
            // hIeuThuoc_QuocCuongDataSet6
            // 
            this.hIeuThuoc_QuocCuongDataSet6.DataSetName = "HIeuThuoc_QuocCuongDataSet6";
            this.hIeuThuoc_QuocCuongDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thuocBindingSource1
            // 
            this.thuocBindingSource1.DataMember = "thuoc";
            this.thuocBindingSource1.DataSource = this.hIeuThuoc_QuocCuongDataSet6;
            // 
            // thuocTableAdapter1
            // 
            this.thuocTableAdapter1.ClearBeforeFill = true;
            // 
            // thongtin_thuoc_capnhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnEX);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.txtGb);
            this.Controls.Add(this.txtCd);
            this.Controls.Add(this.txtXx);
            this.Controls.Add(this.txtTent);
            this.Controls.Add(this.txtDvt);
            this.Controls.Add(this.txtTp);
            this.Controls.Add(this.txtMAn);
            this.Controls.Add(this.txtMAt);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.datathuoc);
            this.Name = "thongtin_thuoc_capnhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "thongtin_thuoc_capnhat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.thongtin_thuoc_capnhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datathuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hieu_thuocDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hIeuThuoc_QuocCuongDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datathuoc;
        private hieu_thuocDataSet1 hieu_thuocDataSet1;
        private System.Windows.Forms.BindingSource thuocBindingSource;
        private hieu_thuocDataSet1TableAdapters.thuocTableAdapter thuocTableAdapter;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.TextBox txtMAt;
        private System.Windows.Forms.TextBox txtMAn;
        private System.Windows.Forms.TextBox txtTent;
        private System.Windows.Forms.TextBox txtCd;
        private System.Windows.Forms.TextBox txtTp;
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.TextBox txtXx;
        private System.Windows.Forms.TextBox txtGb;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn congdungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhphanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuatxuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnEX;
        private System.Windows.Forms.ToolStripMenuItem nhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtToolStripMenuItem;
        private HIeuThuoc_QuocCuongDataSet6 hIeuThuoc_QuocCuongDataSet6;
        private System.Windows.Forms.BindingSource thuocBindingSource1;
        private HIeuThuoc_QuocCuongDataSet6TableAdapters.thuocTableAdapter thuocTableAdapter1;
    }
}
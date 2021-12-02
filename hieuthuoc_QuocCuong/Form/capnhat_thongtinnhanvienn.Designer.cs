
namespace hieuthuoc_QuocCuong
{
    partial class capnhat_thongtinnhanvienn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(capnhat_thongtinnhanvienn));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendangnhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanvienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hIeuThuoc_QuocCuongDataSet3 = new hieuthuoc_QuocCuong.HIeuThuoc_QuocCuongDataSet3();
            this.btnADd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtChuc = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFix = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hieu_thuocDataSet = new hieuthuoc_QuocCuong.hieu_thuocDataSet();
            this.nhanvienTableAdapter = new hieuthuoc_QuocCuong.hieu_thuocDataSetTableAdapters.nhanvienTableAdapter();
            this.nhanvienTableAdapter1 = new hieuthuoc_QuocCuong.HIeuThuoc_QuocCuongDataSet3TableAdapters.nhanvienTableAdapter();
            this.btnXuats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIeuThuoc_QuocCuongDataSet3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hieu_thuocDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.chucvuDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.tuoiDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sodtDataGridViewTextBoxColumn,
            this.tendangnhapDataGridViewTextBoxColumn,
            this.matkhauDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhanvienBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 504);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1350, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "ma_NV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "ma_NV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "ho_ten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "ho_ten";
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            // 
            // chucvuDataGridViewTextBoxColumn
            // 
            this.chucvuDataGridViewTextBoxColumn.DataPropertyName = "chuc_vu";
            this.chucvuDataGridViewTextBoxColumn.HeaderText = "chuc_vu";
            this.chucvuDataGridViewTextBoxColumn.Name = "chucvuDataGridViewTextBoxColumn";
            // 
            // gioitinhDataGridViewTextBoxColumn
            // 
            this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "gioi_tinh";
            this.gioitinhDataGridViewTextBoxColumn.HeaderText = "gioi_tinh";
            this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
            // 
            // tuoiDataGridViewTextBoxColumn
            // 
            this.tuoiDataGridViewTextBoxColumn.DataPropertyName = "tuoi";
            this.tuoiDataGridViewTextBoxColumn.HeaderText = "tuoi";
            this.tuoiDataGridViewTextBoxColumn.Name = "tuoiDataGridViewTextBoxColumn";
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "dia_chi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "dia_chi";
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // sodtDataGridViewTextBoxColumn
            // 
            this.sodtDataGridViewTextBoxColumn.DataPropertyName = "so_dt";
            this.sodtDataGridViewTextBoxColumn.HeaderText = "so_dt";
            this.sodtDataGridViewTextBoxColumn.Name = "sodtDataGridViewTextBoxColumn";
            // 
            // tendangnhapDataGridViewTextBoxColumn
            // 
            this.tendangnhapDataGridViewTextBoxColumn.DataPropertyName = "ten_dang_nhap";
            this.tendangnhapDataGridViewTextBoxColumn.HeaderText = "ten_dang_nhap";
            this.tendangnhapDataGridViewTextBoxColumn.Name = "tendangnhapDataGridViewTextBoxColumn";
            // 
            // matkhauDataGridViewTextBoxColumn
            // 
            this.matkhauDataGridViewTextBoxColumn.DataPropertyName = "mat_khau";
            this.matkhauDataGridViewTextBoxColumn.HeaderText = "mat_khau";
            this.matkhauDataGridViewTextBoxColumn.Name = "matkhauDataGridViewTextBoxColumn";
            // 
            // nhanvienBindingSource1
            // 
            this.nhanvienBindingSource1.DataMember = "nhanvien";
            this.nhanvienBindingSource1.DataSource = this.hIeuThuoc_QuocCuongDataSet3;
            // 
            // hIeuThuoc_QuocCuongDataSet3
            // 
            this.hIeuThuoc_QuocCuongDataSet3.DataSetName = "HIeuThuoc_QuocCuongDataSet3";
            this.hIeuThuoc_QuocCuongDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnADd
            // 
            this.btnADd.Location = new System.Drawing.Point(447, 157);
            this.btnADd.Name = "btnADd";
            this.btnADd.Size = new System.Drawing.Size(118, 41);
            this.btnADd.TabIndex = 10;
            this.btnADd.Text = "Thêm";
            this.btnADd.UseVisualStyleBackColor = true;
            this.btnADd.Click += new System.EventHandler(this.btnADd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(616, 157);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 41);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(250, 226);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(299, 20);
            this.txtMa.TabIndex = 1;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(250, 261);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(299, 20);
            this.txtHoten.TabIndex = 2;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(810, 263);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(300, 20);
            this.txtdiachi.TabIndex = 6;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(810, 228);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(300, 20);
            this.txtTuoi.TabIndex = 5;
            // 
            // txtChuc
            // 
            this.txtChuc.Location = new System.Drawing.Point(250, 293);
            this.txtChuc.Name = "txtChuc";
            this.txtChuc.Size = new System.Drawing.Size(299, 20);
            this.txtChuc.TabIndex = 3;
            this.txtChuc.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(810, 330);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(810, 295);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(300, 20);
            this.txtMail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã nv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(746, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "tuổi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(746, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(746, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(746, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Số đt";
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioitinh.Location = new System.Drawing.Point(250, 335);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(299, 21);
            this.cbGioitinh.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(992, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
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
            this.lậpHóaĐơnToolStripMenuItem.Name = "lậpHóaĐơnToolStripMenuItem";
            this.lậpHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.lậpHóaĐơnToolStripMenuItem.Text = "Lập hóa đơn";
            this.lậpHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.lậpHóaĐơnToolStripMenuItem_Click);
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
            this.btnFix.Location = new System.Drawing.Point(792, 157);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(117, 41);
            this.btnFix.TabIndex = 12;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1194, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(285, 157);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(105, 41);
            this.btnNhap.TabIndex = 9;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            this.nhanvienBindingSource.DataSource = this.hieu_thuocDataSet;
            // 
            // hieu_thuocDataSet
            // 
            this.hieu_thuocDataSet.DataSetName = "hieu_thuocDataSet";
            this.hieu_thuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // nhanvienTableAdapter1
            // 
            this.nhanvienTableAdapter1.ClearBeforeFill = true;
            // 
            // btnXuats
            // 
            this.btnXuats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXuats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuats.Location = new System.Drawing.Point(587, 395);
            this.btnXuats.Name = "btnXuats";
            this.btnXuats.Size = new System.Drawing.Size(125, 41);
            this.btnXuats.TabIndex = 15;
            this.btnXuats.Text = "Xuất file";
            this.btnXuats.UseVisualStyleBackColor = false;
            this.btnXuats.Click += new System.EventHandler(this.btnXuats_Click);
            // 
            // capnhat_thongtinnhanvienn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnXuats);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbGioitinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtChuc);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnADd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "capnhat_thongtinnhanvienn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "capnhat_thongtinnhanvienn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.AutoSizeChanged += new System.EventHandler(this.capnhat_thongtinnhanvienn_Load);
            this.MaximizedBoundsChanged += new System.EventHandler(this.capnhat_thongtinnhanvienn_Load);
            this.MaximumSizeChanged += new System.EventHandler(this.capnhat_thongtinnhanvienn_Load);
            this.Load += new System.EventHandler(this.capnhat_thongtinnhanvienn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIeuThuoc_QuocCuongDataSet3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hieu_thuocDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private hieu_thuocDataSet hieu_thuocDataSet;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private hieu_thuocDataSetTableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
        private System.Windows.Forms.Button btnADd;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtChuc;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNhap;
        private HIeuThuoc_QuocCuongDataSet3 hIeuThuoc_QuocCuongDataSet3;
        private System.Windows.Forms.BindingSource nhanvienBindingSource1;
        private HIeuThuoc_QuocCuongDataSet3TableAdapters.nhanvienTableAdapter nhanvienTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendangnhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnXuats;
    }
}
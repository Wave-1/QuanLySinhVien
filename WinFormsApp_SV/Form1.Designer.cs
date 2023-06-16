namespace WinFormsApp_SV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbHocLuc = new ComboBox();
            cbGioiTinh = new ComboBox();
            label10 = new Label();
            tbDiemTB = new TextBox();
            label9 = new Label();
            tbDiemAnh = new TextBox();
            label8 = new Label();
            tbDiemVan = new TextBox();
            label7 = new Label();
            tbDiemToan = new TextBox();
            label6 = new Label();
            tbTuoi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tbTen = new TextBox();
            label3 = new Label();
            tbId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvDanhSachSV = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            Tuoi = new DataGridViewTextBoxColumn();
            DiemToan = new DataGridViewTextBoxColumn();
            DiemVan = new DataGridViewTextBoxColumn();
            DiemAnh = new DataGridViewTextBoxColumn();
            DiemTB = new DataGridViewTextBoxColumn();
            HocLuc = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            textBox1 = new TextBox();
            btnTim = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSV).BeginInit();
            SuspendLayout();
            // 
            // cbHocLuc
            // 
            cbHocLuc.FormattingEnabled = true;
            cbHocLuc.Items.AddRange(new object[] { "Giỏi", "Khá", "Trung bình", "Yếu" });
            cbHocLuc.Location = new Point(401, 337);
            cbHocLuc.Name = "cbHocLuc";
            cbHocLuc.Size = new Size(125, 28);
            cbHocLuc.TabIndex = 40;
            cbHocLuc.SelectedIndexChanged += cbHocLuc_SelectedIndexChanged;
            cbHocLuc.KeyPress += cbHocLuc_KeyPress;
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Items.AddRange(new object[] { "Nam ", "Nữ", "Không Xác Định" });
            cbGioiTinh.Location = new Point(107, 239);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(143, 28);
            cbGioiTinh.TabIndex = 39;
            cbGioiTinh.KeyPress += cbGioiTinh_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(300, 340);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 38;
            label10.Text = "Học lực";
            // 
            // tbDiemTB
            // 
            tbDiemTB.Location = new Point(401, 289);
            tbDiemTB.Name = "tbDiemTB";
            tbDiemTB.Size = new Size(125, 27);
            tbDiemTB.TabIndex = 37;
            tbDiemTB.KeyPress += tbDiemTB_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(300, 292);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 36;
            label9.Text = "Điểm TB";
            // 
            // tbDiemAnh
            // 
            tbDiemAnh.Location = new Point(401, 242);
            tbDiemAnh.Name = "tbDiemAnh";
            tbDiemAnh.Size = new Size(125, 27);
            tbDiemAnh.TabIndex = 35;
            tbDiemAnh.TextChanged += tbDiemAnh_TextChanged;
            tbDiemAnh.KeyPress += tbDiemAnh_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(300, 248);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 34;
            label8.Text = "Điểm anh";
            // 
            // tbDiemVan
            // 
            tbDiemVan.Location = new Point(401, 194);
            tbDiemVan.Name = "tbDiemVan";
            tbDiemVan.Size = new Size(125, 27);
            tbDiemVan.TabIndex = 33;
            tbDiemVan.TextChanged += tbDiemVan_TextChanged;
            tbDiemVan.KeyPress += tbDiemVan_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(300, 200);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 32;
            label7.Text = "Điểm văn";
            // 
            // tbDiemToan
            // 
            tbDiemToan.Location = new Point(401, 146);
            tbDiemToan.Name = "tbDiemToan";
            tbDiemToan.Size = new Size(125, 27);
            tbDiemToan.TabIndex = 31;
            tbDiemToan.TextChanged += tbDiemToan_TextChanged;
            tbDiemToan.KeyPress += tbDiemToan_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 152);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 30;
            label6.Text = "Điểm toán";
            // 
            // tbTuoi
            // 
            tbTuoi.Location = new Point(109, 289);
            tbTuoi.Name = "tbTuoi";
            tbTuoi.Size = new Size(141, 27);
            tbTuoi.TabIndex = 29;
            tbTuoi.KeyPress += tbTuoi_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 292);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 28;
            label5.Text = "Tuổi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 242);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 27;
            label4.Text = "Giới tính";
            // 
            // tbTen
            // 
            tbTen.Location = new Point(109, 194);
            tbTen.Name = "tbTen";
            tbTen.Size = new Size(141, 27);
            tbTen.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 197);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 25;
            label3.Text = "Tên";
            // 
            // tbId
            // 
            tbId.Location = new Point(109, 149);
            tbId.Name = "tbId";
            tbId.Size = new Size(141, 27);
            tbId.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 152);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 23;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(341, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 31);
            label1.TabIndex = 22;
            label1.Text = "Quản Lý Sinh Viên";
            // 
            // dgvDanhSachSV
            // 
            dgvDanhSachSV.AllowUserToAddRows = false;
            dgvDanhSachSV.AllowUserToDeleteRows = false;
            dgvDanhSachSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachSV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDanhSachSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSV.Columns.AddRange(new DataGridViewColumn[] { ID, Ten, GioiTinh, Tuoi, DiemToan, DiemVan, DiemAnh, DiemTB, HocLuc });
            dgvDanhSachSV.Dock = DockStyle.Bottom;
            dgvDanhSachSV.Location = new Point(0, 391);
            dgvDanhSachSV.Name = "dgvDanhSachSV";
            dgvDanhSachSV.ReadOnly = true;
            dgvDanhSachSV.RowHeadersWidth = 51;
            dgvDanhSachSV.RowTemplate.Height = 29;
            dgvDanhSachSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachSV.Size = new Size(1020, 383);
            dgvDanhSachSV.TabIndex = 41;
            dgvDanhSachSV.CellClick += dgvDanhSachSV_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Ten
            // 
            Ten.DataPropertyName = "Ten";
            Ten.HeaderText = "Tên";
            Ten.MinimumWidth = 6;
            Ten.Name = "Ten";
            Ten.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // Tuoi
            // 
            Tuoi.DataPropertyName = "Tuoi";
            Tuoi.HeaderText = "Tuổi";
            Tuoi.MinimumWidth = 6;
            Tuoi.Name = "Tuoi";
            Tuoi.ReadOnly = true;
            // 
            // DiemToan
            // 
            DiemToan.DataPropertyName = "DiemToan";
            DiemToan.HeaderText = "Điểm Toán";
            DiemToan.MinimumWidth = 6;
            DiemToan.Name = "DiemToan";
            DiemToan.ReadOnly = true;
            // 
            // DiemVan
            // 
            DiemVan.DataPropertyName = "DiemVan";
            DiemVan.HeaderText = "Điểm Văn";
            DiemVan.MinimumWidth = 6;
            DiemVan.Name = "DiemVan";
            DiemVan.ReadOnly = true;
            // 
            // DiemAnh
            // 
            DiemAnh.DataPropertyName = "DiemAnh";
            DiemAnh.HeaderText = "Điểm Anh";
            DiemAnh.MinimumWidth = 6;
            DiemAnh.Name = "DiemAnh";
            DiemAnh.ReadOnly = true;
            // 
            // DiemTB
            // 
            DiemTB.DataPropertyName = "DiemTB";
            DiemTB.HeaderText = "Điểm TB";
            DiemTB.MinimumWidth = 6;
            DiemTB.Name = "DiemTB";
            DiemTB.ReadOnly = true;
            // 
            // HocLuc
            // 
            HocLuc.DataPropertyName = "HocLuc";
            HocLuc.HeaderText = "Học Lực";
            HocLuc.MinimumWidth = 6;
            HocLuc.Name = "HocLuc";
            HocLuc.ReadOnly = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(649, 162);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 42;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(649, 221);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 43;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(649, 283);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 45;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 27);
            textBox1.TabIndex = 47;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(442, 83);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 48;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 774);
            Controls.Add(btnTim);
            Controls.Add(textBox1);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dgvDanhSachSV);
            Controls.Add(cbHocLuc);
            Controls.Add(cbGioiTinh);
            Controls.Add(label10);
            Controls.Add(tbDiemTB);
            Controls.Add(label9);
            Controls.Add(tbDiemAnh);
            Controls.Add(label8);
            Controls.Add(tbDiemVan);
            Controls.Add(label7);
            Controls.Add(tbDiemToan);
            Controls.Add(label6);
            Controls.Add(tbTuoi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbTen);
            Controls.Add(label3);
            Controls.Add(tbId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbHocLuc;
        private ComboBox cbGioiTinh;
        private Label label10;
        private TextBox tbDiemTB;
        private Label label9;
        private TextBox tbDiemAnh;
        private Label label8;
        private TextBox tbDiemVan;
        private Label label7;
        private TextBox tbDiemToan;
        private Label label6;
        private TextBox tbTuoi;
        private Label label5;
        private Label label4;
        private TextBox tbTen;
        private Label label3;
        private TextBox tbId;
        private Label label2;
        private Label label1;
        private DataGridView dgvDanhSachSV;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn Tuoi;
        private DataGridViewTextBoxColumn DiemToan;
        private DataGridViewTextBoxColumn DiemVan;
        private DataGridViewTextBoxColumn DiemAnh;
        private DataGridViewTextBoxColumn DiemTB;
        private DataGridViewTextBoxColumn HocLuc;
        private TextBox textBox1;
        private Button btnTim;
    }
}
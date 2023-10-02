namespace C3_Bai2
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
            groupBox3 = new GroupBox();
            dtgSach = new DataGridView();
            txtTimKiem = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btnHienThi = new Button();
            btnXoaForm = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            cmbxNXB = new ComboBox();
            txtMa = new TextBox();
            txtTen = new TextBox();
            rbtnHetHang = new RadioButton();
            rbtnConHang = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgSach).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgSach);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(178, 344);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(788, 204);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hiển thị";
            // 
            // dtgSach
            // 
            dtgSach.BackgroundColor = SystemColors.ButtonShadow;
            dtgSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSach.GridColor = SystemColors.GradientActiveCaption;
            dtgSach.Location = new Point(0, 70);
            dtgSach.Name = "dtgSach";
            dtgSach.RowHeadersWidth = 51;
            dtgSach.RowTemplate.Height = 29;
            dtgSach.Size = new Size(788, 134);
            dtgSach.TabIndex = 9;
            dtgSach.CellContentClick += dtgSach_CellContentClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(130, 37);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(372, 27);
            txtTimKiem.TabIndex = 8;
            txtTimKiem.Text = "Nhập tên để tìm kiếm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 40);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnHienThi);
            groupBox2.Controls.Add(btnXoaForm);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(686, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 238);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(6, 137);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(268, 42);
            btnHienThi.TabIndex = 3;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnXoaForm
            // 
            btnXoaForm.Location = new Point(6, 190);
            btnXoaForm.Name = "btnXoaForm";
            btnXoaForm.Size = new Size(268, 42);
            btnXoaForm.TabIndex = 2;
            btnXoaForm.Text = "Xóa form";
            btnXoaForm.UseVisualStyleBackColor = true;
            btnXoaForm.Click += btnXoaForm_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(6, 84);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(268, 42);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(268, 42);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbxNXB);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(rbtnHetHang);
            groupBox1.Controls.Add(rbtnConHang);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(178, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 233);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // cmbxNXB
            // 
            cmbxNXB.FormattingEnabled = true;
            cmbxNXB.Location = new Point(130, 174);
            cmbxNXB.Name = "cmbxNXB";
            cmbxNXB.Size = new Size(280, 28);
            cmbxNXB.TabIndex = 8;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(130, 85);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(280, 27);
            txtMa.TabIndex = 7;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(130, 39);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(280, 27);
            txtTen.TabIndex = 6;
            // 
            // rbtnHetHang
            // 
            rbtnHetHang.AutoSize = true;
            rbtnHetHang.Location = new Point(319, 131);
            rbtnHetHang.Name = "rbtnHetHang";
            rbtnHetHang.Size = new Size(91, 24);
            rbtnHetHang.TabIndex = 5;
            rbtnHetHang.TabStop = true;
            rbtnHetHang.Text = "Hết hàng";
            rbtnHetHang.UseVisualStyleBackColor = true;
            // 
            // rbtnConHang
            // 
            rbtnConHang.AutoSize = true;
            rbtnConHang.Location = new Point(130, 130);
            rbtnConHang.Name = "rbtnConHang";
            rbtnConHang.Size = new Size(93, 24);
            rbtnConHang.TabIndex = 4;
            rbtnConHang.TabStop = true;
            rbtnConHang.Text = "Còn hàng";
            rbtnConHang.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 177);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Nhà xuất bản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 132);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 87);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 42);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 652);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgSach).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dtgSach;
        private TextBox txtTimKiem;
        private Label label5;
        private GroupBox groupBox2;
        private Button btnHienThi;
        private Button btnXoaForm;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox1;
        private ComboBox cmbxNXB;
        private TextBox txtMa;
        private TextBox txtTen;
        private RadioButton rbtnHetHang;
        private RadioButton rbtnConHang;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
namespace btlquanlycuahanginternet
{
    partial class frmTKNV
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
            this.dataGridView_TKNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.msknamsinh = new System.Windows.Forms.MaskedTextBox();
            this.cbomaca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btntrove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TKNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_TKNV
            // 
            this.dataGridView_TKNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TKNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.MaCa,
            this.NamSinh,
            this.GioiTinh,
            this.DiaChi,
            this.SDT});
            this.dataGridView_TKNV.Location = new System.Drawing.Point(21, 158);
            this.dataGridView_TKNV.Name = "dataGridView_TKNV";
            this.dataGridView_TKNV.Size = new System.Drawing.Size(744, 150);
            this.dataGridView_TKNV.TabIndex = 0;
            this.dataGridView_TKNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TKNV_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.Name = "TenNV";
            // 
            // MaCa
            // 
            this.MaCa.DataPropertyName = "MaCa";
            this.MaCa.HeaderText = "Mã Ca";
            this.MaCa.Name = "MaCa";
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm Sinh";
            this.NamSinh.Name = "NamSinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Ca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Năm Sinh";
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(92, 16);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(100, 20);
            this.txttennv.TabIndex = 7;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(92, 46);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(100, 20);
            this.txtmanv.TabIndex = 9;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(391, 42);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(100, 20);
            this.txtdiachi.TabIndex = 10;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Location = new System.Drawing.Point(391, 16);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(100, 20);
            this.txtgioitinh.TabIndex = 11;
            // 
            // msknamsinh
            // 
            this.msknamsinh.Location = new System.Drawing.Point(92, 108);
            this.msknamsinh.Mask = "00/00/0000";
            this.msknamsinh.Name = "msknamsinh";
            this.msknamsinh.Size = new System.Drawing.Size(100, 20);
            this.msknamsinh.TabIndex = 12;
            this.msknamsinh.ValidatingType = typeof(System.DateTime);
            // 
            // cbomaca
            // 
            this.cbomaca.FormattingEnabled = true;
            this.cbomaca.Location = new System.Drawing.Point(92, 74);
            this.cbomaca.Name = "cbomaca";
            this.cbomaca.Size = new System.Drawing.Size(100, 21);
            this.cbomaca.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "SDT";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(391, 74);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(100, 20);
            this.txtsdt.TabIndex = 15;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(21, 328);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 16;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(690, 328);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 17;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(488, 328);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 18;
            this.btntimkiem.Text = "TÌM KIẾM";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(391, 328);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 19;
            this.btnhuy.Text = "HỦY";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(302, 328);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 20;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(211, 328);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 21;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(117, 328);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 22;
            this.btnluu.Text = "LƯU";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(590, 328);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 23);
            this.btnin.TabIndex = 23;
            this.btnin.Text = "IN";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btntrove
            // 
            this.btntrove.Location = new System.Drawing.Point(21, 357);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(75, 23);
            this.btntrove.TabIndex = 24;
            this.btntrove.Text = "Trở Về";
            this.btntrove.UseVisualStyleBackColor = true;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // frmTKNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbomaca);
            this.Controls.Add(this.msknamsinh);
            this.Controls.Add(this.txtgioitinh);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_TKNV);
            this.Name = "frmTKNV";
            this.Text = "frmTKNV";
            this.Load += new System.EventHandler(this.frmTKNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TKNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_TKNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.MaskedTextBox msknamsinh;
        private System.Windows.Forms.ComboBox cbomaca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btntrove;
    }
}
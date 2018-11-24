namespace GUI_QLRV
{
    partial class Fkhachhang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txttimkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkhid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.rdonam = new System.Windows.Forms.RadioButton();
            this.rdonu = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdonu);
            this.panel1.Controls.Add(this.rdonam);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtsdt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txthoten);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtkhid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 569);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvkhachhang);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 569);
            this.panel2.TabIndex = 1;
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvkhachhang.Location = new System.Drawing.Point(0, 53);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.Size = new System.Drawing.Size(537, 516);
            this.dgvkhachhang.TabIndex = 1;
            this.dgvkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhachhang_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txttimkh);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 53);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm khách hàng :";
            // 
            // txttimkh
            // 
            this.txttimkh.Location = new System.Drawing.Point(129, 15);
            this.txttimkh.Name = "txttimkh";
            this.txttimkh.Size = new System.Drawing.Size(208, 20);
            this.txttimkh.TabIndex = 1;
            this.txttimkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttimkh_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "KHID :";
            // 
            // txtkhid
            // 
            this.txtkhid.Location = new System.Drawing.Point(12, 38);
            this.txtkhid.Name = "txtkhid";
            this.txtkhid.Size = new System.Drawing.Size(155, 20);
            this.txtkhid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên :";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(12, 84);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(155, 20);
            this.txthoten.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại :";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(12, 137);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(155, 20);
            this.txtsdt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ :";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(12, 192);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(155, 20);
            this.txtdiachi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(48, 331);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(95, 29);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(48, 379);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(95, 29);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(48, 428);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(95, 29);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // rdonam
            // 
            this.rdonam.AutoSize = true;
            this.rdonam.Location = new System.Drawing.Point(25, 255);
            this.rdonam.Name = "rdonam";
            this.rdonam.Size = new System.Drawing.Size(47, 17);
            this.rdonam.TabIndex = 3;
            this.rdonam.TabStop = true;
            this.rdonam.Text = "Nam";
            this.rdonam.UseVisualStyleBackColor = true;
            // 
            // rdonu
            // 
            this.rdonu.AutoSize = true;
            this.rdonu.Location = new System.Drawing.Point(25, 278);
            this.rdonu.Name = "rdonu";
            this.rdonu.Size = new System.Drawing.Size(39, 17);
            this.rdonu.TabIndex = 3;
            this.rdonu.TabStop = true;
            this.rdonu.Text = "Nữ";
            this.rdonu.UseVisualStyleBackColor = true;
            // 
            // Fkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 569);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Fkhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fkhachhang";
            this.Load += new System.EventHandler(this.Fkhachhang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdonu;
        private System.Windows.Forms.RadioButton rdonam;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkhid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttimkh;
        private System.Windows.Forms.Label label1;
    }
}
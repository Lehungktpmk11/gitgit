namespace GUI_QLRV
{
    partial class Fsanpham
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
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtgiasp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtspid = new System.Windows.Forms.TextBox();
            this.lblspid = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txttimsanpham = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.txtgiasp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttensp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtspid);
            this.panel1.Controls.Add(this.lblspid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 474);
            this.panel1.TabIndex = 0;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(58, 367);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(86, 35);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(58, 308);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(86, 35);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(58, 252);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(86, 35);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtgiasp
            // 
            this.txtgiasp.Location = new System.Drawing.Point(16, 180);
            this.txtgiasp.Name = "txtgiasp";
            this.txtgiasp.Size = new System.Drawing.Size(158, 20);
            this.txtgiasp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá :";
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(16, 119);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(158, 20);
            this.txttensp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm ;";
            // 
            // txtspid
            // 
            this.txtspid.Location = new System.Drawing.Point(16, 56);
            this.txtspid.Name = "txtspid";
            this.txtspid.Size = new System.Drawing.Size(158, 20);
            this.txtspid.TabIndex = 1;
            // 
            // lblspid
            // 
            this.lblspid.AutoSize = true;
            this.lblspid.Location = new System.Drawing.Point(18, 32);
            this.lblspid.Name = "lblspid";
            this.lblspid.Size = new System.Drawing.Size(38, 13);
            this.lblspid.TabIndex = 0;
            this.lblspid.Text = "SPID :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvsanpham);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 474);
            this.panel2.TabIndex = 1;
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsanpham.Location = new System.Drawing.Point(0, 45);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.Size = new System.Drawing.Size(361, 429);
            this.dgvsanpham.TabIndex = 1;
            this.dgvsanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txttimsanpham);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 45);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tìm sản phẩm :";
            // 
            // txttimsanpham
            // 
            this.txttimsanpham.Location = new System.Drawing.Point(120, 12);
            this.txttimsanpham.Name = "txttimsanpham";
            this.txttimsanpham.Size = new System.Drawing.Size(158, 20);
            this.txttimsanpham.TabIndex = 0;
            this.txttimsanpham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttimsanpham_KeyPress);
            // 
            // Fsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Fsanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fsanpham";
            this.Load += new System.EventHandler(this.Fsanpham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtgiasp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtspid;
        private System.Windows.Forms.Label lblspid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttimsanpham;
    }
}
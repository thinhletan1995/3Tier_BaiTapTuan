namespace PresentationTier
{
    partial class MainForm
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
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstDanhMuc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(12, 291);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(187, 36);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem Danh Sách Sản Phẩm";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(205, 291);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(188, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa Danh Sách Sản Phẩm";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(399, 291);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(187, 36);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát Chương Trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lstDanhMuc
            // 
            this.lstDanhMuc.FormattingEnabled = true;
            this.lstDanhMuc.Location = new System.Drawing.Point(12, 12);
            this.lstDanhMuc.Name = "lstDanhMuc";
            this.lstDanhMuc.Size = new System.Drawing.Size(575, 251);
            this.lstDanhMuc.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 353);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.lstDanhMuc);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListBox lstDanhMuc;
    }
}


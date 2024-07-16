namespace PRL
{
    partial class NhanVien_NhapHang
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
            ID_NV = new TextBox();
            ID_SP_VN = new TextBox();
            SL_NV = new TextBox();
            DATE_NV = new TextBox();
            ID_CH_NV = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // ID_NV
            // 
            ID_NV.Font = new Font("Times New Roman", 16.2F);
            ID_NV.Location = new Point(281, 188);
            ID_NV.Name = "ID_NV";
            ID_NV.Size = new Size(386, 39);
            ID_NV.TabIndex = 25;
            // 
            // ID_SP_VN
            // 
            ID_SP_VN.Font = new Font("Times New Roman", 16.2F);
            ID_SP_VN.Location = new Point(281, 143);
            ID_SP_VN.Name = "ID_SP_VN";
            ID_SP_VN.Size = new Size(386, 39);
            ID_SP_VN.TabIndex = 24;
            // 
            // SL_NV
            // 
            SL_NV.Font = new Font("Times New Roman", 16.2F);
            SL_NV.Location = new Point(281, 235);
            SL_NV.Name = "SL_NV";
            SL_NV.Size = new Size(386, 39);
            SL_NV.TabIndex = 23;
            // 
            // DATE_NV
            // 
            DATE_NV.Font = new Font("Times New Roman", 16.2F);
            DATE_NV.Location = new Point(281, 278);
            DATE_NV.Name = "DATE_NV";
            DATE_NV.Size = new Size(386, 39);
            DATE_NV.TabIndex = 22;
            // 
            // ID_CH_NV
            // 
            ID_CH_NV.Font = new Font("Times New Roman", 16.2F);
            ID_CH_NV.Location = new Point(281, 98);
            ID_CH_NV.Name = "ID_CH_NV";
            ID_CH_NV.Size = new Size(386, 39);
            ID_CH_NV.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label6.Location = new Point(106, 280);
            label6.Name = "label6";
            label6.Size = new Size(136, 32);
            label6.TabIndex = 18;
            label6.Text = "Ngày xuất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label5.Location = new Point(106, 235);
            label5.Name = "label5";
            label5.Size = new Size(122, 32);
            label5.TabIndex = 17;
            label5.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label4.Location = new Point(106, 190);
            label4.Name = "label4";
            label4.Size = new Size(174, 32);
            label4.TabIndex = 16;
            label4.Text = "ID Nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label3.Location = new Point(106, 142);
            label3.Name = "label3";
            label3.Size = new Size(172, 32);
            label3.TabIndex = 15;
            label3.Text = "ID Sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label2.Location = new Point(106, 100);
            label2.Name = "label2";
            label2.Size = new Size(169, 32);
            label2.TabIndex = 14;
            label2.Text = "ID Cửa hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 31);
            label1.Name = "label1";
            label1.Size = new Size(213, 44);
            label1.TabIndex = 13;
            label1.Text = "Nhập hàng";
            // 
            // NhanVien_NhapHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ID_NV);
            Controls.Add(ID_SP_VN);
            Controls.Add(SL_NV);
            Controls.Add(DATE_NV);
            Controls.Add(ID_CH_NV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NhanVien_NhapHang";
            Text = "NhanVien_NhapHang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ID_NV;
        private TextBox ID_SP_VN;
        private TextBox SL_NV;
        private TextBox DATE_NV;
        private TextBox ID_CH_NV;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
namespace PRL
{
    partial class Nhan_vien
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            panel1.Location = new Point(169, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 139);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 192);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 677);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(285, 21);
            label1.Name = "label1";
            label1.Size = new Size(422, 60);
            label1.TabIndex = 0;
            label1.Text = "Quản lý bán hàng";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.nền;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(171, 139);
            button1.TabIndex = 0;
            button1.Text = "MENU";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.nền1;
            button2.Location = new Point(-1, 136);
            button2.Name = "button2";
            button2.Size = new Size(171, 102);
            button2.TabIndex = 1;
            button2.Text = "Hóa đơn";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.nền1;
            button3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 235);
            button3.Name = "button3";
            button3.Size = new Size(171, 103);
            button3.TabIndex = 2;
            button3.Text = "Nhập hàng";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.nền1;
            button4.Location = new Point(0, 590);
            button4.Name = "button4";
            button4.Size = new Size(171, 84);
            button4.TabIndex = 3;
            button4.Text = "Thông tin nhân viên";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FPT_Polytechnic;
            pictureBox1.Location = new Point(221, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(824, 297);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Nhan_vien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1073, 671);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "Nhan_vien";
            Text = "Nhan_vien";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
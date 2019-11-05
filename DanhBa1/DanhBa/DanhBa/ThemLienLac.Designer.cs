namespace DanhBa
{
    partial class ThemLienLac
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_tenLienLac = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_soDienThoai = new System.Windows.Forms.TextBox();
            this.textBox_diaChi = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_them = new System.Windows.Forms.Button();
            this.bindingSource_nhom = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_nhom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên liên lạc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhóm";
            // 
            // textBox_tenLienLac
            // 
            this.textBox_tenLienLac.Location = new System.Drawing.Point(199, 64);
            this.textBox_tenLienLac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_tenLienLac.Name = "textBox_tenLienLac";
            this.textBox_tenLienLac.Size = new System.Drawing.Size(160, 20);
            this.textBox_tenLienLac.TabIndex = 5;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(199, 97);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(160, 20);
            this.textBox_email.TabIndex = 6;
            // 
            // textBox_soDienThoai
            // 
            this.textBox_soDienThoai.Location = new System.Drawing.Point(199, 128);
            this.textBox_soDienThoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_soDienThoai.Name = "textBox_soDienThoai";
            this.textBox_soDienThoai.Size = new System.Drawing.Size(160, 20);
            this.textBox_soDienThoai.TabIndex = 7;
            // 
            // textBox_diaChi
            // 
            this.textBox_diaChi.Location = new System.Drawing.Point(199, 162);
            this.textBox_diaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_diaChi.Name = "textBox_diaChi";
            this.textBox_diaChi.Size = new System.Drawing.Size(160, 20);
            this.textBox_diaChi.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 189);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(189, 251);
            this.button_them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(56, 19);
            this.button_them.TabIndex = 10;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // ThemLienLac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 366);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_diaChi);
            this.Controls.Add(this.textBox_soDienThoai);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_tenLienLac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThemLienLac";
            this.Text = "Thêm Liên Lạc";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_nhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_tenLienLac;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_soDienThoai;
        private System.Windows.Forms.TextBox textBox_diaChi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.BindingSource bindingSource_nhom;
    }
}
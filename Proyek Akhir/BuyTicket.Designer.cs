namespace Proyek_Akhir {
    partial class BuyTicket {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox_detailPenerbangan = new System.Windows.Forms.GroupBox();
            this.label_tanggal_pulang = new System.Windows.Forms.Label();
            this.dateTimePicker_pulang = new System.Windows.Forms.DateTimePicker();
            this.label_tanggal_pergi = new System.Windows.Forms.Label();
            this.dateTimePicker_pergi = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_pulang_pergi = new System.Windows.Forms.RadioButton();
            this.radioButton_sekali_jalan = new System.Windows.Forms.RadioButton();
            this.comboBox_ke = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_dari = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2_detailPenumpang = new System.Windows.Forms.GroupBox();
            this.incrementBayi = new System.Windows.Forms.Button();
            this.textBox_bayi = new System.Windows.Forms.TextBox();
            this.decrementBayi = new System.Windows.Forms.Button();
            this.incrementAnak = new System.Windows.Forms.Button();
            this.textBox_anak = new System.Windows.Forms.TextBox();
            this.decrementAnak = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.incrementDewasa = new System.Windows.Forms.Button();
            this.textBox_dewasa = new System.Windows.Forms.TextBox();
            this.decrementDewasa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_detailPenerbangan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2_detailPenumpang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_detailPenerbangan
            // 
            this.groupBox_detailPenerbangan.Controls.Add(this.label_tanggal_pulang);
            this.groupBox_detailPenerbangan.Controls.Add(this.dateTimePicker_pulang);
            this.groupBox_detailPenerbangan.Controls.Add(this.label_tanggal_pergi);
            this.groupBox_detailPenerbangan.Controls.Add(this.dateTimePicker_pergi);
            this.groupBox_detailPenerbangan.Controls.Add(this.panel1);
            this.groupBox_detailPenerbangan.Controls.Add(this.comboBox_ke);
            this.groupBox_detailPenerbangan.Controls.Add(this.label3);
            this.groupBox_detailPenerbangan.Controls.Add(this.label2);
            this.groupBox_detailPenerbangan.Controls.Add(this.comboBox_dari);
            this.groupBox_detailPenerbangan.Location = new System.Drawing.Point(19, 72);
            this.groupBox_detailPenerbangan.Name = "groupBox_detailPenerbangan";
            this.groupBox_detailPenerbangan.Size = new System.Drawing.Size(265, 280);
            this.groupBox_detailPenerbangan.TabIndex = 1;
            this.groupBox_detailPenerbangan.TabStop = false;
            this.groupBox_detailPenerbangan.Text = "Detail Penerbangan";
            this.groupBox_detailPenerbangan.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label_tanggal_pulang
            // 
            this.label_tanggal_pulang.AutoSize = true;
            this.label_tanggal_pulang.Location = new System.Drawing.Point(13, 224);
            this.label_tanggal_pulang.Name = "label_tanggal_pulang";
            this.label_tanggal_pulang.Size = new System.Drawing.Size(82, 13);
            this.label_tanggal_pulang.TabIndex = 11;
            this.label_tanggal_pulang.Text = "Tanggal Pulang";
            // 
            // dateTimePicker_pulang
            // 
            this.dateTimePicker_pulang.Location = new System.Drawing.Point(10, 240);
            this.dateTimePicker_pulang.Name = "dateTimePicker_pulang";
            this.dateTimePicker_pulang.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_pulang.TabIndex = 10;
            // 
            // label_tanggal_pergi
            // 
            this.label_tanggal_pergi.AutoSize = true;
            this.label_tanggal_pergi.Location = new System.Drawing.Point(13, 177);
            this.label_tanggal_pergi.Name = "label_tanggal_pergi";
            this.label_tanggal_pergi.Size = new System.Drawing.Size(73, 13);
            this.label_tanggal_pergi.TabIndex = 9;
            this.label_tanggal_pergi.Text = "Tanggal Pergi";
            // 
            // dateTimePicker_pergi
            // 
            this.dateTimePicker_pergi.Location = new System.Drawing.Point(10, 193);
            this.dateTimePicker_pergi.Name = "dateTimePicker_pergi";
            this.dateTimePicker_pergi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_pergi.TabIndex = 8;
            this.dateTimePicker_pergi.ValueChanged += new System.EventHandler(this.dateTimePicker_pergi_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_pulang_pergi);
            this.panel1.Controls.Add(this.radioButton_sekali_jalan);
            this.panel1.Location = new System.Drawing.Point(10, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 27);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButton_pulang_pergi
            // 
            this.radioButton_pulang_pergi.AutoSize = true;
            this.radioButton_pulang_pergi.Location = new System.Drawing.Point(100, 3);
            this.radioButton_pulang_pergi.Name = "radioButton_pulang_pergi";
            this.radioButton_pulang_pergi.Size = new System.Drawing.Size(85, 17);
            this.radioButton_pulang_pergi.TabIndex = 1;
            this.radioButton_pulang_pergi.Text = "Pulang Pergi";
            this.radioButton_pulang_pergi.UseVisualStyleBackColor = true;
            this.radioButton_pulang_pergi.CheckedChanged += new System.EventHandler(this.radioButton_pulang_pergi_CheckedChanged);
            // 
            // radioButton_sekali_jalan
            // 
            this.radioButton_sekali_jalan.AutoSize = true;
            this.radioButton_sekali_jalan.Checked = true;
            this.radioButton_sekali_jalan.Location = new System.Drawing.Point(3, 3);
            this.radioButton_sekali_jalan.Name = "radioButton_sekali_jalan";
            this.radioButton_sekali_jalan.Size = new System.Drawing.Size(82, 17);
            this.radioButton_sekali_jalan.TabIndex = 0;
            this.radioButton_sekali_jalan.TabStop = true;
            this.radioButton_sekali_jalan.Text = "Sekali Jalan";
            this.radioButton_sekali_jalan.UseVisualStyleBackColor = true;
            // 
            // comboBox_ke
            // 
            this.comboBox_ke.FormattingEnabled = true;
            this.comboBox_ke.Location = new System.Drawing.Point(10, 100);
            this.comboBox_ke.Name = "comboBox_ke";
            this.comboBox_ke.Size = new System.Drawing.Size(206, 21);
            this.comboBox_ke.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dari";
            // 
            // comboBox_dari
            // 
            this.comboBox_dari.FormattingEnabled = true;
            this.comboBox_dari.Location = new System.Drawing.Point(10, 47);
            this.comboBox_dari.Name = "comboBox_dari";
            this.comboBox_dari.Size = new System.Drawing.Size(206, 21);
            this.comboBox_dari.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Form Pembelian Tiket";
            // 
            // groupBox2_detailPenumpang
            // 
            this.groupBox2_detailPenumpang.Controls.Add(this.incrementBayi);
            this.groupBox2_detailPenumpang.Controls.Add(this.textBox_bayi);
            this.groupBox2_detailPenumpang.Controls.Add(this.decrementBayi);
            this.groupBox2_detailPenumpang.Controls.Add(this.incrementAnak);
            this.groupBox2_detailPenumpang.Controls.Add(this.textBox_anak);
            this.groupBox2_detailPenumpang.Controls.Add(this.decrementAnak);
            this.groupBox2_detailPenumpang.Controls.Add(this.label4);
            this.groupBox2_detailPenumpang.Controls.Add(this.incrementDewasa);
            this.groupBox2_detailPenumpang.Controls.Add(this.textBox_dewasa);
            this.groupBox2_detailPenumpang.Controls.Add(this.decrementDewasa);
            this.groupBox2_detailPenumpang.Controls.Add(this.label6);
            this.groupBox2_detailPenumpang.Controls.Add(this.label5);
            this.groupBox2_detailPenumpang.Location = new System.Drawing.Point(290, 72);
            this.groupBox2_detailPenumpang.Name = "groupBox2_detailPenumpang";
            this.groupBox2_detailPenumpang.Size = new System.Drawing.Size(278, 280);
            this.groupBox2_detailPenumpang.TabIndex = 3;
            this.groupBox2_detailPenumpang.TabStop = false;
            this.groupBox2_detailPenumpang.Text = "Detail Penumpang";
            // 
            // incrementBayi
            // 
            this.incrementBayi.Location = new System.Drawing.Point(144, 151);
            this.incrementBayi.Name = "incrementBayi";
            this.incrementBayi.Size = new System.Drawing.Size(23, 22);
            this.incrementBayi.TabIndex = 13;
            this.incrementBayi.Text = "+";
            this.incrementBayi.UseVisualStyleBackColor = true;
            this.incrementBayi.Click += new System.EventHandler(this.incrementBayi_Click);
            // 
            // textBox_bayi
            // 
            this.textBox_bayi.Enabled = false;
            this.textBox_bayi.Location = new System.Drawing.Point(39, 152);
            this.textBox_bayi.Name = "textBox_bayi";
            this.textBox_bayi.Size = new System.Drawing.Size(100, 20);
            this.textBox_bayi.TabIndex = 12;
            this.textBox_bayi.Text = "0";
            this.textBox_bayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // decrementBayi
            // 
            this.decrementBayi.Location = new System.Drawing.Point(10, 151);
            this.decrementBayi.Name = "decrementBayi";
            this.decrementBayi.Size = new System.Drawing.Size(23, 22);
            this.decrementBayi.TabIndex = 11;
            this.decrementBayi.Text = "-";
            this.decrementBayi.UseVisualStyleBackColor = true;
            this.decrementBayi.Click += new System.EventHandler(this.decrementBayi_Click);
            // 
            // incrementAnak
            // 
            this.incrementAnak.Location = new System.Drawing.Point(144, 98);
            this.incrementAnak.Name = "incrementAnak";
            this.incrementAnak.Size = new System.Drawing.Size(23, 22);
            this.incrementAnak.TabIndex = 10;
            this.incrementAnak.Text = "+";
            this.incrementAnak.UseVisualStyleBackColor = true;
            this.incrementAnak.Click += new System.EventHandler(this.incrementAnak_Click);
            // 
            // textBox_anak
            // 
            this.textBox_anak.Enabled = false;
            this.textBox_anak.Location = new System.Drawing.Point(39, 99);
            this.textBox_anak.Name = "textBox_anak";
            this.textBox_anak.Size = new System.Drawing.Size(100, 20);
            this.textBox_anak.TabIndex = 9;
            this.textBox_anak.Text = "0";
            this.textBox_anak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // decrementAnak
            // 
            this.decrementAnak.Location = new System.Drawing.Point(10, 98);
            this.decrementAnak.Name = "decrementAnak";
            this.decrementAnak.Size = new System.Drawing.Size(23, 22);
            this.decrementAnak.TabIndex = 8;
            this.decrementAnak.Text = "-";
            this.decrementAnak.UseVisualStyleBackColor = true;
            this.decrementAnak.Click += new System.EventHandler(this.decrementAnak_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bayi (<2 Tahun)";
            // 
            // incrementDewasa
            // 
            this.incrementDewasa.Location = new System.Drawing.Point(144, 47);
            this.incrementDewasa.Name = "incrementDewasa";
            this.incrementDewasa.Size = new System.Drawing.Size(23, 22);
            this.incrementDewasa.TabIndex = 7;
            this.incrementDewasa.Text = "+";
            this.incrementDewasa.UseVisualStyleBackColor = true;
            this.incrementDewasa.Click += new System.EventHandler(this.incrementDewasa_Click);
            // 
            // textBox_dewasa
            // 
            this.textBox_dewasa.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_dewasa.Enabled = false;
            this.textBox_dewasa.Location = new System.Drawing.Point(39, 48);
            this.textBox_dewasa.Name = "textBox_dewasa";
            this.textBox_dewasa.Size = new System.Drawing.Size(100, 20);
            this.textBox_dewasa.TabIndex = 6;
            this.textBox_dewasa.Text = "1";
            this.textBox_dewasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_dewasa.TextChanged += new System.EventHandler(this.textBox_dewasa_TextChanged);
            // 
            // decrementDewasa
            // 
            this.decrementDewasa.Location = new System.Drawing.Point(10, 47);
            this.decrementDewasa.Name = "decrementDewasa";
            this.decrementDewasa.Size = new System.Drawing.Size(23, 22);
            this.decrementDewasa.TabIndex = 5;
            this.decrementDewasa.Text = "-";
            this.decrementDewasa.UseVisualStyleBackColor = true;
            this.decrementDewasa.Click += new System.EventHandler(this.decrementDewasa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Anak-anak (2-11 Tahun";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dewasa (>11 Tahun)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search Flights...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 435);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2_detailPenumpang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_detailPenerbangan);
            this.Name = "BuyTicket";
            this.Text = "Buy Ticket";
            this.Load += new System.EventHandler(this.BuyTicket_Load);
            this.groupBox_detailPenerbangan.ResumeLayout(false);
            this.groupBox_detailPenerbangan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2_detailPenumpang.ResumeLayout(false);
            this.groupBox2_detailPenumpang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_detailPenerbangan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_pulang_pergi;
        private System.Windows.Forms.RadioButton radioButton_sekali_jalan;
        private System.Windows.Forms.ComboBox comboBox_ke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_dari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2_detailPenumpang;
        private System.Windows.Forms.Button incrementBayi;
        private System.Windows.Forms.TextBox textBox_bayi;
        private System.Windows.Forms.Button decrementBayi;
        private System.Windows.Forms.Button incrementAnak;
        private System.Windows.Forms.TextBox textBox_anak;
        private System.Windows.Forms.Button decrementAnak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button incrementDewasa;
        private System.Windows.Forms.TextBox textBox_dewasa;
        private System.Windows.Forms.Button decrementDewasa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_tanggal_pulang;
        private System.Windows.Forms.DateTimePicker dateTimePicker_pulang;
        private System.Windows.Forms.Label label_tanggal_pergi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_pergi;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
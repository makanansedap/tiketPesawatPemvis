using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyek_Akhir {
    public partial class BuyTicket : Form {
        int totalPenumpang = 1;
        public BuyTicket() {
            InitializeComponent();

            Color color1 = textBox_dewasa.BackColor;
            textBox_dewasa.BackColor = System.Drawing.Color.FromArgb(color1.A, color1.R, color1.G, color1.B);

            color1 = textBox_dewasa.ForeColor;
            textBox_dewasa.ForeColor = System.Drawing.Color.FromArgb(color1.A, color1.R, color1.G, color1.B);

            Color color2 = textBox_anak.BackColor;
            textBox_anak.BackColor = System.Drawing.Color.FromArgb(color2.A, color2.R, color2.G, color2.B);

            color2 = textBox_anak.ForeColor;
            textBox_anak.ForeColor = System.Drawing.Color.FromArgb(color2.A, color2.R, color2.G, color2.B);

            Color color3 = textBox_bayi.BackColor;
            textBox_bayi.BackColor = System.Drawing.Color.FromArgb(color3.A, color3.R, color3.G, color3.B);

            color3 = textBox_bayi.ForeColor;
            textBox_bayi.ForeColor = System.Drawing.Color.FromArgb(color3.A, color3.R, color3.G, color3.B);

            dateTimePicker_pergi.MinDate = DateTime.Now;
            dateTimePicker_pulang.MinDate = dateTimePicker_pergi.Value;

            label_tanggal_pulang.Visible = false;
            dateTimePicker_pulang.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void textBox_dewasa_TextChanged(object sender, EventArgs e) {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void incrementDewasa_Click(object sender, EventArgs e) {
            int jumlahDewasa = Int32.Parse(textBox_dewasa.Text);
            if (totalPenumpang < 9) {
                jumlahDewasa++;
                totalPenumpang++;
            }
            textBox_dewasa.Text = jumlahDewasa.ToString();
        }

        private void decrementDewasa_Click(object sender, EventArgs e) {
            int jumlahDewasa = Int32.Parse(textBox_dewasa.Text);
            int jumlahBayi = Int32.Parse(textBox_bayi.Text);
            if (jumlahDewasa > 1) {
                jumlahDewasa--;
                totalPenumpang--;
                if (jumlahDewasa < jumlahBayi) jumlahBayi--;
            }
            textBox_dewasa.Text = jumlahDewasa.ToString();
            textBox_bayi.Text = jumlahBayi.ToString();
        }

        private void incrementAnak_Click(object sender, EventArgs e) {
            int jumlahAnak = Int32.Parse(textBox_anak.Text);
            if (totalPenumpang < 9) {
                jumlahAnak++;
                totalPenumpang++;
            }
            textBox_anak.Text = jumlahAnak.ToString();
        }

        private void decrementAnak_Click(object sender, EventArgs e) {
            int jumlahAnak = Int32.Parse(textBox_anak.Text);
            if (jumlahAnak > 0) {
                jumlahAnak--;
                totalPenumpang--;
            }
            textBox_anak.Text = jumlahAnak.ToString();
        }

        private void incrementBayi_Click(object sender, EventArgs e) {
            int jumlahBayi = Int32.Parse(textBox_bayi.Text);
            int jumlahDewasa = Int32.Parse(textBox_dewasa.Text);
            if(jumlahBayi < jumlahDewasa) jumlahBayi++;
            textBox_bayi.Text = jumlahBayi.ToString();
        }

        private void decrementBayi_Click(object sender, EventArgs e) {
            int jumlahBayi = Int32.Parse(textBox_bayi.Text);
            int jumlahDewasa = Int32.Parse(textBox_dewasa.Text);
            if (jumlahBayi > 0) jumlahBayi--;
            textBox_bayi.Text = jumlahBayi.ToString();
        }

        private void BuyTicket_Load(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void radioButton_pulang_pergi_CheckedChanged(object sender, EventArgs e) {
            if (radioButton_pulang_pergi.Checked) {
                label_tanggal_pulang.Visible = true;
                dateTimePicker_pulang.Visible = true;
            }
            else {
                label_tanggal_pulang.Visible = false;
                dateTimePicker_pulang.Visible = false;
            }
        }

        private void dateTimePicker_pergi_ValueChanged(object sender, EventArgs e) {
            dateTimePicker_pulang.MinDate = dateTimePicker_pergi.Value;
        }
    }
}

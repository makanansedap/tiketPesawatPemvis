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
        private string conn;
        private MySqlConnection connection;
        MySqlDataReader reader;
        MySqlCommand da;

        private void connect_mysql() {
            try {
                conn = "Server = localhost; Database= ta_pemvis; uid = root; pwd=;";
                String query = "SELECT city, airport_name, IATA FROM airport_table";
                connection = new MySqlConnection(conn);                
                da = new MySqlCommand(query, connection);
                connection.Open();

            }
            catch (MySqlException e) {
                throw e;
            }
        }
        public BuyTicket() {
            InitializeComponent();

            connect_mysql();

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

            comboBox_dari.Items.Clear();
            comboBox_ke.Items.Clear();
            reader = da.ExecuteReader();
            while (reader.Read()) {
                string city = reader.GetString("city");
                string airport_name = reader.GetString("airport_name");
                string IATA = reader.GetString("IATA");
                comboBox_dari.Items.Add(String.Format("{0} ({1}), {2}", city, IATA, airport_name));
                comboBox_ke.Items.Add(String.Format("{0} ({1}), {2}", city, IATA, airport_name));
            }
            reader.Close();
            
            comboBox_dari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox_dari.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_dari.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox_ke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox_ke.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_ke.AutoCompleteSource = AutoCompleteSource.ListItems;
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
                ListFlight.one_way = false;
                PrintTiket.one_way = false;
            }
            else {
                label_tanggal_pulang.Visible = false;
                dateTimePicker_pulang.Visible = false;
            }
        }

        private void dateTimePicker_pergi_ValueChanged(object sender, EventArgs e) {
            dateTimePicker_pulang.MinDate = dateTimePicker_pergi.Value;
        }

        private void comboBox_dari_SelectedIndexChanged(object sender, EventArgs e) {
            comboBox_ke.Items.Clear();
            reader = da.ExecuteReader();
            while (reader.Read()) {
                string city = reader.GetString("city");
                string airport_name = reader.GetString("airport_name");
                string IATA = reader.GetString("IATA");
                comboBox_ke.Items.Add(String.Format("{0} ({1}), {2}", city, IATA, airport_name));
            }
            reader.Close();
            String selected = comboBox_dari.GetItemText(comboBox_dari.SelectedItem);
            comboBox_ke.Items.Remove(selected);

            PrintTiket.dari = comboBox_dari.GetItemText(comboBox_dari.SelectedItem);
            ListFlight.dari = comboBox_dari.GetItemText(comboBox_dari.SelectedItem);
        }

        private void comboBox_ke_SelectedIndexChanged(object sender, EventArgs e) {
            comboBox_dari.Items.Clear();
            reader = da.ExecuteReader();
            while (reader.Read()) {
                string city = reader.GetString("city");
                string airport_name = reader.GetString("airport_name");
                string IATA = reader.GetString("IATA");
                comboBox_dari.Items.Add(String.Format("{0} ({1}), {2}", city, IATA, airport_name));
            }
            reader.Close();
            String selected = comboBox_ke.GetItemText(comboBox_dari.SelectedItem);
            comboBox_dari.Items.Remove(selected);

            PrintTiket.ke = comboBox_ke.GetItemText(comboBox_ke.SelectedItem);
            ListFlight.ke = comboBox_ke.GetItemText(comboBox_ke.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e) {
            if(comboBox_dari.Text == "" || comboBox_ke.Text == "") {
                MessageBox.Show("Harap mengisi Detail Penerbangan dengan lengkap", "Notice", MessageBoxButtons.OK);
            }
            else {
                PrintTiket.dest_date = dateTimePicker_pergi.Value.ToString("dd MMM yyyy");
                PrintTiket.return_date = dateTimePicker_pulang.Value.ToString("dd MMM yyyy");

                NamaPenumpang.total_penumpang = totalPenumpang;

                ListFlight listflight = new ListFlight();
                listflight.StartPosition = FormStartPosition.Manual;
                listflight.Location = new Point(this.Location.X, this.Location.Y);
                this.Close();
                listflight.ShowDialog();
            }
            
        }
    }
}

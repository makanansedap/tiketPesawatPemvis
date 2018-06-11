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
    public partial class NamaPenumpang : Form {
        public static string dari = "", ke = "";
        public static string dest_date = "", return_date = "";
        public static string dest_time = "", return_time = "";
        public static int total_penumpang;
        public static int dest_price = 0, return_price = 0;
        public static bool one_way = true;

        string curr_bookingcode;

        string[] titel = new string[9];
        string[] nama_depan = new string[9];
        string[] nama_belakang = new string[9];

        bool error_nama = false, error_titel = false;

        private String connection;
        MySqlConnection connect;
        MySqlCommand sqlQuery;

        private void connect_mysql() {
            try {
                connection = "Server=localhost;Database=ta_pemvis;Uid=root;Pwd=;";
                connect = new MySqlConnection(connection);
                connect.Open();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public NamaPenumpang() {
            InitializeComponent();
            enable_input_penumpang();
            count_booking();
        }

        private void button_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button_next_Click(object sender, EventArgs e) {
            input_penumpang();

            for (int i = 0; i < total_penumpang; i++) {
                if (nama_depan[i] == "" || nama_belakang[i] == "") {
                    error_nama = true;
                    break;
                }
                if (titel[i] == "") {
                    error_titel = true;
                    break;
                }
            }

            if (error_nama == true) {
                MessageBox.Show("Nama tidak boleh kosong", "Warning", MessageBoxButtons.OK);
                error_nama = false;
            }
            else if (error_titel == true) {
                MessageBox.Show("Titel tidak boleh kosong", "Warning", MessageBoxButtons.OK);
                error_titel = false;
            }
            else {
                string dest_flight = "", return_flight = "";

                connect_mysql();
                sqlQuery = connect.CreateCommand();

                if (one_way == true) {
                    dest_flight = dari + " - " + ke;

                    return_flight = "";
                    return_date = "";
                    return_time = "";
                }
                else {
                    dest_flight = dari + " - " + ke;
                    return_flight = ke + " - " + dari;
                }

                for (int i = 0; i < total_penumpang; i++) {
                    string temp_titel = titel[i];
                    string temp_namadepan = nama_depan[i];
                    string temp_namabelakang = nama_belakang[i];
                    if (one_way == true) {
                        return_date = "1970-01-01";
                        return_price = 0;
                    }
                    sqlQuery.CommandText = "INSERT INTO booking_table(booking_code, title, nama_depan, nama_belakang, dest_flight, dest_date, dest_time, dest_price, return_flight, return_date, return_time, return_price) VALUES ('" + curr_bookingcode + "', '" + temp_titel + "', '" + temp_namadepan + "', '" + temp_namabelakang + "', '" + dest_flight + "', '" + dest_date + "', '" + dest_time + "', '"+ dest_price +"', '" + return_flight + "', '" + return_date + "', '" + return_time + "', '"+ return_price +"')";
                    sqlQuery.ExecuteNonQuery();
                }

                PrintTiket.total_price = (dest_price + return_price) * total_penumpang;
                PrintTiket.booking_code = curr_bookingcode;

                PrintTiket printtiket = new PrintTiket();
                printtiket.StartPosition = FormStartPosition.Manual;
                printtiket.Location = new Point(this.Location.X, this.Location.Y);
                printtiket.ShowDialog();
            }
        }

        private void count_booking() {
            int counter = 0;

            connect_mysql();
            sqlQuery = connect.CreateCommand();
            sqlQuery.CommandText = "SELECT COUNT(DISTINCT booking_code) AS booking_counter FROM booking_table";
            MySqlDataReader sqlReader = sqlQuery.ExecuteReader();

            while (sqlReader.Read()) {
                counter = sqlReader.GetInt32("booking_counter");
            }

            sqlReader.Close();

            counter++;

            curr_bookingcode = "TKG" + counter.ToString();

            //MessageBox.Show(String.Format("Booking code : {0}", curr_bookingcode));
        }

        private void enable_input_penumpang() {
            for (int i = 1; i <= total_penumpang; i++) {
                var groupboxControl = Controls.Find("groupBox_" + i, true).FirstOrDefault() as GroupBox;
                groupboxControl.Enabled = true;
            }
        }

        private void input_penumpang() {
            if (groupBox_1.Enabled == true) {
                nama_depan[0] = textBox_namadepan_1.Text;
                nama_belakang[0] = textBox_namabelakang_1.Text;

                titel[0] = comboBox_titel_1.GetItemText(comboBox_titel_1.SelectedItem);
            }
            if (groupBox_2.Enabled == true) {
                nama_depan[1] = textBox_namadepan_2.Text;
                nama_belakang[1] = textBox_namabelakang_2.Text;

                titel[1] = comboBox_titel_2.GetItemText(comboBox_titel_2.SelectedItem);
            }
            if (groupBox_3.Enabled == true) {
                nama_depan[2] = textBox_namadepan_3.Text;
                nama_belakang[2] = textBox_namabelakang_3.Text;

                titel[2] = comboBox_titel_4.GetItemText(comboBox_titel_4.SelectedItem);
            }
            if (groupBox_4.Enabled == true) {
                nama_depan[3] = textBox_namadepan_4.Text;
                nama_belakang[3] = textBox_namabelakang_4.Text;

                titel[3] = comboBox_titel_4.GetItemText(comboBox_titel_4.SelectedItem);
            }
            if (groupBox_5.Enabled == true) {
                nama_depan[4] = textBox_namadepan_5.Text;
                nama_belakang[4] = textBox_namabelakang_5.Text;

                titel[4] = comboBox_titel_5.GetItemText(comboBox_titel_5.SelectedItem);
            }
            if (groupBox_6.Enabled == true) {
                nama_depan[5] = textBox_namadepan_6.Text;
                nama_belakang[5] = textBox_namabelakang_6.Text;

                titel[5] = comboBox_titel_6.GetItemText(comboBox_titel_6.SelectedItem);
            }
            if (groupBox_7.Enabled == true) {
                nama_depan[6] = textBox_namadepan_7.Text;
                nama_belakang[6] = textBox_namabelakang_7.Text;

                titel[6] = comboBox_titel_7.GetItemText(comboBox_titel_7.SelectedItem);
            }
            if (groupBox_8.Enabled == true) {
                nama_depan[7] = textBox_namadepan_8.Text;
                nama_belakang[7] = textBox_namabelakang_8.Text;

                titel[7] = comboBox_titel_8.GetItemText(comboBox_titel_8.SelectedItem);
            }
            if (groupBox_9.Enabled == true) {
                nama_depan[8] = textBox_namadepan_9.Text;
                nama_belakang[8] = textBox_namabelakang_9.Text;

                titel[8] = comboBox_titel_9.GetItemText(comboBox_titel_9.SelectedItem);
            }
        }
    }
}
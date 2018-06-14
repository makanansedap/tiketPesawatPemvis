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
    public partial class ListFlight : Form {
        private String connection;
        MySqlConnection connect;
        MySqlDataReader sqlReader;
        MySqlCommand sqlQuery;

        public static string dari = "", ke = "";
        public static string dest_date = "", return_date = "";

        public static bool one_way = true;

        int row_FlightList;

        int[] price_dest = new int[6];
        int[] price_return = new int[6];

        int select_dest_price, select_return_price;

        private void connect_mysql() {
            try {
                connection = "Server=localhost;Database=ta_pemvis;Uid=root;Pwd=;";
                connect = new MySqlConnection(connection);
                connect.Open();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public ListFlight() {
            InitializeComponent();
            ListSelectedFlight();
            price_generator();
        }

        private void ListSelectedFlight() {
            string temp_dari = substring(dari);
            string temp_ke = substring(ke);

            if (one_way == true) {
                groupBox_return.Enabled = false;

                label_destination.Text = temp_dari + " - " + temp_ke;
                label_return.Text = "";
            }
            else {
                groupBox_return.Enabled = true;

                label_destination.Text = temp_dari + " - " + temp_ke;
                label_return.Text = temp_ke + " - " + temp_dari;
            }

            try {
                connect_mysql();
                sqlQuery = connect.CreateCommand();
                sqlQuery.CommandText = "SELECT DATE_FORMAT(departure, '%H:%i') AS depart, DATE_FORMAT(arrival, '%H:%i') AS arrival FROM time_table";
                sqlReader = sqlQuery.ExecuteReader();

                while (sqlReader.Read()) {
                    string depart = sqlReader.GetString("depart");
                    string arrival = sqlReader.GetString("arrival");
                    comboBox_dest_time.Items.Add(string.Format("{0} - {1}", depart, arrival));
                    comboBox_return_time.Items.Add(string.Format("{0} - {1}", depart, arrival));
                }
                if (one_way == false && dest_date == return_date) {
                    comboBox_dest_time.Items.RemoveAt(comboBox_dest_time.Items.Count - 1);
                }

                sqlReader.Close();

            }
            catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }

            comboBox_dest_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox_dest_time.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_dest_time.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox_return_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox_return_time.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_return_time.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void dataGridView_Flight_CellClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void button_next_Click(object sender, EventArgs e) {
            if (comboBox_dest_time.Text == "" && one_way == true) {
                MessageBox.Show("Waktu penerbangan harus dipilih", "Notice", MessageBoxButtons.OK);
            }
            else if ((comboBox_dest_time.Text == "" || comboBox_return_time.Text == "") && one_way == false) {
                MessageBox.Show("Waktu penerbangan harus dipilih", "Notice", MessageBoxButtons.OK);
            }
            else {
                PrintTiket.dest_time = comboBox_dest_time.GetItemText(comboBox_dest_time.SelectedItem);
                PrintTiket.return_time = comboBox_return_time.GetItemText(comboBox_return_time.SelectedItem);

                NamaPenumpang.dest_time = comboBox_dest_time.GetItemText(comboBox_dest_time.SelectedItem);
                NamaPenumpang.return_time = comboBox_return_time.GetItemText(comboBox_return_time.SelectedItem);
                NamaPenumpang.dest_price = price_dest[select_dest_price];
                NamaPenumpang.return_price = price_return[select_return_price];

                NamaPenumpang namapenumpang = new NamaPenumpang();
                namapenumpang.StartPosition = FormStartPosition.Manual;
                namapenumpang.Location = new Point(this.Location.X, this.Location.Y);
                this.Visible = false;
                this.Close();
                namapenumpang.ShowDialog();
                //this.Visible = true;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void comboBox_return_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_return_price = comboBox_return_time.SelectedIndex;

            label_return_price.Visible = true;

            label_return_price.Text = "Rp." + price_return[select_return_price].ToString("N2") + "/person";
        }

        string substring(string s) {
            int startIndex = 0;
            int endIndex = s.IndexOf(",");

            string temp = s.Substring(startIndex, endIndex);

            return temp;
        }

        private void comboBox_dest_time_SelectedIndexChanged(object sender, EventArgs e) {
            select_dest_price = comboBox_dest_time.SelectedIndex;

            if (one_way == false && dest_date == return_date) {
                comboBox_return_time.Items.Clear();
                sqlQuery.CommandText = String.Format("SELECT DATE_FORMAT(departure, '%H:%i') AS depart, DATE_FORMAT(arrival, '%H:%i') AS arrival FROM time_table WHERE id_time > {0}", comboBox_dest_time.SelectedIndex + 1);
                sqlReader = sqlQuery.ExecuteReader();
                while (sqlReader.Read()) {
                    String depart = sqlReader.GetString("depart");
                    String arrival = sqlReader.GetString("arrival");
                    comboBox_return_time.Items.Add(String.Format("{0} - {1}", depart, arrival));
                }
                sqlReader.Close();
            }

            label_dest_price.Visible = true;

            label_dest_price.Text = "Rp." + price_dest[select_dest_price].ToString("N2") + "/person";
        }
        
        private void price_generator() {
            Random rnd = new Random();
            
            for(int n = 0; n < 6; n++)
            {
                price_dest[n] = rnd.Next(300, 500)*10000;
                price_return[n] = rnd.Next(300, 500)*10000;
            }

            label_dest_price.Visible = false;
            label_return_price.Visible = false;
        }
    }
}

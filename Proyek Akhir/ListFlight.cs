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

namespace Proyek_Akhir
{
    public partial class ListFlight : Form
    {
        private String connection;
        MySqlConnection connect;
        MySqlCommand sqlQuery;

        public static string dari = "";
        public static string ke = "";

        public static bool one_way = true;

        int row_FlightList;

        private void connect_mysql()
        {
            try
            {
                connection = "Server=localhost;Database=ta_pemvis;Uid=root;Pwd=;";
                connect = new MySqlConnection(connection);
                connect.Open();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public ListFlight()
        {
            InitializeComponent();
            ListSelectedFlight();
        }

        private void ListSelectedFlight()
        {
            string temp_dari = substring(dari);
            string temp_ke = substring(ke);

            if (one_way == true)
            {
                groupBox_return.Enabled = false;

                label_destination.Text = temp_dari + " - " + temp_ke;
                label_return.Text = "";
            }
            else
            {
                groupBox_return.Enabled = true;

                label_destination.Text = temp_dari + " - " + temp_ke;
                label_return.Text = temp_ke + " - " + temp_dari;
            }

            try
            {
                connect_mysql();
                sqlQuery = connect.CreateCommand();
                sqlQuery.CommandText = "SELECT DATE_FORMAT(departure, '%H:%i') AS depart, DATE_FORMAT(arrival, '%H:%i') AS arrival FROM time_table";
                MySqlDataReader sqlReader = sqlQuery.ExecuteReader();

                while(sqlReader.Read())
                {
                    string depart = sqlReader.GetString("depart");
                    string arrival = sqlReader.GetString("arrival");
                    comboBox_dest_time.Items.Add(string.Format("{0} - {1}", depart, arrival));
                    comboBox_return_time.Items.Add(string.Format("{0} - {1}", depart, arrival));
                }

                sqlReader.Close();

                /*MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT d.city AS 'Depart', a.city AS 'Arrival' , t.departure AS 'Depart Time', t.arrival AS 'Arrival Time' FROM airport_table AS d, airport_table AS a, time_table AS t WHERE d.city = 'Goroka' AND a.city = 'Madang'", connect);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView_Flight.DataSource = ds.Tables[0];
                connect.Close();

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView_Flight.Columns.Add(btn);
                btn.HeaderText = "Selection";
                btn.Text = "Select Here";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;

                dataGridView_Flight.CellClick += new DataGridViewCellEventHandler(dataGridView_Flight_CellClick);*/
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            comboBox_dest_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox_dest_time.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_dest_time.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox_return_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox_return_time.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_return_time.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void dataGridView_Flight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dataGridView_Flight.CurrentCell != null && dataGridView_Flight.CurrentCell.Value != null)
            {
                row_FlightList = dataGridView_Flight.CurrentCell.RowIndex;
                //MessageBox.Show(dataGridView_Flight.CurrentCell.RowIndex.ToString());
            }

            PrintTiket printtiket = new PrintTiket();
            printtiket.StartPosition = FormStartPosition.Manual;
            printtiket.Location = new Point(this.Location.X, this.Location.Y);
            this.Close();
            printtiket.ShowDialog();*/
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if(comboBox_dest_time.Text == "" && one_way == true)
            {
                MessageBox.Show("Waktu penerbangan harus dipilih", "Notice", MessageBoxButtons.OK);
            }
            else if((comboBox_dest_time.Text == "" || comboBox_return_time.Text == "") && one_way == false)
            {
                MessageBox.Show("Waktu penerbangan harus dipilih", "Notice", MessageBoxButtons.OK);
            }
            else
            {
                PrintTiket.dest_time = comboBox_dest_time.GetItemText(comboBox_dest_time.SelectedItem);
                PrintTiket.return_time = comboBox_return_time.GetItemText(comboBox_return_time.SelectedItem);

                NamaPenumpang namapenumpang = new NamaPenumpang();
                namapenumpang.StartPosition = FormStartPosition.Manual;
                namapenumpang.Location = new Point(this.Location.X, this.Location.Y);
                this.Close();
                namapenumpang.ShowDialog();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string substring(string s)
        {
            int startIndex = 0;
            int endIndex = s.IndexOf(",");

            string temp = s.Substring(startIndex, endIndex);

            return temp;
        }
    }
}

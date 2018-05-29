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

        public void ListSelectedFlight()
        {
            try
            {
                connect_mysql();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT d.city AS 'Depart', a.city AS 'Arrival' , t.departure AS 'Depart Time', t.arrival AS 'Arrival Time' FROM airport_table AS d, airport_table AS a, time_table AS t WHERE d.city = 'Goroka' AND a.city = 'Madang'", connect);
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

                dataGridView_Flight.CellClick += new DataGridViewCellEventHandler(dataGridView_Flight_CellClick);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void dataGridView_Flight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Flight.CurrentCell != null && dataGridView_Flight.CurrentCell.Value != null)
            {
                row_FlightList = dataGridView_Flight.CurrentCell.RowIndex;
                //MessageBox.Show(dataGridView_Flight.CurrentCell.RowIndex.ToString());
            }

            PrintTiket printtiket = new PrintTiket();
            printtiket.StartPosition = FormStartPosition.Manual;
            printtiket.Location = new Point(this.Location.X, this.Location.Y);
            this.Close();
            printtiket.ShowDialog();
        }
    }
}

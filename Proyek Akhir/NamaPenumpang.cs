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
    public partial class NamaPenumpang : Form
    {
        public static int total_penumpang;

        private String connection;
        MySqlConnection connect;
        MySqlCommand sqlQuery;

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

        public NamaPenumpang()
        {
            InitializeComponent();
            input_penumpang();
        }

        private void input_penumpang()
        {
            switch(total_penumpang)
            {
                case 1:
                    groupBox_1.Enabled = true;
                    break;
                case 2:
                    groupBox_2.Enabled = true;
                    break;
                case 3:
                    groupBox_3.Enabled = true;
                    break;
                case 4:
                    groupBox_4.Enabled = true;
                    break;
                case 5:
                    groupBox_5.Enabled = true;
                    break;
                case 6:
                    groupBox_6.Enabled = true;
                    break;
                case 7:
                    groupBox_7.Enabled = true;
                    break;
                case 8:
                    groupBox_8.Enabled = true;
                    break;
                case 9:
                    groupBox_9.Enabled = true;
                    break;
            }


        }

        private void button_next_Click(object sender, EventArgs e)
        {


            PrintTiket printtiket = new PrintTiket();
            printtiket.StartPosition = FormStartPosition.Manual;
            printtiket.Location = new Point(this.Location.X, this.Location.Y);
            this.Close();
            printtiket.ShowDialog();
        }

        private void count_booking()
        {

        }
    }
}

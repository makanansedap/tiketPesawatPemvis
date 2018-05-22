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
    public partial class LoginForm : Form {
        private String connection;
        MySqlConnection connect;
        MySqlCommand sqlQuery;

        public LoginForm() {
            InitializeComponent();
            label_invalidLogin.Visible = false;
        }

        private void connect_mysql() {
            try {
                connection = "Server=localhost;Database=ta_pemvis;Uid=root;Pwd=;";
                connect = new MySqlConnection(connection);
                connect.Open();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void button_login_Click(object sender, EventArgs e) {
            connect_mysql();
            sqlQuery = connect.CreateCommand();
            sqlQuery.CommandText = "SELECT * FROM user_table WHERE username='"+ textBox_username.Text + "' AND password='" + textBox_password.Text + "'";
            MySqlDataReader data_login = sqlQuery.ExecuteReader();
            if (data_login.Read()) {
                int statusIndexNamaDepan = data_login.GetOrdinal("nama_depan");
                String nama = data_login.GetString(statusIndexNamaDepan);
                int statusIndexNamaBelakang = data_login.GetOrdinal("nama_belakang");
                if( !data_login.IsDBNull(statusIndexNamaBelakang) ) nama += " " + data_login.GetString(statusIndexNamaBelakang);
                MessageBox.Show("Welcome, " + nama, "Success", MessageBoxButtons.OK);

                //Form1.login = true;
                Form1.nama = nama;

                this.Close();
            }
            else {
                label_invalidLogin.Visible = true;
            }
        }

        private void linkLabel_signUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            SignUpForm signUp = new SignUpForm();
            signUp.StartPosition = FormStartPosition.Manual;
            signUp.Location = new Point(this.Location.X, this.Location.Y);
            this.Close();
            signUp.ShowDialog();
        }

        private void button_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

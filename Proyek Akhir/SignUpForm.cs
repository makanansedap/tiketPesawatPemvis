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
    public partial class SignUpForm : Form {
        private string connection;
        MySqlConnection connect;
        MySqlCommand sqlQuery;
        MySqlDataReader sqlReader;

        private void connect_mysql() {
            try {
                connection = "Server = localhost; Database= ta_pemvis; uid = root; pwd=;";
                connect = new MySqlConnection(connection);
                connect.Open();
            }
            catch (MySqlException e) {
                throw e;
            }
        }
        public SignUpForm() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            connect_mysql();

            try {
                
                if (textBox_namaDepan.Text == "" || textBox_namaBelakang.Text == "" || textBox_email.Text == "" ||
                    textBox_emailConfirm.Text =="" || textBox_username.Text == "" || textBox_password.Text == "" ||
                    textBox_passwordConfirm.Text == "") {
                   MessageBox.Show("Field yang ditandai dengan * wajib diisi.", "Notice", MessageBoxButtons.OK);
                }
                else {
                    var eMailValidator = new System.Net.Mail.MailAddress(textBox_email.Text);
                    if (textBox_email.Text != textBox_emailConfirm.Text)
                        MessageBox.Show("Konfirmasi email tidak sesuai.", "Notice", MessageBoxButtons.OK);
                    else if (textBox_password.Text.Length < 8)
                        MessageBox.Show("Password tidak boleh kurang dari 8 karakter.", "Notice", MessageBoxButtons.OK);
                    else if (textBox_password.Text != textBox_passwordConfirm.Text)
                        MessageBox.Show("Konfirmasi password tidak sesuai.", "Notice", MessageBoxButtons.OK);
                    else {
                        DialogResult result = MessageBox.Show("Apakah informasi yang anda input sudah benar?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes) {
                            int count_username = 0;
                            int count_email = 0;

                            string temp_username = textBox_username.Text;
                            string temp_email = textBox_email.Text;

                            //Cek username
                            {
                                sqlQuery = connect.CreateCommand();
                                sqlQuery.CommandText = "SELECT COUNT(*) AS count_username FROM user_table WHERE username = '" + temp_username + "'";
                                sqlReader = sqlQuery.ExecuteReader();
                                while (sqlReader.Read())
                                {
                                    string temp = sqlReader.GetString("count_username");
                                    Int32.TryParse(temp, out count_username);
                                }
                                sqlReader.Close();
                            }

                            //Cek email
                            {
                                sqlQuery = connect.CreateCommand();
                                sqlQuery.CommandText = "SELECT COUNT(*) AS count_email FROM user_table WHERE email = '" + temp_email + "'";
                                sqlReader = sqlQuery.ExecuteReader();
                                while (sqlReader.Read())
                                {
                                    string temp = sqlReader.GetString("count_email");
                                    Int32.TryParse(temp, out count_email);
                                }
                                sqlReader.Close();
                            }


                            if (count_username > 0 && count_email > 0)
                            {
                                MessageBox.Show("Username dan Email sudah digunakan.", "Notice", MessageBoxButtons.OK);
                            }
                            else if (count_username > 0)
                            {
                                MessageBox.Show("Username sudah digunakan.", "Notice", MessageBoxButtons.OK);
                            }
                            else if(count_email > 0)
                            {
                                MessageBox.Show("Email sudah digunakan.", "Notice", MessageBoxButtons.OK);
                            }
                            

                            if (count_username == 0 && count_email == 0)
                            {
                                sqlQuery = connect.CreateCommand();
                                sqlQuery.CommandText = "INSERT INTO user_table(username, password, nama_depan, nama_belakang, email, no_hp, no_rumah, tanggal_lahir, kebangsaan) VALUES ('" + textBox_username.Text + "', '" + textBox_passwordConfirm.Text + "', '" + textBox_namaDepan.Text + "', '" + textBox_namaBelakang.Text + "', '" + textBox_emailConfirm.Text + "', '" + textBox_noHP.Text + "', '" + textBox_telp.Text + "', '" + dateTimePicker_tanggalLahir.Value.ToString("yyyy-MM-dd") + "', '" + textBox_kebangsaan.Text + "')";
                                sqlQuery.ExecuteNonQuery();
                                MessageBox.Show("Sign Up sukses, silahkan login.", "Notice", MessageBoxButtons.OK);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (FormatException ex) {
                MessageBox.Show("Email yang anda masukkan tidak valid.", "Notice", MessageBoxButtons.OK);
            }
        }

        private void textBox_email_TextChanged(object sender, EventArgs e) {

        }
    }
}

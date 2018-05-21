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
        public SignUpForm() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
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
                    else MessageBox.Show("Apakah informasi yang anda input sudah benar?", "Confirmation", MessageBoxButtons.YesNo);
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

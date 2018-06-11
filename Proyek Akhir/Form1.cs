using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Proyek_Akhir {
    public partial class Form1 : Form {
        public static bool login = false;
        public static string nama;
        public Form1() {
            InitializeComponent();
        }

        public void setLogin(bool status) {
            login = status;
            button_belitiket.Visible = status;
            button_logout.Visible = status;
            button_login.Visible = !status;
            button_signup.Visible = !status;
            if (status == true) {
                label_welcome.Text = "You are logged in as " + nama;
            }
            else {
                label_welcome.Text = "Login or Sign Up to continue";
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            BuyTicket beliTiket = new BuyTicket();
            beliTiket.StartPosition = FormStartPosition.Manual;
            beliTiket.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            beliTiket.ShowDialog();
            this.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e) {
            label_welcome.Text = "Login or Sign Up to continue";
        }

        private void button_signup_Click(object sender, EventArgs e) {
            SignUpForm signUp = new SignUpForm();
            signUp.StartPosition = FormStartPosition.Manual;
            signUp.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            signUp.ShowDialog();
            this.Visible = true;
        }

        private void button_login_Click(object sender, EventArgs e) {
            button_belitiket.Visible = false;
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = new Point(this.Location.X, this.Location.Y);
            loginForm.ShowDialog();
            label_welcome.Text = "You are logged in as " + nama;
            setLogin(login);
            /*BuyTicket beliTiket = new BuyTicket();
            beliTiket.StartPosition = FormStartPosition.Manual;
            beliTiket.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            beliTiket.ShowDialog();
            this.Visible = true;*/
        }

        private void button_logout_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) setLogin(false);
        }
    }
}
namespace Proyek_Akhir {
    partial class LoginForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_invalidLogin = new System.Windows.Forms.Label();
            this.linkLabel_signUp = new System.Windows.Forms.LinkLabel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(68, 150);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(220, 20);
            this.textBox_password.TabIndex = 12;
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_password_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(68, 95);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(220, 20);
            this.textBox_username.TabIndex = 10;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            this.textBox_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_username_KeyDown);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(183, 215);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 14;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_invalidLogin
            // 
            this.label_invalidLogin.AutoSize = true;
            this.label_invalidLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.label_invalidLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_invalidLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_invalidLogin.Location = new System.Drawing.Point(68, 54);
            this.label_invalidLogin.Name = "label_invalidLogin";
            this.label_invalidLogin.Size = new System.Drawing.Size(220, 16);
            this.label_invalidLogin.TabIndex = 15;
            this.label_invalidLogin.Text = "Invalid login credentials                        ";
            // 
            // linkLabel_signUp
            // 
            this.linkLabel_signUp.AutoSize = true;
            this.linkLabel_signUp.Location = new System.Drawing.Point(68, 178);
            this.linkLabel_signUp.Name = "linkLabel_signUp";
            this.linkLabel_signUp.Size = new System.Drawing.Size(148, 13);
            this.linkLabel_signUp.TabIndex = 16;
            this.linkLabel_signUp.TabStop = true;
            this.linkLabel_signUp.Text = "Don\'t have account? Sign Up";
            this.linkLabel_signUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_signUp_LinkClicked);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(90, 215);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 17;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 274);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.linkLabel_signUp);
            this.Controls.Add(this.label_invalidLogin);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_invalidLogin;
        private System.Windows.Forms.LinkLabel linkLabel_signUp;
        private System.Windows.Forms.Button button_cancel;
    }
}
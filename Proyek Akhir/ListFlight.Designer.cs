namespace Proyek_Akhir
{
    partial class ListFlight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_destination = new System.Windows.Forms.GroupBox();
            this.label_dest_price = new System.Windows.Forms.Label();
            this.comboBox_dest_time = new System.Windows.Forms.ComboBox();
            this.label_destination = new System.Windows.Forms.Label();
            this.groupBox_return = new System.Windows.Forms.GroupBox();
            this.label_return_price = new System.Windows.Forms.Label();
            this.comboBox_return_time = new System.Windows.Forms.ComboBox();
            this.label_return = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.groupBox_destination.SuspendLayout();
            this.groupBox_return.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Form Pembelian Tiket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(24, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "*) Harap memilih waktu penerbangan yang Anda inginkan";
            // 
            // groupBox_destination
            // 
            this.groupBox_destination.Controls.Add(this.label_dest_price);
            this.groupBox_destination.Controls.Add(this.comboBox_dest_time);
            this.groupBox_destination.Controls.Add(this.label_destination);
            this.groupBox_destination.Location = new System.Drawing.Point(27, 76);
            this.groupBox_destination.Name = "groupBox_destination";
            this.groupBox_destination.Size = new System.Drawing.Size(356, 103);
            this.groupBox_destination.TabIndex = 5;
            this.groupBox_destination.TabStop = false;
            this.groupBox_destination.Text = "Destination Flight";
            // 
            // label_dest_price
            // 
            this.label_dest_price.AutoSize = true;
            this.label_dest_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dest_price.Location = new System.Drawing.Point(186, 64);
            this.label_dest_price.Name = "label_dest_price";
            this.label_dest_price.Size = new System.Drawing.Size(69, 13);
            this.label_dest_price.TabIndex = 2;
            this.label_dest_price.Text = "Dest_Price";
            // 
            // comboBox_dest_time
            // 
            this.comboBox_dest_time.FormattingEnabled = true;
            this.comboBox_dest_time.Location = new System.Drawing.Point(9, 61);
            this.comboBox_dest_time.Name = "comboBox_dest_time";
            this.comboBox_dest_time.Size = new System.Drawing.Size(122, 21);
            this.comboBox_dest_time.TabIndex = 1;
            this.comboBox_dest_time.SelectedIndexChanged += new System.EventHandler(this.comboBox_dest_time_SelectedIndexChanged);
            // 
            // label_destination
            // 
            this.label_destination.AutoSize = true;
            this.label_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_destination.Location = new System.Drawing.Point(6, 27);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(75, 16);
            this.label_destination.TabIndex = 0;
            this.label_destination.Text = "Destination";
            // 
            // groupBox_return
            // 
            this.groupBox_return.Controls.Add(this.label_return_price);
            this.groupBox_return.Controls.Add(this.comboBox_return_time);
            this.groupBox_return.Controls.Add(this.label_return);
            this.groupBox_return.Location = new System.Drawing.Point(27, 185);
            this.groupBox_return.Name = "groupBox_return";
            this.groupBox_return.Size = new System.Drawing.Size(356, 106);
            this.groupBox_return.TabIndex = 6;
            this.groupBox_return.TabStop = false;
            this.groupBox_return.Text = "Return Flight";
            // 
            // label_return_price
            // 
            this.label_return_price.AutoSize = true;
            this.label_return_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return_price.Location = new System.Drawing.Point(186, 71);
            this.label_return_price.Name = "label_return_price";
            this.label_return_price.Size = new System.Drawing.Size(74, 13);
            this.label_return_price.TabIndex = 3;
            this.label_return_price.Text = "Retrn_Price";
            // 
            // comboBox_return_time
            // 
            this.comboBox_return_time.FormattingEnabled = true;
            this.comboBox_return_time.Location = new System.Drawing.Point(9, 68);
            this.comboBox_return_time.Name = "comboBox_return_time";
            this.comboBox_return_time.Size = new System.Drawing.Size(122, 21);
            this.comboBox_return_time.TabIndex = 2;
            this.comboBox_return_time.SelectedIndexChanged += new System.EventHandler(this.comboBox_return_time_SelectedIndexChanged);
            // 
            // label_return
            // 
            this.label_return.AutoSize = true;
            this.label_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return.Location = new System.Drawing.Point(6, 31);
            this.label_return.Name = "label_return";
            this.label_return.Size = new System.Drawing.Size(47, 16);
            this.label_return.TabIndex = 1;
            this.label_return.Text = "Return";
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(283, 338);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(100, 23);
            this.button_next.TabIndex = 7;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(148, 338);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 23);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // ListFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 383);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.groupBox_return);
            this.Controls.Add(this.groupBox_destination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListFlight";
            this.Text = "ListFlight";
            this.groupBox_destination.ResumeLayout(false);
            this.groupBox_destination.PerformLayout();
            this.groupBox_return.ResumeLayout(false);
            this.groupBox_return.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_destination;
        private System.Windows.Forms.GroupBox groupBox_return;
        private System.Windows.Forms.Label label_destination;
        private System.Windows.Forms.Label label_return;
        private System.Windows.Forms.ComboBox comboBox_dest_time;
        private System.Windows.Forms.ComboBox comboBox_return_time;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_dest_price;
        private System.Windows.Forms.Label label_return_price;
    }
}
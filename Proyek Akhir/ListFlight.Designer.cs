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
            this.dataGridView_Flight = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Flight)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Flight
            // 
            this.dataGridView_Flight.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_Flight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Flight.Location = new System.Drawing.Point(12, 61);
            this.dataGridView_Flight.Name = "dataGridView_Flight";
            this.dataGridView_Flight.Size = new System.Drawing.Size(526, 210);
            this.dataGridView_Flight.TabIndex = 0;
            // 
            // ListFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 282);
            this.Controls.Add(this.dataGridView_Flight);
            this.Name = "ListFlight";
            this.Text = "ListFlight";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Flight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Flight;
    }
}
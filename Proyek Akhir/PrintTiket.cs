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
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;

namespace Proyek_Akhir {
    public partial class PrintTiket : Form {
        public static string booking_code = "";
        public static string nama_depan = "";
        public static string nama_belakang = "";
        public static string dari = "";
        public static string ke = "";
        public static string dest_date = "", return_date = "";
        public static string dest_time = "", return_time = "";
        public static int total_price = 0;
        public static int total_penumpang = 0;
        public static bool one_way = true;

        private string conn;
        private MySqlConnection connection;
        MySqlDataReader reader;
        MySqlCommand da;

        private void connect_mysql() {
            try {
                conn = "Server = localhost; Database= ta_pemvis; uid = root; pwd=;";
                String query = "SELECT title, nama_depan, nama_belakang, no_identitas, dest_flight, dest_date, dest_time, dest_price, return_flight, return_date, return_time, return_price FROM booking_table WHERE booking_code = '" + booking_code + "'";
                connection = new MySqlConnection(conn);
                da = new MySqlCommand(query, connection);
                connection.Open();

            }
            catch (MySqlException e) {
                throw e;
            }
        }

        public PrintTiket() {
            InitializeComponent();
            Print();
        }

        private void button_close_Click(object sender, EventArgs e) {
            BuyTicket beliTiket = new BuyTicket();
            beliTiket.StartPosition = FormStartPosition.Manual;
            beliTiket.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            this.Close();
            beliTiket.ShowDialog();
        }

        private void button_exportPdf_Click(object sender, EventArgs e) {

            connect_mysql();
            reader = da.ExecuteReader();

            PdfDocument pdf = new PdfDocument();
            
            while (reader.Read()) {
                string nama = reader.GetString("title") + " " +  reader.GetString("nama_depan") + " " + reader.GetString("nama_belakang");
                string identitas = reader.GetString("no_identitas");
                string dest_flight = reader.GetString("dest_flight");
                string dest_date = reader.GetString("dest_date");
                string dest_time = reader.GetString("dest_time");
                int dest_price = reader.GetInt32("dest_price");
                string return_flight = reader.GetString("return_flight");
                string return_date = reader.GetString("return_date");
                string return_time = reader.GetString("return_time");
                int return_price = reader.GetInt32("return_price");

                string content =
                    "\n\n\n\n\nBooking Reference    : " + booking_code +
                    "\nPassenger Name       : " + nama +
                    "\nIdentity Number      : " + identitas +
                    "\nDestination Details  : " +
                    "\n    • Flight    : " + dest_flight +
                    "\n    • Date      : " + dest_date +
                    "\n    • Time      : " + dest_time +
                    "\n    • Price     : " + "Rp." + dest_price.ToString("N2");

                if (one_way == false) content +=
                    "\nReturn Details       : " +
                    "\n    • Flight    : " + return_flight +
                    "\n    • Date      : " + return_date +
                    "\n    • Time      : " + return_time +
                    "\n    • Price     : " + "Rp." + return_price.ToString("N2");

                PdfPage pdfPage = pdf.AddPage();
                pdfPage.Size = PageSize.A5;
                pdfPage.Orientation = PageOrientation.Landscape;
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont fontHeading1 = new XFont("Arial", 20, XFontStyle.Bold);
                XFont fontHeading2 = new XFont("Arial", 16, XFontStyle.Bold);
                XFont fontContent = new XFont("Consolas", 11);
                XTextFormatter tf = new XTextFormatter(graph);

                XRect xrect = new XRect(25, 20, pdfPage.Width.Point, pdfPage.Height.Point);
                tf.DrawString("Thonkang Airlines", fontHeading1, XBrushes.Black, xrect, XStringFormats.TopLeft);
                tf.DrawString("\n\nElectronic Ticket Receipt", fontHeading2, XBrushes.Black, xrect, XStringFormats.TopLeft);
                tf.DrawString(content, fontContent, XBrushes.Black, xrect, XStringFormats.TopLeft);
            }
            reader.Close();

            string time = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string path = "E-ticket_" + time + ".pdf";
            pdf.Save(path.ToString());
        }

        private void closeAllWindow(object sender, FormClosingEventArgs e) {

        }

        private void Print() {
            if (one_way == true) groupBox_pulang.Enabled = false;

            string temp_dari = substring(dari);
            string temp_ke = substring(ke);

            label_code.Text = booking_code;
            label_price.Text = "Rp." + total_price.ToString("N2");

            if (one_way == true) {
                label_dest_from.Text = temp_dari;
                label_dest_to.Text = temp_ke;
                label_dest_date.Text = dest_date;
                label_dest_time.Text = dest_time;

                label_return_from.Text = "";
                label_return_to.Text = "";
                label_return_date.Text = "";
                label_return_time.Text = "";
            }
            else {
                label_dest_from.Text = temp_dari;
                label_dest_to.Text = temp_ke;
                label_dest_date.Text = dest_date;
                label_dest_time.Text = dest_time;

                label_return_from.Text = temp_ke;
                label_return_to.Text = temp_dari;
                label_return_date.Text = return_date;
                label_return_time.Text = return_time;
            }
        }

        string substring(string s) {
            int startIndex = 0;
            int endIndex = s.IndexOf(",");

            string temp = s.Substring(startIndex, endIndex);

            return temp;
        }
    }
}

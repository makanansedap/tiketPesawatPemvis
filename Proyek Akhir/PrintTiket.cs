using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
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

        public static bool one_way = true;

        public PrintTiket() {
            InitializeComponent();
            Print();
        }

        private void button_close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button_exportPdf_Click(object sender, EventArgs e) {
            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            graph.DrawString("This is my first pdf", font, XBrushes.Black,
                new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            pdf.Save("firstpage.pdf");
        }

        private void Print() {
            if (one_way == true) groupBox_pulang.Enabled = false;

            string temp_dari = substring(dari);
            string temp_ke = substring(ke);

            label_code.Text = booking_code;
            label_price.Text = "Rp. " + total_price.ToString("N2");

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

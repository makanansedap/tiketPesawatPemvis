using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_Akhir
{
    public partial class PrintTiket : Form
    {
        public static string nama_depan = "";
        public static string nama_belakang = "";
        public static string dari = "";
        public static string ke = "";

        public PrintTiket()
        {
            InitializeComponent();
            Print();
        }

        public void Print()
        {
            label_nama.Text = nama_belakang + ", " + nama_depan;
            label_from.Text = dari;
            label_to.Text = ke;
        }
    }
}

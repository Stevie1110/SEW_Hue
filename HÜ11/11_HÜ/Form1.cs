using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_HÜ
{
    public partial class Form1 : Form
    {
        private int zähler = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btninkrement_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txt_Liste.Text += this.txt_Vorname.Text + " " + this.txt_Nachname.Text + "\r\n";
            this.txt_Vorname.Text = "";
            this.txt_Nachname.Text = "";
            this.zähler += 1;
            this.lbl_Anzahl.Text = zähler + " Personen anwesend";
        }

        private void btn_Löschen_Click(object sender, EventArgs e)
        {
            this.txt_Liste.Text = "";
            this.lbl_Anzahl.Text = "0 Personen anwesend";
            this.zähler = 0;
        }

        private void lbl_Anzahl_Click(object sender, EventArgs e)
        {

        }
    }
}

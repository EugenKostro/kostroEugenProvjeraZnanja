using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostroEugenProvjeraZnanja
{
    public partial class Form2 : Form
    {
        private string ime;

        public string Ime
        {
            get { return ime;  }
            set { Ime = value; }
        }
        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { Prezime = value; }
        }
        private string oib;

        public string OIB
        {
            get { return oib; }
            set { OIB = value; }
        }
        private string datum;

        public string Datum
        {
            get { return datum; }
            set { Datum = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBoxIme_TextChanged(object sender, EventArgs e)
        {
            Ime = textBoxIme.Text;
            
        }

        private void TextBoxPrezime_TextChanged(object sender, EventArgs e)
        {
            Prezime = textBoxPrezime.Text;
        }

        private void TextBoxOIB_TextChanged(object sender, EventArgs e)
        {
            OIB = textBoxOIB.Text;
        }
    }
}

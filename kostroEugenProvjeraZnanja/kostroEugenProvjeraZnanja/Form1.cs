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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUnesi_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            if(frm2.ShowDialog() == DialogResult.OK)
            {
                textBoxIme.Text = frm2.Ime;
                textBoxPrezime.Text = frm2.Prezime;
                textBoxOIB.Text = frm2.OIB;
                
            }
            
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
    }
}

using System;
using System.Windows.Forms;

namespace Poznamkovnik
{
    public partial class Form2 : Form
    {
        public Poznamka NovaPoznamka { get; set; }

        public Form2(Poznamka poznamka)
        {
            InitializeComponent();
            if (poznamka != null)
            {
                textBoxNazev.Text = poznamka.Nazev;
                textBoxText.Text = poznamka.Text;
            }
        }

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            NovaPoznamka = new Poznamka(textBoxNazev.Text, textBoxText.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonZrusit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
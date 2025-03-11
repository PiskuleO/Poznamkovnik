using System;
using System.Windows.Forms;

namespace Poznamkovnik
{
    public partial class MainForm : Form
    {
        private Data data = new Data();
        private string soubor = "poznamky.json";

        public MainForm()
        {
            InitializeComponent();
            data.NacistData(soubor);
            AktualizovatListBox();
        }

        private void AktualizovatListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = data.Poznamky;
        }

        private void buttonPridat_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(null);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                data.PridatPoznamku(form2.NovaPoznamka);
                AktualizovatListBox();
            }
        }

        private void buttonUpravit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Poznamka vybranaPoznamka = (Poznamka)listBox1.SelectedItem;
                Form2 form2 = new Form2(vybranaPoznamka);
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    data.UpravitPoznamku(listBox1.SelectedIndex, form2.NovaPoznamka);
                    AktualizovatListBox();
                }
            }
        }

        private void buttonSmazat_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                data.SmazatPoznamku(listBox1.SelectedIndex);
                AktualizovatListBox();
            }
        }

        private void ulozitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.UlozitData(soubor);
        }

        private void nacistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.NacistData(soubor);
            AktualizovatListBox();
        }
    }
}
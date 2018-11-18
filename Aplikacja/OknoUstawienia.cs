using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class OknoUstawienia : Form
    {
        public OknoUstawienia()
        {
            InitializeComponent();
            TextBoxKierownikProjektu.Text = Properties.Settings.Default.KierownikProjektu;
            TextBoxSzacujacy.Text = Properties.Settings.Default.Szacujacy;
            TextBoxNazwaFirmy.Text = Properties.Settings.Default.NazwaFirmy;
            TextBoxAdres.Text = Properties.Settings.Default.Adres;
            TextBoxTelefon.Text = Properties.Settings.Default.Telefon;
            TextBoxEmail.Text = Properties.Settings.Default.Email;

        }

        private void TextBoxKierownikProjektu_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempKierownikProjektu = TextBoxKierownikProjektu.Text;
        }

        private void TextBoxSzacujacy_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempSzacujacy = TextBoxSzacujacy.Text;
        }

        private void TextBoxNazwaFirmy_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempNazwaFirmy = TextBoxNazwaFirmy.Text;
        }

        private void TextBoxAdres_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempAdres = TextBoxAdres.Text;
        }

        private void TextBoxTelefon_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTelefon = TextBoxTelefon.Text;
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempEmail = TextBoxEmail.Text;
        }

        private void NumericUCPgodziny_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUCPlinieKodu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericStawkaGodz_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericOsoboMGodz_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericDzRobGodz_ValueChanged(object sender, EventArgs e)
        {
                
        }
    }
}

using System;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class OknoDomyslneUstawienia : Form
    {
        public OknoDomyslneUstawienia()
        {
            InitializeComponent();
            TextBoxKierownikProjektu.Text = Properties.Settings.Default.KierownikProjektu;
            TextBoxSzacujacy.Text = Properties.Settings.Default.Szacujacy;
            TextBoxNazwaFirmy.Text = Properties.Settings.Default.NazwaFirmy;
            TextBoxAdres.Text = Properties.Settings.Default.Adres;
            TextBoxTelefon.Text = Properties.Settings.Default.Telefon;
            TextBoxEmail.Text = Properties.Settings.Default.Email;
            ComboBoxJezykProgram.SelectedIndex = Properties.Settings.Default.JezykProgramowania;
            NumericStawkaGodz.Value = (decimal)Properties.Settings.Default.StawkaGodz;
            NumericOsoboMGodz.Value = Properties.Settings.Default.OsoboMGodz;
            NumericDzRobGodz.Value = Properties.Settings.Default.DzRobGodz;

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

        private void ComboBoxJezykProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempJezykProgramowania = ComboBoxJezykProgram.SelectedIndex;
        }

        private void NumericStawkaGodz_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempStawkaGodz = (double)NumericStawkaGodz.Value;
        }

        private void NumericOsoboMGodz_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempOsoboMGodz = (long)NumericOsoboMGodz.Value;
        }

        private void NumericDzRobGodz_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempDzRobGodz = (long)NumericDzRobGodz.Value;
        }

    }
}

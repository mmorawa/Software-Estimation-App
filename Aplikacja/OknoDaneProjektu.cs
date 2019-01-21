using System;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class OknoDaneProjektu : Form
    {
        public OknoDaneProjektu()
        {
            InitializeComponent();
            TextBoxKierownikProjektu.Text = OknoGlowne.KierownikProjektu;
            TextBoxSzacujacy.Text = OknoGlowne.Szacujacy;
            TextBoxNazwaFirmy.Text = OknoGlowne.NazwaFirmy;
            TextBoxAdres.Text = OknoGlowne.Adres;
            TextBoxTelefon.Text = OknoGlowne.Telefon;
            TextBoxEmail.Text = OknoGlowne.Email;
            RichTextBoxOpisProjektu.Text = OknoGlowne.OpisProjektu;

            CheckBoxDomyslne.Checked = OknoGlowne.Domyslne;
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
        
        private void RichTextBoxOpisProjektu_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempOpisProjektu = RichTextBoxOpisProjektu.Text;
        }

        
        private void CheckBoxDomyslne_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.KierownikProjektu.Length == 0 &&
                Properties.Settings.Default.Szacujacy.Length == 0 &&
                Properties.Settings.Default.NazwaFirmy.Length == 0 &&
                Properties.Settings.Default.Adres.Length == 0 &&
                Properties.Settings.Default.Telefon.Length == 0 &&
                Properties.Settings.Default.Email.Length ==0)
            {
                CheckBoxDomyslne.Checked = false;
                OknoGlowne.TempDomyslne = false;
                
                MessageBox.Show("Nie ma żadnych domyślnych danych.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckBoxDomyslne.Checked == true)
            {
                TextBoxKierownikProjektu.Text = Properties.Settings.Default.KierownikProjektu;
                TextBoxSzacujacy.Text = Properties.Settings.Default.Szacujacy;
                TextBoxNazwaFirmy.Text = Properties.Settings.Default.NazwaFirmy;
                TextBoxAdres.Text = Properties.Settings.Default.Adres;
                TextBoxTelefon.Text = Properties.Settings.Default.Telefon;
                TextBoxEmail.Text = Properties.Settings.Default.Email;

                OknoGlowne.TempDomyslne = true;
                MessageBox.Show("Domyślne dane zostały wprowadzone.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TextBoxKierownikProjektu.Text = "";
                TextBoxSzacujacy.Text = "";
                TextBoxNazwaFirmy.Text = "";
                TextBoxAdres.Text = "";
                TextBoxTelefon.Text = "";
                TextBoxEmail.Text = "";

                OknoGlowne.TempDomyslne = false;
            }
        }
    }
}

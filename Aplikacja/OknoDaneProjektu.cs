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
        //TODO: problem z wieloma liniami tekstu i zapisz/odczyt
        private void RichTextBoxOpisProjektu_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempOpisProjektu = RichTextBoxOpisProjektu.Text;
        }
    }
}

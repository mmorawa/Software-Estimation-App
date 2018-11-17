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
            TextBoxKierownikProjektu.Text = OknoGlowne.TabDaneProjektu[2];
            TextBoxSzacujacy.Text = OknoGlowne.TabDaneProjektu[3];
            TextBoxNazwaFirmy.Text = OknoGlowne.TabDaneProjektu[4];
            TextBoxAdres.Text = OknoGlowne.TabDaneProjektu[5];
            TextBoxTelefon.Text = OknoGlowne.TabDaneProjektu[6];
            TextBoxEmail.Text = OknoGlowne.TabDaneProjektu[7];
            RichTextBoxOpisProjektu.Text = OknoGlowne.TabDaneProjektu[8];
        }

        private void TextBoxKierownikProjektu_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabDaneProjektu[2] = TextBoxKierownikProjektu.Text;
        }

        private void TextBoxSzacujacy_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabDaneProjektu[3] = TextBoxSzacujacy.Text;
        }

        private void TextBoxNazwaFirmy_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabDaneProjektu[4] = TextBoxNazwaFirmy.Text;
        }

        private void TextBoxAdres_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabDaneProjektu[5] = TextBoxAdres.Text;
        }

        private void TextBoxTelefon_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabDaneProjektu[6] = TextBoxTelefon.Text;
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabDaneProjektu[7] = TextBoxEmail.Text;
        }
        //TODO: problem z wieloma liniami tekstu i zapisz/odczyt
        private void RichTextBoxOpisProjektu_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabDaneProjektu[8] = RichTextBoxOpisProjektu.Text;
        }
    }
}

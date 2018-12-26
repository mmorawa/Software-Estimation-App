using System;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class OknoKreator : Form
    {
        public OknoKreator()
        {
            InitializeComponent();

            TextBoxNazwaProjektu.Text = OknoGlowne.TempNazwaProjektu;
            DateTimePicker.Value = DateTime.Today;

            ComboBoxJezykProgram.SelectedIndex = OknoGlowne.JezykProgramowania;
            NumericStawkaGodz.Value = (decimal)OknoGlowne.StawkaGodz;
            NumericOsoboMGodz.Value = OknoGlowne.OsoboMGodz;
            NumericDzRobGodz.Value = OknoGlowne.DzRobGodz;

        }

        private void TextBoxNazwaProjektu_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempNazwaProjektu = TextBoxNazwaProjektu.Text;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempDataProjektu = DateTimePicker.Text;
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
                Properties.Settings.Default.Email.Length == 0)
            {
                CheckBoxDomyslne.Checked = false;
                OknoGlowne.TempDomyslne = false;
                MessageBox.Show("Nie ma żadnych domyślnych danych.");
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

        private void ButtonNDaneProj_Click(object sender, EventArgs e)
        {
            TabControlKreator.SelectTab(1);
        }




        //---------------------------------------------------------------


        private void CheckBoxAktywacja_CheckedChanged(object sender, EventArgs e)
        {
            if (TableLayoutOgraniczenia.Enabled == false)
            {
                OknoGlowne.TempOgraniczenia = true;
                TableLayoutOgraniczenia.Enabled = true;
            }
            else
            {
                OknoGlowne.TempOgraniczenia = false;
                TableLayoutOgraniczenia.Enabled = false;
            }
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

        private void NumericMaxPrac_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempMaxPrac = (long)NumericMaxPrac.Value;
        }

        private void NumericMaxHarm_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempMaxHarm = (long)NumericMaxHarm.Value;
        }

        private void TimePickerDeadline_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempDeadline = TimePickerDeadline.Value;
        }

        private void NumericMaxKoszt_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempMaxKoszt = (double)NumericMaxKoszt.Value;
        }

        private void NumericMaxZespol_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempMaxZespol = (long)NumericMaxZespol.Value;
        }

        private void ButtonPopZalProj_Click(object sender, EventArgs e)
        {
            TabControlKreator.SelectTab(0);
        }

        private void ButtonNZalProj_Click(object sender, EventArgs e)
        {
            TabControlKreator.SelectTab(2);
        }

        //--------------------------------------------------------------

        private void NumUUCWProsty_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabUUCW[0] = (long)NumUUCWProsty.Value;
        }

        private void NumUUCWSredni_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabUUCW[1] = (long)NumUUCWSredni.Value;
        }

        private void NumUUCWZlozony_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabUUCW[2] = (long)NumUUCWZlozony.Value;
        }

        private void NumUAWProsty_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabUAW[0] = (long)NumUAWProsty.Value;
        }

        private void NumUAWSredni_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabUAW[1] = (long)NumUAWSredni.Value;
        }

        private void NumUAWZlozony_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabUAW[2] = (long)NumUAWZlozony.Value;
        }

        private void ButtonPopUCP_Click(object sender, EventArgs e)
        {
            TabControlKreator.SelectTab(1);
        }

        private void ButtonNUCP_Click(object sender, EventArgs e)
        {
            TabControlKreator.SelectTab(3);
        }


        //---------------------------------------------------------------

        private void ButtonCzSk_Click(object sender, EventArgs e)
        {
            using (OknoCzynnikiSkali OknoCzynS = new OknoCzynnikiSkali())
            {
                DialogResult rezultat = OknoCzynS.ShowDialog();

            }
        }

        private void ButtonMnPr_Click(object sender, EventArgs e)
        {
            using (OknoMnoznikiPracochlonnosci OknoMnozP = new OknoMnoznikiPracochlonnosci())
            {
                DialogResult rezultat = OknoMnozP.ShowDialog();

            }
        }

        private void ButtonPopCOCOMO_Click(object sender, EventArgs e)
        {
            TabControlKreator.SelectTab(2);
        }



    }


}

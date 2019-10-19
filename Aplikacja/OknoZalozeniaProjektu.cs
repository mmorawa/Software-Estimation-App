using System;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class OknoZalozeniaProjektu : Form
    {
        public OknoZalozeniaProjektu()
        {
            InitializeComponent();

            ComboBoxJezykProgram.SelectedIndex = OknoGlowne.JezykProgramowania;

            NumericStawkaGodz.Value = (decimal)OknoGlowne.StawkaGodz;
            NumericOsoboMGodz.Value = OknoGlowne.OsoboMGodz;
            NumericDzRobGodz.Value = OknoGlowne.DzRobGodz;

            NumericMaxPrac.Value = OknoGlowne.MaxPrac;
            NumericMaxHarm.Value = OknoGlowne.MaxHarm;

            NumericMaxKoszt.Value = (decimal)OknoGlowne.MaxKoszt;
            NumericMaxZespol.Value = OknoGlowne.MaxZespol;
            TimePickerDeadline.Value = OknoGlowne.Deadline;
            CheckBoxAktywacja.Checked = OknoGlowne.Ograniczenia;
            TableLayoutOgraniczenia.Enabled = OknoGlowne.Ograniczenia;

        }



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


        private void ButtonPrzywrocDomyslne_Click(object sender, EventArgs e)
        {
            OknoGlowne.TempJezykProgramowania = Properties.Settings.Default.JezykProgramowania;
            OknoGlowne.TempStawkaGodz = Properties.Settings.Default.StawkaGodz;
            OknoGlowne.TempOsoboMGodz = Properties.Settings.Default.OsoboMGodz;
            OknoGlowne.TempDzRobGodz = Properties.Settings.Default.DzRobGodz;

            ComboBoxJezykProgram.SelectedIndex = Properties.Settings.Default.JezykProgramowania;
            NumericStawkaGodz.Value = (decimal)Properties.Settings.Default.StawkaGodz;
            NumericOsoboMGodz.Value = Properties.Settings.Default.OsoboMGodz;
            NumericDzRobGodz.Value = Properties.Settings.Default.DzRobGodz;

            MessageBox.Show("Domyślne wartości zostały przywrócone.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}

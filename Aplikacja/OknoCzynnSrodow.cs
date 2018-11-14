using System;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class OknoCzynnSrodow : Form
    {
        public OknoCzynnSrodow()
        {
            InitializeComponent();

            ComboBoxCzSZaznajProj.SelectedIndex = OknoGlowne.TabEF[0];
            ComboBoxCzSNieWymG.SelectedIndex = OknoGlowne.TabEF[1];
            ComboBoxCzSUmAnalW.SelectedIndex = OknoGlowne.TabEF[2];
            ComboBoxCzSDoswAplik.SelectedIndex = OknoGlowne.TabEF[3];
            ComboBoxCzSDoswMetOb.SelectedIndex = OknoGlowne.TabEF[4];
            ComboBoxCzSMotyw.SelectedIndex = OknoGlowne.TabEF[5];
            ComboBoxCzSTrudnJProg.SelectedIndex = OknoGlowne.TabEF[6];
            ComboBoxCzSStabWymag.SelectedIndex = OknoGlowne.TabEF[7];

        }

        private void ComboBoxCzSZaznajProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEF[0] = ComboBoxCzSZaznajProj.SelectedIndex;
        }

        private void ComboBoxCzSNieWymG_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEF[1] = ComboBoxCzSNieWymG.SelectedIndex;
        }

        private void ComboBoxCzSUmAnalW_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEF[2] = ComboBoxCzSUmAnalW.SelectedIndex;
        }

        private void ComboBoxCzSDoswAplik_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEF[3] = ComboBoxCzSDoswAplik.SelectedIndex;
        }

        private void ComboBoxCzSDoswMetOb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEF[4] = ComboBoxCzSDoswMetOb.SelectedIndex;
        }

        private void ComboBoxCzSMotyw_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEF[5] = ComboBoxCzSMotyw.SelectedIndex;
        }

        private void ComboBoxCzSTrudnJProg_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEF[6] = ComboBoxCzSTrudnJProg.SelectedIndex;
        }

        private void ComboBoxCzSStabWymag_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEF[7] = ComboBoxCzSStabWymag.SelectedIndex;
        }
    }
}

using System;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class OknoCzynnSrodow : Form
    {
        public OknoCzynnSrodow()
        {
            InitializeComponent();

            ComboBoxCzSZaznajProj.SelectedIndex = OknoGlowne.TabIndEF[0];
            ComboBoxCzSNieWymG.SelectedIndex = OknoGlowne.TabIndEF[1];
            ComboBoxCzSUmAnalW.SelectedIndex = OknoGlowne.TabIndEF[2];
            ComboBoxCzSDoswAplik.SelectedIndex = OknoGlowne.TabIndEF[3];
            ComboBoxCzSDoswMetOb.SelectedIndex = OknoGlowne.TabIndEF[4];
            ComboBoxCzSMotyw.SelectedIndex = OknoGlowne.TabIndEF[5];
            ComboBoxCzSTrudnJProg.SelectedIndex = OknoGlowne.TabIndEF[6];
            ComboBoxCzSStabWymag.SelectedIndex = OknoGlowne.TabIndEF[7];

        }

        private void ComboBoxCzSZaznajProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabIndEF[0] = ComboBoxCzSZaznajProj.SelectedIndex;
        }

        private void ComboBoxCzSNieWymG_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabIndEF[1] = ComboBoxCzSNieWymG.SelectedIndex;
        }

        private void ComboBoxCzSUmAnalW_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabIndEF[2] = ComboBoxCzSUmAnalW.SelectedIndex;
        }

        private void ComboBoxCzSDoswAplik_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabIndEF[3] = ComboBoxCzSDoswAplik.SelectedIndex;
        }

        private void ComboBoxCzSDoswMetOb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabIndEF[4] = ComboBoxCzSDoswMetOb.SelectedIndex;
        }

        private void ComboBoxCzSMotyw_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabIndEF[5] = ComboBoxCzSMotyw.SelectedIndex;
        }

        private void ComboBoxCzSTrudnJProg_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabIndEF[6] = ComboBoxCzSTrudnJProg.SelectedIndex;
        }

        private void ComboBoxCzSStabWymag_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabIndEF[7] = ComboBoxCzSStabWymag.SelectedIndex;
        }
    }
}

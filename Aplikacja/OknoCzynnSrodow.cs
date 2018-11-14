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
    public partial class OknoCzynnSrodow : Form
    {
        public OknoCzynnSrodow()
        {
            InitializeComponent();

            ComboBoxCzSZaznajProj.SelectedIndex = OknoGlowne.EF[0];
            ComboBoxCzSNieWymG.SelectedIndex = OknoGlowne.EF[1];
            ComboBoxCzSUmAnalW.SelectedIndex = OknoGlowne.EF[2];
            ComboBoxCzSDoswAplik.SelectedIndex = OknoGlowne.EF[3];
            ComboBoxCzSDoswMetOb.SelectedIndex = OknoGlowne.EF[4];
            ComboBoxCzSMotyw.SelectedIndex = OknoGlowne.EF[5];
            ComboBoxCzSTrudnJProg.SelectedIndex = OknoGlowne.EF[6];
            ComboBoxCzSStabWymag.SelectedIndex = OknoGlowne.EF[7];

        }

        private void ComboBoxCzSZaznajProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.EF[0] = ComboBoxCzSZaznajProj.SelectedIndex;
        }

        private void ComboBoxCzSNieWymG_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.EF[1] = ComboBoxCzSNieWymG.SelectedIndex;
        }

        private void ComboBoxCzSUmAnalW_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.EF[2] = ComboBoxCzSUmAnalW.SelectedIndex;
        }

        private void ComboBoxCzSDoswAplik_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.EF[3] = ComboBoxCzSDoswAplik.SelectedIndex;
        }

        private void ComboBoxCzSDoswMetOb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.EF[4] = ComboBoxCzSDoswMetOb.SelectedIndex;
        }

        private void ComboBoxCzSMotyw_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.EF[5] = ComboBoxCzSMotyw.SelectedIndex;
        }

        private void ComboBoxCzSTrudnJProg_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.EF[6] = ComboBoxCzSTrudnJProg.SelectedIndex;
        }

        private void ComboBoxCzSStabWymag_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.EF[7] = ComboBoxCzSStabWymag.SelectedIndex;
        }
    }
}

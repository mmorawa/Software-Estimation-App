using System;
using System.Windows.Forms;


namespace Aplikacja
{
    public partial class OknoCzynnikiSkali : Form
    {
        public OknoCzynnikiSkali()
        {
            InitializeComponent();

            ComboBoxCzynnSkTyp.SelectedIndex = OknoGlowne.TabIndCzynnSkali[0];
            ComboBoxCzynnSkElast.SelectedIndex = OknoGlowne.TabIndCzynnSkali[1];
            ComboBoxCzynnSkRyzyko.SelectedIndex = OknoGlowne.TabIndCzynnSkali[2];
            ComboBoxCzynnSkZesp.SelectedIndex = OknoGlowne.TabIndCzynnSkali[3];
            ComboBoxCzynnSkDojrz.SelectedIndex = OknoGlowne.TabIndCzynnSkali[4];
        }

        

        private void ComboBoxCzynnSkTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndCzynnSkali[0] = ComboBoxCzynnSkTyp.SelectedIndex;
        }

        private void ComboBoxCzynnSkElast_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndCzynnSkali[1] = ComboBoxCzynnSkElast.SelectedIndex;
        }

        private void ComboBoxCzynnSkRyzyko_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndCzynnSkali[2] = ComboBoxCzynnSkRyzyko.SelectedIndex;
        }

        private void ComboBoxCzynnSkZesp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndCzynnSkali[3] = ComboBoxCzynnSkZesp.SelectedIndex;
        }

        private void ComboBoxCzynnSkDojrz_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndCzynnSkali[4] = ComboBoxCzynnSkDojrz.SelectedIndex;
        }
    }
}

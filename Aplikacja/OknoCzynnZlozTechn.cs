using System;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class OknoCzynnZlozTechn : Form
    {
        

        public OknoCzynnZlozTechn()
        {            
            InitializeComponent();

            ComboBoxCzTRozp.SelectedIndex = OknoGlowne.TabIndTCF[0];
            ComboBoxCzTWydaj.SelectedIndex = OknoGlowne.TabIndTCF[1];
            ComboBoxCzTWydajUztk.SelectedIndex = OknoGlowne.TabIndTCF[2];
            ComboBoxCzTPrzetwW.SelectedIndex = OknoGlowne.TabIndTCF[3];
            ComboBoxCzTPonUzycie.SelectedIndex = OknoGlowne.TabIndTCF[4];
            ComboBoxCzTLatwInst.SelectedIndex = OknoGlowne.TabIndTCF[5];
            ComboBoxCzTLatwUzyc.SelectedIndex = OknoGlowne.TabIndTCF[6];
            ComboBoxCzTPrzen.SelectedIndex = OknoGlowne.TabIndTCF[7];
            ComboBoxCzTLatwZmian.SelectedIndex = OknoGlowne.TabIndTCF[8];
            ComboBoxCzTPrzetwWsp.SelectedIndex = OknoGlowne.TabIndTCF[9];
            ComboBoxCzTSpecZabezp.SelectedIndex = OknoGlowne.TabIndTCF[10];
            ComboBoxCzTZewnOpr.SelectedIndex = OknoGlowne.TabIndTCF[11];
            ComboBoxCzTDodSzkol.SelectedIndex = OknoGlowne.TabIndTCF[12];
            
               
        }

        private void ComboBoxCzTRozp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndTCF[0] = ComboBoxCzTRozp.SelectedIndex;
        }

        private void ComboBoxCzTWydaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndTCF[1] = ComboBoxCzTWydaj.SelectedIndex;
        }

        private void ComboBoxCzTWydajUztk_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndTCF[2] = ComboBoxCzTWydajUztk.SelectedIndex;
        }

        private void ComboBoxCzTPrzetwW_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndTCF[3] = ComboBoxCzTPrzetwW.SelectedIndex;
        }

        private void ComboBoxCzTPonUzycie_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndTCF[4] = ComboBoxCzTPonUzycie.SelectedIndex;
        }

        private void ComboBoxCzTLatwInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndTCF[5] = ComboBoxCzTLatwInst.SelectedIndex;
        }

        private void ComboBoxCzTLatwUzyc_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndTCF[6] = ComboBoxCzTLatwUzyc.SelectedIndex;
        }

        private void ComboBoxCzTPrzen_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndTCF[7] = ComboBoxCzTPrzen.SelectedIndex;
        }

        private void ComboBoxCzTLatwZmian_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndTCF[8] = ComboBoxCzTLatwZmian.SelectedIndex;
        }

        private void ComboBoxCzTPrzetwWsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndTCF[9] = ComboBoxCzTPrzetwWsp.SelectedIndex;
        }

        private void ComboBoxCzTSpecZabezp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndTCF[10] = ComboBoxCzTSpecZabezp.SelectedIndex;
        }

        private void ComboBoxCzTZewnOpr_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndTCF[11] = ComboBoxCzTZewnOpr.SelectedIndex;
        }

        private void ComboBoxCzTDodSzkol_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndTCF[12] = ComboBoxCzTDodSzkol.SelectedIndex;
        }

    }
}

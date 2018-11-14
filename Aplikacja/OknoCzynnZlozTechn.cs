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
    public partial class OknoCzynnZlozTechn : Form
    {
        

        public OknoCzynnZlozTechn()
        {            
            InitializeComponent();

            ComboBoxCzTRozp.SelectedIndex = OknoGlowne.TabTCF[0];
            ComboBoxCzTWydaj.SelectedIndex = OknoGlowne.TabTCF[1];
            ComboBoxCzTWydajUztk.SelectedIndex = OknoGlowne.TabTCF[2];
            ComboBoxCzTPrzetwW.SelectedIndex = OknoGlowne.TabTCF[3];
            ComboBoxCzTPonUzycie.SelectedIndex = OknoGlowne.TabTCF[4];
            ComboBoxCzTLatwInst.SelectedIndex = OknoGlowne.TabTCF[5];
            ComboBoxCzTLatwUzyc.SelectedIndex = OknoGlowne.TabTCF[6];
            ComboBoxCzTPrzen.SelectedIndex = OknoGlowne.TabTCF[7];
            ComboBoxCzTLatwZmian.SelectedIndex = OknoGlowne.TabTCF[8];
            ComboBoxCzTPrzetwWsp.SelectedIndex = OknoGlowne.TabTCF[9];
            ComboBoxCzTSpecZabezp.SelectedIndex = OknoGlowne.TabTCF[10];
            ComboBoxCzTZewnOpr.SelectedIndex = OknoGlowne.TabTCF[11];
            ComboBoxCzTDodSzkol.SelectedIndex = OknoGlowne.TabTCF[12];
            
               
        }

        private void ComboBoxCzTRozp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabTCF[0] = ComboBoxCzTRozp.SelectedIndex;
        }

        private void ComboBoxCzTWydaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabTCF[1] = ComboBoxCzTWydaj.SelectedIndex;
        }

        private void ComboBoxCzTWydajUztk_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabTCF[2] = ComboBoxCzTWydajUztk.SelectedIndex;
        }

        private void ComboBoxCzTPrzetwW_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabTCF[3] = ComboBoxCzTPrzetwW.SelectedIndex;
        }

        private void ComboBoxCzTPonUzycie_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabTCF[4] = ComboBoxCzTPonUzycie.SelectedIndex;
        }

        private void ComboBoxCzTLatwInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabTCF[5] = ComboBoxCzTLatwInst.SelectedIndex;
        }

        private void ComboBoxCzTLatwUzyc_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabTCF[6] = ComboBoxCzTLatwUzyc.SelectedIndex;
        }

        private void ComboBoxCzTPrzen_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabTCF[7] = ComboBoxCzTPrzen.SelectedIndex;
        }

        private void ComboBoxCzTLatwZmian_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabTCF[8] = ComboBoxCzTLatwZmian.SelectedIndex;
        }

        private void ComboBoxCzTPrzetwWsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabTCF[9] = ComboBoxCzTPrzetwWsp.SelectedIndex;
        }

        private void ComboBoxCzTSpecZabezp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabTCF[10] = ComboBoxCzTSpecZabezp.SelectedIndex;
        }

        private void ComboBoxCzTZewnOpr_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabTCF[11] = ComboBoxCzTZewnOpr.SelectedIndex;
        }

        private void ComboBoxCzTDodSzkol_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabTCF[12] = ComboBoxCzTDodSzkol.SelectedIndex;
        }

    }
}

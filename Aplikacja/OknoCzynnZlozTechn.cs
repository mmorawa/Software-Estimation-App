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

            ComboBoxCzTRozp.SelectedIndex = OknoGlowne.TCF[0];
            ComboBoxCzTWydaj.SelectedIndex = OknoGlowne.TCF[1];
            ComboBoxCzTWydajUztk.SelectedIndex = OknoGlowne.TCF[2];
            ComboBoxCzTPrzetwW.SelectedIndex = OknoGlowne.TCF[3];
            ComboBoxCzTPonUzycie.SelectedIndex = OknoGlowne.TCF[4];
            ComboBoxCzTLatwInst.SelectedIndex = OknoGlowne.TCF[5];
            ComboBoxCzTLatwUzyc.SelectedIndex = OknoGlowne.TCF[6];
            ComboBoxCzTPrzen.SelectedIndex = OknoGlowne.TCF[7];
            ComboBoxCzTLatwZmian.SelectedIndex = OknoGlowne.TCF[8];
            ComboBoxCzTPrzetwWsp.SelectedIndex = OknoGlowne.TCF[9];
            ComboBoxCzTSpecZabezp.SelectedIndex = OknoGlowne.TCF[10];
            ComboBoxCzTZewnOpr.SelectedIndex = OknoGlowne.TCF[11];
            ComboBoxCzTDodSzkol.SelectedIndex = OknoGlowne.TCF[12];
            
               
        }

        private void ComboBoxCzTRozp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[0] = ComboBoxCzTRozp.SelectedIndex;
        }

        private void ComboBoxCzTWydaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[1] = ComboBoxCzTWydaj.SelectedIndex;
        }

        private void ComboBoxCzTWydajUztk_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[2] = ComboBoxCzTWydajUztk.SelectedIndex;
        }

        private void ComboBoxCzTPrzetwW_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[3] = ComboBoxCzTPrzetwW.SelectedIndex;
        }

        private void ComboBoxCzTPonUzycie_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[4] = ComboBoxCzTPonUzycie.SelectedIndex;
        }

        private void ComboBoxCzTLatwInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[5] = ComboBoxCzTLatwInst.SelectedIndex;
        }

        private void ComboBoxCzTLatwUzyc_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[6] = ComboBoxCzTLatwUzyc.SelectedIndex;
        }

        private void ComboBoxCzTPrzen_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[7] = ComboBoxCzTPrzen.SelectedIndex;
        }

        private void ComboBoxCzTLatwZmian_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[8] = ComboBoxCzTLatwZmian.SelectedIndex;
        }

        private void ComboBoxCzTPrzetwWsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[9] = ComboBoxCzTPrzetwWsp.SelectedIndex;
        }

        private void ComboBoxCzTSpecZabezp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[10] = ComboBoxCzTSpecZabezp.SelectedIndex;
        }

        private void ComboBoxCzTZewnOpr_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[11] = ComboBoxCzTZewnOpr.SelectedIndex;
        }

        private void ComboBoxCzTDodSzkol_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[12] = ComboBoxCzTDodSzkol.SelectedIndex;
        }

    }
}

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

            ComboBoxCzTDodSzkol.SelectedIndex = 0;
            ComboBoxCzTLatwInst.SelectedIndex = 0;
            ComboBoxCzTLatwUzyc.SelectedIndex = 0;
            ComboBoxCzTLatwZmian.SelectedIndex = 0;
            ComboBoxCzTPonUzycie.SelectedIndex = 0;
            ComboBoxCzTPrzen.SelectedIndex = 0;
            ComboBoxCzTPrzetwW.SelectedIndex = 0;
            ComboBoxCzTPrzetwWsp.SelectedIndex = 0;
            ComboBoxCzTRozp.SelectedIndex = 0;
            ComboBoxCzTSpecZabezp.SelectedIndex = 0;
            ComboBoxCzTWydaj.SelectedIndex = 0;
            ComboBoxCzTWydajUztk.SelectedIndex = 0;
            ComboBoxCzTZewnOpr.SelectedIndex = 0;
        }

        private void ComboBoxCzTRozp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[0] = 2 * ComboBoxCzTRozp.SelectedIndex;
        }

        private void ComboBoxCzTWydaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[1] = 1 * ComboBoxCzTWydaj.SelectedIndex;
        }

        private void ComboBoxCzTWydajUztk_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[2] = 1 * ComboBoxCzTWydajUztk.SelectedIndex;
        }

        private void ComboBoxCzTPrzetwW_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[3] = 1 * ComboBoxCzTPrzetwW.SelectedIndex;
        }

        private void ComboBoxCzTPonUzycie_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[4] = 1 * ComboBoxCzTPonUzycie.SelectedIndex;
        }

        private void ComboBoxCzTLatwInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[5] = 0.5 * ComboBoxCzTLatwInst.SelectedIndex;
        }

        private void ComboBoxCzTLatwUzyc_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[6] = 0.5 * ComboBoxCzTLatwUzyc.SelectedIndex;
        }

        private void ComboBoxCzTPrzen_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[7] = 2 * ComboBoxCzTPrzen.SelectedIndex;
        }

        private void ComboBoxCzTLatwZmian_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[8] = 1 * ComboBoxCzTLatwZmian.SelectedIndex;
        }

        private void ComboBoxCzTPrzetwWsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[9] = 1 * ComboBoxCzTPrzetwWsp.SelectedIndex;
        }

        private void ComboBoxCzTSpecZabezp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[10] = 1 * ComboBoxCzTSpecZabezp.SelectedIndex;
        }

        private void ComboBoxCzTZewnOpr_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[11] = 1 * ComboBoxCzTZewnOpr.SelectedIndex;
        }

        private void ComboBoxCzTDodSzkol_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TCF[12] = 1 * ComboBoxCzTDodSzkol.SelectedIndex;
        }

    }
}

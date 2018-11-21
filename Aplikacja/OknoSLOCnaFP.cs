using System;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class OknoSLOCnaFP : Form
    {
        public OknoSLOCnaFP()
        {
            InitializeComponent();

            NumericABAP.Value = Properties.Settings.Default.TabPrzeliczeniowa[0];
            NumericASP.Value = Properties.Settings.Default.TabPrzeliczeniowa[1];
            NumericAssembler.Value = Properties.Settings.Default.TabPrzeliczeniowa[2];
            NumericBrio.Value = Properties.Settings.Default.TabPrzeliczeniowa[3];
            NumericC.Value = Properties.Settings.Default.TabPrzeliczeniowa[4];
            NumericCpp.Value = Properties.Settings.Default.TabPrzeliczeniowa[5];
            NumericCsharp.Value = Properties.Settings.Default.TabPrzeliczeniowa[6];
            NumericCOBOL.Value = Properties.Settings.Default.TabPrzeliczeniowa[7];
            NumericCognos.Value = Properties.Settings.Default.TabPrzeliczeniowa[8];
            NumericCross.Value = Properties.Settings.Default.TabPrzeliczeniowa[9];
            NumericCool.Value = Properties.Settings.Default.TabPrzeliczeniowa[10];
            NumericDatastage.Value = Properties.Settings.Default.TabPrzeliczeniowa[11];
            NumericExcel.Value = Properties.Settings.Default.TabPrzeliczeniowa[12];
            NumericFocus.Value = Properties.Settings.Default.TabPrzeliczeniowa[13];
            NumericFoxPro.Value = Properties.Settings.Default.TabPrzeliczeniowa[14];
            NumericHTML.Value = Properties.Settings.Default.TabPrzeliczeniowa[15];
            NumericJ2EE.Value = Properties.Settings.Default.TabPrzeliczeniowa[16];
            NumericJava.Value = Properties.Settings.Default.TabPrzeliczeniowa[17];
            NumericJavaScript.Value = Properties.Settings.Default.TabPrzeliczeniowa[18];
            NumericJCL.Value = Properties.Settings.Default.TabPrzeliczeniowa[19];
            NumericLINC.Value = Properties.Settings.Default.TabPrzeliczeniowa[20];
            NumericLotus.Value = Properties.Settings.Default.TabPrzeliczeniowa[21];
            NumericNatural.Value = Properties.Settings.Default.TabPrzeliczeniowa[22];
            NumericDotNet.Value = Properties.Settings.Default.TabPrzeliczeniowa[23];
            NumericOracle.Value = Properties.Settings.Default.TabPrzeliczeniowa[24];
            NumericPACBASE.Value = Properties.Settings.Default.TabPrzeliczeniowa[25];
            NumericPerl.Value = Properties.Settings.Default.TabPrzeliczeniowa[26];
            NumericPLI.Value = Properties.Settings.Default.TabPrzeliczeniowa[27];
            NumericPLSQL.Value = Properties.Settings.Default.TabPrzeliczeniowa[28];
            NumericPowerbuilder.Value = Properties.Settings.Default.TabPrzeliczeniowa[29];
            NumericREXX.Value = Properties.Settings.Default.TabPrzeliczeniowa[30];
            NumericSabretalk.Value = Properties.Settings.Default.TabPrzeliczeniowa[31];
            NumericSAS.Value = Properties.Settings.Default.TabPrzeliczeniowa[32];
            NumericSiebel.Value = Properties.Settings.Default.TabPrzeliczeniowa[33];
            NumericSLOGAN.Value = Properties.Settings.Default.TabPrzeliczeniowa[34];
            NumericSQL.Value = Properties.Settings.Default.TabPrzeliczeniowa[35];
            NumericVBNet.Value = Properties.Settings.Default.TabPrzeliczeniowa[36];
            NumericVisualBasic.Value = Properties.Settings.Default.TabPrzeliczeniowa[37];

        }

        private void NumericABAP_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[0] = (int)NumericABAP.Value;
        }

        private void NumericASP_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[1] = (int)NumericASP.Value;
        }

        private void NumericAssembler_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[2] = (int)NumericAssembler.Value;
        }

        private void NumericBrio_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[3] = (int)NumericBrio.Value;
        }

        private void NumericC_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[4] = (int)NumericC.Value;
        }

        private void NumericCpp_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[5] = (int)NumericCpp.Value;
        }

        private void NumericCsharp_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[6] = (int)NumericCsharp.Value;
        }

        private void NumericCOBOL_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[7] = (int)NumericCOBOL.Value;
        }

        private void NumericCognos_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[8] = (int)NumericCognos.Value;
        }

        private void NumericCross_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[9] = (int)NumericCross.Value;
        }

        private void NumericCool_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[10] = (int)NumericCool.Value;
        }

        private void NumericDatastage_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[11] = (int)NumericDatastage.Value;
        }

        private void NumericExcel_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[12] = (int)NumericExcel.Value;
        }

        private void NumericFocus_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[13] = (int)NumericFocus.Value;
        }

        private void NumericFoxPro_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[14] = (int)NumericFoxPro.Value;
        }

        private void NumericHTML_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[15] = (int)NumericHTML.Value;
        }

        private void NumericJ2EE_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[16] = (int)NumericJ2EE.Value;
        }

        private void NumericJava_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[17] = (int)NumericJava.Value;
        }

        private void NumericJavaScript_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[18] = (int)NumericJavaScript.Value;
        }

        private void NumericJCL_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[19] = (int)NumericJCL.Value;
        }

        private void NumericLINC_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[20] = (int)NumericLINC.Value;
        }

        private void NumericLotus_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[21] = (int)NumericLotus.Value;
        }

        private void NumericNatural_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[22] = (int)NumericNatural.Value;
        }

        private void NumericDotNet_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[23] = (int)NumericDotNet.Value;
        }

        private void NumericOracle_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[24] = (int)NumericOracle.Value;
        }

        private void NumericPACBASE_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[25] = (int)NumericPACBASE.Value;
        }

        private void NumericPerl_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[26] = (int)NumericPerl.Value;
        }

        private void NumericPLI_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[27] = (int)NumericPLI.Value;
        }

        private void NumericPLSQL_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[28] = (int)NumericPLSQL.Value;
        }

        private void NumericPowerbuilder_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[29] = (int)NumericPowerbuilder.Value;
        }

        private void NumericREXX_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[30] = (int)NumericREXX.Value;
        }

        private void NumericSabretalk_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[31] = (int)NumericSabretalk.Value;
        }

        private void NumericSAS_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[32] = (int)NumericSAS.Value;
        }

        private void NumericSiebel_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[33] = (int)NumericSiebel.Value;
        }

        private void NumericSLOGAN_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[34] = (int)NumericSLOGAN.Value;
        }

        private void NumericSQL_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[35] = (int)NumericSQL.Value;
        }

        private void NumericVBNet_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[36] = (int)NumericVBNet.Value;
        }

        private void NumericVisualBasic_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabPktFunkSLOC[37] = (int)NumericVisualBasic.Value;
        }



        private void ButtonPrzywrocDomyslne_Click(object sender, EventArgs e)
        {

        }
    }
}

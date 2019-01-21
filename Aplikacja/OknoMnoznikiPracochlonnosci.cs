using System;
using System.Windows.Forms;


namespace Aplikacja
{
    public partial class OknoMnoznikiPracochlonnosci : Form
    {

        public OknoMnoznikiPracochlonnosci()
        {
            InitializeComponent();

            ComboBoxMnPrNiezaw.SelectedIndex = OknoGlowne.TabIndMnPrac[0];
            ComboBoxMnPrBaza.SelectedIndex = OknoGlowne.TabIndMnPrac[1] - 1;
            ComboBoxMnPrZloz.SelectedIndex = OknoGlowne.TabIndMnPrac[2];
            //zamiana kolejności inicjalizacji ze względu na warunek ograniczający mnożnik 
            ComboBoxMnPrDoku.SelectedIndex = OknoGlowne.TabIndMnPrac[4];
            ComboBoxMnPrPonow.SelectedIndex = OknoGlowne.TabIndMnPrac[3] - 1;
            

            ComboBoxMnPrAnal.SelectedIndex = OknoGlowne.TabIndMnPrac[5];
            ComboBoxMnPrProgr.SelectedIndex = OknoGlowne.TabIndMnPrac[6];
            ComboBoxMnPrZesp.SelectedIndex = OknoGlowne.TabIndMnPrac[7];
            ComboBoxMnPrDoswA.SelectedIndex = OknoGlowne.TabIndMnPrac[8];
            ComboBoxMnPrDoswP.SelectedIndex = OknoGlowne.TabIndMnPrac[9];
            ComboBoxMnPrDoswJ.SelectedIndex = OknoGlowne.TabIndMnPrac[10];
            

            ComboBoxMnPrOgrCz.SelectedIndex = OknoGlowne.TabIndMnPrac[11] - 2;
            ComboBoxMnPrOgrP.SelectedIndex = OknoGlowne.TabIndMnPrac[12] - 2;
            ComboBoxMnPrZmP.SelectedIndex = OknoGlowne.TabIndMnPrac[13] - 1;

            ComboBoxMnPrNarzP.SelectedIndex = OknoGlowne.TabIndMnPrac[14];
            ComboBoxMnPrLokal.SelectedIndex = OknoGlowne.TabIndMnPrac[15];
            ComboBoxMnPrHarm.SelectedIndex = OknoGlowne.TabIndMnPrac[16];

        }
        

        //---------------Dot. produktu----------------------------------
        private void ComboBoxMnPrNiezaw_SelectedIndexChanged(object sender, EventArgs e)
        {
            //uwzględniamy ograniczenia nałożone przez mnożnik "możliwość ponownego wykorzystania"
            if (ComboBoxMnPrNiezaw.SelectedIndex >= (OknoGlowne.TempTabIndMnPrac[3]))
            {
                OknoGlowne.TempTabIndMnPrac[0] = ComboBoxMnPrNiezaw.SelectedIndex;
            }
            else
            {
                ComboBoxMnPrNiezaw.SelectedIndex = OknoGlowne.TempTabIndMnPrac[0];
                MessageBox.Show("Mnożnik wymagana niezawodność oprogramowania może być co najwyżej o jeden poziom niższy od " +
                    "mnożnika możliwość ponownego wykorzystania.", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void ComboBoxMnPrBaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[1] = ComboBoxMnPrBaza.SelectedIndex + 1;
        }

        private void ComboBoxMnPrZloz_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[2] = ComboBoxMnPrZloz.SelectedIndex;
        }

        private void ComboBoxMnPrPonow_SelectedIndexChanged(object sender, EventArgs e)
        {
            //uwzględniamy ograniczenia           
            if (OknoGlowne.TempTabIndMnPrac[0] < ComboBoxMnPrPonow.SelectedIndex)
            {
                ComboBoxMnPrPonow.SelectedIndex = OknoGlowne.TempTabIndMnPrac[3];
                MessageBox.Show("Zwiększenie poziomu mnożnika możliwość ponownego wykorzystania wymaga najpierw podwyższenia poziomu" +
                    " mnożnika wymagana niezawodność oprogramowania co najmniej do poziomu o jeden niższego od zaplanowanego zwiększenia tego pierwszego. ", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if ((ComboBoxMnPrPonow.SelectedIndex == 1 || ComboBoxMnPrPonow.SelectedIndex == 2) && OknoGlowne.TempTabIndMnPrac[4] < 2)
            {
                ComboBoxMnPrPonow.SelectedIndex = OknoGlowne.TempTabIndMnPrac[3];
                MessageBox.Show("Zwiększenie poziomu mnożnika możliwość ponownego wykorzystania do poziomu nominalnego lub wysokiego wymaga najpierw podwyższenia poziomu" +
                    " mnożnika dokumentacja odpowiada wymaganiom cyklu życia co najmniej do poziomu nominalnego. ", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((ComboBoxMnPrPonow.SelectedIndex == 3 || ComboBoxMnPrPonow.SelectedIndex == 4) && OknoGlowne.TempTabIndMnPrac[4] < 3)
            {
                MessageBox.Show("Zwiększenie poziomu mnożnika możliwość ponownego wykorzystania do poziomu bardzo wysokiego lub ekstra wysokiego wymaga najpierw podwyższenia poziomu" +
                    " mnożnika dokumentacja odpowiada wymaganiom cyklu życia co najmniej do poziomu wysokiego. ", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBoxMnPrPonow.SelectedIndex = OknoGlowne.TempTabIndMnPrac[3];
            }
            else
            {
                OknoGlowne.TempTabIndMnPrac[3] = ComboBoxMnPrPonow.SelectedIndex + 1;
            }

        }

        private void ComboBoxMnPrDoku_SelectedIndexChanged(object sender, EventArgs e)
        {
            //uwzględniamy ograniczenia nałożone przez mnożnik "możliwość ponownego wykorzystania"
            if ((OknoGlowne.TempTabIndMnPrac[3] == 1 || OknoGlowne.TempTabIndMnPrac[3] == 2) && ComboBoxMnPrDoku.SelectedIndex < 2)
            {
                ComboBoxMnPrDoku.SelectedIndex = OknoGlowne.TempTabIndMnPrac[4];
                MessageBox.Show("Mnożnik dokumentacja odpowiada wymaganiom cyklu życia musi być co najmniej na poziomie nominalnym," +
                    " gdy poziom mnożnika możliwość ponownego wykorzystania jest na poziomie nominalnym lub wysokim.", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((OknoGlowne.TempTabIndMnPrac[3] == 3 || OknoGlowne.TempTabIndMnPrac[3] == 4) && ComboBoxMnPrDoku.SelectedIndex < 3)
            {
                ComboBoxMnPrDoku.SelectedIndex = OknoGlowne.TempTabIndMnPrac[4];
                MessageBox.Show("Mnożnik dokumentacja odpowiada wymaganiom cyklu życia musi być co najmniej na poziomie wysokim," +
                    " gdy poziom mnożnika możliwość ponownego wykorzystania jest na poziomie bardzo wysokim lub esktra wysokim.", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OknoGlowne.TempTabIndMnPrac[4] = ComboBoxMnPrDoku.SelectedIndex;
            }

        }

        //----------------Dot. personelu--------------------------------------------
        private void ComboBoxMnPrAnal_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[5] = ComboBoxMnPrAnal.SelectedIndex;
        }

        private void ComboBoxMnPrProgr_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[6] = ComboBoxMnPrProgr.SelectedIndex;
        }

        private void ComboBoxMnPrZesp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[7] = ComboBoxMnPrZesp.SelectedIndex;
        }

        private void ComboBoxMnPrDoswA_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[8] = ComboBoxMnPrDoswA.SelectedIndex;
        }

        private void ComboBoxMnPrDoswP_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[9] = ComboBoxMnPrDoswP.SelectedIndex;
        }

        private void ComboBoxMnPrDoswJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[10] = ComboBoxMnPrDoswJ.SelectedIndex;
        }

        //-----------------Dot. platformy-------------------------------------------
        private void ComboBoxMnPrOgrCz_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[11] = ComboBoxMnPrOgrCz.SelectedIndex + 2;
        }

        private void ComboBoxMnPrOgrP_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[12] = ComboBoxMnPrOgrP.SelectedIndex + 2;
        }

        private void ComboBoxMnPrZmP_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[13] = ComboBoxMnPrZmP.SelectedIndex + 1;
        }


        //-----------------Dot. projektu-------------------------------------------
        private void ComboBoxMnPrNarzP_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[14] = ComboBoxMnPrNarzP.SelectedIndex;
        }

        private void ComboBoxMnPrLokal_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[15] = ComboBoxMnPrLokal.SelectedIndex;
        }

        private void ComboBoxMnPrHarm_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndMnPrac[16] = ComboBoxMnPrHarm.SelectedIndex;
        }


    }
}

/*! \file Form1.cs
\brief Plik Form1.cs zawiera klasę Form1 z głównym oknem aplikacji.

Plik Form1.cs zawiera rdzeń programu czyli główne okno aplikacji wraz z menu, pozwalającym na dokonanie wyboru różnych opcji menadżera zadań takich jak: szyfrowanie/deszyfrowanie bazy danych.
*/

using System;
using System.Windows.Forms;


//! Przestrzeń nazw Password_Manager obejmuje całą aplikację Menedżera Haseł.
/*! Password_Manager to przestrzeń nazw, która obejmuje całą aplikację Menedżera Haseł, ze wszystkimi klasami Form. */
namespace Aplikacja
{
    //! Klasa Form1 zawiera główne okno aplikacji.
    /*! W klasie Form1 znajduje się menu główne aplikacji, przyciski oraz Textboxy z danymi, oraz warstwa logiczna aplikacji */
    public partial class OknoMnoznikiPracochlonnosci : Form
    {
        //! Konstruktor klasy Form1.
        /*! Inicjalizuje komponenty klasy Form1. */
        public OknoMnoznikiPracochlonnosci()
        {
            InitializeComponent();

            ComboBoxMnPrNiezaw.SelectedIndex = OknoGlowne.TabIndEM[0];
            ComboBoxMnPrBaza.SelectedIndex = OknoGlowne.TabIndEM[1];
            ComboBoxMnPrZloz.SelectedIndex = OknoGlowne.TabIndEM[2];
            //zamiana kolejności inicjalizacji ze względu na warunek ograniczający mnożnik 
            ComboBoxMnPrDoku.SelectedIndex = OknoGlowne.TabIndEM[4];
            ComboBoxMnPrPonow.SelectedIndex = OknoGlowne.TabIndEM[3];
            

            ComboBoxMnPrAnal.SelectedIndex = OknoGlowne.TabIndEM[5];
            ComboBoxMnPrProgr.SelectedIndex = OknoGlowne.TabIndEM[6];
            ComboBoxMnPrZesp.SelectedIndex = OknoGlowne.TabIndEM[7];
            ComboBoxMnPrDoswA.SelectedIndex = OknoGlowne.TabIndEM[8];
            ComboBoxMnPrDoswP.SelectedIndex = OknoGlowne.TabIndEM[9];
            ComboBoxMnPrDoswJ.SelectedIndex = OknoGlowne.TabIndEM[10];
            

            ComboBoxMnPrOgrCz.SelectedIndex = OknoGlowne.TabIndEM[11];
            ComboBoxMnPrOgrP.SelectedIndex = OknoGlowne.TabIndEM[12];
            ComboBoxMnPrZmP.SelectedIndex = OknoGlowne.TabIndEM[13];

            ComboBoxMnPrNarzP.SelectedIndex = OknoGlowne.TabIndEM[14];
            ComboBoxMnPrLokal.SelectedIndex = OknoGlowne.TabIndEM[15];
            ComboBoxMnPrHarm.SelectedIndex = OknoGlowne.TabIndEM[16];

            //ToolTip.SetToolTip(comboBox1, "Save changes");

        }
        

        //---------------Dot. produktu----------------------------------
        private void ComboBoxMnPrNiezaw_SelectedIndexChanged(object sender, EventArgs e)
        {
            //uwzględniamy ograniczenia nałożone przez mnożnik możliwość ponownego wykorzystania
            if (ComboBoxMnPrNiezaw.SelectedIndex >= (OknoGlowne.TempTabIndEM[3]))
            {
                OknoGlowne.TempTabIndEM[0] = ComboBoxMnPrNiezaw.SelectedIndex;
            }
            else
            {
                ComboBoxMnPrNiezaw.SelectedIndex = OknoGlowne.TempTabIndEM[0];
                MessageBox.Show("Mnożnik wymagana niezawodność oprogramowania może być co najwyżej o jeden poziom niższy od " +
                    "mnożnika możliwość ponownego wykorzystania.", "Ostrzeżenie");
            }
            
        }

        private void ComboBoxMnPrBaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[1] = ComboBoxMnPrBaza.SelectedIndex;
        }

        private void ComboBoxMnPrZloz_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[2] = ComboBoxMnPrZloz.SelectedIndex;
        }

        private void ComboBoxMnPrPonow_SelectedIndexChanged(object sender, EventArgs e)
        {
            //uwzględniamy ograniczenia           
            if (OknoGlowne.TempTabIndEM[0] < ComboBoxMnPrPonow.SelectedIndex)
            {
                ComboBoxMnPrPonow.SelectedIndex = OknoGlowne.TempTabIndEM[3];
                MessageBox.Show("Zwiększenie poziomu mnożnika możliwość ponownego wykorzystania wymaga najpierw podwyższenia poziomu" +
                    " mnożnika wymagana niezawodność oprogramowania co najmniej do poziomu o jeden niższego od zaplanowanego zwiększenia tego pierwszego. ", "Ostrzeżenie");

            }
            else if ((ComboBoxMnPrPonow.SelectedIndex == 1 || ComboBoxMnPrPonow.SelectedIndex == 2) && OknoGlowne.TempTabIndEM[4] < 2)
            {
                ComboBoxMnPrPonow.SelectedIndex = OknoGlowne.TempTabIndEM[3];
                MessageBox.Show("Zwiększenie poziomu mnożnika możliwość ponownego wykorzystania do poziomu nominalnego lub wysokiego wymaga najpierw podwyższenia poziomu" +
                    " mnożnika dokumentacja odpowiada wymaganiom cyklu życia co najmniej do poziomu nominalnego. ", "Ostrzeżenie");
            }
            else if ((ComboBoxMnPrPonow.SelectedIndex == 3 || ComboBoxMnPrPonow.SelectedIndex == 4) && OknoGlowne.TempTabIndEM[4] < 3)
            {
                MessageBox.Show("Zwiększenie poziomu mnożnika możliwość ponownego wykorzystania do poziomu bardzo wysokiego lub ekstra wysokiego wymaga najpierw podwyższenia poziomu" +
                    " mnożnika dokumentacja odpowiada wymaganiom cyklu życia co najmniej do poziomu wysokiego. ", "Ostrzeżenie");
                ComboBoxMnPrPonow.SelectedIndex = OknoGlowne.TempTabIndEM[3];
            }
            else
            {
                OknoGlowne.TempTabIndEM[3] = ComboBoxMnPrPonow.SelectedIndex;
            }

        }

        private void ComboBoxMnPrDoku_SelectedIndexChanged(object sender, EventArgs e)
        {
            //uwzględniamy ograniczenia nałożone przez mnożnik możliwość ponownego wykorzystania
            if ((OknoGlowne.TempTabIndEM[3] == 1 || OknoGlowne.TempTabIndEM[3] == 2) && ComboBoxMnPrDoku.SelectedIndex < 2)
            {
                ComboBoxMnPrDoku.SelectedIndex = OknoGlowne.TempTabIndEM[4];
                MessageBox.Show("Mnożnik dokumentacja odpowiada wymaganiom cyklu życia musi być co najmniej na poziomie nominalnym," +
                    " gdy poziom mnożnika możliwość ponownego wykorzystania jest na poziomie nominalnym lub wysokim.", "Ostrzeżenie"); 
            }
            else if ((OknoGlowne.TempTabIndEM[3] == 3 || OknoGlowne.TempTabIndEM[3] == 4) && ComboBoxMnPrDoku.SelectedIndex < 3)
            {
                ComboBoxMnPrDoku.SelectedIndex = OknoGlowne.TempTabIndEM[4];
                MessageBox.Show("Mnożnik dokumentacja odpowiada wymaganiom cyklu życia musi być co najmniej na poziomie wysokim," +
                    " gdy poziom mnożnika możliwość ponownego wykorzystania jest na poziomie bardzo wysokim lub esktra wysokim.", "Ostrzeżenie");
            }
            else
            {
                OknoGlowne.TempTabIndEM[4] = ComboBoxMnPrDoku.SelectedIndex;
            }

        }

        //----------------Dot. personelu--------------------------------------------
        private void ComboBoxMnPrAnal_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[5] = ComboBoxMnPrAnal.SelectedIndex;
        }

        private void ComboBoxMnPrProgr_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[6] = ComboBoxMnPrProgr.SelectedIndex;
        }

        private void ComboBoxMnPrZesp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[7] = ComboBoxMnPrZesp.SelectedIndex;
        }

        private void ComboBoxMnPrDoswA_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[8] = ComboBoxMnPrDoswA.SelectedIndex;
        }

        private void ComboBoxMnPrDoswP_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[9] = ComboBoxMnPrDoswP.SelectedIndex;
        }

        private void ComboBoxMnPrDoswJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[10] = ComboBoxMnPrDoswJ.SelectedIndex;
        }

        //-----------------Dot. platformy-------------------------------------------
        private void ComboBoxMnPrOgrCz_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[11] = ComboBoxMnPrOgrCz.SelectedIndex;
        }

        private void ComboBoxMnPrOgrP_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[12] = ComboBoxMnPrOgrP.SelectedIndex;
        }

        private void ComboBoxMnPrZmP_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[13] = ComboBoxMnPrZmP.SelectedIndex;
        }


        //-----------------Dot. projektu-------------------------------------------
        private void ComboBoxMnPrNarzP_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[14] = ComboBoxMnPrNarzP.SelectedIndex;
        }

        private void ComboBoxMnPrLokal_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[15] = ComboBoxMnPrLokal.SelectedIndex;
        }

        private void ComboBoxMnPrHarm_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[16] = ComboBoxMnPrHarm.SelectedIndex;
        }


    }
}

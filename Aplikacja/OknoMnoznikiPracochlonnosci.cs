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
            ComboBoxMnPrPonow.SelectedIndex = OknoGlowne.TabIndEM[3];
            ComboBoxMnPrDoku.SelectedIndex = OknoGlowne.TabIndEM[4];

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
            OknoGlowne.TempTabIndEM[0] = ComboBoxMnPrNiezaw.SelectedIndex;
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
            OknoGlowne.TempTabIndEM[3] = ComboBoxMnPrPonow.SelectedIndex;
        }

        private void ComboBoxMnPrDoku_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndEM[4] = ComboBoxMnPrDoku.SelectedIndex;
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

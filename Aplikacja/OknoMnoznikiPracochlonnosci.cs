/*! \file Form1.cs
\brief Plik Form1.cs zawiera klasę Form1 z głównym oknem aplikacji.

Plik Form1.cs zawiera rdzeń programu czyli główne okno aplikacji wraz z menu, pozwalającym na dokonanie wyboru różnych opcji menadżera zadań takich jak: szyfrowanie/deszyfrowanie bazy danych.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO: wysoki/a, wyrównanie, tooltipy, opisy.

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

            ComboBoxMnPrNiezaw.SelectedIndex = OknoGlowne.TabEM[0];
            ComboBoxMnPrBaza.SelectedIndex = OknoGlowne.TabEM[1];
            ComboBoxMnPrZloz.SelectedIndex = OknoGlowne.TabEM[2];
            ComboBoxMnPrPonow.SelectedIndex = OknoGlowne.TabEM[3];
            ComboBoxMnPrDoku.SelectedIndex = OknoGlowne.TabEM[4];

            ComboBoxMnPrAnal.SelectedIndex = OknoGlowne.TabEM[5];
            ComboBoxMnPrProgr.SelectedIndex = OknoGlowne.TabEM[6];
            ComboBoxMnPrZesp.SelectedIndex = OknoGlowne.TabEM[7];
            ComboBoxMnPrZnajA.SelectedIndex = OknoGlowne.TabEM[8];
            ComboBoxMnPrZnajP.SelectedIndex = OknoGlowne.TabEM[9];
            ComboBoxMnPrZnajJ.SelectedIndex = OknoGlowne.TabEM[10];
            

            ComboBoxMnPrOgrCz.SelectedIndex = OknoGlowne.TabEM[11];
            ComboBoxMnPrOgrP.SelectedIndex = OknoGlowne.TabEM[12];
            ComboBoxMnPrZmP.SelectedIndex = OknoGlowne.TabEM[13];

            ComboBoxMnPrNarzP.SelectedIndex = OknoGlowne.TabEM[14];
            ComboBoxMnPrLokal.SelectedIndex = OknoGlowne.TabEM[15];
            ComboBoxMnPrHarm.SelectedIndex = OknoGlowne.TabEM[16];


            //TODO doświadczenie a nie znajomość??
            //ToolTip.SetToolTip(comboBox1, "Save changes");

        }

        private void ComboBoxMnPrNiezaw_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[0] = ComboBoxMnPrNiezaw.SelectedIndex;
        }

        private void ComboBoxMnPrBaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[1] = ComboBoxMnPrBaza.SelectedIndex;
        }

        private void ComboBoxMnPrZloz_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[2] = ComboBoxMnPrZloz.SelectedIndex;
        }

        private void ComboBoxMnPrPonow_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[3] = ComboBoxMnPrPonow.SelectedIndex;
        }

        private void ComboBoxMnPrDoku_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[4] = ComboBoxMnPrDoku.SelectedIndex;
        }

        //------------------------------------------------------------
        private void ComboBoxMnPrAnal_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[5] = ComboBoxMnPrAnal.SelectedIndex;
        }

        private void ComboBoxMnPrProgr_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[6] = ComboBoxMnPrProgr.SelectedIndex;
        }

        private void ComboBoxMnPrZesp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[7] = ComboBoxMnPrZesp.SelectedIndex;
        }

        private void ComboBoxMnPrZnajA_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[8] = ComboBoxMnPrZnajA.SelectedIndex;
        }

        private void ComboBoxMnPrZnajP_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[9] = ComboBoxMnPrZnajP.SelectedIndex;
        }

        private void ComboBoxMnPrZnajJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[10] = ComboBoxMnPrZnajJ.SelectedIndex;
        }

        //------------------------------------------------------------
        private void ComboBoxMnPrOgrCz_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[11] = ComboBoxMnPrOgrCz.SelectedIndex;
        }

        private void ComboBoxMnPrOgrP_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[12] = ComboBoxMnPrOgrP.SelectedIndex;
        }

        private void ComboBoxMnPrZmP_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[13] = ComboBoxMnPrZmP.SelectedIndex;
        }


        //------------------------------------------------------------
        private void ComboBoxMnPrNarzP_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[14] = ComboBoxMnPrNarzP.SelectedIndex;
        }

        private void ComboBoxMnPrLokal_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[15] = ComboBoxMnPrLokal.SelectedIndex;
        }

        private void ComboBoxMnPrHarm_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabEM[16] = ComboBoxMnPrHarm.SelectedIndex;
        }
    }
}

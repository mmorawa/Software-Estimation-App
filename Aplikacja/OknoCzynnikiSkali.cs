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
    public partial class OknoCzynnikiSkali : Form
    {
        //! Konstruktor klasy Form1.
        /*! Inicjalizuje komponenty klasy Form1. */
        public OknoCzynnikiSkali()
        {
            InitializeComponent();

            ComboBoxCzynnSkTyp.SelectedIndex = OknoGlowne.TabSF[0];
            ComboBoxCzynnSkElast.SelectedIndex = OknoGlowne.TabSF[1];
            ComboBoxCzynnSkRyzyko.SelectedIndex = OknoGlowne.TabSF[2];
            ComboBoxCzynnSkZesp.SelectedIndex = OknoGlowne.TabSF[3];
            ComboBoxCzynnSkDojrz.SelectedIndex = OknoGlowne.TabSF[4];
        }

        //TODO anuluj anuluje

        private void ComboBoxCzynnSkTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabSF[0] = ComboBoxCzynnSkTyp.SelectedIndex;
        }

        private void ComboBoxCzynnSkElast_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabSF[1] = ComboBoxCzynnSkElast.SelectedIndex;
        }

        private void ComboBoxCzynnSkRyzyko_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabSF[2] = ComboBoxCzynnSkRyzyko.SelectedIndex;
        }

        private void ComboBoxCzynnSkZesp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabSF[3] = ComboBoxCzynnSkZesp.SelectedIndex;
        }

        private void ComboBoxCzynnSkDojrz_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TabSF[4] = ComboBoxCzynnSkDojrz.SelectedIndex;
        }
    }
}

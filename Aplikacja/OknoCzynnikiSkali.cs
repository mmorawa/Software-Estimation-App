/*! \file Form1.cs
\brief Plik Form1.cs zawiera klasę Form1 z głównym oknem aplikacji.

Plik Form1.cs zawiera rdzeń programu czyli główne okno aplikacji wraz z menu, pozwalającym na dokonanie wyboru różnych opcji menadżera zadań takich jak: szyfrowanie/deszyfrowanie bazy danych.
*/

using System;
using System.Windows.Forms;

//TODO:   wyrównanie, tooltipy, opisy.

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

            ComboBoxCzynnSkTyp.SelectedIndex = OknoGlowne.TabIndCzynnSkali[0];
            ComboBoxCzynnSkElast.SelectedIndex = OknoGlowne.TabIndCzynnSkali[1];
            ComboBoxCzynnSkRyzyko.SelectedIndex = OknoGlowne.TabIndCzynnSkali[2];
            ComboBoxCzynnSkZesp.SelectedIndex = OknoGlowne.TabIndCzynnSkali[3];
            ComboBoxCzynnSkDojrz.SelectedIndex = OknoGlowne.TabIndCzynnSkali[4];
        }

        

        private void ComboBoxCzynnSkTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndCzynnSkali[0] = ComboBoxCzynnSkTyp.SelectedIndex;
        }

        private void ComboBoxCzynnSkElast_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndCzynnSkali[1] = ComboBoxCzynnSkElast.SelectedIndex;
        }

        private void ComboBoxCzynnSkRyzyko_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndCzynnSkali[2] = ComboBoxCzynnSkRyzyko.SelectedIndex;
        }

        private void ComboBoxCzynnSkZesp_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndCzynnSkali[3] = ComboBoxCzynnSkZesp.SelectedIndex;
        }

        private void ComboBoxCzynnSkDojrz_SelectedIndexChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempTabIndCzynnSkali[4] = ComboBoxCzynnSkDojrz.SelectedIndex;
        }
    }
}

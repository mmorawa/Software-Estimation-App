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

            ComboBoxMnPrAnal.SelectedIndex = 2;
            ComboBoxMnPrBaza.SelectedIndex = 2;
            ComboBoxMnPrDoku.SelectedIndex = 2;
            ComboBoxMnPrHarm.SelectedIndex = 2;
            ComboBoxMnPrLokal.SelectedIndex = 2;
            ComboBoxMnPrNarzP.SelectedIndex = 2;
            ComboBoxMnPrNiezaw.SelectedIndex = 2;
            ComboBoxMnPrOgrCz.SelectedIndex = 2;
            ComboBoxMnPrOgrP.SelectedIndex = 2;
            ComboBoxMnPrPonow.SelectedIndex = 2;
            ComboBoxMnPrProgr.SelectedIndex = 2;
            ComboBoxMnPrZesp.SelectedIndex = 2;
            ComboBoxMnPrZloz.SelectedIndex = 2;
            ComboBoxMnPrZmP.SelectedIndex = 2;
            ComboBoxMnPrZnajA.SelectedIndex = 2;
            ComboBoxMnPrZnajJ.SelectedIndex = 2;
            ComboBoxMnPrZnajP.SelectedIndex = 2;
            //ToolTip.SetToolTip(comboBox1, "Save changes");

        }

        //TODO doświadczenie a nie znajomość??



    }
}

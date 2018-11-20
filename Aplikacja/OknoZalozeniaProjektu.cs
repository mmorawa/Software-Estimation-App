/*! \file Form1.cs
\brief Plik Form1.cs zawiera klasę Form1 z głównym oknem aplikacji.

Plik Form1.cs zawiera rdzeń programu czyli główne okno aplikacji wraz z menu, pozwalającym na dokonanie wyboru różnych opcji menadżera zadań takich jak: szyfrowanie/deszyfrowanie bazy danych.
*/

using System;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class OknoZalozeniaProjektu : Form
    {
        public OknoZalozeniaProjektu()
        {
            InitializeComponent();

            NumericUCPgodziny.Value = (decimal)OknoGlowne.UCPgodziny;
            NumericUCPlinieKodu.Value = (decimal)OknoGlowne.UCPlinieKodu;
            NumericStawkaGodz.Value = (decimal)OknoGlowne.StawkaGodz;
            NumericOsoboMGodz.Value = OknoGlowne.OsoboMGodz;
            NumericDzRobGodz.Value = OknoGlowne.DzRobGodz;
            NumericMaxKoszt.Value = (decimal)OknoGlowne.MaxKoszt;
            NumericMaxPrac.Value = OknoGlowne.MaxPrac;
            NumericMaxHarm.Value = OknoGlowne.MaxHarm;
            
            CheckBoxAktywacja.Checked = OknoGlowne.Ograniczenia;
            TableLayoutOgraniczenia.Enabled = OknoGlowne.Ograniczenia;

        }



        private void CheckBoxAktywacja_CheckedChanged(object sender, EventArgs e)
        {

            if (TableLayoutOgraniczenia.Enabled == false)
            {
                OknoGlowne.TempOgraniczenia = true;
                TableLayoutOgraniczenia.Enabled = true;
            }
            else
            {
                OknoGlowne.TempOgraniczenia = false;
                TableLayoutOgraniczenia.Enabled = false;
            }
        }


        //TODO domyślnie decimal????
        


        private void NumericUCPgodziny_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempUCPgodziny = (double)NumericUCPgodziny.Value;
        }

        private void NumericUCPlinieKodu_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempUCPlinieKodu = (double)NumericUCPlinieKodu.Value;
        }

        private void NumericStawkaGodz_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempStawkaGodz = (double)NumericStawkaGodz.Value;
        }

        private void NumericOsoboMGodz_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempOsoboMGodz = (long)NumericOsoboMGodz.Value;
        }

        private void NumericDzRobGodz_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempDzRobGodz = (long)NumericDzRobGodz.Value;
        }

        private void NumericMaxKoszt_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempMaxKoszt = (double)NumericMaxKoszt.Value;
        }

        private void NumericMaxPrac_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempMaxPrac = (long)NumericMaxPrac.Value;
        }

        private void NumericMaxHarm_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempMaxHarm = (long)NumericMaxHarm.Value;
        }


    }
}

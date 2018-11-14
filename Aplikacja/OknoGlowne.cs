﻿/*! \file Form1.cs
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


//! Przestrzeń nazw Password_Manager obejmuje całą aplikację Menedżera Haseł.
/*! Password_Manager to przestrzeń nazw, która obejmuje całą aplikację Menedżera Haseł, ze wszystkimi klasami Form. */
namespace Aplikacja
{
    //! Klasa Form1 zawiera główne okno aplikacji.
    /*! W klasie Form1 znajduje się menu główne aplikacji, przyciski oraz Textboxy z danymi, oraz warstwa logiczna aplikacji */
    public partial class OknoGlowne : Form
    {
        //! Konstruktor klasy Form1.
        /*! Inicjalizuje komponenty klasy Form1. */
        public OknoGlowne()
        {
            InitializeComponent();
            
        }

        /*****************************************************************************//**
        *  Properties.
        ********************************************************************************/

        //TODO encapsulate?? domyślnie zera?
        public static int[] UAW = new int[3];
        public static int[] UUCW = new int[3];

        public static int[] TCF = new int[13];
        public static int[] EF = new int[8];

        /*******************************************************************************
        *  Metody klasy Form1.
        ********************************************************************************/

        //! Metoda wywoływana po naciśnięciu przycisku New na pasku Menu.
        /*! Metoda NewToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku New na pasku Menu.
         * Najpierw otwiera nowe okno, gdzie pyta użytkownika o podstawowe dane odnośnie nowej bazy a następnie tworzy pierwszy Panel, w którym użytkownik może zacząć wpisywać swoje dane.
         */
        private void ToolStripMenuNowyProj_Click(object sender, EventArgs e)
        {

        }

        //! Metoda wywoływana po naciśnięciu przycisku Open na pasku Menu.
        /*! Metoda OpenToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Open na pasku Menu.
         * Odpowiada za wczytanie pliku z bazą haseł a następnie jego odszyfrowanie przy użyciu podanego przez użytkownika klucza.
         * Następnie generuje ona Panele z Textboxami, do których podstawiane są odszyfrowane dane tekstowe. 
         */
        private void ToolStripMenuOtworzProj_Click(object sender, EventArgs e)
        {

        }

        //! Metoda wywoływana po naciśnięciu przycisku Save na pasku Menu.
        /*! Metoda SaveToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Save na pasku Menu.
         * Powoduje ona automatyczne zaszyfrowanie wpisów z hasłami, znajdujących w głównym oknie programu bez konieczności podania ścieżki do pliku bazy.
         */
        private void ToolStripMenuZapiszProj_Click(object sender, EventArgs e)
        {

        }

        //! Metoda wywoływana po naciśnięciu przycisku Save As na pasku Menu.
        /*! Metoda SaveAsToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Save As na pasku Menu.
         * Powoduje ona zamknięcie aktywnej bazy poprzez wywołanie metody CloseDatabase.
         */
        private void ToolStripMenuZapiszJakoProj_Click(object sender, EventArgs e)
        {

        }

        //! Metoda wywoływana po naciśnięciu przycisku Exit na pasku Menu.
        /*! Metoda ExitToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Exit na pasku Menu.
         * Skutkuje ona zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjściem z programu.
         */
        private void ToolStripMenuWyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //! Metoda wywoływana po naciśnięciu przycisku Exit na pasku Menu.
        /*! Metoda ExitToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Exit na pasku Menu.
         * Skutkuje ona zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjściem z programu.
         */
        private void ToolStripMenuKalibracja_Click(object sender, EventArgs e)
        {

        }

        //! Metoda wywoływana po naciśnięciu przycisku Exit na pasku Menu.
        /*! Metoda ExitToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Exit na pasku Menu.
         * Skutkuje ona zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjściem z programu.
         */
        private void ToolStripMenuPrzeliczniki_Click(object sender, EventArgs e)
        {

        }

        //! Metoda wywoływana po naciśnięciu przycisku Exit na pasku Menu.
        /*! Metoda ExitToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Exit na pasku Menu.
         * Skutkuje ona zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjściem z programu.
         */
        private void ToolStripMenuDokumentacja_Click(object sender, EventArgs e)
        {

        }

        //! Metoda wywoływana po naciśnięciu przycisku Exit na pasku Menu.
        /*! Metoda ExitToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Exit na pasku Menu.
         * Skutkuje ona zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjściem z programu.
         */
        private void ToolStripMenuOProgramie_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCZT_Click(object sender, EventArgs e)
        {
            using (OknoCzynnZlozTechn OknoCzynZT = new OknoCzynnZlozTechn())
            {
                DialogResult dr = OknoCzynZT.ShowDialog();


                if (dr == DialogResult.OK)
                {

                    MessageBox.Show("Czynniki złożoności technicznej zostały wprowadzone.", "Sukces");

                }
            }
        }

        private void ButtonCzSr_Click(object sender, EventArgs e)
        {
            using (OknoCzynnSrodow OknoCzynSrod = new OknoCzynnSrodow())
            {
                DialogResult dr = OknoCzynSrod.ShowDialog();


                if (dr == DialogResult.OK)
                {

                    MessageBox.Show("Czynniki środowiskowe zostały wprowadzone.", "Sukces");

                }
            }
        }

        private void ButtonCzSk_Click(object sender, EventArgs e)
        {
            using (OknoCzynnikiSkali OknoCzynS = new OknoCzynnikiSkali())
            {
                DialogResult dr = OknoCzynS.ShowDialog();


                if (dr == DialogResult.OK)
                {

                    MessageBox.Show("Czynniki skali wprowadzone.", "Sukces");
                }
            }
        }

        private void ButtonMnPr_Click(object sender, EventArgs e)
        {
            using (OknoMnoznikiPracochlonnosci OknoMnozP = new OknoMnoznikiPracochlonnosci())
            {
                DialogResult dr = OknoMnozP.ShowDialog();


                if (dr == DialogResult.OK)
                {

                    MessageBox.Show("Mnożniki pracochłonności wprowadzone.", "Sukces");
                }
            }
        }



        private void NumUUCWProsty_ValueChanged(object sender, EventArgs e)
        {
            UUCW[0] = (int)NumUUCWProsty.Value;
        }

        private void NumUUCWSredni_ValueChanged(object sender, EventArgs e)
        {
            UUCW[1] = (int)NumUUCWSredni.Value;
        }

        private void NumUUCWZlozony_ValueChanged(object sender, EventArgs e)
        {
            UUCW[2] = (int)NumUUCWZlozony.Value;
        }

        private void NumUAWProsty_ValueChanged(object sender, EventArgs e)
        {
            UAW[0] = (int)NumUAWProsty.Value;
        }

        private void NumUAWSredni_ValueChanged(object sender, EventArgs e)
        {
            UAW[1] = (int)NumUAWSredni.Value;
        }

        private void NumUAWZlozony_ValueChanged(object sender, EventArgs e)
        {
            UAW[2] = (int)NumUAWZlozony.Value;
        }

        private void ButtonOblicz_Click(object sender, EventArgs e)
        {
            //TODO walidacja danych wejściowych
            
            MessageBox.Show(( 
                0.6 + (TCF[0] * 2 + TCF[1] * 1 + TCF[2] * 1 + TCF[3] * 1 + TCF[4] * 1 + TCF[5] * 0.5 + TCF[6] * 0.5 + TCF[7] * 2 + TCF[8] * 1 + TCF[9] * 1 + TCF[10] * 1 + TCF[11] * 1 + TCF[12] * 1) / 100
                ).ToString());

            MessageBox.Show((
                1.4 + (-0.03 * (EF[0] * 1.5 + EF[1] * -1 + EF[2] * 0.5 + EF[3] * 0.5 + EF[4] * 1 + EF[5] * 1 + EF[6] * -1 + EF[7] * 2 ))
                ).ToString());

            LabelPktUCP.Text = (UUCW[0] * 5 + UUCW[1] * 10 + UUCW[2] * 15 + UAW[0] * 1 + UAW[1] * 2 + UAW[2] * 3).ToString();

            //MessageBox.Show((0.6 + TCF.Sum()/100).ToString());

            //MessageBox.Show(TCF[0].ToString());
        }
    }
}

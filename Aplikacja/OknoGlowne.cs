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
            DateTimePicker.Value = DateTime.Now;
        }

        /*****************************************************************************//**
        *  Properties.
        ********************************************************************************/

        //TODO encapsulate?? domyślnie zera?
        public static int[] TabUAW = new int[3];
        public static int[] TabUUCW = new int[3];

        public static int[] TabTCF = new int[13];
        public static int[] TabEF = new int[8];

        public static double[] wagiTCF = { 2, 1, 1, 1, 1, 0.5, 0.5, 2, 1, 1, 1, 1, 1 };
        public static double iloczynWagTCF = 0;

        public static double[] wagiEF = { 1.5, -1, 0.5, 0.5, 1, 1, -1, 2 };
        public static double iloczynWagEF = 0;

        public static int[] TabSF = { 2, 2, 2, 2, 2 };
        public static int[] TabEM = { 2, 1, 2, 1, 2, 2, 2, 2, 2, 2, 2, 0, 0, 1, 2, 2, 2 };

        public static double[,] TabWspSF = { 
            {6.2, 4.96, 3.72, 2.48, 1.24, 0},
            {5.07, 4.05, 3.04, 2.03, 1.01, 0},
            {7.07, 5.65, 4.24, 2.83, 1.41, 0},
            {5.48, 4.38, 3.29, 2.19, 1.1, 0},
            {7.8, 6.24, 4.68, 3.12, 1.56, 0 }
        };

        double EFc1 = 1.4;
        double EFc2 = -0.03;

        double TCFc1 = 0.6;
        double TCFc2 = 0.01;

        double SumaSF = 0;
        double TCF = 0;
        double EF = 0;
        double UUCW = 0;
        double UAW = 0;
        double UCP = 0;

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
            TabUUCW[0] = (int)NumUUCWProsty.Value;
        }

        private void NumUUCWSredni_ValueChanged(object sender, EventArgs e)
        {
            TabUUCW[1] = (int)NumUUCWSredni.Value;
        }

        private void NumUUCWZlozony_ValueChanged(object sender, EventArgs e)
        {
            TabUUCW[2] = (int)NumUUCWZlozony.Value;
        }

        private void NumUAWProsty_ValueChanged(object sender, EventArgs e)
        {
            TabUAW[0] = (int)NumUAWProsty.Value;
        }

        private void NumUAWSredni_ValueChanged(object sender, EventArgs e)
        {
            TabUAW[1] = (int)NumUAWSredni.Value;
        }

        private void NumUAWZlozony_ValueChanged(object sender, EventArgs e)
        {
            TabUAW[2] = (int)NumUAWZlozony.Value;
        }



        private void ButtonOblicz_Click(object sender, EventArgs e)
        {

        }

        private void ButtonZapiszProjektJako_Click(object sender, EventArgs e)
        {

            SaveFileDialog ZapiszProjektDialog = new SaveFileDialog
            {
                Filter = "Plik projetku | *.prj",
                FileName = "Projekt.prj",
                Title = "Zapisz plik projektu jako:"
            };



            //zapisanie danych do pliku tekstowego
            if (ZapiszProjektDialog.ShowDialog() == DialogResult.OK)
            {
                string path = ZapiszProjektDialog.FileName;
            }

            /*
                StreamWriter sw = new StreamWriter(File.Create(path));

                int[] numery = new int[4];


                int j = 0;
                for (int i = 0; i < Form2.Moduly.Length; i++)
                {
                    if (Form2.Moduly[i] != 0)
                    {
                        numery[j] = i;
                        j++;
                    }
                }

                sw.WriteLine(string.Format("byte Program_{0}", Form2.Nazwa_Programu) + "_MODUL[]={" + string.Format("{0},{1},{2},{3}", numery[0], numery[1], numery[2], numery[3]) + "};");

                foreach (var item in Dane)
                {
                    sw.WriteLine(item);
                }

                sw.Write(string.Format("unsigned int* Program_{0}", Form2.Nazwa_Programu) + "[] = {");

                for (int i = 0; i < Programy.Length - 2; i++)
                {
                    sw.Write(Programy[i] + ", ");
                }
                sw.Write(Programy[Programy.Length - 2] + "};");

                sw.Dispose();

                MessageBox.Show("Plik zapisano.");
            } */

        }

        private void ButtonOszacuj_Click(object sender, EventArgs e)
        {
            //TODO walidacja danych wejściowych, zaokrąglanie


            for (int i = 0; i <= 12; i++)
            {
                iloczynWagTCF = TabTCF[i] * wagiTCF[i];
            }

            TCF = TCFc1 + iloczynWagTCF * TCFc2;

            for (int i = 0; i <= 7; i++)
            {
                iloczynWagEF = TabEF[i] * wagiEF[i];
            }

            EF = EFc1 + (EFc2 * iloczynWagEF);

            UUCW = TabUUCW[0] * 5 + TabUUCW[1] * 10 + TabUUCW[2] * 15;
            UAW = TabUAW[0] * 1 + TabUAW[1] * 2 + TabUAW[2] * 3;
            UCP = TCF * EF * (UAW + UUCW);

            LabelPktUCP.Text = UCP.ToString();


            for (int i = 0; i <= 4; i++)
            {
                SumaSF += TabWspSF[i, TabSF[i]];
            }

            MessageBox.Show(SumaSF.ToString());
        }
    }
}

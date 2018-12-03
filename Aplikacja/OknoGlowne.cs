/*! \file Form1.cs
\brief Plik Form1.cs zawiera klasę Form1 z głównym oknem aplikacji.

Plik Form1.cs zawiera rdzeń programu czyli główne okno aplikacji wraz z menu, pozwalającym na dokonanie wyboru różnych opcji menadżera zadań takich jak: szyfrowanie/deszyfrowanie bazy danych.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Fields;
using MigraDoc.Rendering;
using MigraDoc.DocumentObjectModel.Tables;
using TabAlignment = MigraDoc.DocumentObjectModel.TabAlignment;


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
            TextBoxNazwaProjektu.Text = NazwaProjektu;
            DateTimePicker.Value = DateTime.Now;

        }

        /*****************************************************************************//**
        *  Properties.
        ********************************************************************************/

        //EXT encapsulate?? 

        string SciezkaDoPliku = "";

        //Dane projektu
        public static string NazwaProjektu = "Projekt";
        public static string DataProjektu = "";
        public static string KierownikProjektu = "";
        public static string Szacujacy = "";
        public static string NazwaFirmy = "";
        public static string Adres = "";
        public static string Telefon = "";
        public static string Email = "";
        public static string OpisProjektu = "";

        //Zmienne tymczasowe
        public static string TempKierownikProjektu = "";
        public static string TempSzacujacy = "";
        public static string TempNazwaFirmy = "";
        public static string TempAdres = "";
        public static string TempTelefon = "";
        public static string TempEmail = "";
        public static string TempOpisProjektu = "";

        //Zmienne zapisujące stan ustawień
        public static bool Ograniczenia = false;
        public static bool TempOgraniczenia = false;
        public static bool Domyslne = false;
        public static bool TempDomyslne = false;

        //Dane modelu
        public static int[] TempTabPrzeliczeniowa = new int[38];

        public static long[] TabUAW = new long[3];
        double[] wagiAktorow = { 1, 2, 3 };
        public static long[] TabUUCW = new long[3];
        double[] wagiUC = { 5, 10, 15 };


        public static int[] TabIndSF = { 2, 2, 2, 2, 2 };
        public static int[] TempTabIndSF = new int[5];

        public static int[] TabIndEM = { 2, 1, 2, 1, 2, 2, 2, 2, 2, 2, 2, 0, 0, 1, 2, 2, 2 };
        public static int[] TempTabIndEM = new int[17];

        double[,] TabWspSF =
        {
            {6.2, 4.96, 3.72, 2.48, 1.24, 0 },
            {5.07, 4.05, 3.04, 2.03, 1.01, 0 },
            {7.07, 5.65, 4.24, 2.83, 1.41, 0 },
            {5.48, 4.38, 3.29, 2.19, 1.1, 0 },
            {7.8, 6.24, 4.68, 3.12, 1.56, 0 }
        };

        double[,] TabWspEM =
        {
            {0.82, 0.92, 1, 1.1, 1.26, 0 },
            {0.9, 1, 1.14, 1.28, 0, 0 },
            {0.73, 0.87, 1, 1.17, 1.34, 1.74 },
            {0.95, 1, 1.07, 1.15, 1.24, 0 },
            {0.81, 0.91, 1, 1.11, 1.23, 0 },
            {1.42, 1.19, 1, 0.85, 0.71, 0 },
            {1.34, 1.15, 1, 0.88, 0.76, 0 },
            {1.29, 1.12, 1, 0.9, 0.81, 0 },
            {1.22, 1.10, 1, 0.88, 0.81, 0 },
            {1.19, 1.09, 1, 0.91, 0.85, 0 },
            {1.2, 1.09, 1, 0.91, 0.84, 0 },
            {1, 1.11, 1.29, 1.63, 0, 0 },
            {1, 1.05, 1.17, 1.46, 0, 0 },
            {0.87, 1, 1.15, 1.3, 0, 0 },
            {1.17, 1.09, 1, 0.9, 0.78, 0 },
            {1.22, 1.09, 1, 0.93, 0.86, 0.8 },
            {1.43, 1.14, 1, 1, 1, 0 }
        };

        double[] TabOgranHarm = { 0.75, 0.85, 1, 1.3, 1.6 };

        //współczynniki
        public static double TempUCPnaFP;
        public static double TempA;
        public static double TempB;
        public static double TempC;
        public static double TempD;

        //Ustawienia
        public static int JezykProgramowania = Properties.Settings.Default.JezykProgramowania;

        static string[] JezykProg = {"ABAP (SAP) ", "ASP", "Assembler", "Brio", "C", "C++", "C#", "COBOL","Cognos Impromptu Scripts", "Cross System Products (CSP)",
            "Cool:Gen/IEF", "Datastage", "Excel", "Focus","FoxPro", "HTML", "J2EE", "Java", "JavaScript", "JCL", "LINC II", "Lotus Notes", "Natural",
            ".NET", "Oracle", "PACBASE", "Perl", "PL/I", "PL/SQL", "Powerbuilder", "REXX", "Sabretalk", "SAS", "Siebel", "SLOGAN", "SQL", "VB.NET", "Visual Basic"
        };

        public static double StawkaGodz = Properties.Settings.Default.StawkaGodz;
        public static long OsoboMGodz = Properties.Settings.Default.OsoboMGodz;
        public static long DzRobGodz = Properties.Settings.Default.DzRobGodz;

        public static double MaxKoszt = 0;
        public static long MaxPrac = 0;
        public static long MaxHarm = 0;

        //wartości tymczasowe
        public static int TempJezykProgramowania;
        public static double TempStawkaGodz;
        public static long TempOsoboMGodz;
        public static long TempDzRobGodz;

        public static double TempMaxKoszt;
        public static long TempMaxPrac;
        public static long TempMaxHarm;

        //wyniki pośrednie 

        double UUCW;
        double UAW;
        double RozmiarKSLOC;
        double E;
        double F;
        double SumaSF;
        double IloczynEM;
        double IloczynEMOgranHarm;
        double PracochlonnoscBezOgran;

        //wyniki końcowe
        double UUCP;
        double Rozmiar;
        double Pracochlonnosc;
        double Harmonogram;
        double Koszt;

        /*******************************************************************************
        *  Metody klasy Form1.
        ********************************************************************************/

        //! Metoda wywoływana po naciśnięciu przycisku New na pasku Menu.
        /*! Metoda NewToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku New na pasku Menu.
         * Najpierw otwiera nowe okno, gdzie pyta użytkownika o podstawowe dane odnośnie nowej bazy a następnie tworzy pierwszy Panel, w którym użytkownik może zacząć wpisywać swoje dane.
         */
        private void ToolStripMenuNowyProj_Click(object sender, EventArgs e)
        {
            ButtonNowyProjekt_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Open na pasku Menu.
        /*! Metoda OpenToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Open na pasku Menu.
         * Odpowiada za wczytanie pliku z bazą haseł a następnie jego odszyfrowanie przy użyciu podanego przez użytkownika klucza.
         * Następnie generuje ona Panele z Textboxami, do których podstawiane są odszyfrowane dane tekstowe. 
         */
        private void ToolStripMenuOtworzProj_Click(object sender, EventArgs e)
        {
            ButtonOtworzProjekt_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Open na pasku Menu.
        /*! Metoda OpenToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Open na pasku Menu.
         * Odpowiada za wczytanie pliku z bazą haseł a następnie jego odszyfrowanie przy użyciu podanego przez użytkownika klucza.
         * Następnie generuje ona Panele z Textboxami, do których podstawiane są odszyfrowane dane tekstowe. 
         */
        private void ToolStripMenuSzczegolyProjektu_Click(object sender, EventArgs e)
        {
            ButtonWiecejSzczeg_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Open na pasku Menu.
        /*! Metoda OpenToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Open na pasku Menu.
         * Odpowiada za wczytanie pliku z bazą haseł a następnie jego odszyfrowanie przy użyciu podanego przez użytkownika klucza.
         * Następnie generuje ona Panele z Textboxami, do których podstawiane są odszyfrowane dane tekstowe. 
         */
        private void ToolStripMenuZalozeniaProjektu_Click(object sender, EventArgs e)
        {
            ButtonZalozenia_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Save na pasku Menu.
        /*! Metoda SaveToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Save na pasku Menu.
         * Powoduje ona automatyczne zaszyfrowanie wpisów z hasłami, znajdujących w głównym oknie programu bez konieczności podania ścieżki do pliku bazy.
         */
        private void ToolStripMenuZapiszProj_Click(object sender, EventArgs e)
        {
            ButtonZapiszProjekt_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Save na pasku Menu.
        /*! Metoda SaveToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Save na pasku Menu.
         * Powoduje ona automatyczne zaszyfrowanie wpisów z hasłami, znajdujących w głównym oknie programu bez konieczności podania ścieżki do pliku bazy.
         */
        private void ToolStripOszacuj_Click(object sender, EventArgs e)
        {
            ButtonOszacuj_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Save As na pasku Menu.
        /*! Metoda SaveAsToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Save As na pasku Menu.
         * Powoduje ona zamknięcie aktywnej bazy poprzez wywołanie metody CloseDatabase.
         */
        private void ToolStripMenuZapiszJakoProj_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ZapiszProjektDialog = new SaveFileDialog())
            {
                ZapiszProjektDialog.Filter = "Plik projetku | *.prj";
                ZapiszProjektDialog.FileName = "Projekt.prj";
                ZapiszProjektDialog.Title = "Zapisz plik projektu jako:";

                DialogResult rezultat = ZapiszProjektDialog.ShowDialog();


                //zapisanie danych do pliku tekstowego
                if (rezultat == DialogResult.OK)
                {
                    SciezkaDoPliku = ZapiszProjektDialog.FileName;

                    Zapis();

                }
            }
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
            ButtonKalibracja_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Exit na pasku Menu.
        /*! Metoda ExitToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Exit na pasku Menu.
         * Skutkuje ona zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjściem z programu.
         */
        private void ToolStripMenuUstawienia_Click(object sender, EventArgs e)
        {
            ButtonUstawienia_Click(sender, e);
        }


        //! Metoda wywoływana po naciśnięciu przycisku Exit na pasku Menu.
        /*! Metoda ExitToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Exit na pasku Menu.
         * Skutkuje ona zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjściem z programu.
         */
        private void ToolStripTablicaPrzeliczeniowa_Click(object sender, EventArgs e)
        {
            ButtonTablicaPrzeliczeniowa_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Exit na pasku Menu.
        /*! Metoda ExitToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Exit na pasku Menu.
         * Skutkuje ona zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjściem z programu.
         */
        private void ToolStripMenuDokumentacja_Click(object sender, EventArgs e)
        {
            //TODO odpowiedni plik w odpowiednim miejscu.
            System.Diagnostics.Process.Start("Dokumentacja.pdf");
        }

        //! Metoda wywoływana po naciśnięciu przycisku Exit na pasku Menu.
        /*! Metoda ExitToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Exit na pasku Menu.
         * Skutkuje ona zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjściem z programu.
         */
        private void ToolStripMenuOProgramie_Click(object sender, EventArgs e)
        {
            using (OknoOAplikacji OknoOProgramie = new OknoOAplikacji())
            {
                DialogResult rezultat = OknoOProgramie.ShowDialog();
            }
        }


        //-----------------------------------------------------------------------------------------------


        private void ButtonCzSk_Click(object sender, EventArgs e)
        {
            using (OknoCzynnikiSkali OknoCzynS = new OknoCzynnikiSkali())
            {
                DialogResult rezultat = OknoCzynS.ShowDialog();


                if (rezultat == DialogResult.OK)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        TabIndSF[i] = TempTabIndSF[i];
                    }

                    MessageBox.Show("Czynniki skali zostały zmienione.", "Sukces");
                }
            }
        }


        private void ButtonMnPr_Click(object sender, EventArgs e)
        {
            using (OknoMnoznikiPracochlonnosci OknoMnozP = new OknoMnoznikiPracochlonnosci())
            {
                DialogResult rezultat = OknoMnozP.ShowDialog();

                if (rezultat == DialogResult.OK)
                {
                    for (int i = 0; i < 17; i++)
                    {
                        TabIndEM[i] = TempTabIndEM[i];
                    }

                    MessageBox.Show("Mnożniki pracochłonności zostały zmienione.", "Sukces");
                }
            }
        }


        //-----------------------------------------------------------------------------------------------

        private void TextBoxNazwaProjektu_TextChanged(object sender, EventArgs e)
        {
            NazwaProjektu = TextBoxNazwaProjektu.Text;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DataProjektu = DateTimePicker.Text;
        }

        private void NumUUCWProsty_ValueChanged(object sender, EventArgs e)
        {
            TabUUCW[0] = (long)NumUUCWProsty.Value;
        }

        private void NumUUCWSredni_ValueChanged(object sender, EventArgs e)
        {
            TabUUCW[1] = (long)NumUUCWSredni.Value;
        }

        private void NumUUCWZlozony_ValueChanged(object sender, EventArgs e)
        {
            TabUUCW[2] = (long)NumUUCWZlozony.Value;
        }

        private void NumUAWProsty_ValueChanged(object sender, EventArgs e)
        {
            TabUAW[0] = (long)NumUAWProsty.Value;
        }

        private void NumUAWSredni_ValueChanged(object sender, EventArgs e)
        {
            TabUAW[1] = (long)NumUAWSredni.Value;
        }

        private void NumUAWZlozony_ValueChanged(object sender, EventArgs e)
        {
            TabUAW[2] = (long)NumUAWZlozony.Value;
        }

        //------------------------Algorytm------------------------------------------------------


        private void ButtonOszacuj_Click(object sender, EventArgs e)
        {
            //TODO walidacja danych wejściowych, zaokrąglanie

            //Obliczenia UUCP

            UUCW = 0;
            for (int i = 0; i < 3; i++)
            {
                UUCW += TabUUCW[i] * wagiUC[i];
            }

            UAW = 0;
            for (int i = 0; i < 3; i++)
            {
                UAW += TabUAW[i] * wagiAktorow[i];
            }

            UUCP = UAW + UUCW;

            Rozmiar = (UUCP * Properties.Settings.Default.UCPnaFP * Properties.Settings.Default.TabPrzeliczeniowa[JezykProgramowania]);

            RozmiarKSLOC = Rozmiar / 1000;

            //Obliczenia COCOMO II

            SumaSF = 0;
            for (int i = 0; i < 5; i++)
            {
                SumaSF += TabWspSF[i, TabIndSF[i]];
            }

            IloczynEM = 1;
            for (int i = 0; i < 17; i++)
            {
                IloczynEM *= TabWspEM[i, TabIndEM[i]];
            }

            E = Properties.Settings.Default.B + 0.01 * SumaSF;

            Pracochlonnosc = Properties.Settings.Default.A * Math.Pow(RozmiarKSLOC, E) * IloczynEM;


            IloczynEMOgranHarm = 1;
            for (int i = 0; i < 16; i++)
            {
                IloczynEMOgranHarm *= TabWspEM[i, TabIndEM[i]];
            }

            PracochlonnoscBezOgran = Properties.Settings.Default.A * Math.Pow(RozmiarKSLOC, E) * IloczynEMOgranHarm;

            F = Properties.Settings.Default.D + 0.2 * (E - Properties.Settings.Default.B);

            Harmonogram = Properties.Settings.Default.C * Math.Pow(PracochlonnoscBezOgran, F) * TabOgranHarm[TabIndEM[16]];

            Koszt = Pracochlonnosc * OsoboMGodz * StawkaGodz;

            //Wyświetlenie wyników
            LabelPktUUCP.Text = string.Format("{0:N0}", UUCP);
            LabelRozmiar.Text = string.Format("{0:N0}", Rozmiar);
            LabelWynikPrac.Text = string.Format("{0:N1}", Pracochlonnosc);
            LabelWynikHarm.Text = string.Format("{0:N1}", Harmonogram);
            LabelWynikKoszt.Text = string.Format("{0:N}", Koszt);

            string Ostrzezenie = "";
            //Ograniczenia projektu

            if (Ograniczenia == true)
            {

                if (MaxPrac != 0 && MaxPrac < Pracochlonnosc)
                {
                    LabelWynikPrac.BackColor = System.Drawing.Color.FromName("red");

                    Ostrzezenie += "Przekroczono założoną pracochłonność projektu. \n";
                }
                else
                {
                    LabelWynikPrac.BackColor = System.Drawing.Color.FromName("GreenYellow");
                }

                if (MaxHarm != 0 && MaxHarm < Harmonogram)
                {
                    LabelWynikHarm.BackColor = System.Drawing.Color.FromName("red");
                    Ostrzezenie += "Przekroczono założony harmonogram projektu. \n";
                }
                else
                {
                    LabelWynikHarm.BackColor = System.Drawing.Color.FromName("GreenYellow");
                }

                if (MaxKoszt != 0 && MaxKoszt < Koszt)
                {
                    LabelWynikKoszt.BackColor = System.Drawing.Color.FromName("red");
                    Ostrzezenie += "Przekroczono założony koszt projektu. \n";
                }
                else
                {
                    LabelWynikKoszt.BackColor = System.Drawing.Color.FromName("GreenYellow");
                }

                MessageBox.Show(Ostrzezenie, "Ostrzeżenie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LabelWynikPrac.BackColor = System.Drawing.Color.FromName("GreenYellow");
                LabelWynikHarm.BackColor = System.Drawing.Color.FromName("GreenYellow");
                LabelWynikKoszt.BackColor = System.Drawing.Color.FromName("GreenYellow");
            }

        }


        //--------------------------------Do zrobienia---------------------------------------------------------

        private void ButtonNowyProjekt_Click(object sender, EventArgs e)
        {

            DialogResult rezultat = MessageBox.Show("Czy chcesz zapisać obecny projekt?",
                "Uwaga!",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation);

            if (rezultat == DialogResult.Yes)
            {
                ButtonZapiszProjekt_Click(sender, e);
            }
            else if (rezultat == DialogResult.Cancel)
            {
                return;
            }

            UsuniecieDanych();

            MessageBox.Show("Rozpoczęto nowy projekt.");
        }


        private void ButtonWiecejSzczeg_Click(object sender, EventArgs e)
        {
            using (OknoDaneProjektu OknoDaneProjektu = new OknoDaneProjektu())
            {
                DialogResult rezultat = OknoDaneProjektu.ShowDialog();

                if (rezultat == DialogResult.OK)
                {
                    KierownikProjektu = TempKierownikProjektu;
                    Szacujacy = TempSzacujacy;
                    NazwaFirmy = TempNazwaFirmy;
                    Adres = TempAdres;
                    Telefon = TempTelefon;
                    Email = TempEmail;
                    OpisProjektu = TempOpisProjektu;
                    //czy są użyte dane domyślne
                    Domyslne = TempDomyslne;

                    MessageBox.Show("Szczegółowe dane projektu zostały zmienione.", "Sukces");
                }
            }
        }


        private void ButtonOtworzProjekt_Click(object sender, EventArgs e)
        {

            DialogResult rezultat = MessageBox.Show("Czy chcesz zapisać obecny projekt?",
                "Uwaga!",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation);

            if (rezultat == DialogResult.Yes)
            {
                ButtonZapiszProjekt_Click(sender, e);
            }
            else if (rezultat == DialogResult.Cancel)
            {
                return;
            }

            UsuniecieDanych();

            using (OpenFileDialog OtworzProjektDialog = new OpenFileDialog())
            {

                DialogResult rezultat2 = OtworzProjektDialog.ShowDialog();

                if (rezultat2 == DialogResult.OK)
                {
                    try
                    {
                        SciezkaDoPliku = OtworzProjektDialog.FileName;

                        using (StreamReader sr = new StreamReader(SciezkaDoPliku))
                        {
                            //int LiczbaLinii = File.ReadLines(SciezkaDoPliku).Count();

                            TextBoxNazwaProjektu.Text = sr.ReadLine();
                            DateTimePicker.Text = sr.ReadLine();

                            KierownikProjektu = sr.ReadLine();
                            Szacujacy = sr.ReadLine();
                            NazwaFirmy = sr.ReadLine();
                            Adres = sr.ReadLine();
                            Telefon = sr.ReadLine();
                            Email = sr.ReadLine();
                            OpisProjektu = sr.ReadLine();

                            Ograniczenia = Convert.ToBoolean(sr.ReadLine());
                            Domyslne = Convert.ToBoolean(sr.ReadLine());

                            NumUUCWProsty.Value = int.Parse(sr.ReadLine());
                            NumUUCWSredni.Value = int.Parse(sr.ReadLine());
                            NumUUCWZlozony.Value = int.Parse(sr.ReadLine());
                            NumUAWProsty.Value = int.Parse(sr.ReadLine());
                            NumUAWSredni.Value = int.Parse(sr.ReadLine());
                            NumUAWZlozony.Value = int.Parse(sr.ReadLine());


                            for (int i = 0; i < 5; i++)
                            {
                                TabIndSF[i] = int.Parse(sr.ReadLine());
                            }

                            for (int i = 0; i < 17; i++)
                            {
                                TabIndEM[i] = int.Parse(sr.ReadLine());
                            }

                            JezykProgramowania = int.Parse(sr.ReadLine());
                            StawkaGodz = double.Parse(sr.ReadLine());
                            OsoboMGodz = long.Parse(sr.ReadLine());
                            DzRobGodz = long.Parse(sr.ReadLine());

                            MaxKoszt = double.Parse(sr.ReadLine());
                            MaxPrac = long.Parse(sr.ReadLine());
                            MaxHarm = long.Parse(sr.ReadLine());

                            UUCP = double.Parse(sr.ReadLine());
                            Rozmiar = double.Parse(sr.ReadLine());
                            Pracochlonnosc = double.Parse(sr.ReadLine());
                            Harmonogram = double.Parse(sr.ReadLine());
                            Koszt = double.Parse(sr.ReadLine());

                            LabelPktUUCP.Text = string.Format("{0:N0}", UUCP);
                            LabelRozmiar.Text = string.Format("{0:N0}", Rozmiar);
                            LabelWynikPrac.Text = string.Format("{0:N1}", Pracochlonnosc);
                            LabelWynikHarm.Text = string.Format("{0:N1}", Harmonogram);
                            LabelWynikKoszt.Text = string.Format("{0:N}", Koszt);

                            LabelWynikPrac.BackColor = System.Drawing.Color.FromName(sr.ReadLine());
                            LabelWynikHarm.BackColor = System.Drawing.Color.FromName(sr.ReadLine());
                            LabelWynikKoszt.BackColor = System.Drawing.Color.FromName(sr.ReadLine());
                        }
                    }
                    catch (Exception)
                    {
                        UsuniecieDanych();
                        MessageBox.Show("Nieprawidłowy format pliku.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void ButtonUstawienia_Click(object sender, EventArgs e)
        {
            using (OknoUstawienia OknoUstawDomyslne = new OknoUstawienia())
            {
                DialogResult rezultat = OknoUstawDomyslne.ShowDialog();

                if (rezultat == DialogResult.OK)
                {
                    Properties.Settings.Default.KierownikProjektu = TempKierownikProjektu;
                    Properties.Settings.Default.Szacujacy = TempSzacujacy;
                    Properties.Settings.Default.NazwaFirmy = TempNazwaFirmy;
                    Properties.Settings.Default.Adres = TempAdres;
                    Properties.Settings.Default.Telefon = TempTelefon;
                    Properties.Settings.Default.Email = TempEmail;
                    Properties.Settings.Default.JezykProgramowania = TempJezykProgramowania;
                    Properties.Settings.Default.StawkaGodz = TempStawkaGodz;
                    Properties.Settings.Default.OsoboMGodz = TempOsoboMGodz;
                    Properties.Settings.Default.DzRobGodz = TempDzRobGodz;

                    //Properties.Settings.Default.Save();
                    MessageBox.Show("Domyślne ustawienia projektu zostały zmienione.", "Sukces");
                }
            }
        }


        private void ButtonZapiszProjekt_Click(object sender, EventArgs e)
        {
            if (SciezkaDoPliku.Length == 0)
            {
                ToolStripMenuZapiszJakoProj_Click(sender, e);
            }
            else
            {
                Zapis();
            }
        }


        private void Zapis()
        {
            using (StreamWriter sw = new StreamWriter(File.Create(SciezkaDoPliku)))
            {
                //Na wypadek gdyby użytkownik nie wybrał żadnej daty
                DataProjektu = DateTimePicker.Text;

                sw.WriteLine(NazwaProjektu);
                sw.WriteLine(DataProjektu);
                sw.WriteLine(KierownikProjektu);
                sw.WriteLine(Szacujacy);
                sw.WriteLine(NazwaFirmy);
                sw.WriteLine(Adres);
                sw.WriteLine(Telefon);
                sw.WriteLine(Email);
                sw.WriteLine(OpisProjektu);

                sw.WriteLine(Ograniczenia);
                sw.WriteLine(Domyslne);

                foreach (var item in TabUUCW)
                {
                    sw.WriteLine(item);
                }

                foreach (var item in TabUAW)
                {
                    sw.WriteLine(item);
                }

                foreach (var item in TabIndSF)
                {
                    sw.WriteLine(item);
                }

                foreach (var item in TabIndEM)
                {
                    sw.WriteLine(item);
                }

                sw.WriteLine(JezykProgramowania);
                sw.WriteLine(StawkaGodz);
                sw.WriteLine(OsoboMGodz);
                sw.WriteLine(DzRobGodz);

                sw.WriteLine(MaxKoszt);
                sw.WriteLine(MaxPrac);
                sw.WriteLine(MaxHarm);

                sw.WriteLine(UUCP);
                sw.WriteLine(Rozmiar);
                sw.WriteLine(Pracochlonnosc);
                sw.WriteLine(Harmonogram);
                sw.WriteLine(Koszt);
                sw.WriteLine(LabelWynikPrac.BackColor.Name);
                sw.WriteLine(LabelWynikHarm.BackColor.Name);
                sw.WriteLine(LabelWynikKoszt.BackColor.Name);

                //sw.Dispose();
                MessageBox.Show("Plik zapisano.");
            }
        }


        private void UsuniecieDanych()
        {
            //Wyzerowanie
            SciezkaDoPliku = "";

            TextBoxNazwaProjektu.Text = "Projekt";
            NazwaProjektu = "Projekt";
            DateTimePicker.Value = DateTime.Now;
            DataProjektu = DateTime.Now.ToString();

            KierownikProjektu = "";
            Szacujacy = "";
            NazwaFirmy = "";
            Adres = "";
            Telefon = "";
            Email = "";
            OpisProjektu = "";


            NumUUCWProsty.Value = 0;
            NumUUCWSredni.Value = 0;
            NumUUCWZlozony.Value = 0;

            NumUAWProsty.Value = 0;
            NumUAWSredni.Value = 0;
            NumUAWZlozony.Value = 0;


            TabIndSF = new int[] { 2, 2, 2, 2, 2 };
            TabIndEM = new int[] { 2, 1, 2, 1, 2, 2, 2, 2, 2, 2, 2, 0, 0, 1, 2, 2, 2 };

            Ograniczenia = false;
            Domyslne = false;

            JezykProgramowania = Properties.Settings.Default.JezykProgramowania;
            StawkaGodz = Properties.Settings.Default.StawkaGodz;
            OsoboMGodz = Properties.Settings.Default.OsoboMGodz;
            DzRobGodz = Properties.Settings.Default.DzRobGodz;

            MaxKoszt = 0;
            MaxPrac = 0;
            MaxHarm = 0;


            LabelRozmiar.Text = "0";
            LabelPktUUCP.Text = "0";
            LabelWynikPrac.Text = "0";
            LabelWynikPrac.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikHarm.Text = "0";
            LabelWynikHarm.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikKoszt.Text = "0";
            LabelWynikKoszt.BackColor = System.Drawing.Color.FromName("Control");
        }


        private void ButtonZalozenia_Click(object sender, EventArgs e)
        {
            using (OknoZalozeniaProjektu OknoZalProj = new OknoZalozeniaProjektu())
            {
                DialogResult rezultat = OknoZalProj.ShowDialog();


                if (rezultat == DialogResult.OK)
                {
                    MessageBox.Show("Założenia projektu zostały zmienione.", "Sukces");

                    Ograniczenia = TempOgraniczenia;

                    JezykProgramowania = TempJezykProgramowania;
                    StawkaGodz = TempStawkaGodz;
                    OsoboMGodz = TempOsoboMGodz;
                    DzRobGodz = TempDzRobGodz;
                    MaxKoszt = TempMaxKoszt;
                    MaxPrac = TempMaxPrac;
                    MaxHarm = TempMaxHarm;

                }
            }
        }


        private void ButtonKalibracja_Click(object sender, EventArgs e)
        {
            using (OknoKalibracja OknoKalib = new OknoKalibracja())
            {
                DialogResult rezultat = OknoKalib.ShowDialog();

                if (rezultat == DialogResult.OK)
                {
                    Properties.Settings.Default.UCPnaFP = TempUCPnaFP;
                    Properties.Settings.Default.A = TempA;
                    Properties.Settings.Default.B = TempB;
                    Properties.Settings.Default.C = TempC;
                    Properties.Settings.Default.D = TempD;

                    //Properties.Settings.Default.Save();
                    MessageBox.Show("Kalibracja modelu została wykonana.", "Sukces");
                }
            }
        }


        private void ButtonKreator_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(TabPktFunkSLOC[JezykProgramowania].ToString());
            //MessageBox.Show(F.ToString());
            //MessageBox.Show(E.ToString());


            /*
            MessageBox.Show(Properties.Settings.Default.A.ToString());
            MessageBox.Show(Properties.Settings.Default.B.ToString());
            MessageBox.Show(Properties.Settings.Default.C.ToString());
            MessageBox.Show(Properties.Settings.Default.D.ToString());
            */
        }


        private void ButtonTablicaPrzeliczeniowa_Click(object sender, EventArgs e)
        {
            using (OknoSLOCnaFP OknoSLOC_FP = new OknoSLOCnaFP())
            {
                DialogResult rezultat = OknoSLOC_FP.ShowDialog();

                if (rezultat == DialogResult.OK)
                {
                    for (int i = 0; i < 38; i++)
                    {
                        Properties.Settings.Default.TabPrzeliczeniowa[i] = TempTabPrzeliczeniowa[i];
                    }

                    //Properties.Settings.Default.Save();
                    MessageBox.Show("Wprowadzono nowe dane do tablicy przeliczeniowej punktów funkcyjnych na źródłowe linie kodu.", "Sukces");
                }
            }
        }


        /*****************************************************************************//**
        *  Raporty.
        ********************************************************************************/
        private void ButtonOpisProjektu_Click(object sender, EventArgs e)
        {
            /*
            using (SaveFileDialog ZapiszPDFDialog = new SaveFileDialog())
            {
                ZapiszPDFDialog.Filter = "Plik Raportu | *.pdf";
                ZapiszPDFDialog.FileName = "Raport_Opis_Projektu.pdf";
                ZapiszPDFDialog.Title = "Zapisz plik Raportu jako:";

                DialogResult rezultat = ZapiszPDFDialog.ShowDialog();


                //zapisanie danych do pliku tekstowego
                if (rezultat == DialogResult.OK)
                {
                    //ZapiszPDFDialog.FileName;
                    */

            // Utworzenie dokumentu przy pomocy MigraDoc
            var dokument = new Document();

            dokument.Info.Title = "Opis projektu";
            dokument.Info.Subject = "Raport zawierający opis projektu";
            dokument.Info.Author = Szacujacy;

            string raport = NazwaProjektu + " - opis projektu";


            // Zdefiniowanie stylu
            DefinicjaStylu(dokument);

            // Dodajemy stronę tytułową
            StronaTytulowa(dokument, raport);

            // Schemat treści
            DefinicjaZawartosci(dokument, raport);

            // Dodanie strony z opisem projektu
            StronaZOpisem(dokument);

            // Flaga wskazuje na to czy dokument ma być utworzony jako plik Unicode PDF czy jako WinAnsi PDF.
            // To ustawienie dotyczy wszystkich czcionek użytych w dokumencie.
            const bool unicode = true;

            // Utworzenie renderera dla dokumentu
            var pdfRenderer = new PdfDocumentRenderer(unicode);

            // Powiązanie dokumentu z rendererem
            pdfRenderer.Document = dokument;

            // Wyrenderowanie dokumentu do formatu PDF
            pdfRenderer.RenderDocument();


            // Wariant z oknem dialogowym
            //pdfRenderer.PdfDocument.Save(ZapiszPDFDialog.FileName);
            //Process.Start(ZapiszPDFDialog.FileName);


            // Zapisanie dokumentu do pliku PDF
            const string filename = "Raport_Opis_Projektu.pdf";
            pdfRenderer.PdfDocument.Save(filename);

            // Uruchomienie pliku z raportem
            Process.Start(filename);

        }

        private void ButtonOszacowanie_Click(object sender, EventArgs e)
        {
            /*
            using (SaveFileDialog ZapiszPDFDialog = new SaveFileDialog())
            {
                ZapiszPDFDialog.Filter = "Plik Raportu | *.pdf";
                ZapiszPDFDialog.FileName = "Raport_Oszacowanie_Pracochlonnosci.pdf";
                ZapiszPDFDialog.Title = "Zapisz plik Raportu jako:";

                DialogResult rezultat = ZapiszPDFDialog.ShowDialog();


                //zapisanie danych do pliku tekstowego
                if (rezultat == DialogResult.OK)
                {
                    //ZapiszPDFDialog.FileName;
                    
             */

            // Utworzenie dokumentu przy pomocy MigraDoc
            var dokument = new Document();

            dokument.Info.Title = "Oszacowanie pracochłonności projektu";
            dokument.Info.Subject = "Raport zawierający oszacowanie pracochłonności projektu z wykorzystaniem połączenia dwóch metod estymacji:" +
                "Use Case Points i COCOMO II";
            dokument.Info.Author = Szacujacy;

            string raport = NazwaProjektu + " - oszacowanie pracochłonności";


            // Zdefiniowanie stylu
            DefinicjaStylu(dokument);

            // Dodajemy stronę tytułową
            StronaTytulowa(dokument, raport);

            // Schemat treści
            DefinicjaZawartosci(dokument, raport);

            // Dodanie strony z opisem projektu
            StronaZOpisem(dokument);

            // Dodanie tabeli
            WprowadzoneDane(dokument);


            // Flaga wskazuje na to czy dokument ma być utworzony jako plik Unicode PDF czy jako WinAnsi PDF.
            // To ustawienie dotyczy wszystkich czcionek użytych w dokumencie.
            const bool unicode = true;

            // Utworzenie renderera dla dokumentu
            var pdfRenderer = new PdfDocumentRenderer(unicode);

            // Powiązanie dokumentu z rendererem
            pdfRenderer.Document = dokument;

            // Wyrenderowanie dokumentu do formatu PDF
            pdfRenderer.RenderDocument();


            // Wariant z oknem dialogowym
            //pdfRenderer.PdfDocument.Save(ZapiszPDFDialog.FileName);
            //Process.Start(ZapiszPDFDialog.FileName);


            // Zapisanie dokumentu do pliku PDF
            const string filename = "Raport_Oszacowanie_Pracochlonnosci.pdf";
            pdfRenderer.PdfDocument.Save(filename);

            // Uruchomienie pliku z raportem
            Process.Start(filename);
        }


        //Funkcja definiująca styl generowanego dokumentu
        public static void DefinicjaStylu(Document dokument)
        {
            // Ustawienie predefiniowanego stylu Normal. Ponieważ wszystkie style od niego pochodzą
            // ma on wpływ na wszystkie sekcje i paragrafy.
            var styl = dokument.Styles["Normal"];

            // Czcionka tekstu
            styl.Font.Name = "Arial";
            styl.Font.Size = 12;

            // Nagłówki Heading1 do Heading2 to predefiniowane style, które automatycznie tworzą odpowiednie poziomy konspektu
            styl = dokument.Styles["Heading1"];
            styl.Font.Name = "Arial";
            styl.Font.Size = 20;
            styl.Font.Bold = true;
            styl.Font.Color = Colors.DarkRed;
            styl.ParagraphFormat.PageBreakBefore = true;
            styl.ParagraphFormat.SpaceBefore = "4cm";
            styl.ParagraphFormat.SpaceAfter = "1cm";

            // Ustawienie KeepWithNext dla wszystkich nagłówków w celu uniknięcia sytuacji, 
            // w której pojawiałyby się one na dole każdej strony. Inne nagłówki dziedziczą tę wartość z Heading1.
            styl.ParagraphFormat.KeepWithNext = true;

            styl = dokument.Styles["Heading2"];
            styl.Font.Size = 16;

            styl.ParagraphFormat.PageBreakBefore = false;
            styl.ParagraphFormat.SpaceBefore = "1cm";
            styl.ParagraphFormat.SpaceAfter = 6;

            styl = dokument.Styles[StyleNames.Header];
            styl.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);
            styl.ParagraphFormat.Font.Color = Colors.DarkRed;

            styl = dokument.Styles[StyleNames.Footer];
            styl.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);


        }


        //Funkcja definiująca schemat zawartości generowanego dokumentu
        static void DefinicjaZawartosci(Document dokument, string nazwaRaportu)
        {
            var sekcja = dokument.AddSection();
            sekcja.PageSetup.OddAndEvenPagesHeaderFooter = true;
            sekcja.PageSetup.StartingNumber = 3;

            var naglowek = sekcja.Headers.Primary;
            naglowek.AddParagraph(nazwaRaportu);
            naglowek.Format.Alignment = ParagraphAlignment.Right;


            naglowek = sekcja.Headers.EvenPage;
            naglowek.AddParagraph(nazwaRaportu);


            // Tworzy paragraf z numerem strony
            var paragraf = new Paragraph();
            paragraf.AddTab();
            paragraf.AddPageField();


            // Dodaje paragraf do stopki dla nieparzystych stron 
            sekcja.Footers.Primary.Add(paragraf);

            // Klonuje powyższy paragraf dla parzystych stron. Klonowanie jest konieczne gdyż obiekt nie może należeć do więcej niż jednego obiektu?
            sekcja.Footers.EvenPage.Add(paragraf.Clone());
        }



        //Domyślny wzór strony tytułowej
        public static void StronaTytulowa(Document dokument, string nazwaRaportu)
        {
            var sekcja = dokument.AddSection();

            var paragraf = sekcja.AddParagraph(nazwaRaportu);
            paragraf.Format.SpaceBefore = "6cm";
            paragraf.Format.SpaceAfter = "1cm";
            paragraf.Format.Font.Size = 28;
            paragraf.Format.Font.Bold = true;
            paragraf.Format.Font.Color = Colors.DarkRed;

            double odstep = 0;

            if (Szacujacy.Length != 0)
            {
                paragraf = sekcja.AddParagraph("Przygotował " + Szacujacy);
                paragraf.Format.Font.Size = 15;
                paragraf.Format.Font.Color = Colors.DarkRed;
                odstep += 6;
            }
            else
            {
                odstep += 6.6;
            }

            if (NazwaFirmy.Length != 0)
            {
                paragraf = sekcja.AddParagraph("dla firmy " + NazwaFirmy);
                paragraf.Format.Font.Size = 15;
                paragraf.Format.Font.Color = Colors.DarkRed;
                odstep += 6;
            }
            else
            {
                odstep += 6.6;
            }

            if (Szacujacy.Length == 0 && NazwaFirmy.Length == 0)
            {
                odstep = 14.2;
            }

            paragraf.Format.SpaceAfter = string.Format("{0}cm", odstep);


            paragraf = sekcja.AddParagraph("Data utworzenia: ");
            paragraf.Add(new DateField() { Format = "dd/MM/yyyy" });
            paragraf.Format.Font.Size = 15;
            paragraf.Format.Font.Color = Colors.DarkRed;

            sekcja.AddPageBreak();

        }

        //Strona z danymi projektu
        public static void StronaZOpisem(Document dokument)
        {
            var sekcja = dokument.LastSection;

            //EXT Jak brak to wpisz brak

            var paragraf = sekcja.AddParagraph("Podstawowe informacje", "Heading1");

            paragraf = sekcja.AddParagraph("Dane projektu", "Heading2");

            paragraf = sekcja.AddParagraph("Nazwa projektu: ");
            paragraf.Format.Font.Bold = true;
            paragraf.AddFormattedText(NazwaProjektu, TextFormat.NotBold);

            paragraf = sekcja.AddParagraph("Kierownik Projektu: ");
            paragraf.Format.Font.Bold = true;
            paragraf.AddFormattedText(KierownikProjektu, TextFormat.NotBold);

            paragraf = sekcja.AddParagraph("Osoba odpowiedzialna za oszacowanie: ");
            paragraf.Format.Font.Bold = true;
            paragraf.AddFormattedText(Szacujacy, TextFormat.NotBold);

            // Na wypadek gdyby użytkownik nie wybrał żadnej daty
            if (DataProjektu.Length == 0)
            {
                DataProjektu = DateTime.Now.ToLongDateString();
            }
            paragraf = sekcja.AddParagraph("Data rozpoczęcia projektu: ");
            paragraf.Format.Font.Bold = true;
            paragraf.AddFormattedText(DataProjektu, TextFormat.NotBold);

            paragraf = sekcja.AddParagraph("Dane firmy", "Heading2");

            paragraf = sekcja.AddParagraph("Nazwa firmy: ");
            paragraf.Format.Font.Bold = true;
            paragraf.AddFormattedText(NazwaFirmy, TextFormat.NotBold);

            paragraf = sekcja.AddParagraph("Adres: ");
            paragraf.Format.Font.Bold = true;
            paragraf.AddFormattedText(Adres, TextFormat.NotBold);

            paragraf = sekcja.AddParagraph("Telefon/Fax: ");
            paragraf.Format.Font.Bold = true;
            paragraf.AddFormattedText(Telefon, TextFormat.NotBold);

            paragraf = sekcja.AddParagraph("E-Mail: ");
            paragraf.Format.Font.Bold = true;
            paragraf.AddFormattedText(Email, TextFormat.NotBold);

            paragraf = sekcja.AddParagraph("Opis projektu", "Heading2");
            paragraf = sekcja.AddParagraph(OpisProjektu);

            paragraf = sekcja.AddParagraph("Założenia projektu", "Heading2");
            paragraf = sekcja.AddParagraph("Główny język programowania użyty w projekcie: ");
            paragraf.Format.Font.Bold = true;
            paragraf.AddFormattedText(JezykProg[JezykProgramowania], TextFormat.NotBold);

            //TODO ładnie opisane
            paragraf = sekcja.AddParagraph("Stawka godzinowa: ");
            paragraf.Format.Font.Bold = true;
            paragraf.AddFormattedText(StawkaGodz + " zł", TextFormat.NotBold);

            paragraf = sekcja.AddParagraph("1 osobomiesiąc stanowi: ");
            paragraf.Format.Font.Bold = true;
            paragraf.AddFormattedText(OsoboMGodz + " osobogodzin", TextFormat.NotBold);

            paragraf = sekcja.AddParagraph("Dzień roboczy wynosi: ");
            paragraf.Format.Font.Bold = true;
            paragraf.AddFormattedText(DzRobGodz + " godzin", TextFormat.NotBold);


            if (Ograniczenia == true)
            {
                paragraf = sekcja.AddParagraph("Ograniczenia nałożone na oszacowanie", "Heading2");

                paragraf = sekcja.AddParagraph("Maksymalna pracochłonność: ");
                paragraf.Format.Font.Bold = true;
                paragraf.AddFormattedText(MaxPrac + " osobomiesięcy", TextFormat.NotBold);

                paragraf = sekcja.AddParagraph("Maksymalny harmonogram: ");
                paragraf.Format.Font.Bold = true;
                paragraf.AddFormattedText(MaxHarm + " miesięcy", TextFormat.NotBold);

                paragraf = sekcja.AddParagraph("Maksymalny koszt: ");
                paragraf.Format.Font.Bold = true;
                paragraf.AddFormattedText(MaxKoszt + " zł", TextFormat.NotBold);

            }


        }





        //Tabela z danymi wprowadzonymi do szacowania
        public static void WprowadzoneDane(Document dokument)
        {
            //var sekcja = dokument.LastSection;
            var sekcja = dokument.LastSection;

            var paragraf = sekcja.AddParagraph("Dane wykorzystane do oszacowania pracochłonności", "Heading1");
     
            paragraf = sekcja.AddParagraph("Metoda Use Case Points", "Heading2");
            
            //nagłówek tabelii
            paragraf = sekcja.AddParagraph("Tabela 1 - przypadki użycia");
            paragraf.Format.SpaceAfter = "0.2cm";

            var TabUseCases = new Table();

            //granice tabelii
            //TabUseCases.Borders.Width = 0.5;

            //dodajemy kolumny
            var column = TabUseCases.AddColumn(Unit.FromCentimeter(2.5));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabUseCases.AddColumn(Unit.FromCentimeter(2));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabUseCases.AddColumn(Unit.FromCentimeter(4));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabUseCases.AddColumn(Unit.FromCentimeter(7));
            column.Format.Alignment = ParagraphAlignment.Center;

            //lub row.Height = Unit.FromCentimeter(1);
            TabUseCases.Rows.Height = Unit.FromCentimeter(1);

            var row = TabUseCases.AddRow();
            row.Shading.Color = Colors.LightSalmon;
            row.VerticalAlignment = VerticalAlignment.Center;

            //dodajemy tekst do nagłówków kolumn
            var cell = row.Cells[0];          
            cell.AddParagraph("");
            cell = row.Cells[1];
            cell.AddParagraph("Waga");
            cell = row.Cells[2];
            cell.AddParagraph("Liczba przypadków użycia");
            cell = row.Cells[3];
            cell.AddParagraph("Liczba transakcji");


            //tylko dodaje do pierwszego kolor
            row = TabUseCases.AddRow();            
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Prosty");
            cell = row.Cells[1];
            cell.AddParagraph("5");
            cell = row.Cells[2];
            cell.AddParagraph(TabUUCW[0].ToString());
            cell = row.Cells[3];
            cell.AddParagraph("od 1 do 3");

            row = TabUseCases.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Średni");
            cell = row.Cells[1];
            cell.AddParagraph("10");
            cell = row.Cells[2];
            cell.AddParagraph(TabUUCW[1].ToString());
            cell = row.Cells[3];
            cell.AddParagraph("od 4 do 7");

            row = TabUseCases.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Złożony");
            cell = row.Cells[1];
            cell.AddParagraph("15");
            cell = row.Cells[2];
            cell.AddParagraph(TabUUCW[2].ToString());
            cell = row.Cells[3];
            cell.AddParagraph("więcej niż 7");


            //ramka od 0,0 do 2 kolumny, 3 rzędy
            //TabUseCases.SetEdge(0, 0, 2, 1, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.Black);
            TabUseCases.SetEdge(0, 0, 4, 4, Edge.Bottom, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.LightSalmon);

            dokument.LastSection.Add(TabUseCases);

            //--------------------------------------------------------------------------


            //nagłówek tabelii
            paragraf = sekcja.AddParagraph("Tabela 2 - aktorzy");
            paragraf.Format.SpaceAfter = "0.2cm";
            paragraf.Format.SpaceBefore = "1cm";

            var TabAktorzy = new Table();

            //dodajemy kolumny
            var column2 = TabAktorzy.AddColumn(Unit.FromCentimeter(2.5));
            column2.Format.Alignment = ParagraphAlignment.Center;

            column2 = TabAktorzy.AddColumn(Unit.FromCentimeter(2));
            column2.Format.Alignment = ParagraphAlignment.Center;

            column2 = TabAktorzy.AddColumn(Unit.FromCentimeter(4));
            column2.Format.Alignment = ParagraphAlignment.Center;

            column2 = TabAktorzy.AddColumn(Unit.FromCentimeter(7));
            column2.Format.Alignment = ParagraphAlignment.Center;

            TabAktorzy.Rows.Height = Unit.FromCentimeter(1);

            var row2 = TabAktorzy.AddRow();
            row2.VerticalAlignment = VerticalAlignment.Center;
            row2.Shading.Color = Colors.LightSalmon;

            //dodajemy tekst do nagłówków kolumn
            var cell2 = row2.Cells[0];
            cell2.AddParagraph("");
            cell2 = row2.Cells[1];
            cell2.AddParagraph("Waga");
            cell2 = row2.Cells[2];
            cell2.AddParagraph("Liczba aktorów");
            cell2 = row2.Cells[3];
            cell2.AddParagraph("Sposób komunikacji z systemem");


            //tylko dodaje do pierwszego kolor
            row2 = TabAktorzy.AddRow();
            row2.VerticalAlignment = VerticalAlignment.Center;
            cell2 = row2.Cells[0];
            cell2.AddParagraph("Prosty");
            cell2 = row2.Cells[1];
            cell2.AddParagraph("5");
            cell2 = row2.Cells[2];
            cell2.AddParagraph(TabUAW[0].ToString());
            cell2 = row2.Cells[3];
            cell2.AddParagraph("aktor systemowy poprzez API");

            row2 = TabAktorzy.AddRow();
            row2.VerticalAlignment = VerticalAlignment.Center;
            cell2 = row2.Cells[0];
            cell2.AddParagraph("Średni");
            cell2 = row2.Cells[1];
            cell2.AddParagraph("10");
            cell2 = row2.Cells[2];
            cell2.AddParagraph(TabUAW[1].ToString());
            cell2 = row2.Cells[3];
            cell2.AddParagraph("aktor systemowy poprzez protokół / człowiek poprzez wiersz poleceń");

            row2 = TabAktorzy.AddRow();
            row2.VerticalAlignment = VerticalAlignment.Center;
            cell2 = row2.Cells[0];
            cell2.AddParagraph("Złożony");
            cell2 = row2.Cells[1];
            cell2.AddParagraph("15");
            cell2 = row2.Cells[2];
            cell2.AddParagraph(TabUAW[2].ToString());
            cell2 = row2.Cells[3];
            cell2.AddParagraph("człowiek poprzez GUI");


            //ramka od 0,0 do 2 kolumny, 3 rzędy
            //TabUseCases.SetEdge(0, 0, 2, 1, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.Black);
            TabAktorzy.SetEdge(0, 0, 4, 4, Edge.Bottom, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.LightSalmon);

            dokument.LastSection.Add(TabAktorzy);


        }





    }
}

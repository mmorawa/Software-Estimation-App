﻿/*! \file Form1.cs
\brief Plik Form1.cs zawiera klasę Form1 z głównym oknem aplikacji.

Plik Form1.cs zawiera rdzeń programu czyli główne okno aplikacji wraz z menu, pozwalającym na dokonanie wyboru różnych opcji menadżera zadań takich jak: szyfrowanie/deszyfrowanie bazy danych.
*/

using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using MigraDoc.DocumentObjectModel;


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


        public static int[] TabIndCzynnSkali = { 2, 2, 2, 2, 2 };
        public static int[] TempTabIndCzynnSkali = new int[5];

        public static int[] TabIndMnPrac = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
        public static int[] TempTabIndMnPrac = new int[17];

        double[,] TabCzynnSkali =
        {
            {6.2, 4.96, 3.72, 2.48, 1.24, 0 },
            {5.07, 4.05, 3.04, 2.03, 1.01, 0 },
            {7.07, 5.65, 4.24, 2.83, 1.41, 0 },
            {5.48, 4.38, 3.29, 2.19, 1.1, 0 },
            {7.8, 6.24, 4.68, 3.12, 1.56, 0 }
        };

        public static string[] TabStringCzynnSkali = { "Bardzo niski", "Niski", "Nominalny", "Wysoki", "Bardzo wysoki", "Ekstra wysoki" };


        double[,] TabMnPrac =
        {
            {0.82, 0.92, 1, 1.1, 1.26, 0 },
            {0, 0.9, 1, 1.14, 1.28, 0 },
            {0.73, 0.87, 1, 1.17, 1.34, 1.74 },
            {0, 0.95, 1, 1.07, 1.15, 1.24 },
            {0.81, 0.91, 1, 1.11, 1.23, 0 },
            {1.42, 1.19, 1, 0.85, 0.71, 0 },
            {1.34, 1.15, 1, 0.88, 0.76, 0 },
            {1.29, 1.12, 1, 0.9, 0.81, 0 },
            {1.22, 1.10, 1, 0.88, 0.81, 0 },
            {1.19, 1.09, 1, 0.91, 0.85, 0 },
            {1.2, 1.09, 1, 0.91, 0.84, 0 },
            {0, 0, 1, 1.11, 1.29, 1.63 },
            {0, 0, 1, 1.05, 1.17, 1.46 },
            {0, 0.87, 1, 1.15, 1.3, 0 },
            {1.17, 1.09, 1, 0.9, 0.78, 0 },
            {1.22, 1.09, 1, 0.93, 0.86, 0.8 },
            {1.43, 1.14, 1, 1, 1, 0 }
        };

        public static string[] TabStringMnPrac = { "Bardzo niski", "Niski", "Nominalny", "Wysoki", "Bardzo wysoki", "Ekstra wysoki" };

        double[] TabOgranHarm = { 0.75, 0.85, 1, 1.3, 1.6 };

        string Ostrzezenie;

        //współczynniki
        public static double TempUCPnaFP;
        public static double TempA;
        public static double TempB;
        public static double TempC;
        public static double TempD;

        //Ustawienia
        public static int JezykProgramowania = Properties.Settings.Default.JezykProgramowania;

        public static string[] JezykProg = {"ABAP (SAP) ", "ASP", "Assembler", "Brio", "C", "C++", "C#", "COBOL","Cognos Impromptu Scripts", "Cross System Products (CSP)",
            "Cool:Gen/IEF", "Datastage", "Excel", "Focus","FoxPro", "HTML", "J2EE", "Java", "JavaScript", "JCL", "LINC II", "Lotus Notes", "Natural",
            ".NET", "Oracle", "PACBASE", "Perl", "PL/I", "PL/SQL", "Powerbuilder", "REXX", "Sabretalk", "SAS", "Siebel", "SLOGAN", "SQL", "VB.NET", "Visual Basic"
        };

        public static double StawkaGodz = Properties.Settings.Default.StawkaGodz;
        public static long OsoboMGodz = Properties.Settings.Default.OsoboMGodz;
        public static long DzRobGodz = Properties.Settings.Default.DzRobGodz;

        public static long MaxPrac = 0;
        public static long MaxHarm = 0;
        public static DateTime Deadline = DateTime.Now;
        public static double MaxKoszt = 0;
        public static long MaxZespol = 0;


        //wartości tymczasowe
        public static int TempJezykProgramowania;
        public static double TempStawkaGodz;
        public static long TempOsoboMGodz;
        public static long TempDzRobGodz;

        public static long TempMaxPrac;
        public static long TempMaxHarm;
        public static DateTime TempDeadline;
        public static double TempMaxKoszt;
        public static long TempMaxZespol;

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
        double PracochlonnoscBezOgranNLep;
        double PracochlonnoscBezOgranNGor;

        //wyniki końcowe
        double UUCP;
        double Rozmiar;

        double Pracochlonnosc;
        double PracochlonnoscNLep;
        double PracochlonnoscNGor;

        double Harmonogram;
        double HarmonogramNLep;
        double HarmonogramNGor;

        DateTime DataZakonczenia;
        DateTime DataZakonczeniaNLep;
        DateTime DataZakonczeniaNGor;

        double Wydajnosc;
        double WydajnoscNLep;
        double WydajnoscNGor;

        double Koszt;
        double KosztNLep;
        double KosztNGor;

        double SrZespol;
        double SrZespolNLep;
        double SrZespolNGor;

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
            Process.Start("Dokumentacja.pdf");
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


        //---------------------------------------Dane COCOMO II--------------------------------------------------


        private void ButtonCzSk_Click(object sender, EventArgs e)
        {
            using (OknoCzynnikiSkali OknoCzynS = new OknoCzynnikiSkali())
            {
                DialogResult rezultat = OknoCzynS.ShowDialog();


                if (rezultat == DialogResult.OK)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        TabIndCzynnSkali[i] = TempTabIndCzynnSkali[i];
                    }

                    Oszacowanie();                                    
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
                        TabIndMnPrac[i] = TempTabIndMnPrac[i];
                    }

                    Oszacowanie();
                }
            }
        }


        //-----------------------------------Dane UCP-----------------------------------------------------

        private void TextBoxNazwaProjektu_TextChanged(object sender, EventArgs e)
        {
            NazwaProjektu = TextBoxNazwaProjektu.Text;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DataProjektu = DateTimePicker.Text;
            Oszacowanie();
        }

        private void NumUUCWProsty_ValueChanged(object sender, EventArgs e)
        {
            TabUUCW[0] = (long)NumUUCWProsty.Value;
            Oszacowanie();
        }

        private void NumUUCWSredni_ValueChanged(object sender, EventArgs e)
        {
            TabUUCW[1] = (long)NumUUCWSredni.Value;
            Oszacowanie();
        }

        private void NumUUCWZlozony_ValueChanged(object sender, EventArgs e)
        {
            TabUUCW[2] = (long)NumUUCWZlozony.Value;
            Oszacowanie();
        }

        private void NumUAWProsty_ValueChanged(object sender, EventArgs e)
        {
            TabUAW[0] = (long)NumUAWProsty.Value;
            Oszacowanie();
        }

        private void NumUAWSredni_ValueChanged(object sender, EventArgs e)
        {
            TabUAW[1] = (long)NumUAWSredni.Value;
            Oszacowanie();
        }

        private void NumUAWZlozony_ValueChanged(object sender, EventArgs e)
        {
            TabUAW[2] = (long)NumUAWZlozony.Value;
            Oszacowanie();
        }

        //------------------------Algorytm------------------------------------------------------

        //TODO kasowanie danych częściowo zbędne bo teraz automatycznie wywołuje się funkcja Oszacowanie
        private void Oszacowanie()
        {
            //TODO walidacja danych wejściowych, zaokrąglanie
            Ostrzezenie = "";

            //Obliczenia UUCP

            UUCW = 0;
            for (int i = 0; i < 3; i++)
            {
                UUCW += TabUUCW[i] * wagiUC[i];
            }

            if (UUCW == 0)
            {
                UsuniecieWynikow();               
                return;
            }

            UAW = 0;
            for (int i = 0; i < 3; i++)
            {
                UAW += TabUAW[i] * wagiAktorow[i];
            }

            UUCP = UAW + UUCW;

            Rozmiar = (UUCP * Properties.Settings.Default.UCPnaFP * Properties.Settings.Default.TabPrzeliczeniowa[JezykProgramowania]);

            if (Rozmiar < 2000)
            {
                Ostrzezenie = "Ten model nie jest skalibrowany dla projektów poniżej 2000 linii kodu. ";
            }

            RozmiarKSLOC = Rozmiar / 1000;

            
            //Obliczenia COCOMO II

            SumaSF = 0;
            for (int i = 0; i < 5; i++)
            {
                SumaSF += TabCzynnSkali[i, TabIndCzynnSkali[i]];
            }

            IloczynEM = 1;
            for (int i = 0; i < 17; i++)
            {
                IloczynEM *= TabMnPrac[i, TabIndMnPrac[i]];
            }

            E = Properties.Settings.Default.B + 0.01 * SumaSF;


            Pracochlonnosc = Properties.Settings.Default.A * Math.Pow(RozmiarKSLOC, E) * IloczynEM;
            PracochlonnoscNLep = Pracochlonnosc * 0.8;
            PracochlonnoscNGor = Pracochlonnosc * 1.25;

            IloczynEMOgranHarm = 1;
            for (int i = 0; i < 16; i++)
            {
                IloczynEMOgranHarm *= TabMnPrac[i, TabIndMnPrac[i]];
            }

            PracochlonnoscBezOgran = Properties.Settings.Default.A * Math.Pow(RozmiarKSLOC, E) * IloczynEMOgranHarm;
            PracochlonnoscBezOgranNLep = PracochlonnoscBezOgran * 0.8;
            PracochlonnoscBezOgranNGor = PracochlonnoscBezOgran * 1.25;

            F = Properties.Settings.Default.D + 0.2 * (E - Properties.Settings.Default.B);

            Harmonogram = Properties.Settings.Default.C * Math.Pow(PracochlonnoscBezOgran, F) * TabOgranHarm[TabIndMnPrac[16]];
            HarmonogramNLep = Properties.Settings.Default.C * Math.Pow(PracochlonnoscBezOgranNLep, F) * TabOgranHarm[TabIndMnPrac[16]];
            HarmonogramNGor = Properties.Settings.Default.C * Math.Pow(PracochlonnoscBezOgranNGor, F) * TabOgranHarm[TabIndMnPrac[16]];

            //TODO pusta data -> brak? danych..., czynniki COCOMO post architecture

            DataZakonczenia = Convert.ToDateTime(DateTimePicker.Text);
            DataZakonczenia = DataZakonczenia.AddDays((int)Math.Round(Harmonogram * 30.42));
            DataZakonczeniaNLep = Convert.ToDateTime(DateTimePicker.Text);
            DataZakonczeniaNLep = DataZakonczeniaNLep.AddDays((int)Math.Round(HarmonogramNLep * 30.42));
            DataZakonczeniaNGor = Convert.ToDateTime(DateTimePicker.Text);
            DataZakonczeniaNGor = DataZakonczeniaNGor.AddDays((int)Math.Round(HarmonogramNGor * 30.42));


            Wydajnosc = Rozmiar / Pracochlonnosc;
            WydajnoscNLep = Rozmiar / PracochlonnoscNLep;
            WydajnoscNGor = Rozmiar / PracochlonnoscNGor;

            Koszt = Pracochlonnosc * OsoboMGodz * StawkaGodz;
            KosztNLep = PracochlonnoscNLep * OsoboMGodz * StawkaGodz;
            KosztNGor = PracochlonnoscNGor * OsoboMGodz * StawkaGodz;

            SrZespol = Pracochlonnosc / Harmonogram;
            SrZespolNLep = PracochlonnoscNLep / HarmonogramNLep;
            SrZespolNGor = PracochlonnoscNGor / HarmonogramNGor;



            //Wyświetlenie wyników
            LabelPktUUCP.Text = string.Format("{0:N0}", UUCP);
            LabelRozmiar.Text = string.Format("{0:N0}", Rozmiar);

            LabelWynikPrac.Text = string.Format("{0:N1}", Pracochlonnosc);
            LabelWynikNLepPrac.Text = string.Format("{0:N1}", PracochlonnoscNLep);
            LabelWynikNGorPrac.Text = string.Format("{0:N1}", PracochlonnoscNGor);

            LabelWynikHarm.Text = string.Format("{0:N1}", Harmonogram);
            LabelWynikNLepHarm.Text = string.Format("{0:N1}", HarmonogramNLep);
            LabelWynikNGorHarm.Text = string.Format("{0:N1}", HarmonogramNGor);

            LabelWynikData.Text = string.Format("{0:d MMMM yyyy}", DataZakonczenia);
            LabelWynikNLepData.Text = string.Format("{0:d MMMM yyyy}", DataZakonczeniaNLep);
            LabelWynikNGorData.Text = string.Format("{0:d MMMM yyyy}", DataZakonczeniaNGor);

            LabelWynikWydaj.Text = string.Format("{0:N1}", Wydajnosc);
            LabelWynikNLepWydaj.Text = string.Format("{0:N1}", WydajnoscNLep);
            LabelWynikNGorWydaj.Text = string.Format("{0:N1}", WydajnoscNGor);

            LabelWynikKoszt.Text = string.Format("{0:N}", Koszt);
            LabelWynikNLepKoszt.Text = string.Format("{0:N}", KosztNLep);
            LabelWynikNGorKoszt.Text = string.Format("{0:N}", KosztNGor);

            LabelWynikSrZesp.Text = string.Format("{0:N1}", SrZespol);
            LabelWynikNLepSrZesp.Text = string.Format("{0:N1}", SrZespolNLep);
            LabelWynikNGorSrZesp.Text = string.Format("{0:N1}", SrZespolNGor);

            

            
            //Ograniczenia nałożone na projekt

            if (Ograniczenia == true)
            {

                if (MaxPrac != 0 && MaxPrac < Pracochlonnosc)
                {
                    LabelWynikPrac.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikPrac.BackColor = System.Drawing.Color.FromName("control");
                }

                if (MaxPrac != 0 && MaxPrac < PracochlonnoscNLep)
                {
                    LabelWynikNLepPrac.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikNLepPrac.BackColor = System.Drawing.Color.FromName("control");
                }

                if (MaxPrac != 0 && MaxPrac < PracochlonnoscNGor)
                {
                    LabelWynikNGorPrac.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikNGorPrac.BackColor = System.Drawing.Color.FromName("control");
                }




                if (MaxHarm != 0 && MaxHarm < Harmonogram)
                {
                    LabelWynikHarm.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikHarm.BackColor = System.Drawing.Color.FromName("control");
                }

                if (MaxHarm != 0 && MaxHarm < HarmonogramNLep)
                {
                    LabelWynikNLepHarm.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikNLepHarm.BackColor = System.Drawing.Color.FromName("control");
                }

                if (MaxHarm != 0 && MaxHarm < HarmonogramNGor)
                {
                    LabelWynikNGorHarm.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikNGorHarm.BackColor = System.Drawing.Color.FromName("control");
                }


                if (Deadline.ToLongDateString() != DateTime.Now.ToLongDateString() && Deadline < DataZakonczenia)
                {
                    LabelWynikData.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikData.BackColor = System.Drawing.Color.FromName("control");
                }

                if (Deadline.ToLongDateString() != DateTime.Now.ToLongDateString() && Deadline < DataZakonczeniaNLep)
                {
                    LabelWynikNLepData.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikNLepData.BackColor = System.Drawing.Color.FromName("control");
                }

                if (Deadline.ToLongDateString() != DateTime.Now.ToLongDateString() && Deadline < DataZakonczeniaNGor)
                {
                    LabelWynikNGorData.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikNGorData.BackColor = System.Drawing.Color.FromName("control");
                }


                if (MaxKoszt != 0 && MaxKoszt < Koszt)
                {
                    LabelWynikKoszt.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikKoszt.BackColor = System.Drawing.Color.FromName("control");
                }

                if (MaxKoszt != 0 && MaxKoszt < KosztNLep)
                {
                    LabelWynikNLepKoszt.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikNLepKoszt.BackColor = System.Drawing.Color.FromName("control");
                }

                if (MaxKoszt != 0 && MaxKoszt < KosztNGor)
                {
                    LabelWynikNGorKoszt.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikNGorKoszt.BackColor = System.Drawing.Color.FromName("control");
                }


                if (MaxZespol != 0 && MaxZespol < SrZespol)
                {
                    LabelWynikSrZesp.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikSrZesp.BackColor = System.Drawing.Color.FromName("control");
                }

                if (MaxZespol != 0 && MaxZespol < SrZespolNLep)
                {
                    LabelWynikNLepSrZesp.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikNLepSrZesp.BackColor = System.Drawing.Color.FromName("control");
                }

                if (MaxZespol != 0 && MaxZespol < SrZespolNGor)
                {
                    LabelWynikNGorSrZesp.BackColor = System.Drawing.Color.FromName("red");
                }
                else
                {
                    LabelWynikNGorSrZesp.BackColor = System.Drawing.Color.FromName("control");
                }


            }


            if (Ostrzezenie.Length == 0)
            {
                LabelUwagi.Text = "Uwagi: brak.";
            }
            else
            {
                LabelUwagi.Text = "Uwagi: " + Ostrzezenie;
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
                                TabIndCzynnSkali[i] = int.Parse(sr.ReadLine());
                            }

                            for (int i = 0; i < 17; i++)
                            {
                                TabIndMnPrac[i] = int.Parse(sr.ReadLine());
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

                            SrZespol = double.Parse(sr.ReadLine());
                            LabelWynikSrZesp.Text = string.Format("{0:N0}", SrZespol);
                            LabelWynikData.Text = sr.ReadLine();
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

                foreach (var item in TabIndCzynnSkali)
                {
                    sw.WriteLine(item);
                }

                foreach (var item in TabIndMnPrac)
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
                sw.WriteLine(SrZespol);
                sw.WriteLine(LabelWynikData.Text);

                
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


            TabIndCzynnSkali = new int[] { 2, 2, 2, 2, 2 };
            TabIndMnPrac = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };

            Ograniczenia = false;
            Domyslne = false;

            JezykProgramowania = Properties.Settings.Default.JezykProgramowania;
            StawkaGodz = Properties.Settings.Default.StawkaGodz;
            OsoboMGodz = Properties.Settings.Default.OsoboMGodz;
            DzRobGodz = Properties.Settings.Default.DzRobGodz;

            
            MaxPrac = 0;
            MaxHarm = 0;
            Deadline = DateTime.Now;
            MaxKoszt = 0;
            MaxZespol = 0;

            UsuniecieWynikow();

        }

        private void UsuniecieWynikow()
        {
            LabelRozmiar.Text = "0";
            LabelPktUUCP.Text = "0";

            LabelUwagi.Text = "Uwagi: Ten model nie jest skalibrowany dla projektów poniżej 2000 linii kodu. ";

            LabelWynikPrac.Text = "0";
            LabelWynikNLepPrac.Text = "0";
            LabelWynikNGorPrac.Text = "0";
            LabelWynikPrac.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikNLepPrac.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikNGorPrac.BackColor = System.Drawing.Color.FromName("Control");

            LabelWynikHarm.Text = "0";
            LabelWynikNLepHarm.Text = "0";
            LabelWynikNGorHarm.Text = "0";
            LabelWynikHarm.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikNLepHarm.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikNGorHarm.BackColor = System.Drawing.Color.FromName("Control");

            LabelWynikData.Text = "brak";
            LabelWynikNLepData.Text = "brak";
            LabelWynikNGorData.Text = "brak";
            LabelWynikData.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikNLepData.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikNGorData.BackColor = System.Drawing.Color.FromName("Control");

            LabelWynikKoszt.Text = "0";
            LabelWynikNLepKoszt.Text = "0";
            LabelWynikNGorKoszt.Text = "0";
            LabelWynikKoszt.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikNLepKoszt.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikNGorKoszt.BackColor = System.Drawing.Color.FromName("Control");

            LabelWynikWydaj.Text = "0";
            LabelWynikNLepWydaj.Text = "0";
            LabelWynikNGorWydaj.Text = "0";
            LabelWynikWydaj.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikNLepWydaj.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikNGorWydaj.BackColor = System.Drawing.Color.FromName("Control");

            LabelWynikSrZesp.Text = "0";
            LabelWynikNLepSrZesp.Text = "0";
            LabelWynikNGorSrZesp.Text = "0";
            LabelWynikSrZesp.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikNLepSrZesp.BackColor = System.Drawing.Color.FromName("Control");
            LabelWynikNGorSrZesp.BackColor = System.Drawing.Color.FromName("Control");
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

                    MaxPrac = TempMaxPrac;
                    MaxHarm = TempMaxHarm;
                    Deadline = TempDeadline;
                    MaxKoszt = TempMaxKoszt;
                    MaxZespol = TempMaxZespol;

                    Oszacowanie();
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
                    Oszacowanie();
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

            Oszacowanie();
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

                    //TODO Properties.Settings.Default.Save();
                    Oszacowanie();
                    MessageBox.Show("Wprowadzono nowe dane do tablicy przeliczeniowej punktów funkcyjnych na źródłowe linie kodu.", "Sukces");
                }
            }
        }


        /*****************************************************************************//**
        *  Raporty.
        ********************************************************************************/
        private void ButtonOpisProjektu_Click(object sender, EventArgs e)
        {
            const string NazwaPliku = "Raport_Opis_Projektu";

            // Utworzenie dokumentu przy pomocy MigraDoc
            var dokument = new Document();

            dokument.Info.Title = "Opis projektu";
            dokument.Info.Subject = "Raport zawierający opis projektu";
            dokument.Info.Author = Szacujacy;

            string raport = NazwaProjektu + " - opis projektu";


            // Zdefiniowanie stylu
            TrescRaportow.DefinicjaStylu(dokument);

            // Dodajemy stronę tytułową
            TrescRaportow.StronaTytulowa(dokument, raport);

            // Schemat treści
            TrescRaportow.DefinicjaZawartosci(dokument, raport);

            // Dodanie strony z opisem projektu
            TrescRaportow.StronaZOpisem(dokument);

            using (OknoPodgladRaportow OknoZalProj = new OknoPodgladRaportow(dokument, NazwaPliku))
            {
                DialogResult rezultat = OknoZalProj.ShowDialog();

                if (rezultat == DialogResult.OK)
                {
                    //TODO walidacja??
                }
            }
        }

        private void ButtonOszacowanie_Click(object sender, EventArgs e)
        {
            const string NazwaPliku = "Raport_Oszacowanie_Pracochlonnosci";

            // Utworzenie dokumentu przy pomocy MigraDoc
            var dokument = new Document();

            dokument.Info.Title = "Pełne oszacowanie pracochłonności projektu";
            dokument.Info.Subject = "Raport zawierający pełne oszacowanie pracochłonności projektu";
            dokument.Info.Author = Szacujacy;

            string raport = NazwaProjektu + " - oszacowanie pracochłonności";


            // Zdefiniowanie stylu
            TrescRaportow.DefinicjaStylu(dokument);

            // Dodajemy stronę tytułową
            TrescRaportow.StronaTytulowa(dokument, raport);

            // Schemat treści
            TrescRaportow.DefinicjaZawartosci(dokument, raport);

            // Dodanie strony z opisem projektu
            TrescRaportow.StronaZOpisem(dokument);

            // Dodanie tabeli
            TrescRaportow.WprowadzoneDane(dokument);

            // Dodanie wyników oszacowania
            TrescRaportow.Wyniki(dokument);

            using (OknoPodgladRaportow OknoZalProj = new OknoPodgladRaportow(dokument, NazwaPliku))
            {
                DialogResult rezultat = OknoZalProj.ShowDialog();

            }



        }

        private void ButtonPodsumowanieProjektu_Click(object sender, EventArgs e)
        {
            const string NazwaPliku = "Raport_Podsumowanie";

            // Utworzenie dokumentu przy pomocy MigraDoc
            var dokument = new Document();

            dokument.Info.Title = "Podsumowanie oszacowania pracochłonności projektu";
            dokument.Info.Subject = "Raport zawierający podsumowanie oszacowania pracochłonności projektu";
            dokument.Info.Author = Szacujacy;

            string raport = NazwaProjektu + " - podsumowanie oszacowania pracochłonności";


            // Zdefiniowanie stylu
            TrescRaportow.DefinicjaStylu(dokument);

            // Dodajemy stronę tytułową
            TrescRaportow.StronaTytulowa(dokument, raport);

            // Schemat treści
            TrescRaportow.DefinicjaZawartosci(dokument, raport);

            // Dodanie strony z opisem projektu
            TrescRaportow.StronaZOpisem(dokument);

            // Dodanie wyników oszacowania
            TrescRaportow.Wyniki(dokument);


            using (OknoPodgladRaportow OknoZalProj = new OknoPodgladRaportow(dokument, NazwaPliku))
            {
                DialogResult rezultat = OknoZalProj.ShowDialog();

            }
        }


    }
}
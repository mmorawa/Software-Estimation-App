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
            TextBoxNazwaProjektu.Text = "Projekt";
            DateTimePicker.Value = DateTime.Now;

        }

        /*****************************************************************************//**
        *  Properties.
        ********************************************************************************/

        //TODO encapsulate?? domyślnie zera?

        string SciezkaDoPliku;

        public static bool Ograniczenia = false;
        public static bool TempOgraniczenia = false;
        public static bool Domyslne = false;
        public static bool TempDomyslne = false;

        public static string[] TabDaneProjektu = new string[15];
        public static string[] TempTabDaneProjektu = new string[15];

        public static string KierownikProjektu;
        public static string TempKierownikProjektu;

        public static string Szacujacy;
        public static string TempSzacujacy;

        public static string NazwaFirmy;
        public static string TempNazwaFirmy;

        public static string Adres;
        public static string TempAdres;

        public static string Telefon;
        public static string TempTelefon;

        public static string Email;
        public static string TempEmail;

        public static string OpisProjektu;
        public static string TempOpisProjektu;

        int[] TabPktFunkSLOC = { 18, 54, 98, 14, 99, 53, 59, 55, 42, 18, 24, 65,
            191, 45, 35, 40, 49, 53, 53, 48, 30, 21, 34, 60, 40, 32, 15, 80, 35,
            28, 80, 66, 37, 60, 75, 21, 60, 44 };
        public static int[] TempTabPktFunkSLOC = new int[38];

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

        //współczynniki
        public static double TempUCPnaFP;
        public static double TempA;
        public static double TempB;
        public static double TempC;
        public static double TempD;

        //przeliczniki - tu domyślne
        public static int JezykProgramowania = Properties.Settings.Default.JezykProgramowania;
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
        double UUCW = 0;
        double UAW = 0;
        double UUCP = 0;
        double Rozmiar = 0;
        double RozmiarKSLOC = 0;
        double E = 1;
        double F = 0;
        double SumaSF = 0;
        double IloczynEM = 1;

        //wyniki końcowe
        
        double Pracochlonnosc = 0;
        double Harmonogram = 0;
        double Koszt = 0;

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

                DialogResult dr = ZapiszProjektDialog.ShowDialog();


                //zapisanie danych do pliku tekstowego
                if (dr == DialogResult.OK)
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
            using (OknoOProgramie OknoOProgramie = new OknoOProgramie())
            {
                DialogResult dr = OknoOProgramie.ShowDialog();
            }
        }


        //-----------------------------------------------------------------------------------------------


        private void ButtonCzSk_Click(object sender, EventArgs e)
        {
            using (OknoCzynnikiSkali OknoCzynS = new OknoCzynnikiSkali())
            {
                DialogResult dr = OknoCzynS.ShowDialog();


                if (dr == DialogResult.OK)
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
                DialogResult dr = OknoMnozP.ShowDialog();

                if (dr == DialogResult.OK)
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
        //TODO usuń TabDaneProjektu
        private void TextBoxNazwaProjektu_TextChanged(object sender, EventArgs e)
        {
            TabDaneProjektu[0] = TextBoxNazwaProjektu.Text;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            TabDaneProjektu[1] = DateTimePicker.Text;
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

            Rozmiar = (UUCP * Properties.Settings.Default.UCPnaFP * TabPktFunkSLOC[JezykProgramowania]);

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

            F = Properties.Settings.Default.D + 0.2 * (E - Properties.Settings.Default.B);

            Harmonogram = Properties.Settings.Default.C * Math.Pow(Pracochlonnosc, F);

            Koszt = Pracochlonnosc * OsoboMGodz * StawkaGodz;

            //Wyświetlenie wyników
            LabelPktUUCP.Text = string.Format("{0:N0}", UUCP);
            LabelRozmiar.Text = string.Format("{0:N0}", Rozmiar);
            LabelWynikPrac.Text = string.Format("{0:N1}", Pracochlonnosc);
            LabelWynikHarm.Text = string.Format("{0:N1}", Harmonogram);
            LabelWynikKoszt.Text = string.Format("{0:N}", Koszt);


            //Ograniczenia projektu
            //TODO pod koniec zbiorczy komunikat
            if (Ograniczenia == true)
            {

                if (MaxPrac != 0 && MaxPrac < Pracochlonnosc)
                {
                    LabelWynikPrac.BackColor = Color.FromName("red");

                    MessageBox.Show("Przekroczono założoną pracochłonność projektu.");
                }
                else
                {
                    LabelWynikPrac.BackColor = Color.FromName("GreenYellow");
                }

                if (MaxHarm != 0 && MaxHarm < Harmonogram)
                {
                    LabelWynikHarm.BackColor = Color.FromName("red");
                    MessageBox.Show("Przekroczono założony harmonogram projektu");
                }
                else
                {
                    LabelWynikHarm.BackColor = Color.FromName("GreenYellow");
                }

                if (MaxKoszt != 0 && MaxKoszt < Koszt)
                {
                    LabelWynikKoszt.BackColor = Color.FromName("red");
                    MessageBox.Show("Przekroczono założony koszt projektu");
                }
                else
                {
                    LabelWynikKoszt.BackColor = Color.FromName("GreenYellow");
                }
            }
            else
            {
                LabelWynikPrac.BackColor = Color.FromName("GreenYellow");
                LabelWynikHarm.BackColor = Color.FromName("GreenYellow");
                LabelWynikKoszt.BackColor = Color.FromName("GreenYellow");
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

            //Wyzerowanie
            SciezkaDoPliku = "";
            TextBoxNazwaProjektu.Text = "Projekt";
            DateTimePicker.Value = DateTime.Now;

            TabDaneProjektu = new string[15];

            NumUUCWProsty.Value = 0;
            NumUUCWSredni.Value = 0;
            NumUUCWZlozony.Value = 0;

            NumUAWProsty.Value = 0;
            NumUAWSredni.Value = 0;
            NumUAWZlozony.Value = 0;


            TabIndSF = new int[] { 2, 2, 2, 2, 2 };
            TabIndEM = new int[] { 2, 1, 2, 1, 2, 2, 2, 2, 2, 2, 2, 0, 0, 1, 2, 2, 2 };



            LabelPktUUCP.Text = "0";
            LabelWynikPrac.Text = "0";
            LabelWynikHarm.Text = "0";

            MessageBox.Show("Rozpoczęto nowy projekt.");
        }


        private void ButtonWiecejSzczeg_Click(object sender, EventArgs e)
        {
            using (OknoDaneProjektu OknoDaneProjektu = new OknoDaneProjektu())
            {
                DialogResult dr = OknoDaneProjektu.ShowDialog();

                if (dr == DialogResult.OK)
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
            //TODO wydzielić do osobnej funkcji??
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

            using (OpenFileDialog OtworzProjektDialog = new OpenFileDialog())
            {
                //TODO try 
                DialogResult dr = OtworzProjektDialog.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    SciezkaDoPliku = OtworzProjektDialog.FileName;

                    using (StreamReader sr = new StreamReader(SciezkaDoPliku))
                    {
                        //int LiczbaLinii = File.ReadLines(SciezkaDoPliku).Count();

                        TextBoxNazwaProjektu.Text = sr.ReadLine();
                        DateTimePicker.Text = sr.ReadLine();

                        for (int i = 2; i < 15; i++)
                        {
                            TabDaneProjektu[i] = sr.ReadLine();
                        }

                        NumUUCWProsty.Value = int.Parse(sr.ReadLine());
                        NumUUCWSredni.Value = int.Parse(sr.ReadLine());
                        NumUUCWZlozony.Value = int.Parse(sr.ReadLine());
                        NumUAWProsty.Value = int.Parse(sr.ReadLine());
                        NumUAWSredni.Value = int.Parse(sr.ReadLine());
                        NumUAWZlozony.Value = int.Parse(sr.ReadLine());


                    }

                }
            }
        }


        //TODO zmiana dr na coś fajniejszego :)
        private void ButtonUstawienia_Click(object sender, EventArgs e)
        {
            using (OknoUstawienia OknoUstawDomyslne = new OknoUstawienia())
            {
                DialogResult dr = OknoUstawDomyslne.ShowDialog();

                if (dr == DialogResult.OK)
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


            //MessageBox.Show(Properties.Settings.Default.GodzinyUCP.ToString());

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
                //na wypadek gdyby użytkownik nie zmienił domyślnej daty
                TabDaneProjektu[1] = DateTimePicker.Text;

                foreach (var item in TabDaneProjektu)
                {
                    sw.WriteLine(item);
                }

                foreach (var item in TabUUCW)
                {
                    sw.WriteLine(item);
                }

                foreach (var item in TabUAW)
                {
                    sw.WriteLine(item);
                }

                sw.Dispose();
                MessageBox.Show("Plik zapisano.");
            }

            //sw.WriteLine(string.Format("byte Program_{0}", Form2.Nazwa_Programu) + "_MODUL[]={" + string.Format("{0},{1},{2},{3}", numery[0], numery[1], numery[2], numery[3]) + "};");

            //sw.Write(string.Format("unsigned int* Program_{0}", Form2.Nazwa_Programu) + "[] = {");

            /*
            for (int i = 0; i < Programy.Length - 2; i++)
            {
                sw.Write(Programy[i] + ", ");
            }*/

            //sw.Write(Programy[Programy.Length - 2] + "};");

        }


        private void ButtonZalozenia_Click(object sender, EventArgs e)
        {
            using (OknoZalozeniaProjektu OknoZalProj = new OknoZalozeniaProjektu())
            {
                DialogResult dr = OknoZalProj.ShowDialog();


                if (dr == DialogResult.OK)
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
                DialogResult dr = OknoKalib.ShowDialog();

                if (dr == DialogResult.OK)
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
            //MessageBox.Show(Rozmiar.ToString());
            MessageBox.Show(Properties.Settings.Default.TabPrzeliczeniowa[0].ToString());
            MessageBox.Show(Properties.Settings.Default.TabPrzeliczeniowa[37].ToString());

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
                DialogResult dr = OknoSLOC_FP.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    for (int i = 0; i < 38; i++)
                    {
                        Properties.Settings.Default.TabPrzeliczeniowa[i] = TempTabPktFunkSLOC[i];
                    }

                    //Properties.Settings.Default.UCPnaFP = TempUCPnaFP;

                    //Properties.Settings.Default.Save();
                    MessageBox.Show("Wprowadzono nowe dane do tablicy przeliczeniowej punktów funkcyjnych na źródłowe linie kodu.", "Sukces");
                }
            }
        }
    }
}

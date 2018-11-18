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

        string SciezkaDoPliku = "";
        public static bool Ograniczenia = false;
        public static bool TempOgraniczenia = false;

        public static string[] TabDaneProjektu = new string[15];
        public static string[] TempTabDaneProjektu = new string[15];

        public static int[] TabUAW = new int[3];
        double[] wagiAktorow = { 1, 2, 3 };
        public static int[] TabUUCW = new int[3];
        double[] wagiUC = { 5, 10, 15 };

        public static int[] TabIndTCF = new int[13];
        public static int[] TempTabIndTCF = new int[13];

        public static int[] TabIndEF = new int[8];
        public static int[] TempTabIndEF = new int[8];

        double[] wagiTCF = { 2, 1, 1, 1, 1, 0.5, 0.5, 2, 1, 1, 1, 1, 1 };
        double iloczynWagTCF = 0;

        double[] wagiEF = { 1.5, -1, 0.5, 0.5, 1, 1, -1, 2 };
        double iloczynWagEF = 0;

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
        double EFc1 = 1.4;
        double EFc2 = -0.03;
        double TCFc1 = 0.6;
        double TCFc2 = 0.01;
        double A = 2.94;
        double B = 0.91;

        //przeliczniki
        public static double UCPgodziny = 25;
        public static double UCPlinieKodu = 60;
        public static double StawkaGodz = 0;
        public static int OsoboMGodz = 152;
        public static int DzRobGodz = 8;
        public static double MaxKoszt = 0;
        public static int MaxPrac = 0;
        public static int MaxHarm = 0;

        //wartości tymczasowe
        public static double TempUCPgodziny;
        public static double TempUCPlinieKodu;
        public static double TempStawkaGodz;
        public static int TempOsoboMGodz;
        public static int TempDzRobGodz;
        public static double TempMaxKoszt;
        public static int TempMaxPrac;
        public static int TempMaxHarm;

        //wyniki pośrednie
        double TCF = 0;
        double EF = 0;
        double UUCW = 0;
        double UAW = 0;
        double UCP = 0;
        double Rozmiar = 0;
        double E = 1;
        double SumaSF = 0;
        double IloczynEM = 1;

        //wyniki końcowe
        double PracUCP = 0;
        double PracCOCOMOII = 0;

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

        }

        //! Metoda wywoływana po naciśnięciu przycisku Exit na pasku Menu.
        /*! Metoda ExitToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Exit na pasku Menu.
         * Skutkuje ona zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjściem z programu.
         */
        private void ToolStripMenuUstawienia_Click(object sender, EventArgs e)
        {

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

        private void ButtonCZT_Click(object sender, EventArgs e)
        {
            using (OknoCzynnZlozTechn OknoCzynZT = new OknoCzynnZlozTechn())
            {
                DialogResult dr = OknoCzynZT.ShowDialog();


                if (dr == DialogResult.OK)
                {
                    for (int i = 0; i < 13; i++)
                    {
                        TabIndTCF[i] = TempTabIndTCF[i];
                    }

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
                    for (int i = 0; i < 8; i++)
                    {
                        TabIndEF[i] = TempTabIndEF[i];
                    }

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
                    for (int i = 0; i < 5; i++)
                    {
                        TabIndSF[i] = TempTabIndSF[i];
                    }

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
                    for (int i = 0; i < 17; i++)
                    {
                        TabIndEM[i] = TempTabIndEM[i];
                    }

                    MessageBox.Show("Mnożniki pracochłonności wprowadzone.", "Sukces");
                }
            }
        }

        //-----------------------------------------------------------------------------------------------

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

        //-----------------------------------------------------------------------------------------------


        private void ButtonOszacuj_Click(object sender, EventArgs e)
        {
            //TODO walidacja danych wejściowych, zaokrąglanie

            //Obliczenia UCP
            for (int i = 0; i <= 12; i++)
            {
                iloczynWagTCF = TabIndTCF[i] * wagiTCF[i];
            }

            TCF = TCFc1 + iloczynWagTCF * TCFc2;

            for (int i = 0; i <= 7; i++)
            {
                iloczynWagEF = TabIndEF[i] * wagiEF[i];
            }

            EF = EFc1 + (EFc2 * iloczynWagEF);

            UUCW = 0;
            for (int i = 0; i < 3; i++)
            {
                UUCW += TabUUCW[i] * wagiUC[i];
            }

            UAW = 0;
            for (int i = 0; i < 3; i++)
            {
                UAW = TabUAW[i] * wagiAktorow[i];
            }

            UCP = TCF * EF * (UAW + UUCW);
            PracUCP = Math.Round(UCP * UCPgodziny, 2);

            //Obliczenia COCOMOII
            Rozmiar = UCP * UCPlinieKodu;

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

            E = B + 0.01 * SumaSF;
            PracCOCOMOII = Math.Round(A * Math.Pow(Rozmiar, E) * IloczynEM, 2);

            //Wyświetlenie wyników
            LabelPktUCP.Text = UCP.ToString();
            LabelWynikPracUCP.Text = PracUCP.ToString();
            LabelWynikPracCOCOMOII.Text = (PracCOCOMOII * 152).ToString();


            //MessageBox.Show(IloczynEM.ToString());
        }


        //--------------------------------Do zrobienia---------------------------------------------------------

        private void ButtonNowyProjekt_Click(object sender, EventArgs e)
        {
            //TODO: czy chcesz rozpocząć nowy projekt bez zapisania starego?

            //Wyzerowanie
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
            TabIndTCF = new int[13];
            TabIndEF = new int[8];

            TCF = 0;
            EF = 0;
            UUCW = 0;
            UAW = 0;
            UCP = 0;
            Rozmiar = 0;
            E = 1;
            SumaSF = 0;
            IloczynEM = 1;
            iloczynWagEF = 0;
            iloczynWagTCF = 0;

            PracUCP = 0;
            PracCOCOMOII = 0;

            LabelPktUCP.Text = "0";
            LabelWynikPracUCP.Text = "0";
            LabelWynikPracCOCOMOII.Text = "0";

            MessageBox.Show("Rozpoczęto nowy projekt.");
        }

        private void ButtonWiecejSzczeg_Click(object sender, EventArgs e)
        {
            using (OknoDaneProjektu OknoDaneProjektu = new OknoDaneProjektu())
            {
                DialogResult dr = OknoDaneProjektu.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        TabDaneProjektu[i] = TempTabDaneProjektu[i];
                    }

                    MessageBox.Show("Szczegółowe dane projektu zostały wprowadzone.", "Sukces");
                }
            }
        }

        private void ButtonOtworzProjekt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OtworzProjektDialog = new OpenFileDialog())
            {
                //TODO try 
                DialogResult dr = OtworzProjektDialog.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    SciezkaDoPliku = OtworzProjektDialog.FileName;

                    using (StreamReader sr = new StreamReader(SciezkaDoPliku))
                    {
                        int LiczbaLinii = File.ReadLines(SciezkaDoPliku).Count();

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

        private void ButtonUstawienia_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Założenia projektu zostały wprowadzone.", "Sukces");

                    Ograniczenia = TempOgraniczenia;


                    UCPgodziny = TempUCPgodziny;
                    UCPlinieKodu = TempUCPlinieKodu;
                    StawkaGodz = TempStawkaGodz;
                    OsoboMGodz = TempOsoboMGodz;
                    DzRobGodz = TempDzRobGodz;
                    MaxKoszt = TempMaxKoszt;
                    MaxPrac = TempMaxPrac;
                    MaxHarm = TempMaxHarm;

                }
            }
        }
    }
}

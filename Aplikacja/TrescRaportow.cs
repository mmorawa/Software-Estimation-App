﻿using System;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using TabAlignment = MigraDoc.DocumentObjectModel.TabAlignment;
using MigraDoc.DocumentObjectModel.Fields;


namespace Aplikacja
{
    //BUG partial zamiast dziedziczenia
    class TrescRaportow : OknoGlowne
    {

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

            styl.ParagraphFormat.PageBreakBefore = true;
            styl.ParagraphFormat.SpaceBefore = "1cm";
            styl.ParagraphFormat.SpaceAfter = 6;

            styl = dokument.Styles["Heading3"];
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
        public static void DefinicjaZawartosci(Document dokument, string nazwaRaportu)
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

            
            var paragraf = sekcja.AddParagraph("Podstawowe informacje", "Heading1");

            paragraf = sekcja.AddParagraph("Dane projektu", "Heading3");

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

            paragraf = sekcja.AddParagraph("Dane firmy", "Heading3");

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

            paragraf = sekcja.AddParagraph("Opis projektu", "Heading3");
            paragraf = sekcja.AddParagraph(OpisProjektu);

            paragraf = sekcja.AddParagraph("Założenia projektu", "Heading3");
            paragraf = sekcja.AddParagraph("Główny język programowania użyty w projekcie: ");
            paragraf.Format.Font.Bold = true;
            paragraf.AddFormattedText(JezykProg[JezykProgramowania], TextFormat.NotBold);

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
                paragraf = sekcja.AddParagraph("Ograniczenia nałożone na oszacowanie", "Heading3");

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

        //Dane wprowadzone przez użytkownika w celu dokonania oszacowania
        public static void WprowadzoneDane(Document dokument)
        {
            //var sekcja = dokument.LastSection;
            var sekcja = dokument.LastSection;

            var paragraf = sekcja.AddParagraph("Dane wykorzystane do oszacowania pracochłonności", "Heading1");

            paragraf = sekcja.AddParagraph("Metoda Use Case Points", "Heading3");

            //nagłówek tabelii
            paragraf = sekcja.AddParagraph("Tabela 1 - przypadki użycia");
            paragraf.Format.SpaceAfter = "0.2cm";

            var TabelaUUCW = new Table();

            //granice tabelii
            //TabelaUUCW.Borders.Width = 0.5;

            //dodajemy kolumny
            var column = TabelaUUCW.AddColumn(Unit.FromCentimeter(2.5));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaUUCW.AddColumn(Unit.FromCentimeter(2));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaUUCW.AddColumn(Unit.FromCentimeter(4));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaUUCW.AddColumn(Unit.FromCentimeter(7.6));
            column.Format.Alignment = ParagraphAlignment.Center;

            //lub row.Height = Unit.FromCentimeter(1);
            TabelaUUCW.Rows.Height = Unit.FromCentimeter(1);

            var row = TabelaUUCW.AddRow();
            row.Shading.Color = Colors.LightSalmon;
            row.VerticalAlignment = VerticalAlignment.Center;

            //dodajemy tekst do nagłówków kolumn
            var cell = row.Cells[0];
            cell.AddParagraph("");
            cell = row.Cells[1];
            cell.AddParagraph("Waga");
            cell = row.Cells[2];
            cell.AddParagraph("Liczba \nprzypadków użycia");
            cell = row.Cells[3];
            cell.AddParagraph("Liczba transakcji");


            //tylko dodaje do pierwszego kolor
            row = TabelaUUCW.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Prosty");
            cell = row.Cells[1];
            cell.AddParagraph("5");
            cell = row.Cells[2];
            cell.AddParagraph(TabUUCW[0].ToString());
            cell = row.Cells[3];
            cell.AddParagraph("od 1 do 3");

            row = TabelaUUCW.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Średni");
            cell = row.Cells[1];
            cell.AddParagraph("10");
            cell = row.Cells[2];
            cell.AddParagraph(TabUUCW[1].ToString());
            cell = row.Cells[3];
            cell.AddParagraph("od 4 do 7");

            row = TabelaUUCW.AddRow();
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
            //TabelaUUCW.SetEdge(0, 0, 2, 1, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.Black);
            TabelaUUCW.SetEdge(0, 0, 4, 4, Edge.Bottom, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.LightSalmon);

            dokument.LastSection.Add(TabelaUUCW);

            //--------------------------------------------------------------------------


            //nagłówek tabelii
            paragraf = sekcja.AddParagraph("Tabela 2 - aktorzy");
            paragraf.Format.SpaceAfter = "0.2cm";
            paragraf.Format.SpaceBefore = "1cm";

            var TabelaUAW = new Table();

            //dodajemy kolumny
            column = TabelaUAW.AddColumn(Unit.FromCentimeter(2.5));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaUAW.AddColumn(Unit.FromCentimeter(2));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaUAW.AddColumn(Unit.FromCentimeter(4));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaUAW.AddColumn(Unit.FromCentimeter(7.6));
            column.Format.Alignment = ParagraphAlignment.Center;

            TabelaUAW.Rows.Height = Unit.FromCentimeter(1);

            row = TabelaUAW.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            row.Shading.Color = Colors.LightSalmon;

            //dodajemy tekst do nagłówków kolumn
            cell = row.Cells[0];
            cell.AddParagraph("");
            cell = row.Cells[1];
            cell.AddParagraph("Waga");
            cell = row.Cells[2];
            cell.AddParagraph("Liczba aktorów");
            cell = row.Cells[3];
            cell.AddParagraph("Sposób komunikacji z systemem");


            //tylko dodaje do pierwszego kolor
            row = TabelaUAW.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Prosty");
            cell = row.Cells[1];
            cell.AddParagraph("5");
            cell = row.Cells[2];
            cell.AddParagraph(TabUAW[0].ToString());
            cell = row.Cells[3];
            cell.AddParagraph("aktor systemowy poprzez API");

            row = TabelaUAW.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Średni");
            cell = row.Cells[1];
            cell.AddParagraph("10");
            cell = row.Cells[2];
            cell.AddParagraph(TabUAW[1].ToString());
            cell = row.Cells[3];
            cell.AddParagraph("aktor systemowy poprzez protokół / człowiek poprzez wiersz poleceń");

            row = TabelaUAW.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Złożony");
            cell = row.Cells[1];
            cell.AddParagraph("15");
            cell = row.Cells[2];
            cell.AddParagraph(TabUAW[2].ToString());
            cell = row.Cells[3];
            cell.AddParagraph("człowiek poprzez GUI");


            //ramka od 0,0 do 2 kolumny, 3 rzędy
            //TabelaUUCW.SetEdge(0, 0, 2, 1, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.Black);
            TabelaUAW.SetEdge(0, 0, 4, 4, Edge.Bottom, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.LightSalmon);

            dokument.LastSection.Add(TabelaUAW);

            //--------------------------------------------------------------------------------------------------------------------

            paragraf = sekcja.AddParagraph("Metoda COCOMO II - Czynniki skali", "Heading2");
            
            //nagłówek tabelii
            paragraf = sekcja.AddParagraph("Tabela 3 - Czynniki skali");
            paragraf.Format.SpaceAfter = "0.2cm";
            paragraf.Format.SpaceBefore = "1cm";

            var TabelaCzynnSkali = new Table();

            //dodajemy kolumny
            column = TabelaCzynnSkali.AddColumn(Unit.FromCentimeter(3.9));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaCzynnSkali.AddColumn(Unit.FromCentimeter(2.4));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaCzynnSkali.AddColumn(Unit.FromCentimeter(9.8));
            column.Format.Alignment = ParagraphAlignment.Justify;

            TabelaCzynnSkali.Rows.Height = Unit.FromCentimeter(3);

            row = TabelaCzynnSkali.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            row.Shading.Color = Colors.LightSalmon;
            row.Height = Unit.FromCentimeter(2);

            //dodajemy tekst do nagłówków kolumn
            cell = row.Cells[0];
            cell.AddParagraph("Nazwa \nczynnika skali");
            cell = row.Cells[1];
            cell.AddParagraph("Poziom oceny");
            cell = row.Cells[2];
            cell.AddParagraph("Krótki opis");
            //przywracay wycentrowany nagłówek
            cell.Format.Alignment = ParagraphAlignment.Center;


            //tylko dodaje do pierwszego kolor
            row = TabelaCzynnSkali.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Typowość projektu");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringCzynnSkali[TabIndCzynnSkali[0]]);
            cell = row.Cells[2];
            cell.AddParagraph("Czynnik ten bierze pod uwagę stopień podobieństwa obecnego projektu, do tych które były wcześniej zrealizowane przez dany zespół programistyczny.");


            row = TabelaCzynnSkali.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Elastyczność wytwarzania oprogramowania");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringCzynnSkali[TabIndCzynnSkali[1]]);
            cell = row.Cells[2];
            cell.AddParagraph("Poziom oceny tego czynnika zależy głównie od tego, czy istnieje potrzeba zgodności tworzonego oprogramowania z ustalonymi wcześniej wymaganiami lub specyfikacjami zewnętrznych interfejsów.");


            row = TabelaCzynnSkali.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Ustalenie architektury \ni ryzyka");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringCzynnSkali[TabIndCzynnSkali[2]]);
            cell = row.Cells[2];
            cell.AddParagraph("W tym przypadku ocenie podlegają kwestie dotyczące wyboru architektury oraz związanego z tym ryzyka, a więc m.in. ustalanie liczby krytycznych elementów i opracowanie Planu Zarządzania Ryzykiem, który pozwoli się z nimi uporać.");

            row = TabelaCzynnSkali.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Spójność zespołu");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringCzynnSkali[TabIndCzynnSkali[3]]);
            cell = row.Cells[2];
            cell.AddParagraph("Uwzględnia wpływ jaki na wielkość pracochłonności mogą wywrzeć problemy z brakiem kooperacji pomiędzy interesariuszami czyli klientami, programistami, testerami i innymi osobami związanymi z projektem.");

            row = TabelaCzynnSkali.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Dojrzałość procesu");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringCzynnSkali[TabIndCzynnSkali[4]]);
            cell = row.Cells[2];
            cell.AddParagraph("Procedura ustalania dojrzałości procesu opiera się na modelu CMM (Capability Maturity Model). Może ona przybrać formę zorganizowanego badania albo sprawdzenia procentowej zgodności z modelem CMM każdego z kluczowych obszarów procesu wytwarzania oprogramowania.");


            TabelaCzynnSkali.SetEdge(0, 0, 3, 6, Edge.Bottom, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.LightSalmon);

            dokument.LastSection.Add(TabelaCzynnSkali);

            //--------------------------------------------------------------------------------------------------------------------

            paragraf = sekcja.AddParagraph("Metoda COCOMO II - Mnożniki pracochłonności dot. produktu", "Heading2");


            //nagłówek tabelii
            paragraf = sekcja.AddParagraph("Tabela 4 - Mnożniki pracochłonności dot. produktu");
            paragraf.Format.SpaceAfter = "0.2cm";
            paragraf.Format.SpaceBefore = "1cm";

            var TabelaMnPracProd = new Table();

            //dodajemy kolumny
            column = TabelaMnPracProd.AddColumn(Unit.FromCentimeter(3.9));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaMnPracProd.AddColumn(Unit.FromCentimeter(2.4));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaMnPracProd.AddColumn(Unit.FromCentimeter(9.8));
            column.Format.Alignment = ParagraphAlignment.Justify;

            TabelaMnPracProd.Rows.Height = Unit.FromCentimeter(3);

            row = TabelaMnPracProd.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            row.Shading.Color = Colors.LightSalmon;
            row.Height = Unit.FromCentimeter(2);

            //dodajemy tekst do nagłówków kolumn
            cell = row.Cells[0];
            cell.AddParagraph("Nazwa mnożnika pracochłonności");
            cell = row.Cells[1];
            cell.AddParagraph("Poziom oceny");
            cell = row.Cells[2];
            cell.AddParagraph("Krótki opis");
            //przywracay wycentrowany nagłówek
            cell.Format.Alignment = ParagraphAlignment.Center;


            //tylko dodaje do pierwszego kolor
            row = TabelaMnPracProd.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Wymagana niezawodność oprogramownia");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[0]]);
            cell = row.Cells[2];
            cell.AddParagraph("Określa stopień zdolności oprogramowania do spełniania swoich funkcji w wyznaczonym przedziale czasu użytkowania. Im bardziej negatywne są konsekwencje awarii, tym wyższa jest wymagana niezawodność.");


            row = TabelaMnPracProd.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Wielkość bazy danych");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[1]]);
            cell = row.Cells[2];
            cell.AddParagraph("Odzwierciedla wpływ dużych wymagań odnośnie danych testowych na wytwarzanie oprogramowania. Ocena jest zależna od stosunku liczby bajtów testowej bazy danych do rozmiaru aplikacji liczonego w liniach kodu (D/P).");


            row = TabelaMnPracProd.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Złożoność produktu");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[2]]);
            cell = row.Cells[2];
            cell.AddParagraph("Ocena złożoności produktu obejmuje pięć głównych obszarów: operacje kontrolne, operacje obliczeniowe, operacje zależne od sprzętu, operacje zarządzania danymi oraz operacje zarządzania interfejsem użytkownika.");

            row = TabelaMnPracProd.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Możliwość ponownego wykorzystania");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[3]]);
            cell = row.Cells[2];
            cell.AddParagraph("Ten mnożnik odpowiada za uwzględnienie dodatkowego nakładu pracy, który wiąże się z tworzeniem komponentów aplikacji w sposób pozwalający na ich ponowne użycie w przyszłości. Im bardziej abstrakcyjny i ogólny musi być dany komponent tym większa będzie pracochłonność jego wytworzenia.");

            row = TabelaMnPracProd.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Dokumentacja odpowiada wymaganiom cyklu życia");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[4]]);
            cell = row.Cells[2];
            cell.AddParagraph("Odpowiedni zakres dokumentacji ustalany jest w oparciu o wymagania cyklu życia projektu.");


            TabelaMnPracProd.SetEdge(0, 0, 3, 6, Edge.Bottom, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.LightSalmon);

            dokument.LastSection.Add(TabelaMnPracProd);

            //--------------------------------------------------------------------------------

            paragraf = sekcja.AddParagraph("Metoda COCOMO II - Mnożniki pracochłonności dot. personelu", "Heading2");


            //nagłówek tabelii
            paragraf = sekcja.AddParagraph("Tabela 5 - Mnożniki pracochłonności dot. personelu");
            paragraf.Format.SpaceAfter = "0.2cm";
            paragraf.Format.SpaceBefore = "1cm";

            var TabelaMnPracPersonel = new Table();

            //dodajemy kolumny
            column = TabelaMnPracPersonel.AddColumn(Unit.FromCentimeter(3.9));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaMnPracPersonel.AddColumn(Unit.FromCentimeter(2.4));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaMnPracPersonel.AddColumn(Unit.FromCentimeter(9.8));
            column.Format.Alignment = ParagraphAlignment.Justify;

            TabelaMnPracPersonel.Rows.Height = Unit.FromCentimeter(3);

            row = TabelaMnPracPersonel.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            row.Shading.Color = Colors.LightSalmon;
            row.Height = Unit.FromCentimeter(2);

            //dodajemy tekst do nagłówków kolumn
            cell = row.Cells[0];
            cell.AddParagraph("Nazwa mnożnika pracochłonności");
            cell = row.Cells[1];
            cell.AddParagraph("Poziom oceny");
            cell = row.Cells[2];
            cell.AddParagraph("Krótki opis");
            //przywracay wycentrowany nagłówek
            cell.Format.Alignment = ParagraphAlignment.Center;


            //tylko dodaje do pierwszego kolor
            row = TabelaMnPracPersonel.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Umiejętności analityków biznesowych");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[5]]);
            cell = row.Cells[2];
            cell.AddParagraph("Analitycy biznesowi opracowują wymagania, które musi spełniać projektowane oprogramowanie w celu uzyskania przez organizację określonych korzyści biznesowych. Ocena umiejętności analityków powinna obejmować ich zdolność analizy i projektowania, dokładność, efektywność oraz komunikatywność.");


            row = TabelaMnPracPersonel.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Umiejętności programistów");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[6]]);
            cell = row.Cells[2];
            cell.AddParagraph("Główne czynniki jakie należy wziąć pod uwagę oceniając umiejętności programistów stanowią: ich efektywność, dokładność, komunikatywność oraz kooperatywność. Natomiast doświadczenie jest uwzględnione przez inne mnożniki.");


            row = TabelaMnPracPersonel.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Ciągłość zespołu");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[7]]);
            cell = row.Cells[2];
            cell.AddParagraph("Poziom oceny tego mnożnika zależy od tego jak wielka jest rotacja pracowników zatrudnionych przy projekcie w skali jednego roku.");

            row = TabelaMnPracPersonel.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Doświadczenie \nw tworzeniu aplikacji");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[8]]);
            cell = row.Cells[2];
            cell.AddParagraph("W celu prawidłowego ustalenia oceny tego mnożnika należy ustalić wielkość doświadczenia w tworzeniu aplikacji zespołu programistycznego, który pracuje nad danym projektem.");

            row = TabelaMnPracPersonel.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Doświadczenie \nw korzystaniu z platformy");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[9]]);
            cell = row.Cells[2];
            cell.AddParagraph("W przypadku tego mnożnika konieczne jest określenie wielkości doświadczenia zespołu projektowego związanego z wykorzystaniem określonej platformy czyli połączenia sprzętu komputerowego i oprogramowania, na którym działał będzie tworzony produkt.");

            row = TabelaMnPracPersonel.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Doświadczenie \nw stosowaniu języka i narzędzi");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[10]]);
            cell = row.Cells[2];
            cell.AddParagraph("Ten mnożnik odzwierciedla wielkość doświadczenia programistów w pracy z zastosowaniem języka programowania i narzędzi, które wykorzystane będą w tworzonym projekcie.");


            TabelaMnPracPersonel.SetEdge(0, 0, 3, 7, Edge.Bottom, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.LightSalmon);

            dokument.LastSection.Add(TabelaMnPracPersonel);

            //--------------------------------------------------------------------------

            paragraf = sekcja.AddParagraph("Metoda COCOMO II - Mnożniki pracochłonności dot. platformy", "Heading2");


            //nagłówek tabelii
            paragraf = sekcja.AddParagraph("Tabela 6 - Mnożniki pracochłonności dot. platformy");
            paragraf.Format.SpaceAfter = "0.2cm";
            paragraf.Format.SpaceBefore = "1cm";

            var TabelaMnPracPlatforma = new Table();

            //dodajemy kolumny
            column = TabelaMnPracPlatforma.AddColumn(Unit.FromCentimeter(3.9));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaMnPracPlatforma.AddColumn(Unit.FromCentimeter(2.4));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaMnPracPlatforma.AddColumn(Unit.FromCentimeter(9.8));
            column.Format.Alignment = ParagraphAlignment.Justify;

            TabelaMnPracPlatforma.Rows.Height = Unit.FromCentimeter(3.1);

            row = TabelaMnPracPlatforma.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            row.Shading.Color = Colors.LightSalmon;
            row.Height = Unit.FromCentimeter(2);

            //dodajemy tekst do nagłówków kolumn
            cell = row.Cells[0];
            cell.AddParagraph("Nazwa mnożnika pracochłonności");
            cell = row.Cells[1];
            cell.AddParagraph("Poziom oceny");
            cell = row.Cells[2];
            cell.AddParagraph("Krótki opis");
            //przywracay wycentrowany nagłówek
            cell.Format.Alignment = ParagraphAlignment.Center;


            //tylko dodaje do pierwszego kolor
            row = TabelaMnPracPlatforma.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Ograniczenia czasu wykonania");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[11]]);
            cell = row.Cells[2];
            cell.AddParagraph("Poziom oceny tego mnożnika zależy od narzuconego na projektowany system ograniczenia czasu wykonania. Jest ono wyrażone w postaci procentowej wielkości dostępnego czasu wykonania, która zostanie zużyta przez tworzony system.");


            row = TabelaMnPracPlatforma.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Ograniczenia pamięciowe");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[12]]);
            cell = row.Cells[2];
            cell.AddParagraph("W tym przypadku ocenie podlega stopień nałożonego na projektowany system ograniczenia pamięciowego określonego w postaci procentowej wielkości dostępnej pamięci, która zostanie zajęta przez tworzony system.");


            row = TabelaMnPracPlatforma.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Zmienność platformy");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[13]]);
            cell = row.Cells[2];
            cell.AddParagraph("Ten mnożnik bierze pod uwagę, jak bardzo podlega zmianom platforma, na której działał będzie tworzony system. W ramach oceny należy uwzględnić zarówno zmiany zachodzące w sprzęcie komputerowym, jak i w oprogramowaniu platformy.");


            TabelaMnPracPlatforma.SetEdge(0, 0, 3, 4, Edge.Bottom, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.LightSalmon);

            dokument.LastSection.Add(TabelaMnPracPlatforma);


            //----------------------------------------------------------------------------------

            paragraf = sekcja.AddParagraph("Metoda COCOMO II - Mnożniki pracochłonności dot. projektu", "Heading2");


            //nagłówek tabelii
            paragraf = sekcja.AddParagraph("Tabela 7 - Mnożniki pracochłonności dot. projektu");
            paragraf.Format.SpaceAfter = "0.2cm";
            paragraf.Format.SpaceBefore = "1cm";

            var TabelaMnPracProjekt = new Table();

            //dodajemy kolumny
            column = TabelaMnPracProjekt.AddColumn(Unit.FromCentimeter(3.9));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaMnPracProjekt.AddColumn(Unit.FromCentimeter(2.4));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaMnPracProjekt.AddColumn(Unit.FromCentimeter(9.8));
            column.Format.Alignment = ParagraphAlignment.Justify;

            TabelaMnPracProjekt.Rows.Height = Unit.FromCentimeter(3.1);

            row = TabelaMnPracProjekt.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            row.Shading.Color = Colors.LightSalmon;
            row.Height = Unit.FromCentimeter(2);

            //dodajemy tekst do nagłówków kolumn
            cell = row.Cells[0];
            cell.AddParagraph("Nazwa mnożnika pracochłonności");
            cell = row.Cells[1];
            cell.AddParagraph("Poziom oceny");
            cell = row.Cells[2];
            cell.AddParagraph("Krótki opis");
            //przywracay wycentrowany nagłówek
            cell.Format.Alignment = ParagraphAlignment.Center;


            //tylko dodaje do pierwszego kolor
            row = TabelaMnPracProjekt.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Wykorzystanie narzędzi programistycznych");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[14]]);
            cell = row.Cells[2];
            cell.AddParagraph("Użycie nowoczesnych narzędzi programistycznych umożliwia znaczne zmniejszenie nakładu pracy potrzebnego do wytworzenia oprogramowania, przy czym im bardziej są one zaawansowane i rozbudowane, tym większą przynoszą korzyść.");


            row = TabelaMnPracProjekt.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Programowanie w wielu lokalizacjach");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[15]]);
            cell = row.Cells[2];
            cell.AddParagraph("Osoby pracujące nad projektem mogą znajdować się w jednym budynku lub w wielu różnych miejscach, co przekłada się na wzrost pracochłonności. Drugim czynnikiem branym pod uwagę przy ocenie tego mnożnika jest sposób komunikacji pomiędzy członkami zespołu.");


            row = TabelaMnPracProjekt.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Ograniczenia nałożone na harmonogram");
            cell = row.Cells[1];
            cell.AddParagraph(TabStringMnPrac[TabIndMnPrac[16]]);
            cell = row.Cells[2];
            cell.AddParagraph("Ten mnożnik odzwierciedla sytuację, gdy zachodzi konieczność skrócenia lub wydłużenia harmonogramu o określony procent jego wartości nominalnej.");


            TabelaMnPracProjekt.SetEdge(0, 0, 3, 4, Edge.Bottom, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.LightSalmon);

            dokument.LastSection.Add(TabelaMnPracProjekt);


        }

        //Końcowe wyniki oszacowania
        public static void Wyniki(Document dokument)
        {
                      
            var sekcja = dokument.LastSection;

            var paragraf = sekcja.AddParagraph("Wyniki oszacowania pracochłonności", "Heading1");

            paragraf = sekcja.AddParagraph("Liczba nieskorygowanych punktów przypadków użycia UUCP: " + UUCP);
            paragraf = sekcja.AddParagraph("Rozmiar (w liniach kodu): " + Rozmiar);


            paragraf = sekcja.AddParagraph(Ostrzezenie);
            //paragraf = sekcja.AddParagraph("Metoda Use Case Points", "Heading3");

            //nagłówek tabelii
            paragraf = sekcja.AddParagraph("Tabela 8 - wyniki");
            paragraf.Format.SpaceBefore = "1cm";
            paragraf.Format.SpaceAfter = "0.2cm";

            var TabelaWyniki = new Table();

            //dodajemy kolumny
            var column = TabelaWyniki.AddColumn(Unit.FromCentimeter(5.3));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaWyniki.AddColumn(Unit.FromCentimeter(5.3));
            column.Format.Alignment = ParagraphAlignment.Center;

            column = TabelaWyniki.AddColumn(Unit.FromCentimeter(5.3));
            column.Format.Alignment = ParagraphAlignment.Center;

            TabelaWyniki.Rows.Height = Unit.FromCentimeter(1);

            var row = TabelaWyniki.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            row.Shading.Color = Colors.LightSalmon;
            

            //dodajemy tekst do nagłówków kolumn
            var cell = row.Cells[0];
            cell.AddParagraph("Najlepszy przypadek");
            cell = row.Cells[1];
            cell.AddParagraph("Oczekiwany przypadek");
            cell = row.Cells[2];
            cell.AddParagraph("Najgorszy przypadek");



            row = TabelaWyniki.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Pracochłonność (w osobomiesiącach):");                      
            cell.MergeRight = 2;


            row = TabelaWyniki.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            if (Ograniczenia == true && MaxPrac != 0 && MaxPrac < PracochlonnoscNLep) cell.Shading.Color = Colors.Red;
            cell.AddParagraph(string.Format("{0:N1}", PracochlonnoscNLep));
            cell = row.Cells[1];
            if (Ograniczenia == true && MaxPrac != 0 && MaxPrac < Pracochlonnosc) cell.Shading.Color = Colors.Red;
            cell.AddParagraph(string.Format("{0:N1}", Pracochlonnosc));
            cell = row.Cells[2];
            if (Ograniczenia == true && MaxPrac != 0 && MaxPrac < PracochlonnoscNGor) cell.Shading.Color = Colors.Red;
            cell.AddParagraph(string.Format("{0:N1}", PracochlonnoscNGor));


            row = TabelaWyniki.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Harmonogram (w miesiącach):");
            cell.MergeRight = 2;


            row = TabelaWyniki.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            if (Ograniczenia == true && MaxHarm != 0 && MaxHarm < HarmonogramNLep) cell.Shading.Color = Colors.Red;
            cell.AddParagraph(string.Format("{0:N1}", HarmonogramNLep));
            cell = row.Cells[1];
            if (Ograniczenia == true && MaxHarm != 0 && MaxHarm < Harmonogram) cell.Shading.Color = Colors.Red;
            cell.AddParagraph(string.Format("{0:N1}", Harmonogram));
            cell = row.Cells[2];
            if (Ograniczenia == true && MaxHarm != 0 && MaxHarm < HarmonogramNGor) cell.Shading.Color = Colors.Red;
            cell.AddParagraph(string.Format("{0:N1}", HarmonogramNGor));


            row = TabelaWyniki.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Szacowana data zakończenia:");
            cell.MergeRight = 2;

            if (DataZakonczenia.Date == DateTime.Today )
            {
                row = TabelaWyniki.AddRow();
                row.VerticalAlignment = VerticalAlignment.Center;
                cell = row.Cells[0];
                cell.AddParagraph("brak");
                cell = row.Cells[1];
                cell.AddParagraph("brak");
                cell = row.Cells[2];
                cell.AddParagraph("brak");
            }
            else
            {
                row = TabelaWyniki.AddRow();
                row.VerticalAlignment = VerticalAlignment.Center;
                cell = row.Cells[0];
                if (Ograniczenia == true && Deadline.Date != DateTime.Today && Deadline.Date < DataZakonczeniaNLep.Date) cell.Shading.Color = Colors.Red;
                cell.AddParagraph(string.Format("{0:d MMMM yyyy}", DataZakonczeniaNLep));
                cell = row.Cells[1];
                if (Ograniczenia == true && Deadline.Date != DateTime.Today && Deadline.Date < DataZakonczenia.Date) cell.Shading.Color = Colors.Red;
                cell.AddParagraph(string.Format("{0:d MMMM yyyy}", DataZakonczenia));
                cell = row.Cells[2];
                if (Ograniczenia == true && Deadline.Date != DateTime.Today && Deadline.Date < DataZakonczeniaNGor.Date) cell.Shading.Color = Colors.Red;
                cell.AddParagraph(string.Format("{0:d MMMM yyyy}", DataZakonczeniaNGor));
            }




            row = TabelaWyniki.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Wydajność (w liniach kodu):");
            cell.MergeRight = 2;


            row = TabelaWyniki.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph(string.Format("{0:N1}", WydajnoscNLep));
            cell = row.Cells[1];
            cell.AddParagraph(string.Format("{0:N1}", Wydajnosc));
            cell = row.Cells[2];
            cell.AddParagraph(string.Format("{0:N1}", WydajnoscNGor));


            row = TabelaWyniki.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Koszt projektu (w złotych):");
            cell.MergeRight = 2;


            row = TabelaWyniki.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            if (Ograniczenia == true && MaxKoszt != 0 && MaxKoszt < KosztNLep) cell.Shading.Color = Colors.Red;
            cell.AddParagraph(string.Format("{0:N}", KosztNLep));
            cell = row.Cells[1];
            if (Ograniczenia == true && MaxKoszt != 0 && MaxKoszt < Koszt) cell.Shading.Color = Colors.Red;
            cell.AddParagraph(string.Format("{0:N}", Koszt));
            cell = row.Cells[2];
            if (Ograniczenia == true && MaxKoszt != 0 && MaxKoszt < KosztNGor) cell.Shading.Color = Colors.Red;
            cell.AddParagraph(string.Format("{0:N}", KosztNGor));


            row = TabelaWyniki.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            cell.AddParagraph("Średnia wielkość zespołu (w osobach):");
            cell.MergeRight = 2;


            row = TabelaWyniki.AddRow();
            row.VerticalAlignment = VerticalAlignment.Center;
            cell = row.Cells[0];
            if (Ograniczenia == true && MaxZespol != 0 && MaxZespol < SrZespolNLep) cell.Shading.Color = Colors.Red;
            cell.AddParagraph(string.Format("{0:N1}", SrZespolNLep));
            cell = row.Cells[1];
            if (Ograniczenia == true && MaxZespol != 0 && MaxZespol < SrZespol) cell.Shading.Color = Colors.Red;
            cell.AddParagraph(string.Format("{0:N1}", SrZespol));
            cell = row.Cells[2];
            if (Ograniczenia == true && MaxZespol != 0 && MaxZespol < SrZespolNGor) cell.Shading.Color = Colors.Red;
            cell.AddParagraph(string.Format("{0:N1}", SrZespolNGor));




            TabelaWyniki.SetEdge(0, 0, 3, 13, Edge.Bottom, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1, Colors.LightSalmon);

            dokument.LastSection.Add(TabelaWyniki);

        }




    }
}

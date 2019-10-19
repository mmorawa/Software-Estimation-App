using System;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Windows.Forms;
using MigraDoc.DocumentObjectModel.IO;
using MigraDoc.Rendering;
using MigraDoc.Rendering.Printing; 
using MigraDoc.RtfRendering;
using MigraDoc.DocumentObjectModel;

namespace Aplikacja
{
    public partial class OknoPodgladRaportow : Form
    {

        public OknoPodgladRaportow(Document Raport, string NazwaPliku)
        {
            InitializeComponent();

            NazwaPlikuDoZapisu = NazwaPliku;

            // Utworzenie nowego dokumentu MigraDoc
            var dokument = Raport;
           
            var ddl = DdlWriter.WriteToString(dokument);
            PodgladRaportu.Ddl = ddl;

            LabelPowiekszenie.Text = "100%";
            LabelStrona.Text = "Str. " + PodgladRaportu.Page.ToString();
        }

        readonly PrinterSettings UstawieniaDrukarki = new PrinterSettings();
        string NazwaPlikuDoZapisu;
        int Powiekszenie = 100;


        private void ButtonPoprzednia_Click(object sender, EventArgs e)
        {
            PodgladRaportu.PrevPage();
            LabelStrona.Text = "Str. " + PodgladRaportu.Page.ToString();
        }

        private void ButtonNastepna_Click(object sender, EventArgs e)
        {
            PodgladRaportu.NextPage();
            LabelStrona.Text = "Str. " + PodgladRaportu.Page.ToString();
        }

        private void ButtonUstawieniaDruk_Click(object sender, EventArgs e)
        {
                using (var dialog = new PrintDialog())
                {
                    dialog.PrinterSettings = UstawieniaDrukarki;
                    dialog.AllowSelection = true;
                    dialog.AllowSomePages = true;
                    dialog.ShowDialog();
                }
            
        }

        private void ButtonDrukuj_Click(object sender, EventArgs e)
        {


                // Wykorzystaj ponownie renderer z podglądu wydruku
                var renderer = PodgladRaportu.Renderer;
                if (renderer == null)
                    return;

                var pageCount = renderer.FormattedDocument.PageCount;

                // Tworzy PrintDocument, który upraszcza drukowanie dokumentu utworzonego przez MigraDoc
                var printDocument = new MigraDocPrintDocument();

                // Dołącz istniejące ustawienia drukowania
                printDocument.PrinterSettings = UstawieniaDrukarki;

                if (UstawieniaDrukarki.PrintRange == PrintRange.Selection)
                    printDocument.SelectedPage = PodgladRaportu.Page;

                // Dołącz istniejący renderer dokumentu
                printDocument.Renderer = renderer;

                // Wydrukowanie dokumentu
                printDocument.Print();


        }

        private void ButtonEksportPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ZapiszPDFDialog = new SaveFileDialog())
            {
                ZapiszPDFDialog.Filter = "Plik Raportu | *.pdf";
                ZapiszPDFDialog.FileName = NazwaPlikuDoZapisu + ".pdf";
                ZapiszPDFDialog.Title = "Zapisz plik Raportu jako:";

                DialogResult rezultat = ZapiszPDFDialog.ShowDialog();

                if (rezultat == DialogResult.OK)
                {               
                    var printer = new PdfDocumentRenderer(true);
                    printer.DocumentRenderer = PodgladRaportu.Renderer;
                    printer.Document = PodgladRaportu.Document;
                    printer.RenderDocument();
                    PodgladRaportu.Document.BindToRenderer(null);
                    printer.Save(ZapiszPDFDialog.FileName);
                    MessageBox.Show("Raport został wyeksportowany do formatu PDF.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ButtonEksportRTF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ZapiszRTFDialog = new SaveFileDialog())
            {
                ZapiszRTFDialog.Filter = "Plik Raportu | *.rtf";
                ZapiszRTFDialog.FileName = NazwaPlikuDoZapisu + ".rtf";
                ZapiszRTFDialog.Title = "Zapisz plik Raportu jako:";

                DialogResult rezultat = ZapiszRTFDialog.ShowDialog();

                if (rezultat == DialogResult.OK)
                {
                    var rtf = new RtfDocumentRenderer();
                    rtf.Render(PodgladRaportu.Document, ZapiszRTFDialog.FileName, null);
                    MessageBox.Show("Raport został wyeksportowany do formatu RTF.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ButtonPowieksz_Click(object sender, EventArgs e)
        {
            if (Powiekszenie >= 800)
            {
                return;
            }
            else
            {
                Powiekszenie += 10;
                PodgladRaportu.ZoomPercent = Powiekszenie;
                LabelPowiekszenie.Text = Powiekszenie.ToString() + "%";
            }
        }

        private void ButtonPomniejsz_Click(object sender, EventArgs e)
        {
            if (Powiekszenie <= 10)
            {
                return;
            }
            else
            {
                Powiekszenie -= 10;
                PodgladRaportu.ZoomPercent = Powiekszenie;
                LabelPowiekszenie.Text = Powiekszenie.ToString() + "%";
            }
        }
    }
}

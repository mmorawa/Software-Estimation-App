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

            NazwaPlikuZapis = NazwaPliku;

            // Create a new MigraDoc document
            var dokument = Raport;
           
            var ddl = DdlWriter.WriteToString(dokument);
            PodgladRaportu.Ddl = ddl;

            LabelPowiekszenie.Text = "100%";
            LabelStrona.Text = "Str. " + PodgladRaportu.Page.ToString();
        }

        readonly PrinterSettings _printerSettings = new PrinterSettings();
        string NazwaPlikuZapis;
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
                    dialog.PrinterSettings = _printerSettings;
                    dialog.AllowSelection = true;
                    dialog.AllowSomePages = true;
                    dialog.ShowDialog();
                }
            
        }

        private void ButtonDrukuj_Click(object sender, EventArgs e)
        {

                //#if true_ // TODO: MigraDoc.Rendering.Printing doesn't exist
                // Reuse the renderer from the preview
                var renderer = PodgladRaportu.Renderer;
                if (renderer == null)
                    return;

                var pageCount = renderer.FormattedDocument.PageCount;

                // Creates a PrintDocument that simplifies printing of MigraDoc documents
                var printDocument = new MigraDocPrintDocument();

                // Attach the current printer settings
                printDocument.PrinterSettings = _printerSettings;

                if (_printerSettings.PrintRange == PrintRange.Selection)
                    printDocument.SelectedPage = PodgladRaportu.Page;

                // Attach the current document renderer
                printDocument.Renderer = renderer;

                // Print the document
                printDocument.Print();
                //#endif

        }

        private void ButtonEksportPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ZapiszPDFDialog = new SaveFileDialog())
            {
                ZapiszPDFDialog.Filter = "Plik Raportu | *.pdf";
                ZapiszPDFDialog.FileName = NazwaPlikuZapis + ".pdf";
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

                    Process.Start(ZapiszPDFDialog.FileName);
                }
            }
        }

        private void ButtonEksportRTF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ZapiszRTFDialog = new SaveFileDialog())
            {
                ZapiszRTFDialog.Filter = "Plik Raportu | *.rtf";
                ZapiszRTFDialog.FileName = NazwaPlikuZapis + ".rtf";
                ZapiszRTFDialog.Title = "Zapisz plik Raportu jako:";

                DialogResult rezultat = ZapiszRTFDialog.ShowDialog();

                if (rezultat == DialogResult.OK)
                {

                    var rtf = new RtfDocumentRenderer();
                    rtf.Render(PodgladRaportu.Document, "test.rtf", null);

                    Process.Start("test.rtf");
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

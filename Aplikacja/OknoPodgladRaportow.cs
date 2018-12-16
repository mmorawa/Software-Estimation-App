using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Forms;
using MigraDoc.DocumentObjectModel.IO;
using MigraDoc.Rendering;
using MigraDoc.Rendering.Printing; 
using MigraDoc.Rendering.Forms;
using MigraDoc.RtfRendering;
using MigraDoc.DocumentObjectModel;

namespace Aplikacja
{
    public partial class OknoPodgladRaportow : Form
    {

        public OknoPodgladRaportow(Document Raport)
        {
            InitializeComponent();

            // Create a new MigraDoc document
            var dokument = Raport;

            // HACK
            var ddl = DdlWriter.WriteToString(dokument);
            PodgladRaportu.Ddl = ddl;
        }

        readonly PrinterSettings _printerSettings = new PrinterSettings();


        private void ButtonPoprzednia_Click(object sender, EventArgs e)
        {
            PodgladRaportu.PrevPage();
            //UpdateStatusBar();
        }

        private void ButtonNastepna_Click(object sender, EventArgs e)
        {
            PodgladRaportu.NextPage();
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
    }
}

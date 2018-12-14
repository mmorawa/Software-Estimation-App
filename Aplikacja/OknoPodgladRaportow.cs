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
using MigraDoc.Rendering.Printing; // TODO: MigraDoc.Rendering.Printing doesn't exist
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
    }
}

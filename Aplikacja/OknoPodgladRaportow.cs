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
        //private DocumentPreview documentPreview1;


        public OknoPodgladRaportow(Document Raport)
        {
            InitializeComponent();

            // Create a new MigraDoc document
            var dokument = Raport;

            // HACK
            var ddl = DdlWriter.WriteToString(dokument);
            documentPreview1.Ddl = ddl;
        }



        private void ButtonPoprzednia_Click(object sender, EventArgs e)
        {
            documentPreview1.PrevPage();
            //UpdateStatusBar();
        }

        private void ButtonNastepna_Click(object sender, EventArgs e)
        {
            documentPreview1.NextPage();
        }
    }
}

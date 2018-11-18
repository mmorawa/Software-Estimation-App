using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class OknoKalibracja : Form
    {
        public OknoKalibracja()
        {
            InitializeComponent();
            TextBoxA.Text = Properties.Settings.Default.A.ToString();
            TextBoxB.Text = Properties.Settings.Default.B.ToString();
        }

        //TODO konwersja kulturowa Parse
        private void TextBoxA_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempA = double.Parse(TextBoxA.Text);
        }

        private void TextBoxB_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempB = double.Parse(TextBoxB.Text);
        }

        //TODO różne kalibracje dla różnych zespołów/projektów

    }
}

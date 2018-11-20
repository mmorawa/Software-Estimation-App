using System;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class OknoKalibracja : Form
    {
        public OknoKalibracja()
        {
            InitializeComponent();

            NumericUCPnaFP.Value = (decimal)Properties.Settings.Default.UCPnaFP;
            TextBoxA.Text = Properties.Settings.Default.A.ToString();
            TextBoxB.Text = Properties.Settings.Default.B.ToString();
            TextBoxC.Text = Properties.Settings.Default.C.ToString();
            TextBoxD.Text = Properties.Settings.Default.D.ToString();

        }

        private void NumericUCPnaFP_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempUCPnaFP = (double)NumericUCPnaFP.Value;
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

        private void TextBoxC_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempC = double.Parse(TextBoxC.Text);
        }

        private void TextBoxD_TextChanged(object sender, EventArgs e)
        {
            OknoGlowne.TempD = double.Parse(TextBoxD.Text);
        }



        //TODO różne kalibracje dla różnych zespołów/projektów

    }
}

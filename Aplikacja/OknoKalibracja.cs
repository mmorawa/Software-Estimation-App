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

        //TODO różne kalibracje dla różnych zespołów/projektów

    }
}

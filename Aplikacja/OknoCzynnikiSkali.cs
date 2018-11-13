using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO: wysoki/a, wyrównanie, tooltipy, opisy.

namespace Aplikacja
{
    public partial class OknoCzynnikiSkali : Form
    {
        public OknoCzynnikiSkali()
        {
            InitializeComponent();
            ComboBoxCzynnSkTyp.SelectedIndex = 2;
            ComboBoxCzynnSkElast.SelectedIndex = 2;
            ComboBoxCzynnSkRyzyko.SelectedIndex = 2;
            ComboBoxCzynnSkZesp.SelectedIndex = 2;
            ComboBoxCzynnSkDojrz.SelectedIndex = 2;
        }
    }
}

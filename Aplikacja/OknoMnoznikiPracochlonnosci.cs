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
    public partial class OknoMnoznikiPracochlonnosci : Form
    {
        public OknoMnoznikiPracochlonnosci()
        {
            InitializeComponent();

            ComboBoxMnPrAnal.SelectedIndex = 2;
            ComboBoxMnPrBaza.SelectedIndex = 2;
            ComboBoxMnPrDoku.SelectedIndex = 2;
            ComboBoxMnPrHarm.SelectedIndex = 2;
            ComboBoxMnPrLokal.SelectedIndex = 2;
            ComboBoxMnPrNarzP.SelectedIndex = 2;
            ComboBoxMnPrNiezaw.SelectedIndex = 2;
            ComboBoxMnPrOgrCz.SelectedIndex = 2;
            ComboBoxMnPrOgrP.SelectedIndex = 2;
            ComboBoxMnPrPonow.SelectedIndex = 2;
            ComboBoxMnPrProgr.SelectedIndex = 2;
            ComboBoxMnPrZesp.SelectedIndex = 2;
            ComboBoxMnPrZloz.SelectedIndex = 2;
            ComboBoxMnPrZmP.SelectedIndex = 2;
            ComboBoxMnPrZnajA.SelectedIndex = 2;
            ComboBoxMnPrZnajJ.SelectedIndex = 2;
            ComboBoxMnPrZnajP.SelectedIndex = 2;
            //ToolTip.SetToolTip(comboBox1, "Save changes");

        }
    }
}

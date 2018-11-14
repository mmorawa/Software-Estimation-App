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
    public partial class OknoCzynnSrodow : Form
    {
        public OknoCzynnSrodow()
        {
            InitializeComponent();

            ComboBoxCzSDoswAplik.SelectedIndex = 0;
            ComboBoxCzSDoswMetOb.SelectedIndex = 0;
            ComboBoxCzSMotyw.SelectedIndex = 0;
            ComboBoxCzSNieWymG.SelectedIndex = 0;
            ComboBoxCzSStabWymag.SelectedIndex = 0;
            ComboBoxCzSTrudnJProg.SelectedIndex = 0;
            ComboBoxCzSUmAnalW.SelectedIndex = 0;
            ComboBoxCzSZaznajProj.SelectedIndex = 0;
            

        }
    }
}

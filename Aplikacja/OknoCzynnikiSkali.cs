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
    public partial class OknoCzynnikiSkali : Form
    {
        public OknoCzynnikiSkali()
        {
            InitializeComponent();
            ComboBoxCzynnSk1.SelectedIndex = 2;
            ComboBoxCzynnSk2.SelectedIndex = 2;
            ComboBoxCzynnSk3.SelectedIndex = 2;
            ComboBoxCzynnSk4.SelectedIndex = 2;
            ComboBoxCzynnSk5.SelectedIndex = 2;
        }
    }
}

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
    public partial class OknoZalozeniaProjektu : Form
    {
        public OknoZalozeniaProjektu()
        {
            InitializeComponent();
        }

        private void CheckBoxAktywacja_CheckedChanged(object sender, EventArgs e)
        {
            if (TableLayoutOgraniczenia.Enabled == false)
            {
                TableLayoutOgraniczenia.Enabled = true;
            }
            else
            {
                TableLayoutOgraniczenia.Enabled = false;
            }
        }
    }
}

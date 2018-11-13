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
    public partial class OknoCzynnZlozTechn : Form
    {
        

        public OknoCzynnZlozTechn()
        {            
            InitializeComponent();

            ComboBoxCzTDodSzkol.SelectedIndex = 0;
            ComboBoxCzTLatwInst.SelectedIndex = 0;
            ComboBoxCzTLatwUzyc.SelectedIndex = 0;
            ComboBoxCzTLatwZmian.SelectedIndex = 0;
            ComboBoxCzTPonUzycie.SelectedIndex = 0;
            ComboBoxCzTPrzen.SelectedIndex = 0;
            ComboBoxCzTPrzetwW.SelectedIndex = 0;
            ComboBoxCzTPrzetwWsp.SelectedIndex = 0;
            ComboBoxCzTRozp.SelectedIndex = 0;
            ComboBoxCzTSpecZabezp.SelectedIndex = 0;
            ComboBoxCzTWydaj.SelectedIndex = 0;
            ComboBoxCzTWydajUztk.SelectedIndex = 0;
            ComboBoxCzTZewnOpr.SelectedIndex = 0;
        }

        /*
        private void ComboBoxCzynnTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show((ComboBoxCzynnTech.Text));
        }
        */
    }
}

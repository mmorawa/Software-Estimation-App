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

            NumericUCPgodziny.Value = (decimal)OknoGlowne.UCPgodziny;
            NumericUCPlinieKodu.Value = (decimal)OknoGlowne.UCPlinieKodu;
            NumericStawkaGodz.Value = (decimal)OknoGlowne.StawkaGodz;
            NumericOsoboMGodz.Value = OknoGlowne.OsoboMGodz;
            NumericDzRobGodz.Value = OknoGlowne.DzRobGodz;
            NumericMaxKoszt.Value = (decimal)OknoGlowne.MaxKoszt;
            NumericMaxPrac.Value = OknoGlowne.MaxPrac;
            NumericMaxHarm.Value = OknoGlowne.MaxHarm;
            
            CheckBoxAktywacja.Checked = OknoGlowne.Ograniczenia;
            TableLayoutOgraniczenia.Enabled = OknoGlowne.Ograniczenia;

        }



        private void CheckBoxAktywacja_CheckedChanged(object sender, EventArgs e)
        {

            if (TableLayoutOgraniczenia.Enabled == false)
            {
                OknoGlowne.Ograniczenia = true;
                TableLayoutOgraniczenia.Enabled = true;
            }
            else
            {
                OknoGlowne.Ograniczenia = false;
                TableLayoutOgraniczenia.Enabled = false;
            }
        }


        //TODO domyślnie decimal????


        private void NumericUCPgodziny_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.UCPgodziny = (double)NumericUCPgodziny.Value;
        }

        private void NumericUCPlinieKodu_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.UCPlinieKodu = (double)NumericUCPlinieKodu.Value;
        }

        private void NumericStawkaGodz_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.StawkaGodz = (double)NumericStawkaGodz.Value;
        }

        private void NumericOsoboMGodz_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.OsoboMGodz = (int)NumericOsoboMGodz.Value;
        }

        private void NumericDzRobGodz_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.DzRobGodz = (int)NumericDzRobGodz.Value;
        }

        private void NumericMaxKoszt_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.MaxKoszt = (double)NumericMaxKoszt.Value;
        }

        private void NumericMaxPrac_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.MaxPrac = (int)NumericMaxPrac.Value;
        }

        private void NumericMaxHarm_ValueChanged(object sender, EventArgs e)
        {
            OknoGlowne.MaxHarm = (int)NumericMaxHarm.Value;
        }


    }
}

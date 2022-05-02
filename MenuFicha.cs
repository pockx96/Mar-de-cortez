using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarDeCortezDsk
{
    public partial class MenuFicha : Form
    {
        //metodos
        void _horadata()
        {
            lb_time.Text = (dtTmpct_datatime.Value.Hour + " : " + dtTmpct_datatime.Value.Minute).ToString();
            lb_data.Text = (dtTmpct_datatime.Value.Day + " / " + dtTmpct_datatime.Value.Month + " / " + dtTmpct_datatime.Value.Year).ToString();
        }


        public MenuFicha()
        {
            InitializeComponent();
        }

        private void MenuFicha_Load(object sender, EventArgs e)
        {
            _horadata();
        }

        private void btt_enviar_Click(object sender, EventArgs e)
        {
            Form bettascreen = new MenuEleccion();
            this.Hide();
            bettascreen.Show();
        }

        private void btt_Shrim_Click(object sender, EventArgs e)
        {
            Form bettafichashirim = new camaronlist();
            bettafichashirim.Show();
        }

        private void bttn_fish_Click(object sender, EventArgs e)
        {
            Form bettafichafish = new peceslist();
            bettafichafish.Show();
        }
    }
}

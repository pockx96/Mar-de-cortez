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
    public partial class MenuEleccion : Form
    {
        public MenuEleccion()
        {
            InitializeComponent();
        }

        private void MenuEleccion_Load(object sender, EventArgs e)
        {
            _horadata();
        }



        void _horadata() {
            lb_time.Text = (dtTmpct_datatime.Value.Hour + " : " + dtTmpct_datatime.Value.Minute).ToString();
            lb_data.Text = (dtTmpct_datatime.Value.Day + " / " + dtTmpct_datatime.Value.Month + " / " + dtTmpct_datatime.Value.Year).ToString();
        }


        private void bttn_provdr_Click_1(object sender, EventArgs e)
        {
            Form btaficha = new MenuFicha();
            this.Hide();
            btaficha.Show();
        }
    }
}

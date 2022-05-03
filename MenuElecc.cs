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
    public partial class MenuElecc : Form
    {
        public MenuElecc()
        {
            InitializeComponent();
        }

        private void bttn_logout_Click(object sender, EventArgs e)
        {
            pnl_alertLogout.Visible = true;
            pnl_alertLogout.Location = new Point(312, 232);
        }

        private void bttn_cnclLogout_Click(object sender, EventArgs e)
        {
            pnl_alertLogout.Visible = false;
            pnl_alertLogout.Location = new Point(913, 248);
        }

        private void MenuElecc_Load(object sender, EventArgs e)
        {
            
            
        }

        //panel agregar Provedor
        private void bttn_prvdr_Click(object sender, EventArgs e)
        {
            pnl_addprvdr.Location = new Point(113, 240);
        }

        private void bttn_cnclAddprvdr_Click(object sender, EventArgs e)
        {
            pnl_addprvdr.Location = new Point(454, 541);
        }

        private void bttn_tnda_Click(object sender, EventArgs e)
        {

        }
    }
}

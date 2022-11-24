using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarDeCortezDsk.UserControlls
{
    public partial class BarraUsuario : UserControl
    {
        public BarraUsuario()
        {
            InitializeComponent();
        }

        public string UserName { get; set; }
        private void BarraUsuario_Load(object sender, EventArgs e)
        {
            if (UserName != null)
            {
                LblUser.Text = UserName;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

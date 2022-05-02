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
    public partial class peceslist : Form
    {
        public peceslist()
        {
            InitializeComponent();
        }

        private void bttn_cancelfish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

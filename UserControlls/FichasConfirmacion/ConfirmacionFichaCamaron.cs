using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.Models;
using MarDeCortezDsk.Controllers;

namespace MarDeCortezDsk.UserControlls.FichasConfirmacion
{
    public partial class ConfirmacionFichaCamaron : UserControl
    {
        public ConfirmacionFichaCamaron()
        {
            InitializeComponent();
        }

        private void ConfirmacionFichaCamaron_Load(object sender, EventArgs e)
        {
            CamaronController CamaronServise = new CamaronController();
            List<Camaron> ListCamaron = CamaronServise.GetCamarones();
            Camaron camaron = ListCamaron[0];

            ListaFicha.Rows.Insert(0,camaron.Tipo_producto,camaron.Presentacion,camaron.Medida,camaron.Cantidad,camaron.kilos);

        }
    }
}

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

namespace MarDeCortezDsk.UserControlls.FichasConfirmacion
{
    public partial class OtrosDatagrid : UserControl
    {
        public OtrosDatagrid()
        {
            InitializeComponent();
        }

        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CargaOtros(List<Pescado> PescadoList)
        {
            int index;
            foreach (Pescado element in PescadoList)
            {
                index = ListaEntrada.RowCount - 1;
                ListaEntrada.Rows.Insert(index, element.Tipo_producto, element.Presentacion, element.Cantidad, element.Kilos);
            }
        }
        public void Clear()
        {
            ListaEntrada.Rows.Clear();
        }

        private void OtrosDatagrid_Load(object sender, EventArgs e)
        {

        }
    }
}

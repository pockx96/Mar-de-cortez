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
    public partial class PescadoDatagrid : UserControl
    {
        public PescadoDatagrid()
        {
            InitializeComponent();
        }


        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CargaPescado(List<Pescado> PescadoList)
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
    }
}

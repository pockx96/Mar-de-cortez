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
    public partial class CamaronDatagrid : UserControl
    {
        public CamaronDatagrid()
        {
            InitializeComponent();
        }

        public void CargaCamaron(List<Camaron> CamaronList)
        {   int index;
            foreach (Camaron element in CamaronList)
            {
                index = ListaEntrada.RowCount - 1;
                ListaEntrada.Rows.Insert(index, element.Tipo_producto, element.Presentacion, element.Medida, element.Cantidad, element.Kilos);
            }
        }

        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CamaronDatagrid_Load(object sender, EventArgs e)
        {
            
        }

        public void Clear()
        {
            ListaEntrada.Rows.Clear();
        }
    }
}

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

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    public partial class FichasEntradaAdmin : UserControl
    {

        public FichasEntradaAdmin()
        {
            InitializeComponent();
          


        }

        public int Index { get; set;}


        public void LoadData(List<Folios> fichaEntrada)
        {
            UsuarioController userServise = new UsuarioController();
            int index;
            foreach (Folios element in fichaEntrada)
            {
                index = ListaEntrada.RowCount - 1;
                Usuarios user = userServise.Get(element.id_usuario);

                ListaEntrada.Rows.Insert(index, element.IdFolio, element.id_proveedor, element.fecha_entrada, user.nombre_usuario);

            }
        }

       public void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow index = ListaEntrada.CurrentRow;


            Index = index.Index;

            DataGridViewRow ficha = ListaEntrada.Rows[Index];

            MessageBox.Show(index.Index.ToString());
        }
    }
}

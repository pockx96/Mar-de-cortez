using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.UserControlls;
using MarDeCortezDsk.Views;
using MarDeCortezDsk.Models;
using MarDeCortezDsk.Controllers;
using CustomMessageBox;

namespace MarDeCortezDsk.Views
{
    public partial class Actulizacion_de_productos : Form
    {
        public Actulizacion_de_productos(Pescado producto)
        {
            InitializeComponent();
            Producto = producto;

        }
        public Actulizacion_de_productos(Camaron producto)
        {
            InitializeComponent();
            Camaron = producto;

        }

        private void Actulizacion_de_productos_Load(object sender, EventArgs e)
        {
            if (Camaron.IdProducto!= null && Camaron.IdProducto[0] == 'C')
            {
                CamaronAdd();
            }
            else if (Producto.IdProducto != null && Producto.IdProducto[0] == 'P')
            {
                PescadoAdd();
            }
            else if (Producto.IdProducto != null && Producto.IdProducto[0] == 'O')
            {
                OtrosAdd();
            }
        }

        Pescado Producto = new Pescado();
        Camaron Camaron = new Camaron();
        FichaCamaron fichaCamaron = new FichaCamaron();
        OtrosFicha fichaOtros = new OtrosFicha();
        PescadoFicha fichaPescado = new PescadoFicha();

        public delegate void ReloadDelegate();
        public event ReloadDelegate Reload;

        private void CamaronAdd()
        {
            ContainerForm.Controls.Add(fichaCamaron);
            fichaCamaron.Location = new Point(24, 91);
        }
        private void PescadoAdd()
        {
            ContainerForm.Controls.Add(fichaPescado);
            fichaPescado.Location = new Point(24, 91);
        }
        private void OtrosAdd()
        {
            ContainerForm.Controls.Add(fichaOtros);
            fichaOtros.Location = new Point(24, 91);
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            CamaronController camaronServise = new CamaronController();
            PescadoController pescadoServise = new PescadoController();

            if (Camaron.IdProducto != null && Camaron.IdProducto[0] == 'C' && fichaCamaron.ValidationForm())
            {
                Camaron camaronEdit = fichaCamaron.GetRow(Camaron.FolioEntrada,Camaron.Almacenaje);
                camaronEdit.IdProducto = Camaron.IdProducto;
                camaronServise.Update(camaronEdit);
                fichaCamaron.Clear();

            }
            else if (Producto.IdProducto != null && Producto.IdProducto[0] == 'P' && fichaPescado.ValidationValues())
            {
                Pescado pescadoEdit = fichaPescado.GetProducto(Producto.FolioEntrada,Producto.Almacenaje);
                pescadoEdit.IdProducto = Producto.IdProducto;
                pescadoServise.Update(pescadoEdit);
                fichaPescado.Clear();
            }
            else if (Producto.IdProducto != null && Producto.IdProducto[0] == 'O' && fichaOtros.ValidationValues())
            {
                Pescado otrosEdit = fichaOtros.GetProducto(Producto.FolioEntrada, Producto.Almacenaje);
                otrosEdit.IdProducto = Producto.IdProducto;
                pescadoServise.Update(otrosEdit);
                fichaOtros.Clear();
            }
            DialogResult result = RJMessageBox.Show("Actualización exitosa.",
        "Aviso!");
            Reload();
            this.Hide();

        }

        private void ContainerForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

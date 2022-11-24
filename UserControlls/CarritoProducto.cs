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
using MarDeCortezDsk.UserControlls;
using MarDeCortezDsk.Views;
using CustomMessageBox;
namespace MarDeCortezDsk.UserControlls
{
    public partial class CarritoProducto : UserControl
    {
        public CarritoProducto()
        {
            InitializeComponent();
        }
        public CarritoProducto(string proveedor,string usuario,string fecha)
        {
            InitializeComponent();
            this.Proveedor = proveedor;
            this.Usuario = usuario;
            this.Fecha = fecha;
            

        }

        public string Proveedor { get; set; }
        public string Fecha { get; set; }
        public string Usuario { get; set; }
        public string Folio { get; set; }
        private string formularioActual { get; set; }

        public PescadoFicha PescadoFicha = new PescadoFicha();
        public OtrosFicha OtrosFicha = new OtrosFicha();

        PescadoFicha formPescado = new PescadoFicha() { Location = new Point(0, 0) };
        OtrosFicha formOtro = new OtrosFicha() { Location = new Point(0, 0) };
        FichaCamaron formCamaron = new FichaCamaron() { Location = new Point(0, 0) };


        public List<Camaron> ListCamaron = new List<Camaron>();
        public List<Pescado> ListPescado = new List<Pescado>();

        public delegate void RestartDelegate();
        public event RestartDelegate Restart;

        private void CarritoProducto_Load(object sender, EventArgs e)
        {
            CamaronAdd();
            FoliosController foliosController = new FoliosController();
            this.Folio = foliosController.NewId();
        }

        public void CamaronAdd()
        {
            FormulariosContainer.Controls.Clear();
            FormulariosContainer.Controls.Add(formCamaron);
            formularioActual = "Camaron";
        }
        public void PescadoAdd()
        {
            FormulariosContainer.Controls.Clear();
            FormulariosContainer.Controls.Add(formPescado);
            formularioActual = "Pescado";
        }
        public void OtrosAdd()
        {
            FormulariosContainer.Controls.Clear();
            FormulariosContainer.Controls.Add(formOtro);
            formularioActual = "Otros";
        }


        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            int index = ListaEntrada.RowCount;
            switch (formularioActual)
            {
                case "Camaron":
                    Camaron camaron = formCamaron.GetRow(Folio, Proveedor);
                    ListCamaron.Add(camaron);
                    ListaEntrada.Rows.Insert(index, camaron.Tipo_producto, camaron.Presentacion, camaron.Cantidad);
                    break;
                case "Pescado":
                    Pescado pescado = formPescado.GetProducto(Folio, Proveedor);
                    ListPescado.Add(pescado);
                    ListaEntrada.Rows.Insert(index, pescado.Tipo_producto, pescado.Presentacion, pescado.Cantidad);
                    break;
                case "Otros":
                    Pescado otros = formOtro.GetProducto(Folio, Proveedor);
                    ListPescado.Add(otros);
                    ListaEntrada.Rows.Insert(index, otros.Tipo_producto, otros.Presentacion, otros.Cantidad);
                    break;

            }


        }
        private void BtnFichas_Click(object sender, EventArgs e)
        {
            PescadoController pescadoController = new PescadoController();
            List<Pescado> ListMixta = pescadoController.MixList(ListCamaron,ListPescado);
            if (ListaEntrada.RowCount>0)
            {
                Folios ficha = new Folios();
                ficha.id_proveedor = Proveedor;
                ficha.id_usuario = Usuario;
                ficha.fecha_entrada = Fecha;

                FichaConfirmacion confirmacion = new FichaConfirmacion(ListCamaron, ListPescado, ListMixta, ficha, Usuario);
                confirmacion.Usuarios = Usuario;
                confirmacion.Reload += new FichaConfirmacion.ReloadDelegate(Restart);
                confirmacion.ShowDialog();

            }
            else
            {
                DialogResult result = RJMessageBox.Show("Agrege productos al carrito.",
               "Aviso!");
            }

        }
    }

 

    
}

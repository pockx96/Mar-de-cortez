using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.Controllers;
using MarDeCortezDsk.Models;
using MarDeCortezDsk.UserControlls;
using MarDeCortezDsk.UserControlls.FichasConfirmacion;
using MarDeCortezDsk.Views;
using MarDeCortezDsk.Styles;
using CustomMessageBox;

namespace MarDeCortezDsk.Views
{
    public partial class FichaConfirmacion : Form , Ipruebas
    {
        public FichaConfirmacion(List<Camaron> camaronList , List<Pescado> pescadoList ,List<Pescado> listaMesclada, Folios ficha,string usuario)
        {
            InitializeComponent();

            ListCamaron = camaronList;
            ListPescado = pescadoList;
            ListTemp = listaMesclada;
            Ficha = ficha;
            Usuarios = usuario;

        }



        public string Usuarios { get; set; } 
        Folios Ficha = new Folios();
        public List<Camaron> ListCamaron = new List<Camaron>();
        public List<Pescado> ListPescado = new List<Pescado>();
        public List<Pescado> ListTemp = new List<Pescado>();

        public delegate void ReloadDelegate();

        public event ReloadDelegate Reload;


        /// <summary>
        /// Posibles estados de la ficha
        /// 1 = solo Camaron
        /// 2 = solo pescados
        /// 3 = solo mariscos
        /// 4 = camaron y pescado
        /// 5 = camaron y mariscos
        /// 6 = pescado y otros
        /// 7 = Camaron pescado y otros
        /// </summary>
        private void FichaConfirmacion_Load(object sender, EventArgs e)
        {
            LoadData();
            ProveedorShowDialog proveedor = new ProveedorShowDialog();

        }






        /// <summary>
        /// 
        /// Envio de Datos
        /// 
        /// </summary>
        /// 

        public void LoadData()
        {

            int index;
            if (ListPescado != null)
            {
                foreach (Pescado element in ListPescado)
                {
                    index = ListaEntrada.RowCount;
                    ListaEntrada.Rows.Insert(index, element.Tipo_producto, element.Presentacion, element.Cantidad, element.Kilos);
                }
            }

            if (ListCamaron != null)
            {
                foreach (Camaron element in ListCamaron)
                {
                    string PresentacionCamaron = element.Presentacion + " " + element.Medida;
                    index = ListaEntrada.RowCount;

                    ListaEntrada.Rows.Insert(index, element.Tipo_producto, PresentacionCamaron, element.Cantidad, element.Kilos);
                }
            }


        }

        public void Clear()
        {
            ListaEntrada.Rows.Clear();
        }


        /// <summary>
        /// 
        /// Manejo de fichas en Pantalla
        /// 
        /// </summary>
        /// 







        private void FlechaICon_Click(object sender, EventArgs e)
        {

        }

        private void LblCamaron_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

     

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            
            FoliosController fichaServise = new FoliosController();
            PescadoController pescadoServise = new PescadoController();
            CamaronController CamaronServise = new CamaronController();


            if (ListCamaron.Count > 0 )
            {
                
                foreach (Camaron element in ListCamaron)
                {
                    CamaronServise.Post(element);
                }
                
            }
            if (ListPescado.Count > 0)
            {
                foreach (Pescado element in ListPescado)
                {
                    pescadoServise.Post(element);
                }
            }

            fichaServise.Post(Ficha);
            DialogResult result = RJMessageBox.Show("Productos añadidos con éxito.", "Aviso!");
            Reload();
            this.Hide();
        }

        private void ListaEntrada_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ListaEntrada.CurrentRow.Selected = true;
            Animations animations = new Animations();
            Point point = animations.BtnlocationDatagrid(ListaEntrada, 240, Cursor.Position.Y, new Point(500, 104), 12);
            BtnEliminar.Location = point;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEliminar_Move(object sender, EventArgs e)
        {
            this.Location = new Point(414, 133);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            FoliosController fichaServise = new FoliosController();
            string id = ListTemp[ListaEntrada.CurrentRow.Index].IdProducto;
            ListaEntrada.Rows.Remove(ListaEntrada.CurrentRow);
            Camaron camaron = new Camaron();
            Pescado pescado = new Pescado();

            foreach (Camaron element in ListCamaron)
            {
                if (id == element.IdProducto)
                {
                    camaron = element;
                }
            }
            foreach (Pescado element in ListPescado)
            {
                if (id == element.IdProducto)
                {
                    pescado = element;
                }
            }

            if (camaron.IdProducto != null) { ListCamaron.Remove(camaron); }
            if (pescado.IdProducto != null) { ListPescado.Remove(pescado); }
        }

        private void ListaEntrada_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FichaConfirmacion_Move(object sender, EventArgs e)
        {
        }
    }
}


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
using MarDeCortezDsk.Styles;
using MarDeCortezDsk.Views;
using CustomMessageBox;

namespace MarDeCortezDsk.Views
{
    public partial class MenuUsuario : Form
    {
        public MenuUsuario(string user)
        {
            InitializeComponent();
            Usuario = user;
        }

        private void MenuUsuario_Load(object sender, EventArgs e)
        {
            loadFolios();
            LblUser.Text = Usuario;
        }

        public string Usuario { get; set; }
        public string Folio { get; set; }

        PescadoController pescadoController = new PescadoController();
        CamaronController camaronController = new CamaronController();
        List<Folios> ListFolios = new List<Folios>();
        Animations animations = new Animations();
        private void loadFolios()
        {
            GetFecha();
            FoliosController fichaServise = new FoliosController();
            ListFolios = fichaServise.GetByUser(Usuario);

             
            foreach (Folios element in ListFolios)
            {
                int index = DataGridFolios.RowCount;

                DataGridFolios.Rows.Insert(index, element.IdFolio, element.id_proveedor, element.fecha_entrada,element.Estado);

            }
        }

        private void GetFecha()
        {
            string DateToday = DateTime.Now.ToString("dd-MM-yyyy");
            LblFecha.Text = DateToday;

        }

        private void loadProductos(List<Pescado> list)
        {
            DatagridProductos.Rows.Clear();
            foreach (Pescado element in list)
            {
                int index = DatagridProductos.RowCount;
                DatagridProductos.Rows.Insert(index, element.IdProducto, element.Tipo_producto, element.Presentacion,element.Cantidad,element.Kilos);

            }
        }

        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Point LocationDelete = animations.BtnlocationDatagrid(DataGridFolios,268,Cursor.Position.Y,new Point(463, 172),12);
            BtnDeleteFolios.Location = LocationDelete;
            DataGridFolios.CurrentRow.Selected = true;


            string folio = DataGridFolios.CurrentRow.Cells[0].Value.ToString();
            Folio = folio;
            List<Camaron> ListCamaron = camaronController.GetbyFolio(folio);
            List<Pescado> ListPescado = pescadoController.GetByFolio(folio);
            List<Pescado> ListMesclada = pescadoController.MixList(ListCamaron, ListPescado);
            loadProductos(ListMesclada);


        }

        private void DatagridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Point LocationDelete = animations.BtnlocationDatagrid(DatagridProductos, 268, Cursor.Position.Y,new Point(1110, 172),12);
            BtnDeleteProducto.Location = LocationDelete;
            Point LocationEdit = animations.BtnlocationDatagrid(DatagridProductos, 268, Cursor.Position.Y, new Point(1150, 172), 12);
            BtnEditProducto.Location = LocationEdit;
            DatagridProductos.CurrentRow.Selected = true;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            PescadoController pescadoServise = new PescadoController();
            CamaronController camaronServise = new CamaronController();
            string folio = DatagridProductos.CurrentRow.Cells[0].Value.ToString();
            if (folio[0] == 'C')
            {
                camaronServise.Delete(folio);
                DatagridProductos.Rows.Remove(DatagridProductos.CurrentRow);
            }
            else
            {
                pescadoServise.Delete(folio);
                DatagridProductos.Rows.Remove(DatagridProductos.CurrentRow);
            }

        }

        private void BtnDeleteFolios_Click(object sender, EventArgs e)
        {
            FoliosController fichaServise = new FoliosController();
            string folio = DataGridFolios.CurrentRow.Cells[0].Value.ToString();
            fichaServise.Delete(folio);
            DataGridFolios.Rows.Remove(DataGridFolios.CurrentRow);
        }
        private void BtnEditProducto_Click(object sender, EventArgs e)
        {
            

        }

        public void ProductosReLoad()
        {
            List<Camaron> ListCamaron = camaronController.GetbyFolio(Folio);
            List<Pescado> ListPescado = pescadoController.GetByFolio(Folio);
            List<Pescado> ListMesclada = pescadoController.MixList(ListCamaron, ListPescado);
            loadProductos(ListMesclada);
        }

        private void BtnFichas_Click(object sender, EventArgs e)
        {
            ProvedorShowDialog showDialog = new ProvedorShowDialog();
            showDialog.ShowDialog();
        }

        private void LoadMenu(string proveedor)
        {
            MenuFicha menu = new  MenuFicha(Usuario,proveedor);          
            menu.Show();
            this.Hide();
        }


        private void PanelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            LblTime.Text = time.ToString("hh:mm:ss tt");
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            MenuFicha menuFicha = new MenuFicha(Usuario,"Tienda");
            menuFicha.Show();
            this.Hide();
        }
    }
}

using MarDeCortezDsk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.Views;
using MarDeCortezDsk.UserControlls;
using MarDeCortezDsk.Controllers;
using MarDeCortezDsk.Styles;
using CustomMessageBox;

namespace MarDeCortezDsk
{
    public partial class MenuFicha : Form ,Ipruebas
    {
        public MenuFicha(string user,string proveedor)
        {

            InitializeComponent();
            Usuario = user;
            Proveedor = proveedor;
        }


        private void MenuFicha_Load(object sender, EventArgs e)
        {
            
            GetFecha();

            LblProveedor.Text = Proveedor;
            FichaAdded = "camaron";
            PanelForm.Controls.Add(CamaronFicha);
            CamaronFicha.Location = Fichalocation;

            FoliosController servise = new FoliosController();
            Ficha = servise.NewId();
            LblFicha.Text = Ficha;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 85);
            MenuContainer.Controls.Add(leftBorderBtn);

            ActivateButton(btt_Shrim, RGBColors.color2);

            ContainerFolio.Location = new Point(230+LblProveedor.Size.Width, 22);



            

        }


        /// <summary>
        /// 
        /// DATOS
        /// 
        /// </summary>

        public string Proveedor { get; set; }
        public string Fecha { get; set; }
        public string Usuario { get; set; }
        public string FichaAdded { get; set; }

 



        public string Ficha { get; set; }

        public List<Camaron> ListCamaron = new List<Camaron>();
        public List<Pescado> ListPescado = new List<Pescado>();
        public List<Pescado> ListTemp = new List<Pescado>();
        public List<Inventario> Listinventarios = new List<Inventario>();
        public List<Pescado> EntradaList = new List<Pescado>();




        /// <summary>
        /// 
        /// Contenedores para las fichas de entrada
        /// 
        /// </summary>

        public PescadoFicha PescadoFicha = new PescadoFicha();
        public FichaCamaron CamaronFicha = new FichaCamaron();
        public OtrosFicha OtrosFicha = new OtrosFicha();
        Point Fichalocation = new Point(21, 22);

        /// <summary>
        /// 
        /// Carga de Catalogos y Datos 
        /// 
        /// </summary>
        
    



    

        private void GetFecha()
        {
            string DateToday = DateTime.Now.ToString("dd-MM-yyyy");
            Fecha = DateToday;
            LblFecha.Text = DateToday;

        }

        public void PostFicha()
        {

            if (Proveedor != null && Proveedor != "")
            {
                FoliosController fichaServer = new FoliosController();
                Folios ficha = new Folios();
                ficha.id_proveedor = Proveedor;
                ficha.id_usuario = Usuario;
                ficha.fecha_entrada = Fecha;
                fichaServer.Post(ficha);
            }

        }


        /// <summary>
        /// 
        /// BOTONES DE NAVEGACION
        /// 
        /// </summary>


        private void btt_Shrim_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            FichaAdded = "camaron";
            CamaronFicha.Location = Fichalocation;
            PanelForm.Controls.Remove(PescadoFicha);
            PanelForm.Controls.Remove(OtrosFicha);
            PanelForm.Controls.Add(CamaronFicha);
        }

        private void bttn_fish_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            FichaAdded = "pescado";
            PescadoFicha.Location = Fichalocation;
            PanelForm.Controls.Remove(CamaronFicha);
            PanelForm.Controls.Remove(OtrosFicha);
            PanelForm.Controls.Add(PescadoFicha);

        }

        private void bttn_other_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            FichaAdded = "otros";
            OtrosFicha.Location = Fichalocation;
            PanelForm.Controls.Remove(PescadoFicha);
            PanelForm.Controls.Remove(CamaronFicha);
            PanelForm.Controls.Add(OtrosFicha);

        }


        ///
        /// Animaciones  de Navegacion
        /// 


        private Button currentBtn;
        private Panel leftBorderBtn;
        Bitmap iconCamaronColor = Properties.Resources.shrimp_Color;
        Bitmap iconCamaron = Properties.Resources.shrimp_white;
        Bitmap iconPescadoColor = Properties.Resources.fish_Color;
        Bitmap iconPescado = Properties.Resources.fish_white;
        Bitmap iconOtrosColor = Properties.Resources.seashell__1_;
        Bitmap iconOtros = Properties.Resources.seashell;

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(244, 208, 63);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton(color);
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(1, 76, 76, 76);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.ForeColor = color;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton(Color color)
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = color;
                currentBtn.BackColor = Color.FromArgb(82, 122, 242);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        /// <summary>
        /// 
        /// BOTONES DE ENVIO , CARGA Y CANCELAR
        /// 
        /// </summary>





        private void btt_Shrim_MouseHover(object sender, EventArgs e)
        {
            /*btt_Shrim.BackColor = HoverColor;*/
        }

        private void bttn_fish_MouseHover(object sender, EventArgs e)
        {
            /*bttn_fish.BackColor = HoverColor;*/

        }

        private void bttn_other_MouseHover(object sender, EventArgs e)
        {
            /*bttn_other.BackColor = HoverColor;*/

        }

        private void PanelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuFicha_Click(object sender, EventArgs e)
        {
        }



        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            
            try
            {
                int index = ListaEntrada.RowCount;

                if (FichaAdded == "camaron" && CamaronFicha.ValidationForm())
                {
                    PescadoController PescadoServise = new PescadoController();
                    Camaron camaron = CamaronFicha.GetRow(Ficha, Proveedor);
                    ListaEntrada.Rows.Insert(index, camaron.Tipo_producto, camaron.Presentacion, camaron.Cantidad);

                    if (camaron.Almacenaje == "Tienda                                            ")
                    {
                    }
                    else 
                    {
                        ListCamaron.Add(camaron);
                        ListTemp.Add(PescadoServise.ConvertToPescado(camaron));

                    }


                    CamaronFicha.Clear();

                }
                else if (FichaAdded == "pescado" && PescadoFicha.ValidationValues())
                {

                    Pescado pescado = PescadoFicha.GetProducto(Ficha, Proveedor);
                    ListaEntrada.Rows.Insert(index, pescado.Tipo_producto, pescado.Presentacion, pescado.Cantidad);
                    if (pescado.Almacenaje == "Tienda                                            ")
                    {

                    }
                    else
                    {
                        ListPescado.Add(pescado);

                    }
                    ListTemp.Add(pescado);
                    PescadoFicha.Clear();

                }
                else if (FichaAdded == "otros" && OtrosFicha.ValidationValues())
                {
                    Pescado otros = OtrosFicha.GetProducto(Ficha, Proveedor);
                    ListaEntrada.Rows.Insert(index, otros.Tipo_producto, otros.Presentacion, otros.Cantidad);
                    if (otros.Almacenaje == "Tienda                                            ")
                    {

                    }
                    else
                    {
                        ListPescado.Add(otros);

                    }

                    ListTemp.Add(otros);
                    OtrosFicha.Clear();
                }

                ListaEntrada.CurrentRow.Selected = false;
                ListaEntrada.Rows[ListaEntrada.Rows.Count-1].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de coneccion con la base de datos"+ ex);
            }

        }



        private void botonRedondo2_Click_1(object sender, EventArgs e)
        {

       

        }




        private Pescado ConvertToPescado(Camaron camaron)
        {
            Pescado pescado = new Pescado
            {
                IdProducto = camaron.IdProducto,
                FolioEntrada = camaron.FolioEntrada,
                Tipo_producto = camaron.Tipo_producto,
                Presentacion = camaron.Presentacion + " " + camaron.Medida,
                Almacenaje = camaron.Almacenaje,
                Cantidad = camaron.Cantidad,
                Kilos = camaron.Kilos

            };
            return pescado;
        }











        /// <summary>
        /// 
        /// TRASH
        /// 
        /// </summary>

        private void BanerInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lb_ficha_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ListaEntrada_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BtnEliminar.Visible = true;
            ListaEntrada.CurrentRow.Selected = true;
            Animations animations = new Animations();
            Point point = animations.BtnlocationDatagrid(ListaEntrada, 237, Cursor.Position.Y, new Point(883, 66), 12);
            BtnEliminar.Location = point;
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            ListaEntrada.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void LblIncorrecto_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            PescadoController pescadoServise = new PescadoController();
            int indexInventario = ListaEntrada.CurrentRow.Index;
            int indexCamaron=0, indexPescado=0;
            int i=0;
            foreach (Pescado element in ListTemp)
            {
                if (element.Tipo_producto == "Camaron Costa" || element.Tipo_producto == "Camaron Costa")
                {
                    indexCamaron++; 
                }
                else
                {
                    indexPescado++;
                }
                if (i >= indexInventario)
                {
                    break;
                }
                i++;
            }



            if (ListCamaron.Count>indexCamaron) 
            {
                Camaron camaron = ListCamaron[indexCamaron-1];
                ListCamaron.Remove(camaron);
                ListTemp.Remove(ListTemp[indexInventario]);
                ListaEntrada.Rows.Remove(ListaEntrada.CurrentRow);
            }
            if(ListPescado.Count>indexPescado) 
            {
                Pescado pescado = ListPescado[indexPescado-1];
                ListPescado.Remove(pescado);
                ListTemp.Remove(ListTemp[indexInventario]);
                ListaEntrada.Rows.Remove(ListaEntrada.CurrentRow);
            }
            if (Listinventarios.Count>0) 
            { 
                Inventario inventarioDelete = Listinventarios[indexInventario];
                Listinventarios.Remove(inventarioDelete);
                ListaEntrada.Rows.Remove(ListaEntrada.CurrentRow);
            }

        }

        private void PanelForm_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PanelFicha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblProveedor_Click(object sender, EventArgs e)
        {

        }

        private void LblTileFicha_Click(object sender, EventArgs e)
        {

        }

        private void CloseForm()
        {
            this.Hide();
            MenuUsuario menu = new MenuUsuario(Usuario);
            menu.Show();
        }

        private void BtnFichas_Click(object sender, EventArgs e)
        {
            bool IsEmptyCell = ValidarCelda();

            if (IsEmptyCell == true)
            {

                if (Proveedor != null && Proveedor != "")
                {
                    Folios ficha = new Folios();
                    ficha.id_proveedor = Proveedor;
                    ficha.id_usuario = Usuario;
                    ficha.fecha_entrada = Fecha;

                    FichaConfirmacion confirmacion = new FichaConfirmacion(ListCamaron, ListPescado, ListTemp, ficha, Usuario);
                    confirmacion.Usuarios = Usuario;
                    confirmacion.Reload += new FichaConfirmacion.ReloadDelegate(CloseForm);
                    confirmacion.ShowDialog();
                    PescadoFicha.Clear();
                    OtrosFicha.Clear();
                    CamaronFicha.Clear();
                }
                else
                {
                    DialogResult result = RJMessageBox.Show("Por favor asegurese de elegir un proveedor.",
           "Aviso!");
                }
            
            }
            else
            {

                DialogResult result = RJMessageBox.Show("Por favor asegurese de  no dejar celdas vacio.",
               "Aviso!");

            }

        }
        
        public bool ValidarCelda()
        {
            bool validator;
            if (ListaEntrada.RowCount>0)
            {
                validator = true;
            }
            else
            {
                validator = false;
            }

            return validator;

        }

        public void MsBox()
        {
            MessageBox.Show("lo logramos hijo de perra");
        }

        private void MenuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ListTemp.Clear();
            ListPescado.Clear();
            ListCamaron.Clear();
            ListaEntrada.Rows.Clear();
        }

        private void MenuFicha_Move(object sender, EventArgs e)
        {
            this.Location = new Point(133, 77);
        }

        private void PanelForm_Click(object sender, EventArgs e)
        {
            BtnEliminar.Visible = false;
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            MenuUsuario menu = new MenuUsuario(Usuario);
            menu.ShowDialog();
            this.Hide();
        }
    }
}

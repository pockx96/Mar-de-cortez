using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarDeCortezDsk.Styles;
using MarDeCortezDsk.UserControlls.FichasAdmin;
using MarDeCortezDsk.UserControlls.FichasConfirmacion;
using MarDeCortezDsk.Controllers;
using MarDeCortezDsk.Models;
using FontAwesome.Sharp;
using MarDeCortezDsk.UserControlls;

namespace MarDeCortezDsk.Views
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin(string usuario)
        {
            Usuario = usuario;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 64);
            MenuContainer.Controls.Add(leftBorderBtn);

        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            FichaEntradaAdd();
            ActivateButton(BtnFichas, RGBColors.color1);
            TitleUsuario.Title(Usuario);
        }

        public string Usuario { get; set; }
        public string Fecha { get; set; }
        Animations animations = new Animations();
        Point FichasLocation = new Point(100, 87);


  

        /// <summary>
        /// 
        /// Contenedores
        /// 
        /// </summary>
        /// 

        
        Ajustes ajustes = new Ajustes();
        ListaUsuarios editarUsuario = new ListaUsuarios();





        /// <summary>
        /// Boton de folios
        /// <summary>
        private void FichaEntradaAdd()
        {
            ListaFolios listaFolios = new ListaFolios(Usuario);
            listaFolios.LoadData("Pendiente");
            listaFolios.Calcular += new ListaFolios.CalcularDelegate(Calcular);
            BtnBack.Visible = false;
            listaFolios.Location = new Point(0,0);
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(listaFolios);

        }
        private void BtnFichas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            FichaEntradaAdd();

        }




        public void Calcular(string folio)
        {
            CalculadoraFichas Calculadora = new CalculadoraFichas(folio);
            Calculadora.Location = new Point(0, 0);
            Calculadora.Clear();
            Calculadora.LoadData(folio);
            Calculadora.Return += new CalculadoraFichas.ReturnDelegate(FichaEntradaAdd);
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(Calculadora);
            BtnBack.Visible = true;
        }

        /// <summary>
        /// Boton Regresar
        /// </summary>

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            FichaEntradaAdd();
        }

        /// <summary>
        /// Boton de inventario
        /// </summary>

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

            Inventarios inventarios = new Inventarios();
            inventarios.Location = new Point(140, 6);
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(inventarios);
            BtnBack.Visible = false;
        }

        /// Boton de agregar usuario

        
        private void BtnAjustes_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);

            UserConfig AggUsuario = new UserConfig() { Location = new Point(0,0)};
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(AggUsuario);
            BtnBack.Visible = false;
        }
        

        /// <summary>
        /// Boton Agregar Provedoor
        /// </summary>

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);

            MenuProveedor proveedor = new MenuProveedor() { Location = new Point(0,0) };
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(proveedor);
            BtnBack.Visible = false;

        }



        private void BtnUser_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }
        ////Boton de producto
        ///
        private void BtnProducto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);

            ProductosConfig producto = new ProductosConfig() { Location = new Point(0, 0) };
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(producto);
            BtnBack.Visible = false;
        }

        /// <summary>
        /// 
        /// Animaciones de Navegacion
        /// 
        /// </summary>

        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(1, 76, 76, 76);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(82, 122, 242);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }




        /// <summary>
        /// 
        /// Ficha de entradas
        /// 
        /// </summary>

   

     

       
        private void MenuAdmin_Move(object sender, EventArgs e)
        {
            this.Location = new Point(277,44);
        }












        private void BtnFichas_MouseHover(object sender, EventArgs e)
        {


        }

        private void PanelForm_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnInventario_MouseHover(object sender, EventArgs e)
        {


        }

        private void BtnAjustes_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnUser_MouseHover(object sender, EventArgs e)
        {


        }

        private void PanelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fichasEntrada1_Load(object sender, EventArgs e)
        {

        }



        private void MenuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleBar_Click(object sender, EventArgs e)
        {

        }
        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void ContainerBtn_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}

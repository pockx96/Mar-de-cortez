
namespace MarDeCortezDsk
{
    partial class MenuFicha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFicha));
            this.MenuContainer = new System.Windows.Forms.Panel();
            this.BtnUser = new FontAwesome.Sharp.IconButton();
            this.bttn_other = new System.Windows.Forms.Button();
            this.bttn_fish = new System.Windows.Forms.Button();
            this.btt_Shrim = new System.Windows.Forms.Button();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.ContainerFolio = new System.Windows.Forms.Panel();
            this.LblTileFicha = new System.Windows.Forms.Label();
            this.LblFicha = new System.Windows.Forms.Label();
            this.ProveedorContainer = new System.Windows.Forms.Panel();
            this.PanelForm = new MarDeCortezDsk.UserControlls.SPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnFichas = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.ListaEntrada = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEnviar = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.circularImagen1 = new MarDeCortezDsk.UserControlls.CircularImagen();
            this.MenuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.ContainerFolio.SuspendLayout();
            this.ProveedorContainer.SuspendLayout();
            this.PanelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularImagen1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.MenuContainer.Controls.Add(this.BtnUser);
            this.MenuContainer.Controls.Add(this.bttn_other);
            this.MenuContainer.Controls.Add(this.bttn_fish);
            this.MenuContainer.Controls.Add(this.btt_Shrim);
            this.MenuContainer.Location = new System.Drawing.Point(13, 132);
            this.MenuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(135, 381);
            this.MenuContainer.TabIndex = 10;
            this.MenuContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuContainer_Paint);
            // 
            // BtnUser
            // 
            this.BtnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnUser.FlatAppearance.BorderSize = 0;
            this.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnUser.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUser.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.BtnUser.IconColor = System.Drawing.Color.White;
            this.BtnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUser.IconSize = 55;
            this.BtnUser.Location = new System.Drawing.Point(-3, 277);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(135, 85);
            this.BtnUser.TabIndex = 27;
            this.BtnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUser.UseVisualStyleBackColor = false;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // bttn_other
            // 
            this.bttn_other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.bttn_other.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttn_other.FlatAppearance.BorderSize = 0;
            this.bttn_other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_other.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_other.ForeColor = System.Drawing.SystemColors.Control;
            this.bttn_other.Image = global::MarDeCortezDsk.Properties.Resources.seashell;
            this.bttn_other.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_other.Location = new System.Drawing.Point(0, 189);
            this.bttn_other.Margin = new System.Windows.Forms.Padding(0);
            this.bttn_other.Name = "bttn_other";
            this.bttn_other.Size = new System.Drawing.Size(135, 85);
            this.bttn_other.TabIndex = 4;
            this.bttn_other.Text = "   Otros";
            this.bttn_other.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttn_other.UseVisualStyleBackColor = false;
            this.bttn_other.Click += new System.EventHandler(this.bttn_other_Click);
            this.bttn_other.MouseHover += new System.EventHandler(this.bttn_other_MouseHover);
            // 
            // bttn_fish
            // 
            this.bttn_fish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.bttn_fish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttn_fish.FlatAppearance.BorderSize = 0;
            this.bttn_fish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_fish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_fish.ForeColor = System.Drawing.SystemColors.Control;
            this.bttn_fish.Image = global::MarDeCortezDsk.Properties.Resources.fish_white;
            this.bttn_fish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_fish.Location = new System.Drawing.Point(-4, 97);
            this.bttn_fish.Margin = new System.Windows.Forms.Padding(0);
            this.bttn_fish.Name = "bttn_fish";
            this.bttn_fish.Size = new System.Drawing.Size(139, 85);
            this.bttn_fish.TabIndex = 3;
            this.bttn_fish.Text = "   Pescado";
            this.bttn_fish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttn_fish.UseVisualStyleBackColor = false;
            this.bttn_fish.Click += new System.EventHandler(this.bttn_fish_Click);
            this.bttn_fish.MouseHover += new System.EventHandler(this.bttn_fish_MouseHover);
            // 
            // btt_Shrim
            // 
            this.btt_Shrim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.btt_Shrim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btt_Shrim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btt_Shrim.FlatAppearance.BorderSize = 0;
            this.btt_Shrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_Shrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Shrim.ForeColor = System.Drawing.SystemColors.Control;
            this.btt_Shrim.Image = global::MarDeCortezDsk.Properties.Resources.shrimp_white;
            this.btt_Shrim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_Shrim.Location = new System.Drawing.Point(-4, 2);
            this.btt_Shrim.Margin = new System.Windows.Forms.Padding(0);
            this.btt_Shrim.Name = "btt_Shrim";
            this.btt_Shrim.Size = new System.Drawing.Size(135, 85);
            this.btt_Shrim.TabIndex = 2;
            this.btt_Shrim.Text = "   Camarón";
            this.btt_Shrim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btt_Shrim.UseVisualStyleBackColor = false;
            this.btt_Shrim.Click += new System.EventHandler(this.btt_Shrim_Click);
            this.btt_Shrim.MouseHover += new System.EventHandler(this.btt_Shrim_MouseHover);
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblProveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.LblProveedor.Location = new System.Drawing.Point(0, 5);
            this.LblProveedor.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(0, 20);
            this.LblProveedor.TabIndex = 1;
            this.LblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblProveedor.Click += new System.EventHandler(this.LblProveedor_Click);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 30;
            this.iconPictureBox3.Location = new System.Drawing.Point(172, 22);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(30, 31);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox3.TabIndex = 14;
            this.iconPictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(909, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 31);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblFecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(36, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(95, 31);
            this.panel1.TabIndex = 13;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.LblFecha.Location = new System.Drawing.Point(0, 5);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(91, 20);
            this.LblFecha.TabIndex = 2;
            this.LblFecha.Text = "11/03/2022";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblFecha.Click += new System.EventHandler(this.label3_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconPictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 30;
            this.iconPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(30, 31);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 14;
            this.iconPictureBox2.TabStop = false;
            // 
            // ContainerFolio
            // 
            this.ContainerFolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContainerFolio.Controls.Add(this.LblTileFicha);
            this.ContainerFolio.Controls.Add(this.LblFicha);
            this.ContainerFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerFolio.ForeColor = System.Drawing.SystemColors.Control;
            this.ContainerFolio.Location = new System.Drawing.Point(796, 22);
            this.ContainerFolio.Name = "ContainerFolio";
            this.ContainerFolio.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ContainerFolio.Size = new System.Drawing.Size(92, 31);
            this.ContainerFolio.TabIndex = 8;
            this.ContainerFolio.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFicha_Paint);
            // 
            // LblTileFicha
            // 
            this.LblTileFicha.AutoSize = true;
            this.LblTileFicha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTileFicha.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblTileFicha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblTileFicha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.LblTileFicha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.LblTileFicha.Location = new System.Drawing.Point(6, 5);
            this.LblTileFicha.Margin = new System.Windows.Forms.Padding(0);
            this.LblTileFicha.Name = "LblTileFicha";
            this.LblTileFicha.Size = new System.Drawing.Size(50, 20);
            this.LblTileFicha.TabIndex = 0;
            this.LblTileFicha.Text = "Folio:";
            this.LblTileFicha.Click += new System.EventHandler(this.LblTileFicha_Click);
            // 
            // LblFicha
            // 
            this.LblFicha.AutoSize = true;
            this.LblFicha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFicha.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblFicha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblFicha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFicha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.LblFicha.Location = new System.Drawing.Point(56, 5);
            this.LblFicha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFicha.Name = "LblFicha";
            this.LblFicha.Size = new System.Drawing.Size(36, 20);
            this.LblFicha.TabIndex = 1;
            this.LblFicha.Text = "001";
            this.LblFicha.Click += new System.EventHandler(this.lb_ficha_Click);
            // 
            // ProveedorContainer
            // 
            this.ProveedorContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProveedorContainer.Controls.Add(this.LblProveedor);
            this.ProveedorContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorContainer.ForeColor = System.Drawing.SystemColors.Control;
            this.ProveedorContainer.Location = new System.Drawing.Point(208, 22);
            this.ProveedorContainer.Name = "ProveedorContainer";
            this.ProveedorContainer.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ProveedorContainer.Size = new System.Drawing.Size(225, 31);
            this.ProveedorContainer.TabIndex = 9;
            // 
            // PanelForm
            // 
            this.PanelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.PanelForm.BorderColor = System.Drawing.Color.White;
            this.PanelForm.Controls.Add(this.iconButton1);
            this.PanelForm.Controls.Add(this.BtnFichas);
            this.PanelForm.Controls.Add(this.BtnEliminar);
            this.PanelForm.Controls.Add(this.ListaEntrada);
            this.PanelForm.Controls.Add(this.BtnEnviar);
            this.PanelForm.Edge = 20;
            this.PanelForm.Location = new System.Drawing.Point(147, 56);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(924, 457);
            this.PanelForm.TabIndex = 12;
            this.PanelForm.Click += new System.EventHandler(this.PanelForm_Click);
            this.PanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelForm_Paint_1);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 38;
            this.iconButton1.Location = new System.Drawing.Point(549, 385);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(91, 40);
            this.iconButton1.TabIndex = 26;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // BtnFichas
            // 
            this.BtnFichas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.BtnFichas.FlatAppearance.BorderSize = 0;
            this.BtnFichas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFichas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFichas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFichas.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnFichas.IconColor = System.Drawing.Color.White;
            this.BtnFichas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFichas.IconSize = 38;
            this.BtnFichas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFichas.Location = new System.Drawing.Point(649, 385);
            this.BtnFichas.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFichas.Name = "BtnFichas";
            this.BtnFichas.Size = new System.Drawing.Size(229, 40);
            this.BtnFichas.TabIndex = 25;
            this.BtnFichas.Text = "Enviar";
            this.BtnFichas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFichas.UseVisualStyleBackColor = false;
            this.BtnFichas.Click += new System.EventHandler(this.BtnFichas_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 25;
            this.BtnEliminar.Location = new System.Drawing.Point(883, 66);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(34, 32);
            this.BtnEliminar.TabIndex = 24;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Visible = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // ListaEntrada
            // 
            this.ListaEntrada.AllowUserToAddRows = false;
            this.ListaEntrada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.ListaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaEntrada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListaEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(13)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.ListaEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaEntrada.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListaEntrada.EnableHeadersVisualStyles = false;
            this.ListaEntrada.Location = new System.Drawing.Point(547, 26);
            this.ListaEntrada.Name = "ListaEntrada";
            this.ListaEntrada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaEntrada.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ListaEntrada.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ListaEntrada.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaEntrada.Size = new System.Drawing.Size(330, 334);
            this.ListaEntrada.TabIndex = 9;
            this.ListaEntrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaEntrada_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo de Producto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Presentación";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.BtnEnviar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.BtnEnviar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEnviar.BorderRadius = 20;
            this.BtnEnviar.BorderSize = 0;
            this.BtnEnviar.FlatAppearance.BorderSize = 0;
            this.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.ForeColor = System.Drawing.Color.White;
            this.BtnEnviar.Location = new System.Drawing.Point(193, 385);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(150, 40);
            this.BtnEnviar.TabIndex = 10;
            this.BtnEnviar.Text = "Agregar";
            this.BtnEnviar.TextColor = System.Drawing.Color.White;
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // circularImagen1
            // 
            this.circularImagen1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularImagen1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularImagen1.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularImagen1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularImagen1.BorderSize = 2;
            this.circularImagen1.GradientAngle = 50F;
            this.circularImagen1.Image = global::MarDeCortezDsk.Properties.Resources.MicrosoftTeams_image;
            this.circularImagen1.Location = new System.Drawing.Point(13, 12);
            this.circularImagen1.Name = "circularImagen1";
            this.circularImagen1.Size = new System.Drawing.Size(113, 113);
            this.circularImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularImagen1.TabIndex = 11;
            this.circularImagen1.TabStop = false;
            // 
            // MenuFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1083, 534);
            this.Controls.Add(this.ContainerFolio);
            this.Controls.Add(this.ProveedorContainer);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.circularImagen1);
            this.Controls.Add(this.MenuContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuFicha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sea Manager";
            this.Load += new System.EventHandler(this.MenuFicha_Load);
            this.Click += new System.EventHandler(this.MenuFicha_Click);
            this.Move += new System.EventHandler(this.MenuFicha_Move);
            this.MenuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ContainerFolio.ResumeLayout(false);
            this.ContainerFolio.PerformLayout();
            this.ProveedorContainer.ResumeLayout(false);
            this.ProveedorContainer.PerformLayout();
            this.PanelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularImagen1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btt_Shrim;
        private System.Windows.Forms.Button bttn_fish;
        private System.Windows.Forms.Button bttn_other;
        private System.Windows.Forms.Panel MenuContainer;
        private UserControlls.CircularImagen circularImagen1;
        private UserControlls.SPanel PanelForm;
        private System.Windows.Forms.DataGridView ListaEntrada;
        private UserControlls.BotonRedondo BtnEnviar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblProveedor;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnFichas;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel ContainerFolio;
        private System.Windows.Forms.Label LblTileFicha;
        private System.Windows.Forms.Label LblFicha;
        private System.Windows.Forms.Panel ProveedorContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private FontAwesome.Sharp.IconButton BtnUser;
    }
}
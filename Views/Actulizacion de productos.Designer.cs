namespace MarDeCortezDsk.Views
{
    partial class Actulizacion_de_productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actulizacion_de_productos));
            this.ContainerForm = new MarDeCortezDsk.UserControlls.SPanel();
            this.BtnAgregar = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.ContainerTileBar = new MarDeCortezDsk.UserControlls.SPanel();
            this.BackButton = new FontAwesome.Sharp.IconButton();
            this.TitleBar = new FontAwesome.Sharp.IconButton();
            this.ContainerForm.SuspendLayout();
            this.ContainerTileBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContainerForm
            // 
            this.ContainerForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ContainerForm.BorderColor = System.Drawing.Color.White;
            this.ContainerForm.Controls.Add(this.BtnAgregar);
            this.ContainerForm.Controls.Add(this.ContainerTileBar);
            this.ContainerForm.Edge = 20;
            this.ContainerForm.Location = new System.Drawing.Point(14, 12);
            this.ContainerForm.Name = "ContainerForm";
            this.ContainerForm.Padding = new System.Windows.Forms.Padding(10, 75, 10, 10);
            this.ContainerForm.Size = new System.Drawing.Size(549, 536);
            this.ContainerForm.TabIndex = 14;
            this.ContainerForm.Paint += new System.Windows.Forms.PaintEventHandler(this.ContainerForm_Paint);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.BtnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.BtnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAgregar.BorderRadius = 20;
            this.BtnAgregar.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Liberation Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(27, 476);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(509, 45);
            this.BtnAgregar.TabIndex = 34;
            this.BtnAgregar.Text = "Actualizar";
            this.BtnAgregar.TextColor = System.Drawing.Color.White;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // ContainerTileBar
            // 
            this.ContainerTileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ContainerTileBar.BorderColor = System.Drawing.Color.White;
            this.ContainerTileBar.Controls.Add(this.BackButton);
            this.ContainerTileBar.Controls.Add(this.TitleBar);
            this.ContainerTileBar.Edge = 20;
            this.ContainerTileBar.Location = new System.Drawing.Point(0, 0);
            this.ContainerTileBar.Name = "ContainerTileBar";
            this.ContainerTileBar.Size = new System.Drawing.Size(555, 72);
            this.ContainerTileBar.TabIndex = 32;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackButton.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.BackButton.IconColor = System.Drawing.Color.White;
            this.BackButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BackButton.IconSize = 35;
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(47, 72);
            this.BackButton.TabIndex = 28;
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleBar.FlatAppearance.BorderSize = 0;
            this.TitleBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBar.Font = new System.Drawing.Font("Liberation Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleBar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.TitleBar.IconColor = System.Drawing.Color.White;
            this.TitleBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TitleBar.IconSize = 35;
            this.TitleBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleBar.Location = new System.Drawing.Point(129, 4);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.TitleBar.Size = new System.Drawing.Size(301, 62);
            this.TitleBar.TabIndex = 10;
            this.TitleBar.Text = "Edición";
            this.TitleBar.UseVisualStyleBackColor = false;
            // 
            // Actulizacion_de_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(575, 560);
            this.Controls.Add(this.ContainerForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Actulizacion_de_productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sea Manager";
            this.Load += new System.EventHandler(this.Actulizacion_de_productos_Load);
            this.ContainerForm.ResumeLayout(false);
            this.ContainerTileBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlls.SPanel ContainerForm;
        private UserControlls.SPanel ContainerTileBar;
        private FontAwesome.Sharp.IconButton BackButton;
        private FontAwesome.Sharp.IconButton TitleBar;
        private UserControlls.BotonRedondo BtnAgregar;
    }
}
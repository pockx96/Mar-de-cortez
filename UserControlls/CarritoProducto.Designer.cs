namespace MarDeCortezDsk.UserControlls
{
    partial class CarritoProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnFichas = new FontAwesome.Sharp.IconButton();
            this.ListaEntrada = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContainerFolio = new System.Windows.Forms.Panel();
            this.LblTileFicha = new System.Windows.Forms.Label();
            this.LblFolio = new System.Windows.Forms.Label();
            this.FormulariosContainer = new System.Windows.Forms.Panel();
            this.BtnEnviar = new MarDeCortezDsk.UserControlls.BotonRedondo();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEntrada)).BeginInit();
            this.ContainerFolio.SuspendLayout();
            this.SuspendLayout();
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
            this.iconButton1.Location = new System.Drawing.Point(519, 445);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(91, 40);
            this.iconButton1.TabIndex = 29;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
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
            this.BtnFichas.Location = new System.Drawing.Point(620, 445);
            this.BtnFichas.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFichas.Name = "BtnFichas";
            this.BtnFichas.Size = new System.Drawing.Size(229, 40);
            this.BtnFichas.TabIndex = 28;
            this.BtnFichas.Text = "Enviar";
            this.BtnFichas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFichas.UseVisualStyleBackColor = false;
            this.BtnFichas.Click += new System.EventHandler(this.BtnFichas_Click);
            // 
            // ListaEntrada
            // 
            this.ListaEntrada.AllowUserToAddRows = false;
            this.ListaEntrada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ListaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaEntrada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListaEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Liberation Sans Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaEntrada.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListaEntrada.EnableHeadersVisualStyles = false;
            this.ListaEntrada.Location = new System.Drawing.Point(546, 72);
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
            this.ListaEntrada.Size = new System.Drawing.Size(305, 334);
            this.ListaEntrada.TabIndex = 30;
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
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.Width = 85;
            // 
            // ContainerFolio
            // 
            this.ContainerFolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContainerFolio.Controls.Add(this.LblTileFicha);
            this.ContainerFolio.Controls.Add(this.LblFolio);
            this.ContainerFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerFolio.ForeColor = System.Drawing.SystemColors.Control;
            this.ContainerFolio.Location = new System.Drawing.Point(13, 3);
            this.ContainerFolio.Name = "ContainerFolio";
            this.ContainerFolio.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ContainerFolio.Size = new System.Drawing.Size(92, 31);
            this.ContainerFolio.TabIndex = 31;
            // 
            // LblTileFicha
            // 
            this.LblTileFicha.AutoSize = true;
            this.LblTileFicha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTileFicha.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblTileFicha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblTileFicha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.LblTileFicha.ForeColor = System.Drawing.Color.White;
            this.LblTileFicha.Location = new System.Drawing.Point(6, 5);
            this.LblTileFicha.Margin = new System.Windows.Forms.Padding(0);
            this.LblTileFicha.Name = "LblTileFicha";
            this.LblTileFicha.Size = new System.Drawing.Size(50, 20);
            this.LblTileFicha.TabIndex = 0;
            this.LblTileFicha.Text = "Folio:";
            // 
            // LblFolio
            // 
            this.LblFolio.AutoSize = true;
            this.LblFolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFolio.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblFolio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFolio.ForeColor = System.Drawing.Color.White;
            this.LblFolio.Location = new System.Drawing.Point(56, 5);
            this.LblFolio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFolio.Name = "LblFolio";
            this.LblFolio.Size = new System.Drawing.Size(36, 20);
            this.LblFolio.TabIndex = 1;
            this.LblFolio.Text = "001";
            // 
            // FormulariosContainer
            // 
            this.FormulariosContainer.Location = new System.Drawing.Point(3, 72);
            this.FormulariosContainer.Name = "FormulariosContainer";
            this.FormulariosContainer.Size = new System.Drawing.Size(509, 350);
            this.FormulariosContainer.TabIndex = 33;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.BtnEnviar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.BtnEnviar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEnviar.BorderRadius = 20;
            this.BtnEnviar.BorderSize = 0;
            this.BtnEnviar.FlatAppearance.BorderSize = 0;
            this.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.ForeColor = System.Drawing.Color.White;
            this.BtnEnviar.Location = new System.Drawing.Point(169, 445);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(150, 40);
            this.BtnEnviar.TabIndex = 27;
            this.BtnEnviar.Text = "Agregar";
            this.BtnEnviar.TextColor = System.Drawing.Color.White;
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // CarritoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.FormulariosContainer);
            this.Controls.Add(this.ContainerFolio);
            this.Controls.Add(this.ListaEntrada);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.BtnFichas);
            this.Controls.Add(this.BtnEnviar);
            this.Name = "CarritoProducto";
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.CarritoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaEntrada)).EndInit();
            this.ContainerFolio.ResumeLayout(false);
            this.ContainerFolio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BtnFichas;
        private BotonRedondo BtnEnviar;
        private System.Windows.Forms.DataGridView ListaEntrada;
        private System.Windows.Forms.Panel ContainerFolio;
        private System.Windows.Forms.Label LblTileFicha;
        private System.Windows.Forms.Label LblFolio;
        private System.Windows.Forms.Panel FormulariosContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    partial class CalculadoraFichas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListaEntrada = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CxU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnFichas = new FontAwesome.Sharp.IconButton();
            this.sPanel1 = new MarDeCortezDsk.UserControlls.SPanel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TitleBar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEntrada)).BeginInit();
            this.sPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaEntrada
            // 
            this.ListaEntrada.AllowUserToAddRows = false;
            this.ListaEntrada.AllowUserToResizeColumns = false;
            this.ListaEntrada.AllowUserToResizeRows = false;
            this.ListaEntrada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.ListaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaEntrada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListaEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(13)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Kilos,
            this.Column3,
            this.CxU,
            this.Total});
            this.ListaEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaEntrada.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListaEntrada.EnableHeadersVisualStyles = false;
            this.ListaEntrada.Location = new System.Drawing.Point(46, 114);
            this.ListaEntrada.Name = "ListaEntrada";
            this.ListaEntrada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaEntrada.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaEntrada.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.ListaEntrada.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ListaEntrada.RowTemplate.Height = 42;
            this.ListaEntrada.Size = new System.Drawing.Size(470, 340);
            this.ListaEntrada.TabIndex = 10;
            this.ListaEntrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaEntrada_CellContentClick);
            this.ListaEntrada.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaEntrada_CellDoubleClick);
            this.ListaEntrada.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.ListaEntrada_CellStateChanged);
            this.ListaEntrada.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaEntrada_CellValueChanged);
            this.ListaEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListaEntrada_KeyPress);
            this.ListaEntrada.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ListaEntrada_PreviewKeyDown);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Presentación";
            this.Column2.Name = "Column2";
            this.Column2.Width = 105;
            // 
            // Kilos
            // 
            this.Kilos.HeaderText = "Kilos";
            this.Kilos.Name = "Kilos";
            this.Kilos.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // CxU
            // 
            this.CxU.HeaderText = "Costo";
            this.CxU.Name = "CxU";
            this.CxU.Width = 70;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(687, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 25;
            this.BtnEliminar.Location = new System.Drawing.Point(522, 131);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(34, 32);
            this.BtnEliminar.TabIndex = 29;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(13)))), ((int)(((byte)(217)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 38;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(667, 333);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(156, 40);
            this.iconButton1.TabIndex = 31;
            this.iconButton1.Text = "Confirmar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // BtnFichas
            // 
            this.BtnFichas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(13)))), ((int)(((byte)(217)))));
            this.BtnFichas.FlatAppearance.BorderSize = 0;
            this.BtnFichas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFichas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFichas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFichas.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnFichas.IconColor = System.Drawing.Color.White;
            this.BtnFichas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFichas.IconSize = 38;
            this.BtnFichas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFichas.Location = new System.Drawing.Point(609, 333);
            this.BtnFichas.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFichas.Name = "BtnFichas";
            this.BtnFichas.Size = new System.Drawing.Size(50, 40);
            this.BtnFichas.TabIndex = 30;
            this.BtnFichas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFichas.UseVisualStyleBackColor = false;
            this.BtnFichas.Click += new System.EventHandler(this.BtnFichas_Click);
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.Controls.Add(this.LblTotal);
            this.sPanel1.Edge = 20;
            this.sPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sPanel1.Location = new System.Drawing.Point(626, 160);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(197, 74);
            this.sPanel1.TabIndex = 17;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(55, 23);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(78, 26);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "0.00 $";
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleBar.FlatAppearance.BorderSize = 0;
            this.TitleBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleBar.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.TitleBar.IconColor = System.Drawing.Color.White;
            this.TitleBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TitleBar.IconSize = 35;
            this.TitleBar.Location = new System.Drawing.Point(32, 2);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(298, 62);
            this.TitleBar.TabIndex = 35;
            this.TitleBar.Text = "Registro de folios";
            this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleBar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TitleBar.UseVisualStyleBackColor = false;
            // 
            // CalculadoraFichas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.BtnFichas);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaEntrada);
            this.Controls.Add(this.sPanel1);
            this.Name = "CalculadoraFichas";
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.CalculadoraFichas_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CalculadoraFichas_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ListaEntrada)).EndInit();
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaEntrada;
        private SPanel sPanel1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BtnFichas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CxU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private FontAwesome.Sharp.IconButton TitleBar;
    }
}

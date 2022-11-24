namespace MarDeCortezDsk.UserControlls.FichasConfirmacion
{
    partial class PescadoDatagrid
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
            this.TipoCamaron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaEntrada
            // 
            this.ListaEntrada.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoCamaron,
            this.Presentacion,
            this.Cantidad,
            this.Kilos});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaEntrada.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListaEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaEntrada.EnableHeadersVisualStyles = false;
            this.ListaEntrada.Location = new System.Drawing.Point(0, 0);
            this.ListaEntrada.Name = "ListaEntrada";
            this.ListaEntrada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
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
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.ListaEntrada.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ListaEntrada.Size = new System.Drawing.Size(585, 248);
            this.ListaEntrada.TabIndex = 11;
            this.ListaEntrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaEntrada_CellContentClick);
            // 
            // TipoCamaron
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.TipoCamaron.DefaultCellStyle = dataGridViewCellStyle2;
            this.TipoCamaron.HeaderText = "Tipo de Pescado";
            this.TipoCamaron.Name = "TipoCamaron";
            this.TipoCamaron.Width = 195;
            // 
            // Presentacion
            // 
            this.Presentacion.HeaderText = "Presentacion";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 120;
            // 
            // Kilos
            // 
            this.Kilos.HeaderText = "Kilos";
            this.Kilos.Name = "Kilos";
            this.Kilos.Width = 119;
            // 
            // PescadoDatagrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.ListaEntrada);
            this.Name = "PescadoDatagrid";
            this.Size = new System.Drawing.Size(585, 248);
            ((System.ComponentModel.ISupportInitialize)(this.ListaEntrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCamaron;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilos;
    }
}

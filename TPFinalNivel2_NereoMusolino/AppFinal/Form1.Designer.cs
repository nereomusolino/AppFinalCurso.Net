namespace AppFinal
{
    partial class FormApp
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModifcar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPapelera = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnDetallar = new System.Windows.Forms.Button();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLista.Location = new System.Drawing.Point(12, 85);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(500, 190);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.SelectionChanged += new System.EventHandler(this.dgvLista_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(53, 22);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnModifcar
            // 
            this.btnModifcar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnModifcar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifcar.Name = "btnModifcar";
            this.btnModifcar.Size = new System.Drawing.Size(62, 22);
            this.btnModifcar.Text = "Modificar";
            this.btnModifcar.Click += new System.EventHandler(this.btnModifcar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPapelera
            // 
            this.btnPapelera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPapelera.Enabled = false;
            this.btnPapelera.Image = ((System.Drawing.Image)(resources.GetObject("btnPapelera.Image")));
            this.btnPapelera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPapelera.Name = "btnPapelera";
            this.btnPapelera.Size = new System.Drawing.Size(23, 22);
            this.btnPapelera.Text = "Papelera";
            this.btnPapelera.Click += new System.EventHandler(this.btnPapelera_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.toolStripSeparator1,
            this.btnModifcar,
            this.toolStripSeparator2,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.btnPapelera});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(737, 25);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip1";
            // 
            // pbImagenes
            // 
            this.pbImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagenes.BackColor = System.Drawing.SystemColors.Control;
            this.pbImagenes.Location = new System.Drawing.Point(531, 85);
            this.pbImagenes.Name = "pbImagenes";
            this.pbImagenes.Size = new System.Drawing.Size(182, 190);
            this.pbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenes.TabIndex = 6;
            this.pbImagenes.TabStop = false;
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Location = new System.Drawing.Point(111, 45);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(239, 20);
            this.txbBusqueda.TabIndex = 7;
            this.txbBusqueda.TextChanged += new System.EventHandler(this.txbBusqueda_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(12, 48);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(93, 13);
            this.lblBuscar.TabIndex = 9;
            this.lblBuscar.Text = "Busqueda rapida: ";
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Location = new System.Drawing.Point(67, 87);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 11;
            this.cmbCampo.Visible = false;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Location = new System.Drawing.Point(253, 87);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterio.TabIndex = 12;
            this.cmbCriterio.Visible = false;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(14, 90);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 13;
            this.lblCampo.Text = "Campo:";
            this.lblCampo.Visible = false;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(207, 91);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 14;
            this.lblCriterio.Text = "Criterio:";
            this.lblCriterio.Visible = false;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(402, 91);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 15;
            this.lblFiltro.Text = "Filtro:";
            this.lblFiltro.Visible = false;
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(111, 327);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(138, 24);
            this.btnBusquedaAvanzada.TabIndex = 16;
            this.btnBusquedaAvanzada.Text = "Busqueda Avanzada";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(559, 87);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 21);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(650, 88);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(23, 20);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "↑";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnDetallar
            // 
            this.btnDetallar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetallar.Location = new System.Drawing.Point(12, 327);
            this.btnDetallar.Name = "btnDetallar";
            this.btnDetallar.Size = new System.Drawing.Size(93, 24);
            this.btnDetallar.TabIndex = 19;
            this.btnDetallar.Text = "Ver Detalles";
            this.btnDetallar.UseVisualStyleBackColor = true;
            this.btnDetallar.Click += new System.EventHandler(this.btnDetallar_Click);
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(440, 88);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(100, 20);
            this.txbFiltro.TabIndex = 8;
            this.txbFiltro.Visible = false;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 363);
            this.Controls.Add(this.btnDetallar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBusquedaAvanzada);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cmbCriterio);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.pbImagenes);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dgvLista);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(753, 479);
            this.MinimumSize = new System.Drawing.Size(753, 402);
            this.Name = "FormApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Articulos";
            this.Load += new System.EventHandler(this.FormApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModifcar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnPapelera;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.PictureBox pbImagenes;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnDetallar;
        private System.Windows.Forms.TextBox txbFiltro;
    }
}


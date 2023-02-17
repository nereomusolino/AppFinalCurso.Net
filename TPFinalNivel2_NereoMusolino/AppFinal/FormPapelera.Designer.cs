namespace AppFinal
{
    partial class FormPapelera
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
            this.dgvPapelera = new System.Windows.Forms.DataGridView();
            this.pbxPapelera = new System.Windows.Forms.PictureBox();
            this.EliminarFisicamente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPapelera)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPapelera
            // 
            this.dgvPapelera.AllowDrop = true;
            this.dgvPapelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPapelera.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPapelera.Location = new System.Drawing.Point(24, 22);
            this.dgvPapelera.Name = "dgvPapelera";
            this.dgvPapelera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPapelera.Size = new System.Drawing.Size(430, 206);
            this.dgvPapelera.TabIndex = 0;
            // 
            // pbxPapelera
            // 
            this.pbxPapelera.Location = new System.Drawing.Point(460, 22);
            this.pbxPapelera.Name = "pbxPapelera";
            this.pbxPapelera.Size = new System.Drawing.Size(179, 206);
            this.pbxPapelera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPapelera.TabIndex = 1;
            this.pbxPapelera.TabStop = false;
            // 
            // EliminarFisicamente
            // 
            this.EliminarFisicamente.Location = new System.Drawing.Point(24, 235);
            this.EliminarFisicamente.Name = "EliminarFisicamente";
            this.EliminarFisicamente.Size = new System.Drawing.Size(94, 31);
            this.EliminarFisicamente.TabIndex = 2;
            this.EliminarFisicamente.Text = "Eliminar";
            this.EliminarFisicamente.UseVisualStyleBackColor = true;
            this.EliminarFisicamente.Click += new System.EventHandler(this.EliminarFisicamente_Click);
            // 
            // FormPapelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 298);
            this.Controls.Add(this.EliminarFisicamente);
            this.Controls.Add(this.pbxPapelera);
            this.Controls.Add(this.dgvPapelera);
            this.Name = "FormPapelera";
            this.Text = "Papelera";
            this.Load += new System.EventHandler(this.Papelera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPapelera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPapelera;
        private System.Windows.Forms.PictureBox pbxPapelera;
        private System.Windows.Forms.Button EliminarFisicamente;
    }
}
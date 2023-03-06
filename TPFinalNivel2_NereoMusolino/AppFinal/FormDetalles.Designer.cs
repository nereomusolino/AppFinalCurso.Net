namespace AppFinal
{
    partial class FormDetalles
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
            this.pbDetalles = new System.Windows.Forms.PictureBox();
            this.lvDetalles = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDetalles
            // 
            this.pbDetalles.Location = new System.Drawing.Point(298, 39);
            this.pbDetalles.Name = "pbDetalles";
            this.pbDetalles.Size = new System.Drawing.Size(159, 157);
            this.pbDetalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDetalles.TabIndex = 1;
            this.pbDetalles.TabStop = false;
            // 
            // lvDetalles
            // 
            this.lvDetalles.HideSelection = false;
            this.lvDetalles.Location = new System.Drawing.Point(42, 39);
            this.lvDetalles.Name = "lvDetalles";
            this.lvDetalles.Size = new System.Drawing.Size(250, 157);
            this.lvDetalles.TabIndex = 2;
            this.lvDetalles.UseCompatibleStateImageBehavior = false;
            this.lvDetalles.View = System.Windows.Forms.View.List;
            // 
            // FormDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 243);
            this.Controls.Add(this.lvDetalles);
            this.Controls.Add(this.pbDetalles);
            this.Name = "FormDetalles";
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.FormDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDetalles;
        private System.Windows.Forms.ListView lvDetalles;
    }
}
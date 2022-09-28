namespace pryMoralesSP1H1
{
    partial class frmLocalidades
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
            this.lblNombreLoc = new System.Windows.Forms.Label();
            this.lblIDLoc = new System.Windows.Forms.Label();
            this.lblTituloLoc = new System.Windows.Forms.Label();
            this.txtNombreLoc = new System.Windows.Forms.TextBox();
            this.btnCargarLoc = new System.Windows.Forms.Button();
            this.mskIDLoc = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblNombreLoc
            // 
            this.lblNombreLoc.AutoSize = true;
            this.lblNombreLoc.Location = new System.Drawing.Point(19, 116);
            this.lblNombreLoc.Name = "lblNombreLoc";
            this.lblNombreLoc.Size = new System.Drawing.Size(163, 20);
            this.lblNombreLoc.TabIndex = 4;
            this.lblNombreLoc.Text = "Nombre de Localidad:";
            // 
            // lblIDLoc
            // 
            this.lblIDLoc.AutoSize = true;
            this.lblIDLoc.Location = new System.Drawing.Point(19, 76);
            this.lblIDLoc.Name = "lblIDLoc";
            this.lblIDLoc.Size = new System.Drawing.Size(161, 20);
            this.lblIDLoc.TabIndex = 3;
            this.lblIDLoc.Text = "Número Identificador:";
            // 
            // lblTituloLoc
            // 
            this.lblTituloLoc.AutoSize = true;
            this.lblTituloLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.lblTituloLoc.Location = new System.Drawing.Point(71, 21);
            this.lblTituloLoc.Name = "lblTituloLoc";
            this.lblTituloLoc.Size = new System.Drawing.Size(223, 30);
            this.lblTituloLoc.TabIndex = 5;
            this.lblTituloLoc.Text = "Ingrese los datos";
            // 
            // txtNombreLoc
            // 
            this.txtNombreLoc.Location = new System.Drawing.Point(200, 116);
            this.txtNombreLoc.Name = "txtNombreLoc";
            this.txtNombreLoc.Size = new System.Drawing.Size(152, 26);
            this.txtNombreLoc.TabIndex = 2;
            // 
            // btnCargarLoc
            // 
            this.btnCargarLoc.Location = new System.Drawing.Point(277, 161);
            this.btnCargarLoc.Name = "btnCargarLoc";
            this.btnCargarLoc.Size = new System.Drawing.Size(75, 30);
            this.btnCargarLoc.TabIndex = 3;
            this.btnCargarLoc.Text = "Cargar";
            this.btnCargarLoc.UseVisualStyleBackColor = true;
            this.btnCargarLoc.Click += new System.EventHandler(this.btnCargarLoc_Click);
            // 
            // mskIDLoc
            // 
            this.mskIDLoc.Location = new System.Drawing.Point(200, 70);
            this.mskIDLoc.Mask = "99999";
            this.mskIDLoc.Name = "mskIDLoc";
            this.mskIDLoc.Size = new System.Drawing.Size(94, 26);
            this.mskIDLoc.TabIndex = 1;
            this.mskIDLoc.ValidatingType = typeof(int);
            // 
            // frmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 210);
            this.Controls.Add(this.mskIDLoc);
            this.Controls.Add(this.btnCargarLoc);
            this.Controls.Add(this.txtNombreLoc);
            this.Controls.Add(this.lblTituloLoc);
            this.Controls.Add(this.lblNombreLoc);
            this.Controls.Add(this.lblIDLoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLocalidades";
            this.Text = "frmLocalidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreLoc;
        private System.Windows.Forms.Label lblIDLoc;
        private System.Windows.Forms.Label lblTituloLoc;
        private System.Windows.Forms.TextBox txtNombreLoc;
        private System.Windows.Forms.Button btnCargarLoc;
        private System.Windows.Forms.MaskedTextBox mskIDLoc;
    }
}
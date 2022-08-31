namespace pryMoralesSP1H1
{
    partial class frmProduccion
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
            this.cboNombreCulPro = new System.Windows.Forms.ComboBox();
            this.cboNombreLocPro = new System.Windows.Forms.ComboBox();
            this.mskToneladaPro = new System.Windows.Forms.MaskedTextBox();
            this.btnCargarPro = new System.Windows.Forms.Button();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.lblNombreCulPro = new System.Windows.Forms.Label();
            this.lblTituloLoc = new System.Windows.Forms.Label();
            this.lblNombreLocPro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboNombreCulPro
            // 
            this.cboNombreCulPro.FormattingEnabled = true;
            this.cboNombreCulPro.Location = new System.Drawing.Point(205, 116);
            this.cboNombreCulPro.Name = "cboNombreCulPro";
            this.cboNombreCulPro.Size = new System.Drawing.Size(152, 28);
            this.cboNombreCulPro.TabIndex = 28;
            // 
            // cboNombreLocPro
            // 
            this.cboNombreLocPro.FormattingEnabled = true;
            this.cboNombreLocPro.Location = new System.Drawing.Point(205, 70);
            this.cboNombreLocPro.Name = "cboNombreLocPro";
            this.cboNombreLocPro.Size = new System.Drawing.Size(152, 28);
            this.cboNombreLocPro.TabIndex = 27;
            // 
            // mskToneladaPro
            // 
            this.mskToneladaPro.Location = new System.Drawing.Point(205, 159);
            this.mskToneladaPro.Mask = "99999";
            this.mskToneladaPro.Name = "mskToneladaPro";
            this.mskToneladaPro.Size = new System.Drawing.Size(97, 26);
            this.mskToneladaPro.TabIndex = 26;
            this.mskToneladaPro.ValidatingType = typeof(int);
            // 
            // btnCargarPro
            // 
            this.btnCargarPro.Location = new System.Drawing.Point(282, 203);
            this.btnCargarPro.Name = "btnCargarPro";
            this.btnCargarPro.Size = new System.Drawing.Size(75, 30);
            this.btnCargarPro.TabIndex = 25;
            this.btnCargarPro.Text = "Cargar";
            this.btnCargarPro.UseVisualStyleBackColor = true;
            this.btnCargarPro.Click += new System.EventHandler(this.btnCargarPro_Click);
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Location = new System.Drawing.Point(21, 162);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(170, 20);
            this.lblToneladas.TabIndex = 24;
            this.lblToneladas.Text = "Toneladas Producidas:";
            // 
            // lblNombreCulPro
            // 
            this.lblNombreCulPro.AutoSize = true;
            this.lblNombreCulPro.Location = new System.Drawing.Point(21, 119);
            this.lblNombreCulPro.Name = "lblNombreCulPro";
            this.lblNombreCulPro.Size = new System.Drawing.Size(142, 20);
            this.lblNombreCulPro.TabIndex = 23;
            this.lblNombreCulPro.Text = "Nombre de Cultivo:";
            // 
            // lblTituloLoc
            // 
            this.lblTituloLoc.AutoSize = true;
            this.lblTituloLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.lblTituloLoc.Location = new System.Drawing.Point(67, 17);
            this.lblTituloLoc.Name = "lblTituloLoc";
            this.lblTituloLoc.Size = new System.Drawing.Size(223, 30);
            this.lblTituloLoc.TabIndex = 22;
            this.lblTituloLoc.Text = "Ingrese los datos";
            // 
            // lblNombreLocPro
            // 
            this.lblNombreLocPro.AutoSize = true;
            this.lblNombreLocPro.Location = new System.Drawing.Point(21, 73);
            this.lblNombreLocPro.Name = "lblNombreLocPro";
            this.lblNombreLocPro.Size = new System.Drawing.Size(163, 20);
            this.lblNombreLocPro.TabIndex = 21;
            this.lblNombreLocPro.Text = "Nombre de Localidad:";
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.cboNombreCulPro);
            this.Controls.Add(this.cboNombreLocPro);
            this.Controls.Add(this.mskToneladaPro);
            this.Controls.Add(this.btnCargarPro);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.lblNombreCulPro);
            this.Controls.Add(this.lblTituloLoc);
            this.Controls.Add(this.lblNombreLocPro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProduccion";
            this.Text = "frmProduccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNombreCulPro;
        private System.Windows.Forms.ComboBox cboNombreLocPro;
        private System.Windows.Forms.MaskedTextBox mskToneladaPro;
        private System.Windows.Forms.Button btnCargarPro;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.Label lblNombreCulPro;
        private System.Windows.Forms.Label lblTituloLoc;
        private System.Windows.Forms.Label lblNombreLocPro;
    }
}
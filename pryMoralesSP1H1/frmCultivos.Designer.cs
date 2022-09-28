namespace pryMoralesSP1H1
{
    partial class frmCultivos
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
            this.txtNombreCul = new System.Windows.Forms.TextBox();
            this.lblTituloCul = new System.Windows.Forms.Label();
            this.lblNombreCul = new System.Windows.Forms.Label();
            this.lblIDCul = new System.Windows.Forms.Label();
            this.btnCargarCul = new System.Windows.Forms.Button();
            this.mskIDCul = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtNombreCul
            // 
            this.txtNombreCul.Location = new System.Drawing.Point(198, 116);
            this.txtNombreCul.Name = "txtNombreCul";
            this.txtNombreCul.Size = new System.Drawing.Size(152, 26);
            this.txtNombreCul.TabIndex = 2;
            // 
            // lblTituloCul
            // 
            this.lblTituloCul.AutoSize = true;
            this.lblTituloCul.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.lblTituloCul.Location = new System.Drawing.Point(72, 21);
            this.lblTituloCul.Name = "lblTituloCul";
            this.lblTituloCul.Size = new System.Drawing.Size(223, 30);
            this.lblTituloCul.TabIndex = 10;
            this.lblTituloCul.Text = "Ingrese los datos";
            // 
            // lblNombreCul
            // 
            this.lblNombreCul.AutoSize = true;
            this.lblNombreCul.Location = new System.Drawing.Point(20, 116);
            this.lblNombreCul.Name = "lblNombreCul";
            this.lblNombreCul.Size = new System.Drawing.Size(142, 20);
            this.lblNombreCul.TabIndex = 9;
            this.lblNombreCul.Text = "Nombre de Cultivo:";
            // 
            // lblIDCul
            // 
            this.lblIDCul.AutoSize = true;
            this.lblIDCul.Location = new System.Drawing.Point(20, 76);
            this.lblIDCul.Name = "lblIDCul";
            this.lblIDCul.Size = new System.Drawing.Size(161, 20);
            this.lblIDCul.TabIndex = 8;
            this.lblIDCul.Text = "Número Identificador:";
            // 
            // btnCargarCul
            // 
            this.btnCargarCul.Location = new System.Drawing.Point(275, 160);
            this.btnCargarCul.Name = "btnCargarCul";
            this.btnCargarCul.Size = new System.Drawing.Size(75, 30);
            this.btnCargarCul.TabIndex = 3;
            this.btnCargarCul.Text = "Cargar";
            this.btnCargarCul.UseVisualStyleBackColor = true;
            this.btnCargarCul.Click += new System.EventHandler(this.btnCargarCul_Click);
            // 
            // mskIDCul
            // 
            this.mskIDCul.Location = new System.Drawing.Point(198, 73);
            this.mskIDCul.Mask = "99999";
            this.mskIDCul.Name = "mskIDCul";
            this.mskIDCul.Size = new System.Drawing.Size(97, 26);
            this.mskIDCul.TabIndex = 1;
            this.mskIDCul.ValidatingType = typeof(int);
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 210);
            this.Controls.Add(this.mskIDCul);
            this.Controls.Add(this.btnCargarCul);
            this.Controls.Add(this.txtNombreCul);
            this.Controls.Add(this.lblTituloCul);
            this.Controls.Add(this.lblNombreCul);
            this.Controls.Add(this.lblIDCul);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCultivos";
            this.Text = "frmCultivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCul;
        private System.Windows.Forms.Label lblTituloCul;
        private System.Windows.Forms.Label lblNombreCul;
        private System.Windows.Forms.Label lblIDCul;
        private System.Windows.Forms.Button btnCargarCul;
        private System.Windows.Forms.MaskedTextBox mskIDCul;
    }
}
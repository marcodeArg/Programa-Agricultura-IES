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
            this.txtNombreLoc = new System.Windows.Forms.TextBox();
            this.lblTituloLoc = new System.Windows.Forms.Label();
            this.lblNombreLoc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreLoc
            // 
            this.txtNombreLoc.Location = new System.Drawing.Point(208, 76);
            this.txtNombreLoc.Name = "txtNombreLoc";
            this.txtNombreLoc.Size = new System.Drawing.Size(152, 26);
            this.txtNombreLoc.TabIndex = 12;
            // 
            // lblTituloLoc
            // 
            this.lblTituloLoc.AutoSize = true;
            this.lblTituloLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.lblTituloLoc.Location = new System.Drawing.Point(70, 20);
            this.lblTituloLoc.Name = "lblTituloLoc";
            this.lblTituloLoc.Size = new System.Drawing.Size(223, 30);
            this.lblTituloLoc.TabIndex = 10;
            this.lblTituloLoc.Text = "Ingrese los datos";
            // 
            // lblNombreLoc
            // 
            this.lblNombreLoc.AutoSize = true;
            this.lblNombreLoc.Location = new System.Drawing.Point(24, 76);
            this.lblNombreLoc.Name = "lblNombreLoc";
            this.lblNombreLoc.Size = new System.Drawing.Size(163, 20);
            this.lblNombreLoc.TabIndex = 9;
            this.lblNombreLoc.Text = "Nombre de Localidad:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 26);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre de Cultivo:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 26);
            this.textBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Toneladas Producidas:";
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 379);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreLoc);
            this.Controls.Add(this.lblTituloLoc);
            this.Controls.Add(this.lblNombreLoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProduccion";
            this.Text = "frmProduccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreLoc;
        private System.Windows.Forms.Label lblTituloLoc;
        private System.Windows.Forms.Label lblNombreLoc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}
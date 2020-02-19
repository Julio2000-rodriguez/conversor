namespace conversor
{
    partial class Form1
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
            this.cboD = new System.Windows.Forms.ComboBox();
            this.cboW = new System.Windows.Forms.ComboBox();
            this.cboEscoger = new System.Windows.Forms.ComboBox();
            this.txtCifra = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.btnConversor = new System.Windows.Forms.Button();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboD
            // 
            this.cboD.FormattingEnabled = true;
            this.cboD.Location = new System.Drawing.Point(221, 90);
            this.cboD.Name = "cboD";
            this.cboD.Size = new System.Drawing.Size(121, 21);
            this.cboD.TabIndex = 0;
            // 
            // cboW
            // 
            this.cboW.FormattingEnabled = true;
            this.cboW.Location = new System.Drawing.Point(221, 228);
            this.cboW.Name = "cboW";
            this.cboW.Size = new System.Drawing.Size(121, 21);
            this.cboW.TabIndex = 1;
            // 
            // cboEscoger
            // 
            this.cboEscoger.FormattingEnabled = true;
            this.cboEscoger.Location = new System.Drawing.Point(12, 108);
            this.cboEscoger.Name = "cboEscoger";
            this.cboEscoger.Size = new System.Drawing.Size(121, 21);
            this.cboEscoger.TabIndex = 2;
            this.cboEscoger.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // txtCifra
            // 
            this.txtCifra.Location = new System.Drawing.Point(230, 152);
            this.txtCifra.Name = "txtCifra";
            this.txtCifra.Size = new System.Drawing.Size(100, 20);
            this.txtCifra.TabIndex = 3;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(55, 212);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(35, 13);
            this.lblR.TabIndex = 4;
            this.lblR.Text = "label1";
            // 
            // btnConversor
            // 
            this.btnConversor.Location = new System.Drawing.Point(32, 186);
            this.btnConversor.Name = "btnConversor";
            this.btnConversor.Size = new System.Drawing.Size(75, 23);
            this.btnConversor.TabIndex = 5;
            this.btnConversor.Text = "PUSH";
            this.btnConversor.UseVisualStyleBackColor = true;
            this.btnConversor.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConversor.Location = new System.Drawing.Point(69, 18);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(211, 33);
            this.lblTipoConversor.TabIndex = 6;
            this.lblTipoConversor.Text = "CONVERSOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CONVERTIR ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CONVERTIR A ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "TIPOS DE CONVERSOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(374, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTipoConversor);
            this.Controls.Add(this.btnConversor);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtCifra);
            this.Controls.Add(this.cboEscoger);
            this.Controls.Add(this.cboW);
            this.Controls.Add(this.cboD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboD;
        private System.Windows.Forms.ComboBox cboW;
        private System.Windows.Forms.ComboBox cboEscoger;
        private System.Windows.Forms.TextBox txtCifra;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Button btnConversor;
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


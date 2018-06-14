namespace Programacion
{
    partial class Sesion3
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
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.gbOperacion = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnPor = new System.Windows.Forms.Button();
            this.btnEntre = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbOperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(10, 28);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(85, 34);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(119, 28);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(85, 34);
            this.btnResta.TabIndex = 2;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(234, 28);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(85, 34);
            this.btnMulti.TabIndex = 3;
            this.btnMulti.Text = "Multiplicación";
            this.btnMulti.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(343, 28);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(85, 34);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "División";
            this.btnDivide.UseVisualStyleBackColor = true;
            // 
            // gbOperacion
            // 
            this.gbOperacion.Controls.Add(this.btnDivide);
            this.gbOperacion.Controls.Add(this.btnMulti);
            this.gbOperacion.Controls.Add(this.btnResta);
            this.gbOperacion.Controls.Add(this.btnSuma);
            this.gbOperacion.Location = new System.Drawing.Point(12, 12);
            this.gbOperacion.Name = "gbOperacion";
            this.gbOperacion.Size = new System.Drawing.Size(441, 79);
            this.gbOperacion.TabIndex = 5;
            this.gbOperacion.TabStop = false;
            this.gbOperacion.Text = "¿QUÉ OPERACIÓN DESEA REALIZAR?";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(255, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 34);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(219, 107);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 20);
            this.tbNumero.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(165, 110);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(47, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Número:";
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(219, 142);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(30, 30);
            this.btnMas.TabIndex = 2;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(138, 189);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 3;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(219, 191);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(100, 20);
            this.tbResultado.TabIndex = 4;
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(264, 142);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(30, 30);
            this.btnMenos.TabIndex = 6;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Visible = false;
            // 
            // btnPor
            // 
            this.btnPor.Location = new System.Drawing.Point(310, 142);
            this.btnPor.Name = "btnPor";
            this.btnPor.Size = new System.Drawing.Size(30, 30);
            this.btnPor.TabIndex = 7;
            this.btnPor.Text = "*";
            this.btnPor.UseVisualStyleBackColor = true;
            this.btnPor.Visible = false;
            // 
            // btnEntre
            // 
            this.btnEntre.Location = new System.Drawing.Point(355, 142);
            this.btnEntre.Name = "btnEntre";
            this.btnEntre.Size = new System.Drawing.Size(30, 30);
            this.btnEntre.TabIndex = 8;
            this.btnEntre.Text = "/";
            this.btnEntre.UseVisualStyleBackColor = true;
            this.btnEntre.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(147, 232);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 34);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Sesion3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 278);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEntre);
            this.Controls.Add(this.btnPor);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label);
            this.Controls.Add(this.gbOperacion);
            this.Controls.Add(this.tbNumero);
            this.Name = "Sesion3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesion3";
            this.Load += new System.EventHandler(this.Sesion3_Load);
            this.gbOperacion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.GroupBox gbOperacion;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnPor;
        private System.Windows.Forms.Button btnEntre;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
namespace Curso
{
    partial class Sesion1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lGradosC = new System.Windows.Forms.Label();
            this.tbGradosC = new System.Windows.Forms.TextBox();
            this.lGradosF = new System.Windows.Forms.Label();
            this.tbGradosF = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversión de Temperaturas.";
            // 
            // lGradosC
            // 
            this.lGradosC.AutoSize = true;
            this.lGradosC.Location = new System.Drawing.Point(22, 78);
            this.lGradosC.Name = "lGradosC";
            this.lGradosC.Size = new System.Drawing.Size(105, 13);
            this.lGradosC.TabIndex = 1;
            this.lGradosC.Text = "Grados Centígrados:";
            // 
            // tbGradosC
            // 
            this.tbGradosC.Location = new System.Drawing.Point(142, 75);
            this.tbGradosC.Name = "tbGradosC";
            this.tbGradosC.Size = new System.Drawing.Size(146, 20);
            this.tbGradosC.TabIndex = 2;
            this.tbGradosC.Text = "0.00";
            this.tbGradosC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGradosC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGradosC_KeyPress);
            // 
            // lGradosF
            // 
            this.lGradosF.AutoSize = true;
            this.lGradosF.Location = new System.Drawing.Point(22, 122);
            this.lGradosF.Name = "lGradosF";
            this.lGradosF.Size = new System.Drawing.Size(97, 13);
            this.lGradosF.TabIndex = 3;
            this.lGradosF.Text = "Grados Fahrenheit:";
            // 
            // tbGradosF
            // 
            this.tbGradosF.Location = new System.Drawing.Point(142, 119);
            this.tbGradosF.Name = "tbGradosF";
            this.tbGradosF.Size = new System.Drawing.Size(146, 20);
            this.tbGradosF.TabIndex = 4;
            this.tbGradosF.Text = "32.00";
            this.tbGradosF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGradosF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGradosF_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(67, 163);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 36);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(163, 163);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Sesion1
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(325, 211);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbGradosF);
            this.Controls.Add(this.lGradosF);
            this.Controls.Add(this.tbGradosC);
            this.Controls.Add(this.lGradosC);
            this.Controls.Add(this.label1);
            this.Name = "Sesion1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesión UNO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lGradosC;
        private System.Windows.Forms.TextBox tbGradosC;
        private System.Windows.Forms.Label lGradosF;
        private System.Windows.Forms.TextBox tbGradosF;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
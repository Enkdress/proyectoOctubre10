namespace VISTA.PROYECTO
{
    partial class VCalculadora
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
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnMayor = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnAbsoluto = new System.Windows.Forms.Button();
            this.btnSerie1 = new System.Windows.Forms.Button();
            this.btnSumatoria = new System.Windows.Forms.Button();
            this.btnSerie2 = new System.Windows.Forms.Button();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuma.ForeColor = System.Drawing.Color.White;
            this.btnSuma.Location = new System.Drawing.Point(352, 135);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(119, 38);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(160, 187);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(125, 27);
            this.txtNumber2.TabIndex = 2;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(160, 135);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(125, 27);
            this.txtNumber1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Segundo número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Primer número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultado:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.LightGreen;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(190, 354);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 7;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Silver;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(21, 404);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(76, 34);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPotencia.ForeColor = System.Drawing.Color.White;
            this.btnPotencia.Location = new System.Drawing.Point(602, 135);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(119, 38);
            this.btnPotencia.TabIndex = 1;
            this.btnPotencia.Text = "Potencia ";
            this.btnPotencia.UseVisualStyleBackColor = false;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModulo.ForeColor = System.Drawing.Color.White;
            this.btnModulo.Location = new System.Drawing.Point(477, 135);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(119, 38);
            this.btnModulo.TabIndex = 1;
            this.btnModulo.Text = "Módulo";
            this.btnModulo.UseVisualStyleBackColor = false;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnMayor
            // 
            this.btnMayor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMayor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMayor.ForeColor = System.Drawing.Color.White;
            this.btnMayor.Location = new System.Drawing.Point(352, 187);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(119, 38);
            this.btnMayor.TabIndex = 1;
            this.btnMayor.Text = "El mayor";
            this.btnMayor.UseVisualStyleBackColor = false;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactorial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFactorial.ForeColor = System.Drawing.Color.White;
            this.btnFactorial.Location = new System.Drawing.Point(352, 242);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(119, 38);
            this.btnFactorial.TabIndex = 1;
            this.btnFactorial.Text = "Factorial";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnAbsoluto
            // 
            this.btnAbsoluto.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAbsoluto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsoluto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbsoluto.ForeColor = System.Drawing.Color.White;
            this.btnAbsoluto.Location = new System.Drawing.Point(477, 299);
            this.btnAbsoluto.Name = "btnAbsoluto";
            this.btnAbsoluto.Size = new System.Drawing.Size(119, 57);
            this.btnAbsoluto.TabIndex = 1;
            this.btnAbsoluto.Text = "Valor absoluto";
            this.btnAbsoluto.UseVisualStyleBackColor = false;
            this.btnAbsoluto.Click += new System.EventHandler(this.btnAbsoluto_Click);
            // 
            // btnSerie1
            // 
            this.btnSerie1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSerie1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerie1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSerie1.ForeColor = System.Drawing.Color.White;
            this.btnSerie1.Location = new System.Drawing.Point(477, 187);
            this.btnSerie1.Name = "btnSerie1";
            this.btnSerie1.Size = new System.Drawing.Size(119, 38);
            this.btnSerie1.TabIndex = 1;
            this.btnSerie1.Text = "Serie 1";
            this.btnSerie1.UseVisualStyleBackColor = false;
            this.btnSerie1.Click += new System.EventHandler(this.btnSerie1_Click);
            // 
            // btnSumatoria
            // 
            this.btnSumatoria.AutoSize = true;
            this.btnSumatoria.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSumatoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumatoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSumatoria.ForeColor = System.Drawing.Color.White;
            this.btnSumatoria.Location = new System.Drawing.Point(602, 242);
            this.btnSumatoria.Name = "btnSumatoria";
            this.btnSumatoria.Size = new System.Drawing.Size(119, 38);
            this.btnSumatoria.TabIndex = 1;
            this.btnSumatoria.Text = "Sumatoria";
            this.btnSumatoria.UseVisualStyleBackColor = false;
            this.btnSumatoria.Click += new System.EventHandler(this.btnSumatoria_Click);
            // 
            // btnSerie2
            // 
            this.btnSerie2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSerie2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerie2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSerie2.ForeColor = System.Drawing.Color.White;
            this.btnSerie2.Location = new System.Drawing.Point(602, 187);
            this.btnSerie2.Name = "btnSerie2";
            this.btnSerie2.Size = new System.Drawing.Size(119, 38);
            this.btnSerie2.TabIndex = 1;
            this.btnSerie2.Text = "Serie 2";
            this.btnSerie2.UseVisualStyleBackColor = false;
            this.btnSerie2.Click += new System.EventHandler(this.btnSerie2_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.AutoSize = true;
            this.btnAleatorio.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAleatorio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAleatorio.ForeColor = System.Drawing.Color.White;
            this.btnAleatorio.Location = new System.Drawing.Point(477, 242);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(119, 38);
            this.btnAleatorio.TabIndex = 1;
            this.btnAleatorio.Text = "Aleatorio fácil";
            this.btnAleatorio.UseVisualStyleBackColor = false;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // VCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.btnSerie2);
            this.Controls.Add(this.btnSumatoria);
            this.Controls.Add(this.btnSerie1);
            this.Controls.Add(this.btnAbsoluto);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.label1);
            this.Name = "VCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnAbsoluto;
        private System.Windows.Forms.Button btnSerie1;
        private System.Windows.Forms.Button btnSumatoria;
        private System.Windows.Forms.Button btnSerie2;
        private System.Windows.Forms.Button btnAleatorio;
    }
}
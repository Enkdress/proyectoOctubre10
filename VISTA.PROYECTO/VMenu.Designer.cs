namespace VISTA.PROYECTO
{
    partial class VMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnAcercade = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(135, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalculadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculadora.ForeColor = System.Drawing.Color.White;
            this.btnCalculadora.Location = new System.Drawing.Point(134, 170);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(144, 42);
            this.btnCalculadora.TabIndex = 1;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = false;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnAcercade
            // 
            this.btnAcercade.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAcercade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcercade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAcercade.ForeColor = System.Drawing.Color.White;
            this.btnAcercade.Location = new System.Drawing.Point(142, 232);
            this.btnAcercade.Name = "btnAcercade";
            this.btnAcercade.Size = new System.Drawing.Size(128, 42);
            this.btnAcercade.TabIndex = 2;
            this.btnAcercade.Text = "Acerca de";
            this.btnAcercade.UseVisualStyleBackColor = false;
            this.btnAcercade.Click += new System.EventHandler(this.btnAcercade_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Coral;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(159, 341);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // VMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAcercade);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.label1);
            this.Name = "VMenu";
            this.Text = "Menu principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnAcercade;
        private System.Windows.Forms.Button btnSalir;
    }
}


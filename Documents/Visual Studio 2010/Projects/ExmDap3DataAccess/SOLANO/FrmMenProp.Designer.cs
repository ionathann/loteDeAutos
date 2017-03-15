namespace SOLANO
{
    partial class FrmMenProp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlumnoActualizar = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblVariableUsuario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAlumnoActualizar);
            this.groupBox1.Controls.Add(this.btnVenta);
            this.groupBox1.Location = new System.Drawing.Point(61, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 109);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SOLANO";
            // 
            // btnAlumnoActualizar
            // 
            this.btnAlumnoActualizar.Location = new System.Drawing.Point(111, 19);
            this.btnAlumnoActualizar.Name = "btnAlumnoActualizar";
            this.btnAlumnoActualizar.Size = new System.Drawing.Size(96, 71);
            this.btnAlumnoActualizar.TabIndex = 1;
            this.btnAlumnoActualizar.Tag = "2";
            this.btnAlumnoActualizar.Text = "Agregar unidades";
            this.btnAlumnoActualizar.UseVisualStyleBackColor = true;
            this.btnAlumnoActualizar.Click += new System.EventHandler(this.btnAlumnoActualizar_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(9, 19);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(96, 71);
            this.btnVenta.TabIndex = 0;
            this.btnVenta.Tag = "1";
            this.btnVenta.Text = "Agregar propietario";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = global::SOLANO.Properties.Resources.fondobueno;
            this.button1.Location = new System.Drawing.Point(263, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVariableUsuario
            // 
            this.lblVariableUsuario.AutoSize = true;
            this.lblVariableUsuario.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariableUsuario.ForeColor = System.Drawing.Color.Firebrick;
            this.lblVariableUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblVariableUsuario.Name = "lblVariableUsuario";
            this.lblVariableUsuario.Size = new System.Drawing.Size(144, 26);
            this.lblVariableUsuario.TabIndex = 107;
            this.lblVariableUsuario.Text = "QUÉ DESEA HACER?";
            // 
            // FrmMenProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SOLANO.Properties.Resources.fondobueno;
            this.ClientSize = new System.Drawing.Size(350, 253);
            this.Controls.Add(this.lblVariableUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenProp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenProp";
            this.Load += new System.EventHandler(this.FrmMenProp_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlumnoActualizar;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblVariableUsuario;
    }
}
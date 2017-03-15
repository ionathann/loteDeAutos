namespace SOLANO
{
    partial class frmMenu
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnPropietarios = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnPropietarios);
            this.groupBox1.Controls.Add(this.btnUsuarios);
            this.groupBox1.Controls.Add(this.btnVenta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SOLANO";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 71);
            this.button2.TabIndex = 4;
            this.button2.Tag = "3";
            this.button2.Text = "GESTION CLIENTES";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPropietarios
            // 
            this.btnPropietarios.Location = new System.Drawing.Point(318, 36);
            this.btnPropietarios.Name = "btnPropietarios";
            this.btnPropietarios.Size = new System.Drawing.Size(96, 71);
            this.btnPropietarios.TabIndex = 3;
            this.btnPropietarios.Tag = "4";
            this.btnPropietarios.Text = "PROPIETARIOS Y UNIDADES";
            this.btnPropietarios.UseVisualStyleBackColor = true;
            this.btnPropietarios.Click += new System.EventHandler(this.btnAlumnoNuevo_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(114, 36);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(96, 71);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Tag = "2";
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnAlumnoBorrar_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(12, 36);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(96, 71);
            this.btnVenta.TabIndex = 0;
            this.btnVenta.Tag = "1";
            this.btnVenta.Text = "VENTA";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = global::SOLANO.Properties.Resources.fondobueno;
            this.button1.Location = new System.Drawing.Point(365, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SOLANO.Properties.Resources.fondobueno;
            this.ClientSize = new System.Drawing.Size(452, 186);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Activated += new System.EventHandler(this.frmMenu_Activated);
            this.Load += new System.EventHandler(this.frmMenu_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPropietarios;
    }
}
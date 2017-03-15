namespace SOLANO
{
    partial class frmFoto
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picMostrar = new System.Windows.Forms.PictureBox();
            this.EspacioCamara = new System.Windows.Forms.PictureBox();
            this.cbxDispositivos = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EspacioCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Tomar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picMostrar
            // 
            this.picMostrar.BackColor = System.Drawing.Color.Transparent;
            this.picMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picMostrar.Location = new System.Drawing.Point(338, 24);
            this.picMostrar.Name = "picMostrar";
            this.picMostrar.Size = new System.Drawing.Size(320, 240);
            this.picMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMostrar.TabIndex = 24;
            this.picMostrar.TabStop = false;
            // 
            // EspacioCamara
            // 
            this.EspacioCamara.BackColor = System.Drawing.Color.Transparent;
            this.EspacioCamara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EspacioCamara.Location = new System.Drawing.Point(12, 24);
            this.EspacioCamara.Name = "EspacioCamara";
            this.EspacioCamara.Size = new System.Drawing.Size(320, 240);
            this.EspacioCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EspacioCamara.TabIndex = 23;
            this.EspacioCamara.TabStop = false;
            // 
            // cbxDispositivos
            // 
            this.cbxDispositivos.Enabled = false;
            this.cbxDispositivos.FormattingEnabled = true;
            this.cbxDispositivos.Location = new System.Drawing.Point(93, 272);
            this.cbxDispositivos.Name = "cbxDispositivos";
            this.cbxDispositivos.Size = new System.Drawing.Size(10, 21);
            this.cbxDispositivos.TabIndex = 28;
            this.cbxDispositivos.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SOLANO.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_application_exit;
            this.pictureBox2.Location = new System.Drawing.Point(651, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 104;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SOLANO.Properties.Resources.fondobueno;
            this.ClientSize = new System.Drawing.Size(670, 302);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbxDispositivos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picMostrar);
            this.Controls.Add(this.EspacioCamara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFoto";
            ((System.ComponentModel.ISupportInitialize)(this.picMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EspacioCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox EspacioCamara;
        private System.Windows.Forms.ComboBox cbxDispositivos;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox picMostrar;

    }
}
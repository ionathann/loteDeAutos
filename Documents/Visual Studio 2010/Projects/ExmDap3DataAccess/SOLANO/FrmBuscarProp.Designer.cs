namespace SOLANO
{
    partial class FrmBuscarProp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBpropietarios = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblVariableUsuario = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografia = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBpropietarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBpropietarios
            // 
            this.dgvBpropietarios.AllowDrop = true;
            this.dgvBpropietarios.AllowUserToAddRows = false;
            this.dgvBpropietarios.AllowUserToDeleteRows = false;
            this.dgvBpropietarios.AllowUserToOrderColumns = true;
            this.dgvBpropietarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBpropietarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBpropietarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvBpropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBpropietarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.fotografia,
            this.nombre,
            this.appaterno,
            this.apmaterno,
            this.telefono});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBpropietarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBpropietarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBpropietarios.EnableHeadersVisualStyles = false;
            this.dgvBpropietarios.Location = new System.Drawing.Point(12, 59);
            this.dgvBpropietarios.MultiSelect = false;
            this.dgvBpropietarios.Name = "dgvBpropietarios";
            this.dgvBpropietarios.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBpropietarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBpropietarios.RowHeadersVisible = false;
            this.dgvBpropietarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBpropietarios.Size = new System.Drawing.Size(840, 456);
            this.dgvBpropietarios.TabIndex = 84;
            this.dgvBpropietarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.AutoSize = true;
            this.btnbuscar.Location = new System.Drawing.Point(788, 30);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(64, 23);
            this.btnbuscar.TabIndex = 83;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscar.Location = new System.Drawing.Point(12, 30);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(770, 20);
            this.TxtBuscar.TabIndex = 82;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SOLANO.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_application_exit;
            this.pictureBox2.Location = new System.Drawing.Point(844, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 85;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblVariableUsuario
            // 
            this.lblVariableUsuario.AutoSize = true;
            this.lblVariableUsuario.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariableUsuario.ForeColor = System.Drawing.Color.Firebrick;
            this.lblVariableUsuario.Location = new System.Drawing.Point(12, 1);
            this.lblVariableUsuario.Name = "lblVariableUsuario";
            this.lblVariableUsuario.Size = new System.Drawing.Size(159, 26);
            this.lblVariableUsuario.TabIndex = 105;
            this.lblVariableUsuario.Text = "BUSCAR PROPIETARIO";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "idpropietario";
            this.Id.FillWeight = 40.47114F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // fotografia
            // 
            this.fotografia.FillWeight = 77.42847F;
            this.fotografia.HeaderText = "fotografia";
            this.fotografia.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.fotografia.Name = "fotografia";
            this.fotografia.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.FillWeight = 40.47114F;
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // appaterno
            // 
            this.appaterno.FillWeight = 40.47114F;
            this.appaterno.HeaderText = "appaterno";
            this.appaterno.Name = "appaterno";
            this.appaterno.ReadOnly = true;
            // 
            // apmaterno
            // 
            this.apmaterno.FillWeight = 40.47114F;
            this.apmaterno.HeaderText = "apmaterno";
            this.apmaterno.Name = "apmaterno";
            this.apmaterno.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.FillWeight = 65.75518F;
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // FrmBuscarProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SOLANO.Properties.Resources.fondobueno;
            this.ClientSize = new System.Drawing.Size(864, 527);
            this.Controls.Add(this.lblVariableUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvBpropietarios);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.TxtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarProp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarProp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBpropietarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBpropietarios;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblVariableUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn fotografia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn appaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}
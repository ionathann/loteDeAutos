namespace SOLANO
{
    partial class ClienteExistente
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
            this.dgvBCLIENTES = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.lblVariableUsuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCLIENTES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBCLIENTES
            // 
            this.dgvBCLIENTES.AllowDrop = true;
            this.dgvBCLIENTES.AllowUserToAddRows = false;
            this.dgvBCLIENTES.AllowUserToDeleteRows = false;
            this.dgvBCLIENTES.AllowUserToOrderColumns = true;
            this.dgvBCLIENTES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBCLIENTES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBCLIENTES.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvBCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBCLIENTES.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBCLIENTES.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBCLIENTES.EnableHeadersVisualStyles = false;
            this.dgvBCLIENTES.Location = new System.Drawing.Point(12, 55);
            this.dgvBCLIENTES.MultiSelect = false;
            this.dgvBCLIENTES.Name = "dgvBCLIENTES";
            this.dgvBCLIENTES.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBCLIENTES.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBCLIENTES.RowHeadersVisible = false;
            this.dgvBCLIENTES.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBCLIENTES.Size = new System.Drawing.Size(869, 433);
            this.dgvBCLIENTES.TabIndex = 87;
            this.dgvBCLIENTES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBCLIENTES_CellContentClick);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.AutoSize = true;
            this.btnbuscar.Location = new System.Drawing.Point(817, 26);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(64, 23);
            this.btnbuscar.TabIndex = 86;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscar.Location = new System.Drawing.Point(12, 29);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(799, 20);
            this.TxtBuscar.TabIndex = 85;
            this.TxtBuscar.Text = "Introducir INE...";
            this.TxtBuscar.Click += new System.EventHandler(this.TxtBuscar_Click);
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // lblVariableUsuario
            // 
            this.lblVariableUsuario.AutoSize = true;
            this.lblVariableUsuario.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariableUsuario.ForeColor = System.Drawing.Color.Firebrick;
            this.lblVariableUsuario.Location = new System.Drawing.Point(7, 0);
            this.lblVariableUsuario.Name = "lblVariableUsuario";
            this.lblVariableUsuario.Size = new System.Drawing.Size(126, 26);
            this.lblVariableUsuario.TabIndex = 106;
            this.lblVariableUsuario.Text = "BUSCAR CLIENTE";
            this.lblVariableUsuario.Click += new System.EventHandler(this.lblVariableUsuario_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SOLANO.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_application_exit;
            this.pictureBox2.Location = new System.Drawing.Point(873, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ClienteExistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SOLANO.Properties.Resources.fondobueno;
            this.ClientSize = new System.Drawing.Size(893, 500);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblVariableUsuario);
            this.Controls.Add(this.dgvBCLIENTES);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.TxtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClienteExistente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteExistente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCLIENTES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBCLIENTES;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        public System.Windows.Forms.Label lblVariableUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
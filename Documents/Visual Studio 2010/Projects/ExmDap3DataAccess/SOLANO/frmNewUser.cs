using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccess.Metodos;

namespace SOLANO
{
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
            cbxRol.DataSource = CsUsuarios.ListarRoles();
        }
        public bool modi = false;
        public int id;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

               

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            
            if (!frmMenu.SessionActiva.isValid)
            {
                frmLogin nVentana = new frmLogin();
                nVentana.ShowDialog();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            foreach (Control _textbox in this.Controls)
            {
                if (_textbox is TextBox && _textbox.Text == string.Empty)
                {
                   errorsito.SetError(_textbox, "Campo obligatorio");
                    valido = false;
                }

            }



            if (modi && valido)
            {
                CsUsuarios.Actualizar(id, txtEmail.Text, txtPassword.Text, Convert.ToInt32(cbxRol.SelectedValue));
                lblmensaje.Text = "Registro modificado";
                lblmensaje.ForeColor = Color.FromName("green");
                CsRegistros.GuardarAccesso(frmMenu.SessionActiva.usuario.pkUsuario, "Modificó un usuario con el id " + id.ToString());
            }
            else if (modi== false && valido)
            {
                CsUsuarios.Guardar(txtEmail.Text, txtPassword.Text,Convert.ToInt32(cbxRol.SelectedValue));
                lblmensaje.Text = "Registro guardado";
                CsRegistros.GuardarAccesso(frmMenu.SessionActiva.usuario.pkUsuario, "Registró un usuario");
                lblmensaje.ForeColor = Color.FromName("green");
            }

            
        }
    }
}

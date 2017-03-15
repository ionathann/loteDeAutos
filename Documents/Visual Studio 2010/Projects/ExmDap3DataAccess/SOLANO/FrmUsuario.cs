using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccess.Metodos;
using System.Data.Entity;
using DataAccess.Context;

namespace SOLANO
{
    public partial class FrmUsuario : Form
    {
        

        public FrmUsuario()
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
        }

        

        public void CargarDatos()
        {
            CsUsuarios usr = new CsUsuarios();
            dgvUsuarios.DataSource = CsUsuarios.ListarUsuarios();
    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {           
                       
            if (!frmMenu.SessionActiva.isValid)
            {
                frmLogin nVentana = new frmLogin();
                nVentana.ShowDialog();
            }
            else
            {
                
            
            }



            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmNewUser abri = new frmNewUser();
            abri.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            

            CargarDatos();
            
           
        }
        

    

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           dgvUsuarios.DataSource = CsUsuarios.BuscarUsuarios(TxtBuscar.Text);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            frmNewUser abri = new frmNewUser();
            abri.lblVariableUsuario.Text = "MODIFICAR USUARIO";
            abri.txtEmail.Text = CsUsuarios.obtenerUsuario(CsHerramientas.gridvg(dgvUsuarios)).sEmail.ToString();
            abri.txtPassword.Text = CsUsuarios.obtenerUsuario(CsHerramientas.gridvg(dgvUsuarios)).sPassword.ToString();
            abri.cbxRol.Text = CsUsuarios.obtenerUsuario(CsHerramientas.gridvg(dgvUsuarios)).rol.sNombre.ToString();
            abri.modi = true;
            abri.id = CsHerramientas.gridvg(dgvUsuarios);
            abri.ShowDialog();
        }
    }
}

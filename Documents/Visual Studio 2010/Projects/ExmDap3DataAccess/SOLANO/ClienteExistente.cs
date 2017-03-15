using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccess.Context;
using DataAccess.Metodos;

namespace SOLANO
{
    public partial class ClienteExistente : Form
    {
        public ClienteExistente()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            DtContext ctx = new DtContext();
            dgvBCLIENTES.DataSource = ctx.clientes.Where(x => x.Ine.Contains(TxtBuscar.Text)).ToList();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscar_Click(object sender, EventArgs e)
        
        {
            if (TxtBuscar.Text == "Introducir INE...")
            {

                TxtBuscar.Text = "";
            }
        }

        private void dgvBCLIENTES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
            FrmCliente abri = FrmCliente.Instanciaa;
            FrmCliente.existe = true;
            FrmCliente.cli = CsClientes.obtenerCliente(CsHerramientas.gridvg(dgvBCLIENTES)).idcomprador;
            abri.txtNombre.Text = CsClientes.obtenerCliente(CsHerramientas.gridvg(dgvBCLIENTES)).nombre.ToString();
            abri.txtapellido.Text = CsClientes.obtenerCliente(CsHerramientas.gridvg(dgvBCLIENTES)).appaterno.ToString();
            abri.txtapellidomtern.Text = CsClientes.obtenerCliente(CsHerramientas.gridvg(dgvBCLIENTES)).apmaterno.ToString();
            abri.txtIne.Text = CsClientes.obtenerCliente(CsHerramientas.gridvg(dgvBCLIENTES)).Ine.ToString();
            abri.txtCalle.Text = CsClientes.obtenerCliente(CsHerramientas.gridvg(dgvBCLIENTES)).calle.ToString();
            abri.txtColonia.Text = CsClientes.obtenerCliente(CsHerramientas.gridvg(dgvBCLIENTES)).colonia.ToString();
            abri.txtnrocasa.Text = CsClientes.obtenerCliente(CsHerramientas.gridvg(dgvBCLIENTES)).ncasa.ToString();
            abri.txtAvenida.Text = CsClientes.obtenerCliente(CsHerramientas.gridvg(dgvBCLIENTES)).avenida.ToString();
            abri.txxtciudad.Text = CsClientes.obtenerCliente(CsHerramientas.gridvg(dgvBCLIENTES)).ciudad.ToString();
            abri.txtpais.Text = CsClientes.obtenerCliente(CsHerramientas.gridvg(dgvBCLIENTES)).pais.ToString();
            abri.Show();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblVariableUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}

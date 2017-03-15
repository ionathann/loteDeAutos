using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccess.Metodos;
using DataAccess.Context;

namespace SOLANO
{
    public partial class FrmGestionCliente : Form
    {
       
        public static int cli;
        public FrmGestionCliente()
        {
            InitializeComponent();
           
        }

        private void dgvBCLIENTES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            FormEditarClien abri = new FormEditarClien();
            cli = CsClientes.obtenerCliente(CsHerramientas.gridvg(dgvBCLIENTES)).idcomprador;
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
            FormEditarClien.id = cli;
            abri.Show();
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

        private void FrmGestionCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

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
using DataAccess.Data;

namespace SOLANO
{
    public partial class FrmCliente : Form
    {
        public static double precioV;
        public static bool existe = false;
        public static int idauto;
        public static int cli;

        private static FrmCliente instancia = new FrmCliente();


        public static FrmCliente Instanciaa
        {
            get
            {
                return FrmCliente.instancia;
            }
        }


       
        private FrmCliente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmVenta.Instanciaa.Refresh();
            FrmVenta.Instanciaa.Show();
           
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

            var Getcol = CsHerramientas.getColonias();
            txtColonia.AutoCompleteMode = AutoCompleteMode.Append;
            AutoCompleteStringCollection acscl = new AutoCompleteStringCollection();
            acscl.AddRange(Getcol.ToArray());
            txtColonia.AutoCompleteCustomSource = acscl;
            txtColonia.AutoCompleteSource = AutoCompleteSource.CustomSource;


            var getPai = CsHerramientas.getPaises();
            txtpais.AutoCompleteMode = AutoCompleteMode.Append;
            AutoCompleteStringCollection acscl2 = new AutoCompleteStringCollection();
            acscl2.AddRange(getPai.ToArray());
            txtpais.AutoCompleteCustomSource = acscl2;
            txtpais.AutoCompleteSource = AutoCompleteSource.CustomSource;


            var getCiudades = CsHerramientas.getMunicipios();
            txxtciudad.AutoCompleteMode = AutoCompleteMode.Append;
            AutoCompleteStringCollection acs3 = new AutoCompleteStringCollection();
            acs3.AddRange(getCiudades.ToArray());
            txxtciudad.AutoCompleteCustomSource = acs3;
            txxtciudad.AutoCompleteSource = AutoCompleteSource.CustomSource;

            lblVendedorEnturno.Text = frmMenu.SessionActiva.usuario.sEmail.ToString();
                       
        }

        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
            if (existe)
            {
                DtContext ctx = new DtContext();
                var vnt = new ventas() { fecha = DateTime.Now, total = precioV};
                CsVenta.Venta(idauto,frmMenu.SessionActiva.usuario.pkUsuario,cli,vnt);
                CsAuto.UpdateAuto(idauto);
                
            MessageBox.Show("Venta realizada con èxito!");
            CsRegistros.GuardarAccesso(frmMenu.SessionActiva.usuario.pkUsuario, "Realizó una venta de el auto con id "+ idauto.ToString());
            this.Hide();
            }
            else if (existe == false)
            { 
            // compra y registra cliente
                var comprador = new Clientes();
                comprador.nombre = txtNombre.Text;
                comprador.appaterno = txtapellido.Text;
                comprador.apmaterno = txtapellidomtern.Text;
                comprador.Ine = txtIne.Text;
                comprador.calle = txtCalle.Text;
                comprador.ncasa = txtnrocasa.Text;
                comprador.avenida = txtAvenida.Text;
                comprador.colonia = txtColonia.Text;
                comprador.ciudad = txxtciudad.Text;
                comprador.pais = txtpais.Text;
                CsVenta.GuardarComprador(comprador);
                DtContext ctx = new DtContext();
                var vnt = new ventas() { fecha = DateTime.Now, total = precioV };
                CsVenta.Venta(idauto, frmMenu.SessionActiva.usuario.pkUsuario, cli, vnt);
                CsAuto.UpdateAuto(idauto);
                MessageBox.Show("Venta realizada con èxito!");
                CsRegistros.GuardarAccesso(frmMenu.SessionActiva.usuario.pkUsuario, "Realizó una venta de el auto con id " + idauto.ToString());
                this.Hide();
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            ClienteExistente abri = new ClienteExistente();
            abri.ShowDialog();
        }

        private void FrmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.Visible = false;
            e.Cancel = true;
        }

        private void txtColonia_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtColonia.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (txtColonia.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCalle.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (txtCalle.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombre.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (txtNombre.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtapellido.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (txtapellido.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void txtapellidomtern_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtapellidomtern.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (txtapellidomtern.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];

        }

        private void txtAvenida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAvenida.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (txtAvenida.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void txxtciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txxtciudad.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (txxtciudad.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void txtpais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtpais.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (txtpais.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
    }
}

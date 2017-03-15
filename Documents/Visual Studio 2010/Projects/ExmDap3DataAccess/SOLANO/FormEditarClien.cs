using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccess.Context;
using DataAccess.Data;
using DataAccess.Metodos;

namespace SOLANO
{
    public partial class FormEditarClien : Form
    {
        

        public static int id;
        public FormEditarClien()
        {
            InitializeComponent();
            
        }

        public void procesarPermisos()
        {
            int permiso = 0;
            foreach (object obj in this.Controls)
            {
                if (obj is Button)
                {
                    Button btn = (Button)obj;
                    permiso = Convert.ToInt32(btn.Tag);
                    btn.Enabled = frmMenu.SessionActiva.TienePermisos(permiso);

                }
            }


        }

        private void btnAceptr_Click(object sender, EventArgs e)
        {
            DtContext agre = new DtContext();
            var comprador = agre.clientes.Find(id);
                        
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
            agre.SaveChanges();            
            this.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar el usuario?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CsClientes.borrarcli(id);
                this.Close();
               

            }
            }

        private void FormEditarClien_Load(object sender, EventArgs e)
        {
            procesarPermisos();

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


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

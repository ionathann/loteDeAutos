using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccess.Data;
using DataAccess.Metodos;
using DataAccess.Context;

namespace SOLANO
{
    public partial class FrmPropietario : Form
    {
        public static Image fotillo;
        public FrmPropietario()
        {
            InitializeComponent();
            pcbFoto.Image = SOLANO.Properties.Resources.perfilfoto;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmMenProp abri = new FrmMenProp();
            abri.Show();
            this.Close();
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
                    lblmensaje.Text = "Error";
                    lblmensaje.ForeColor = Color.FromName("red");
                }

            }

            if (valido)
            {
                var datos = new propietario()
                {
                    nombre = txtNombre.Text,
                    appaterno = txtApPaterno.Text,
                    apmaterno = txtApMateno.Text,
                    ine = txtINE.Text,
                    telefono = txtTelefono.Text,
                    correo = txtCorreo.Text,
                    calle = txtCalle.Text,
                    ncasa = txtNoCasa.Text,
                    avenida = txtAvenida.Text,
                    colonia = txtColonia.Text,
                    ciudad = txtCiudad.Text,
                    pais = txtPais.Text,
                    fotografia =  CsHerramientas.ImageToBase64(pcbFoto.Image)
                    
                };
                CsPropietario.GuardarPropietario(datos);


                lblmensaje.Text = "OK!";
                lblmensaje.ForeColor = Color.FromName("green");

                CsRegistros.GuardarAccesso(frmMenu.SessionActiva.usuario.pkUsuario, "Registró un propietario");
            
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenProp abri = new FrmMenProp();
            abri.Show();
        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            frmFoto abri = new frmFoto();
            abri.ShowDialog();
        }

        private void FrmPropietario_Activated(object sender, EventArgs e)
        {

            pcbFoto.Image = fotillo;

        }

        private void pcbFoto_Click(object sender, EventArgs e)
        {
            frmVisPrevia vp = new frmVisPrevia();
            frmVisPrevia.fotoprop = true;
            vp.ShowDialog();

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dSelFichero =
                     new System.Windows.Forms.OpenFileDialog();
            dSelFichero.Filter = "Ficheros de imagen (*.jpg)|*.jpg|Todos los archivos (*.*)|*.*";
            dSelFichero.Title = "Ficheros de imagen";
            dSelFichero.DefaultExt = "jpg";
            if (dSelFichero.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (System.IO.File.Exists(dSelFichero.FileName))
                {
                    pcbFoto.Image = Image.FromFile(dSelFichero.FileName);
                    fotillo = Image.FromFile(dSelFichero.FileName);
                    
                }
            } 
        }

        private void pcbFoto_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}

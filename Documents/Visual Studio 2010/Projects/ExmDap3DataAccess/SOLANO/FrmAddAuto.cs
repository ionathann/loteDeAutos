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
using DataAccess.Data;

namespace SOLANO
{
    public partial class FrmAddAuto : Form
    {
        public int id;
        public string propie;
        Image img1,img2,img3;
        

        public FrmAddAuto()
        {
            InitializeComponent();
        }

        private void ptbFotoAuto3Modificar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddAuto_Load(object sender, EventArgs e)
        {
            txtpropietario.Text = propie;
            
            
        }

        private void btnAgregarModificarAuto_Click(object sender, EventArgs e)
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
                var aut = new autos()
                {
                    
                    marca = txtMarca.Text,
                    modelo = txtModelo.Text,
                    nserie = txtNroSerie.Text,
                    precio = Convert.ToDouble(txtPrecio.Text),
                    color = txtColor.Text,
                    nacionalidad = cmbNacionalidad.Text,
                    fotografia1 = CsHerramientas.ImageToBase64(img1),
                    fotografia2 = CsHerramientas.ImageToBase64(img2),
                    fotografia3 = CsHerramientas.ImageToBase64(img3),
                
                    Observacion = txtObversacion.Text,

                };
                lblmensaje.Text = "OK!";
                lblmensaje.ForeColor = Color.FromName("green");

                

            CsAuto.Guardar(aut,id);

            var ctx = new DtContext();
            

            int max = ctx.autos.Max(p => p.idauto);

            
            int idcomprador = id;
            if (max == 0)
            {
                max = 1;
            }
            
            
            int idusuario = frmMenu.SessionActiva.usuario.pkUsuario;

            CsVenta.savePagoPorRegistro(idusuario);

            MessageBox.Show("Se generó un recargo por $200 pesos al propietario");
            
            }
        }

        private void btnSalirModificarAuto_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenProp abri = new FrmMenProp();
            abri.Show();
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
                    
                    img1 = Image.FromFile(dSelFichero.FileName);
                    pbx1.Image = Image.FromFile(dSelFichero.FileName);
                }
            } 




        }

        private void button2_Click(object sender, EventArgs e)
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

                    img2 = Image.FromFile(dSelFichero.FileName);
                    pbx2.Image = Image.FromFile(dSelFichero.FileName);

                }
            } 
        }

        private void button3_Click(object sender, EventArgs e)
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

                    img3 = Image.FromFile(dSelFichero.FileName);
                    pbx3.Image = Image.FromFile(dSelFichero.FileName);

                }
            } 
        }
    }
}

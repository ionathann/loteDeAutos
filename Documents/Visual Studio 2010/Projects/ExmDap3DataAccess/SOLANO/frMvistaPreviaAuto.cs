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
    public partial class frMvistaPreviaAuto : Form
    {
        public static int id;
        public static double precio;
        public static Image foto1, foto2, foto3;
        public frMvistaPreviaAuto()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frMvistaPreviaAuto_Load(object sender, EventArgs e)
        {
            var ctx = new DtContext();
            foreach (var item in ctx.autos.Where(x => x.idauto == id).ToList())
            {
                precio = item.precio;
                label1.Text = item.marca;
                label7.Text = item.modelo;
                label8.Text = item.nserie;
                label9.Text = "$" + item.precio;
                label10.Text = item.color;
                label11.Text = item.nacionalidad;
                label12.Text = item.Observacion;
                pictureBox1.Image = CsHerramientas.Base64ToImage(item.fotografia1);
                pictureBox2.Image = CsHerramientas.Base64ToImage(item.fotografia2);
                pictureBox3.Image = CsHerramientas.Base64ToImage(item.fotografia3);
                foto1 = CsHerramientas.Base64ToImage(item.fotografia1);
                foto2 = CsHerramientas.Base64ToImage(item.fotografia2);
                foto3 = CsHerramientas.Base64ToImage(item.fotografia3);
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCliente abri = FrmCliente.Instanciaa;
            abri.txtSubtotalCliente.Text = label9.Text;
            double subtotal,iva,comision, total;

            subtotal = precio;
            iva = subtotal * 0.16;
            comision = subtotal * 0.20;
            total = subtotal + iva + comision;

            abri.txtIvaCliente.Text = "$"+iva.ToString();
            abri.txtDatosAauto.Text = "$" + comision.ToString();
            abri.txtTotalCliente.Text = "$" + total.ToString();
            FrmCliente.precioV = total;
            FrmCliente.idauto = id;
            abri.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmVisPrevia.fotoau1 = true;
            frmVisPrevia.fotoau2 = false;
            frmVisPrevia.fotoau3 = false;
            frmVisPrevia abri = new frmVisPrevia();
            abri.ShowDialog();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmVisPrevia.fotoau1 = false;
            frmVisPrevia.fotoau2 = true;
            frmVisPrevia.fotoau3 = false;
            frmVisPrevia abri = new frmVisPrevia();
            abri.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmVisPrevia.fotoau1 = false;
            frmVisPrevia.fotoau2 = false;
            frmVisPrevia.fotoau3 = true;
            frmVisPrevia abri = new frmVisPrevia();
            abri.ShowDialog();
        }
    }
}

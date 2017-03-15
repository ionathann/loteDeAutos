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
    public partial class FrmPrincipal : Form
    {
        public static SessionHelper SessionActiva;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmMenu abri = new frmMenu();
            abri.MdiParent = this;            
            abri.Show();
        }

        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteVenta abri = new ReporteVenta();
            abri.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmMenu.SessionActiva.isValid)
            {
                CsRegistros.GuardarAccesso(frmMenu.SessionActiva.usuario.pkUsuario, "Salió del sistema");
            }
           
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu abri = new frmMenu();
            abri.Show();
        }
    }
}

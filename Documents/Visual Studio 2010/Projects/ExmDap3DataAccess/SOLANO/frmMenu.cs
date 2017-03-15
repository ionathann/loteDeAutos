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
    public partial class frmMenu : Form
    {
        public static SessionHelper SessionActiva;
            

        public void procesarPermisos()
        {
            int permiso = 0;
            foreach (object obj in this.groupBox1.Controls)
            {
                if (obj is Button)
                {
                    Button btn = (Button)obj;
                    permiso = Convert.ToInt32(btn.Tag);
                    btn.Enabled = SessionActiva.TienePermisos(permiso);
                   
                }
            }
           
           
        }
        

        public frmMenu()
        {
            InitializeComponent();
            SessionActiva = new SessionHelper();
        }


        private void frmMenu_Load_1(object sender, EventArgs e)
        {
            if (!frmMenu.SessionActiva.isValid)
            {
                frmLogin nVentana = new frmLogin();                
                nVentana.ShowDialog();
            }

        }

        private void frmMenu_Activated(object sender, EventArgs e)
        {
            if (frmMenu.SessionActiva.isValid)
            {
                procesarPermisos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnAlumnoBorrar_Click(object sender, EventArgs e)
        {
            FrmUsuario abri = new FrmUsuario();
            abri.Show();

        }

        private void btnAlumnoNuevo_Click(object sender, EventArgs e)
        {
            
            FrmMenProp abri = new FrmMenProp();          
            abri.Show();
            
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FrmVenta.Instanciaa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            FrmGestionCliente abri = new FrmGestionCliente();
            abri.Show();
        }
         
    }
}

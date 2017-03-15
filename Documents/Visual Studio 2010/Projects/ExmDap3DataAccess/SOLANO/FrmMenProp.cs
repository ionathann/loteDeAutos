using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOLANO
{
    public partial class FrmMenProp : Form
    {
        public FrmMenProp()
        {
            InitializeComponent();
           
        }

        private void FrmMenProp_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void btnAlumnoActualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBuscarProp abri = new FrmBuscarProp();            
            abri.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {   this.Hide();
            FrmPropietario abri = new FrmPropietario();            
            abri.Show();
        }
    }
}

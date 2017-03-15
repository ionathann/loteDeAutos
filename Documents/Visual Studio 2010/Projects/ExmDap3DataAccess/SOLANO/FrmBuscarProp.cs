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
    public partial class FrmBuscarProp : Form
    {
        public FrmBuscarProp()
        {
            InitializeComponent();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmMenProp abri = new FrmMenProp();
            abri.Show();
            this.Close();
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            FrmAddAuto abri = new FrmAddAuto();

            abri.id = CsHerramientas.gridvg(dgvBpropietarios);
            abri.propie = CsHerramientas.gridvgNom(dgvBpropietarios);



            abri.Show();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
             var ctx = new DtContext();
             foreach (var item in ctx.propietarios.Where(r => r.nombre.Contains(TxtBuscar.Text) || r.appaterno.Contains(TxtBuscar.Text) || r.apmaterno.Contains(TxtBuscar.Text)).ToList())
             {
                 dgvBpropietarios.Rows.Add(item.idpropietario.ToString(),CsHerramientas.Base64ToImage(item.fotografia),item.nombre,item.appaterno,item.apmaterno,item.telefono);
                     
                 
             }
                
                

        }
    }
}

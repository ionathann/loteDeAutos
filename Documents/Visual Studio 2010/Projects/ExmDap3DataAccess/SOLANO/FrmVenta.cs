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
    public partial class FrmVenta : Form
    {
        private static FrmVenta instancia = new FrmVenta();
        public static FrmVenta Instanciaa
        {
            get
            {
                return FrmVenta.instancia;
            }
        }

        private FrmVenta()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dgvENTA.Rows.Clear();
            
            var ctx = new DtContext();
            foreach (var item in ctx.autos.Where(x => x.bStatus).ToList())
            {
               dgvENTA.Rows.Add(item.idauto.ToString(), item.marca,item.modelo, CsHerramientas.Base64ToImage(item.fotografia1));
                
            }
        }

        private void dgvENTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           frMvistaPreviaAuto.id = CsHerramientas.gridvg(dgvENTA);
           frMvistaPreviaAuto abri = new frMvistaPreviaAuto();
           abri.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvENTA.Rows.Clear();
            var ctx = new DtContext();
            foreach (var item in ctx.autos.Where(r => r.modelo.Contains(TxtBuscar.Text) == r.bStatus).ToList())
            {
                dgvENTA.Rows.Add(item.idauto.ToString(), item.marca, item.modelo, CsHerramientas.Base64ToImage(item.fotografia1));

            }
        }

        private void FrmVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.Visible = false;
            e.Cancel = true;
        }
    }
}

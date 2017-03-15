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
    public partial class frmVisPrevia : Form
    {
        public static bool fotoprop = false;
        public static bool fotoau1 = false;
        public static bool fotoau2 = false;
        public static bool fotoau3 = false;
        public frmVisPrevia()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVisPrevia_Load(object sender, EventArgs e)
        {
            if (fotoprop)
            {
                pictureBox1.Image = FrmPropietario.fotillo;
            }
            else if (fotoau1)
            {
                pictureBox1.Image = frMvistaPreviaAuto.foto1;
            }
            else if(fotoau2)
            {
                pictureBox1.Image = frMvistaPreviaAuto.foto2;
            }
            else if (fotoau3)
            {
                pictureBox1.Image = frMvistaPreviaAuto.foto3;
            }



            efectito();



            
        }

        public void efectito()
        {
            int duration = 500;
            int steps = 50;
            Timer timer = new Timer();
            timer.Interval = duration / steps;

            int currentStep = 0;
            timer.Tick += (arg1, arg2) =>
            {
                Opacity = ((double)currentStep) / steps;
                currentStep++;

                if (currentStep >= steps)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };

            timer.Start();
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

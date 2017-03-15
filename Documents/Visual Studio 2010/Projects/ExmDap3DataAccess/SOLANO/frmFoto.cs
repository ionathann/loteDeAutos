using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace SOLANO
{
    public partial class frmFoto : Form
    {
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        public string foto;

        public frmFoto()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }

            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);

            }
        }

        //Cargar dispositivos de camara
        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cbxDispositivos.Items.Add(Dispositivos[0].Name.ToString());
            cbxDispositivos.Text = cbxDispositivos.Items[0].ToString();

        }

        //Mostrar video en picture box
        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            EspacioCamara.Image = Imagen;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivos.SelectedIndex].MonikerString);
            FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
            FuenteDeVideo.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picMostrar.Image = EspacioCamara.Image;
            FrmPropietario pr = new FrmPropietario();
            pr.lblVariableUsuario.Text = "cambiando";
            FrmPropietario.fotillo = EspacioCamara.Image;
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            FuenteDeVideo.Stop();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

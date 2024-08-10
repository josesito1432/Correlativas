using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas1
{
    public partial class WindowsHome : Form
    {
        // Importar la función ReleaseCapture de la API de Windows
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Importar la función SendMessage de la API de Windows
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Definir el mensaje WM_NCLBUTTONDOWN
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;


        public WindowsHome()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnWindowsClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWindowsMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void layTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Verificar que se ha hecho clic con el botón izquierdo del mouse
            if (e.Button == MouseButtons.Left)
            {
                // Soltar la captura del mouse
                ReleaseCapture();
                // Enviar el mensaje para mover la ventana
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnTecnicaturasExpand_Click(object sender, EventArgs e)
        {
            layTecnicaturas.AutoSize = !layTecnicaturas.AutoSize;
            layProfesorados.AutoSize = false;
        }

        private void btnProfesoradosExpand_Click(object sender, EventArgs e)
        {
            layProfesorados.AutoSize = !layProfesorados.AutoSize;
            layTecnicaturas.AutoSize = false;
        }
    }
}

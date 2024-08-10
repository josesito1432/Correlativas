namespace Pruebas1
{
    using System.Drawing;


    public partial class VentanaHome : Form
    {
        string nombreButon = "";

        public VentanaHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void btnTecnicaturas_Click(object sender, EventArgs e)
        {
            lytTecnicaturas.AutoSize = !lytTecnicaturas.AutoSize;
            lytProfesorados.AutoSize = false;
        }

        private void btnProfesorados_Click(object sender, EventArgs e)
        {
            lytProfesorados.AutoSize = !lytProfesorados.AutoSize;
            lytTecnicaturas.AutoSize = false;
        }

        Color generadorColor()
        {
            // Generar valores RGB aleatorios en el rango 128-255 para colores pastel
            Random random = new Random();
            int r = random.Next(128, 256);
            int g = random.Next(128, 256);
            int b = random.Next(128, 256);

            // Crear el color
            Color pastelColor = Color.FromArgb(r, g, b);
            return pastelColor;

        }

        private void btnInformatica_Click(object sender, EventArgs e)
        {
            Button yo = sender as Button;
            yo.BackColor = generadorColor();
            pnlTrabajo.BackColor = yo.BackColor;
        }

        private void btnFrutihorticula_Click(object sender, EventArgs e)
        {
            Button yo = sender as Button;
            yo.BackColor = generadorColor();
            pnlTrabajo.BackColor = yo.BackColor;
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            Button yo = sender as Button;
            yo.BackColor = generadorColor();
            pnlTrabajo.BackColor = yo.BackColor;
        }

        private void btnTurismo_Click(object sender, EventArgs e)
        {
            Button yo = sender as Button;
            yo.BackColor = generadorColor();
            pnlTrabajo.BackColor = yo.BackColor;
        }

        private void btnForestal_Click(object sender, EventArgs e)
        {
            Button yo = sender as Button;
            yo.BackColor = generadorColor();
            pnlTrabajo.BackColor = yo.BackColor;
        }

        private void btnDisenoGrafico_Click(object sender, EventArgs e)
        {
            Button yo = sender as Button;
            yo.BackColor = generadorColor();
            pnlTrabajo.BackColor = yo.BackColor;
        }
    }
}

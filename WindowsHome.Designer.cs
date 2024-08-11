namespace Pruebas1
{
    partial class WindowsHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTrabajo = new Panel();
            pnlTrabajoHome = new Panel();
            pnlSidebar = new Panel();
            panel3 = new Panel();
            layProfesorados = new FlowLayoutPanel();
            btnProfesoradosExpand = new Button();
            btnLengua = new Button();
            btnIngles = new Button();
            btnHistoria = new Button();
            btnBiologia = new Button();
            btnMatematicas = new Button();
            btnEducacionFisica = new Button();
            btnQuimica = new Button();
            btnPrimaria = new Button();
            layTecnicaturas = new FlowLayoutPanel();
            btnTecnicaturasExpand = new Button();
            btnInformatica = new Button();
            btnFrutihorticola = new Button();
            btnAlimentos = new Button();
            btnTurismo = new Button();
            btnForestal = new Button();
            btnDisGrafico = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            layFooter = new FlowLayoutPanel();
            lblStated = new Label();
            label1 = new Label();
            layTopBar = new FlowLayoutPanel();
            btnWindowsClosed = new Button();
            btnMaximized = new Button();
            btnWindowsMinimized = new Button();
            pnlTrabajo.SuspendLayout();
            pnlSidebar.SuspendLayout();
            panel3.SuspendLayout();
            layProfesorados.SuspendLayout();
            layTecnicaturas.SuspendLayout();
            layFooter.SuspendLayout();
            layTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTrabajo
            // 
            pnlTrabajo.Controls.Add(pnlTrabajoHome);
            pnlTrabajo.Controls.Add(pnlSidebar);
            pnlTrabajo.Dock = DockStyle.Fill;
            pnlTrabajo.Location = new Point(0, 30);
            pnlTrabajo.Name = "pnlTrabajo";
            pnlTrabajo.Size = new Size(1280, 670);
            pnlTrabajo.TabIndex = 8;
            // 
            // pnlTrabajoHome
            // 
            pnlTrabajoHome.BackColor = Color.LightBlue;
            pnlTrabajoHome.BackgroundImageLayout = ImageLayout.Stretch;
            pnlTrabajoHome.Dock = DockStyle.Fill;
            pnlTrabajoHome.Location = new Point(200, 0);
            pnlTrabajoHome.Name = "pnlTrabajoHome";
            pnlTrabajoHome.Size = new Size(1080, 670);
            pnlTrabajoHome.TabIndex = 1;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(21, 101, 192);
            pnlSidebar.Controls.Add(panel3);
            pnlSidebar.Controls.Add(panel2);
            pnlSidebar.Controls.Add(panel1);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 670);
            pnlSidebar.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(layProfesorados);
            panel3.Controls.Add(layTecnicaturas);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 505);
            panel3.TabIndex = 2;
            // 
            // layProfesorados
            // 
            layProfesorados.BackColor = Color.FromArgb(25, 118, 210);
            layProfesorados.Controls.Add(btnProfesoradosExpand);
            layProfesorados.Controls.Add(btnLengua);
            layProfesorados.Controls.Add(btnIngles);
            layProfesorados.Controls.Add(btnHistoria);
            layProfesorados.Controls.Add(btnBiologia);
            layProfesorados.Controls.Add(btnMatematicas);
            layProfesorados.Controls.Add(btnEducacionFisica);
            layProfesorados.Controls.Add(btnQuimica);
            layProfesorados.Controls.Add(btnPrimaria);
            layProfesorados.Dock = DockStyle.Top;
            layProfesorados.FlowDirection = FlowDirection.RightToLeft;
            layProfesorados.Location = new Point(0, 30);
            layProfesorados.Name = "layProfesorados";
            layProfesorados.Size = new Size(200, 30);
            layProfesorados.TabIndex = 1;
            // 
            // btnProfesoradosExpand
            // 
            btnProfesoradosExpand.BackColor = Color.FromArgb(25, 118, 210);
            btnProfesoradosExpand.FlatAppearance.BorderSize = 0;
            btnProfesoradosExpand.FlatStyle = FlatStyle.Flat;
            btnProfesoradosExpand.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfesoradosExpand.ForeColor = Color.White;
            btnProfesoradosExpand.Location = new Point(20, 0);
            btnProfesoradosExpand.Margin = new Padding(0);
            btnProfesoradosExpand.Name = "btnProfesoradosExpand";
            btnProfesoradosExpand.Size = new Size(180, 30);
            btnProfesoradosExpand.TabIndex = 0;
            btnProfesoradosExpand.Text = "Profesorados";
            btnProfesoradosExpand.TextAlign = ContentAlignment.MiddleRight;
            btnProfesoradosExpand.UseVisualStyleBackColor = false;
            btnProfesoradosExpand.Click += btnProfesoradosExpand_Click;
            // 
            // btnLengua
            // 
            btnLengua.BackColor = Color.FromArgb(25, 118, 210);
            btnLengua.FlatAppearance.BorderSize = 0;
            btnLengua.FlatStyle = FlatStyle.Flat;
            btnLengua.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLengua.ForeColor = Color.WhiteSmoke;
            btnLengua.Location = new Point(40, 30);
            btnLengua.Margin = new Padding(0);
            btnLengua.Name = "btnLengua";
            btnLengua.Size = new Size(160, 25);
            btnLengua.TabIndex = 1;
            btnLengua.Text = "Lengua";
            btnLengua.TextAlign = ContentAlignment.MiddleRight;
            btnLengua.UseVisualStyleBackColor = false;
            // 
            // btnIngles
            // 
            btnIngles.BackColor = Color.FromArgb(25, 118, 210);
            btnIngles.FlatAppearance.BorderSize = 0;
            btnIngles.FlatStyle = FlatStyle.Flat;
            btnIngles.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngles.ForeColor = Color.WhiteSmoke;
            btnIngles.Location = new Point(40, 55);
            btnIngles.Margin = new Padding(0);
            btnIngles.Name = "btnIngles";
            btnIngles.Size = new Size(160, 25);
            btnIngles.TabIndex = 2;
            btnIngles.Text = "Inglés";
            btnIngles.TextAlign = ContentAlignment.MiddleRight;
            btnIngles.UseVisualStyleBackColor = false;
            // 
            // btnHistoria
            // 
            btnHistoria.BackColor = Color.FromArgb(25, 118, 210);
            btnHistoria.FlatAppearance.BorderSize = 0;
            btnHistoria.FlatStyle = FlatStyle.Flat;
            btnHistoria.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistoria.ForeColor = Color.WhiteSmoke;
            btnHistoria.Location = new Point(40, 80);
            btnHistoria.Margin = new Padding(0);
            btnHistoria.Name = "btnHistoria";
            btnHistoria.Size = new Size(160, 25);
            btnHistoria.TabIndex = 3;
            btnHistoria.Text = "Historia";
            btnHistoria.TextAlign = ContentAlignment.MiddleRight;
            btnHistoria.UseVisualStyleBackColor = false;
            // 
            // btnBiologia
            // 
            btnBiologia.BackColor = Color.FromArgb(25, 118, 210);
            btnBiologia.FlatAppearance.BorderSize = 0;
            btnBiologia.FlatStyle = FlatStyle.Flat;
            btnBiologia.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBiologia.ForeColor = Color.WhiteSmoke;
            btnBiologia.Location = new Point(40, 105);
            btnBiologia.Margin = new Padding(0);
            btnBiologia.Name = "btnBiologia";
            btnBiologia.Size = new Size(160, 25);
            btnBiologia.TabIndex = 4;
            btnBiologia.Text = "Biología";
            btnBiologia.TextAlign = ContentAlignment.MiddleRight;
            btnBiologia.UseVisualStyleBackColor = false;
            // 
            // btnMatematicas
            // 
            btnMatematicas.BackColor = Color.FromArgb(25, 118, 210);
            btnMatematicas.FlatAppearance.BorderSize = 0;
            btnMatematicas.FlatStyle = FlatStyle.Flat;
            btnMatematicas.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMatematicas.ForeColor = Color.WhiteSmoke;
            btnMatematicas.Location = new Point(40, 130);
            btnMatematicas.Margin = new Padding(0);
            btnMatematicas.Name = "btnMatematicas";
            btnMatematicas.Size = new Size(160, 25);
            btnMatematicas.TabIndex = 5;
            btnMatematicas.Text = "Matemáticas";
            btnMatematicas.TextAlign = ContentAlignment.MiddleRight;
            btnMatematicas.UseVisualStyleBackColor = false;
            // 
            // btnEducacionFisica
            // 
            btnEducacionFisica.BackColor = Color.FromArgb(25, 118, 210);
            btnEducacionFisica.FlatAppearance.BorderSize = 0;
            btnEducacionFisica.FlatStyle = FlatStyle.Flat;
            btnEducacionFisica.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEducacionFisica.ForeColor = Color.WhiteSmoke;
            btnEducacionFisica.Location = new Point(40, 155);
            btnEducacionFisica.Margin = new Padding(0);
            btnEducacionFisica.Name = "btnEducacionFisica";
            btnEducacionFisica.Size = new Size(160, 25);
            btnEducacionFisica.TabIndex = 6;
            btnEducacionFisica.Text = "Educación Física";
            btnEducacionFisica.TextAlign = ContentAlignment.MiddleRight;
            btnEducacionFisica.UseVisualStyleBackColor = false;
            // 
            // btnQuimica
            // 
            btnQuimica.BackColor = Color.FromArgb(25, 118, 210);
            btnQuimica.FlatAppearance.BorderSize = 0;
            btnQuimica.FlatStyle = FlatStyle.Flat;
            btnQuimica.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuimica.ForeColor = Color.WhiteSmoke;
            btnQuimica.Location = new Point(40, 180);
            btnQuimica.Margin = new Padding(0);
            btnQuimica.Name = "btnQuimica";
            btnQuimica.Size = new Size(160, 25);
            btnQuimica.TabIndex = 7;
            btnQuimica.Text = "Química";
            btnQuimica.TextAlign = ContentAlignment.MiddleRight;
            btnQuimica.UseVisualStyleBackColor = false;
            // 
            // btnPrimaria
            // 
            btnPrimaria.BackColor = Color.FromArgb(25, 118, 210);
            btnPrimaria.FlatAppearance.BorderSize = 0;
            btnPrimaria.FlatStyle = FlatStyle.Flat;
            btnPrimaria.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrimaria.ForeColor = Color.WhiteSmoke;
            btnPrimaria.Location = new Point(40, 205);
            btnPrimaria.Margin = new Padding(0);
            btnPrimaria.Name = "btnPrimaria";
            btnPrimaria.Size = new Size(160, 25);
            btnPrimaria.TabIndex = 8;
            btnPrimaria.Text = "Primaria";
            btnPrimaria.TextAlign = ContentAlignment.MiddleRight;
            btnPrimaria.UseVisualStyleBackColor = false;
            // 
            // layTecnicaturas
            // 
            layTecnicaturas.BackColor = Color.FromArgb(25, 118, 210);
            layTecnicaturas.Controls.Add(btnTecnicaturasExpand);
            layTecnicaturas.Controls.Add(btnInformatica);
            layTecnicaturas.Controls.Add(btnFrutihorticola);
            layTecnicaturas.Controls.Add(btnAlimentos);
            layTecnicaturas.Controls.Add(btnTurismo);
            layTecnicaturas.Controls.Add(btnForestal);
            layTecnicaturas.Controls.Add(btnDisGrafico);
            layTecnicaturas.Dock = DockStyle.Top;
            layTecnicaturas.FlowDirection = FlowDirection.RightToLeft;
            layTecnicaturas.Location = new Point(0, 0);
            layTecnicaturas.Name = "layTecnicaturas";
            layTecnicaturas.Size = new Size(200, 30);
            layTecnicaturas.TabIndex = 0;
            // 
            // btnTecnicaturasExpand
            // 
            btnTecnicaturasExpand.BackColor = Color.FromArgb(25, 118, 210);
            btnTecnicaturasExpand.FlatAppearance.BorderSize = 0;
            btnTecnicaturasExpand.FlatStyle = FlatStyle.Flat;
            btnTecnicaturasExpand.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTecnicaturasExpand.ForeColor = Color.White;
            btnTecnicaturasExpand.Location = new Point(20, 0);
            btnTecnicaturasExpand.Margin = new Padding(0);
            btnTecnicaturasExpand.Name = "btnTecnicaturasExpand";
            btnTecnicaturasExpand.Size = new Size(180, 30);
            btnTecnicaturasExpand.TabIndex = 0;
            btnTecnicaturasExpand.Text = "Tecnicaturas";
            btnTecnicaturasExpand.TextAlign = ContentAlignment.MiddleRight;
            btnTecnicaturasExpand.UseVisualStyleBackColor = false;
            btnTecnicaturasExpand.Click += btnTecnicaturasExpand_Click;
            // 
            // btnInformatica
            // 
            btnInformatica.BackColor = Color.FromArgb(25, 118, 210);
            btnInformatica.FlatAppearance.BorderSize = 0;
            btnInformatica.FlatStyle = FlatStyle.Flat;
            btnInformatica.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInformatica.ForeColor = Color.WhiteSmoke;
            btnInformatica.Location = new Point(40, 30);
            btnInformatica.Margin = new Padding(0);
            btnInformatica.Name = "btnInformatica";
            btnInformatica.Size = new Size(160, 25);
            btnInformatica.TabIndex = 1;
            btnInformatica.Text = "Informática";
            btnInformatica.TextAlign = ContentAlignment.MiddleRight;
            btnInformatica.UseVisualStyleBackColor = false;
            btnInformatica.Click += btnInformatica_Click;
            // 
            // btnFrutihorticola
            // 
            btnFrutihorticola.BackColor = Color.FromArgb(25, 118, 210);
            btnFrutihorticola.FlatAppearance.BorderSize = 0;
            btnFrutihorticola.FlatStyle = FlatStyle.Flat;
            btnFrutihorticola.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFrutihorticola.ForeColor = Color.WhiteSmoke;
            btnFrutihorticola.Location = new Point(40, 55);
            btnFrutihorticola.Margin = new Padding(0);
            btnFrutihorticola.Name = "btnFrutihorticola";
            btnFrutihorticola.Size = new Size(160, 25);
            btnFrutihorticola.TabIndex = 2;
            btnFrutihorticola.Text = "Frutihortícola";
            btnFrutihorticola.TextAlign = ContentAlignment.MiddleRight;
            btnFrutihorticola.UseVisualStyleBackColor = false;
            // 
            // btnAlimentos
            // 
            btnAlimentos.BackColor = Color.FromArgb(25, 118, 210);
            btnAlimentos.FlatAppearance.BorderSize = 0;
            btnAlimentos.FlatStyle = FlatStyle.Flat;
            btnAlimentos.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlimentos.ForeColor = Color.WhiteSmoke;
            btnAlimentos.Location = new Point(40, 80);
            btnAlimentos.Margin = new Padding(0);
            btnAlimentos.Name = "btnAlimentos";
            btnAlimentos.Size = new Size(160, 25);
            btnAlimentos.TabIndex = 3;
            btnAlimentos.Text = "Alimentos";
            btnAlimentos.TextAlign = ContentAlignment.MiddleRight;
            btnAlimentos.UseVisualStyleBackColor = false;
            // 
            // btnTurismo
            // 
            btnTurismo.BackColor = Color.FromArgb(25, 118, 210);
            btnTurismo.FlatAppearance.BorderSize = 0;
            btnTurismo.FlatStyle = FlatStyle.Flat;
            btnTurismo.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTurismo.ForeColor = Color.WhiteSmoke;
            btnTurismo.Location = new Point(40, 105);
            btnTurismo.Margin = new Padding(0);
            btnTurismo.Name = "btnTurismo";
            btnTurismo.Size = new Size(160, 25);
            btnTurismo.TabIndex = 4;
            btnTurismo.Text = "Turismo";
            btnTurismo.TextAlign = ContentAlignment.MiddleRight;
            btnTurismo.UseVisualStyleBackColor = false;
            // 
            // btnForestal
            // 
            btnForestal.BackColor = Color.FromArgb(25, 118, 210);
            btnForestal.FlatAppearance.BorderSize = 0;
            btnForestal.FlatStyle = FlatStyle.Flat;
            btnForestal.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnForestal.ForeColor = Color.WhiteSmoke;
            btnForestal.Location = new Point(40, 130);
            btnForestal.Margin = new Padding(0);
            btnForestal.Name = "btnForestal";
            btnForestal.Size = new Size(160, 25);
            btnForestal.TabIndex = 5;
            btnForestal.Text = "Forestal";
            btnForestal.TextAlign = ContentAlignment.MiddleRight;
            btnForestal.UseVisualStyleBackColor = false;
            // 
            // btnDisGrafico
            // 
            btnDisGrafico.BackColor = Color.FromArgb(25, 118, 210);
            btnDisGrafico.FlatAppearance.BorderSize = 0;
            btnDisGrafico.FlatStyle = FlatStyle.Flat;
            btnDisGrafico.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDisGrafico.ForeColor = Color.WhiteSmoke;
            btnDisGrafico.Location = new Point(40, 155);
            btnDisGrafico.Margin = new Padding(0);
            btnDisGrafico.Name = "btnDisGrafico";
            btnDisGrafico.Size = new Size(160, 25);
            btnDisGrafico.TabIndex = 6;
            btnDisGrafico.Text = "Diseño Gráfico";
            btnDisGrafico.TextAlign = ContentAlignment.MiddleRight;
            btnDisGrafico.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 29);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 42, 86);
            panel1.BackgroundImage = Properties.Resources.Screenshot_1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 136);
            panel1.TabIndex = 0;
            // 
            // layFooter
            // 
            layFooter.BackColor = Color.SlateGray;
            layFooter.Controls.Add(lblStated);
            layFooter.Controls.Add(label1);
            layFooter.Dock = DockStyle.Bottom;
            layFooter.FlowDirection = FlowDirection.RightToLeft;
            layFooter.Location = new Point(0, 700);
            layFooter.Name = "layFooter";
            layFooter.Size = new Size(1280, 20);
            layFooter.TabIndex = 6;
            // 
            // lblStated
            // 
            lblStated.AutoSize = true;
            lblStated.Location = new Point(1261, 0);
            lblStated.Name = "lblStated";
            lblStated.Size = new Size(16, 15);
            lblStated.TabIndex = 0;
            lblStated.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1213, 0);
            label1.Margin = new Padding(3, 0, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Estado:";
            // 
            // layTopBar
            // 
            layTopBar.BackColor = Color.FromArgb(41, 98, 255);
            layTopBar.Controls.Add(btnWindowsClosed);
            layTopBar.Controls.Add(btnMaximized);
            layTopBar.Controls.Add(btnWindowsMinimized);
            layTopBar.Dock = DockStyle.Top;
            layTopBar.FlowDirection = FlowDirection.RightToLeft;
            layTopBar.Location = new Point(0, 0);
            layTopBar.Name = "layTopBar";
            layTopBar.Size = new Size(1280, 30);
            layTopBar.TabIndex = 7;
            layTopBar.MouseDown += layTopBar_MouseDown;
            // 
            // btnWindowsClosed
            // 
            btnWindowsClosed.BackColor = Color.LightCoral;
            btnWindowsClosed.FlatAppearance.BorderSize = 0;
            btnWindowsClosed.FlatStyle = FlatStyle.Flat;
            btnWindowsClosed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWindowsClosed.Location = new Point(1248, 3);
            btnWindowsClosed.Name = "btnWindowsClosed";
            btnWindowsClosed.Size = new Size(29, 23);
            btnWindowsClosed.TabIndex = 5;
            btnWindowsClosed.Text = "X";
            btnWindowsClosed.UseVisualStyleBackColor = false;
            btnWindowsClosed.Click += btnWindowsClosed_Click;
            // 
            // btnMaximized
            // 
            btnMaximized.BackColor = Color.Ivory;
            btnMaximized.FlatAppearance.BorderSize = 0;
            btnMaximized.FlatStyle = FlatStyle.Flat;
            btnMaximized.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximized.Location = new Point(1213, 3);
            btnMaximized.Name = "btnMaximized";
            btnMaximized.Size = new Size(29, 23);
            btnMaximized.TabIndex = 7;
            btnMaximized.Text = "❐";
            btnMaximized.UseVisualStyleBackColor = false;
            btnMaximized.Click += btnMaximized_Click;
            // 
            // btnWindowsMinimized
            // 
            btnWindowsMinimized.BackColor = Color.Ivory;
            btnWindowsMinimized.FlatAppearance.BorderSize = 0;
            btnWindowsMinimized.FlatStyle = FlatStyle.Flat;
            btnWindowsMinimized.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWindowsMinimized.Location = new Point(1178, 3);
            btnWindowsMinimized.Name = "btnWindowsMinimized";
            btnWindowsMinimized.Size = new Size(29, 23);
            btnWindowsMinimized.TabIndex = 6;
            btnWindowsMinimized.Text = "_";
            btnWindowsMinimized.UseVisualStyleBackColor = false;
            btnWindowsMinimized.Click += btnWindowsMinimized_Click;
            // 
            // WindowsHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlTrabajo);
            Controls.Add(layFooter);
            Controls.Add(layTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WindowsHome";
            Text = "WindowsHome";
            pnlTrabajo.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            layProfesorados.ResumeLayout(false);
            layTecnicaturas.ResumeLayout(false);
            layFooter.ResumeLayout(false);
            layFooter.PerformLayout();
            layTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTrabajo;
        private FlowLayoutPanel layFooter;
        private Label lblStated;
        private Label label1;
        private FlowLayoutPanel layTopBar;
        private Button btnWindowsClosed;
        private Button btnWindowsMinimized;
        private Button btnMaximized;
        private Panel pnlSidebar;
        private Panel pnlTrabajoHome;
        private Panel panel1;
        private Panel panel3;
        private FlowLayoutPanel layTecnicaturas;
        private Button btnTecnicaturasExpand;
        private Panel panel2;
        private Button btnInformatica;
        private Button btnFrutihorticola;
        private Button btnAlimentos;
        private Button btnTurismo;
        private Button btnForestal;
        private Button btnDisGrafico;
        private FlowLayoutPanel layProfesorados;
        private Button btnProfesoradosExpand;
        private Button btnLengua;
        private Button btnIngles;
        private Button btnHistoria;
        private Button btnBiologia;
        private Button btnMatematicas;
        private Button btnEducacionFisica;
        private Button btnQuimica;
        private Button btnPrimaria;
    }
}
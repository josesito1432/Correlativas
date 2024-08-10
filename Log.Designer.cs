namespace Pruebas1
{
    partial class Log
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
            layTopBar = new FlowLayoutPanel();
            btnWindowsClosed = new Button();
            btnWindowsMinimized = new Button();
            pnlTrabajo = new Panel();
            layFooter = new FlowLayoutPanel();
            lblStated = new Label();
            label1 = new Label();
            btnAdmin = new Button();
            btnAlumno = new Button();
            layTopBar.SuspendLayout();
            pnlTrabajo.SuspendLayout();
            layFooter.SuspendLayout();
            SuspendLayout();
            // 
            // layTopBar
            // 
            layTopBar.BackColor = Color.DarkSlateGray;
            layTopBar.Controls.Add(btnWindowsClosed);
            layTopBar.Controls.Add(btnWindowsMinimized);
            layTopBar.Dock = DockStyle.Top;
            layTopBar.FlowDirection = FlowDirection.RightToLeft;
            layTopBar.Location = new Point(0, 0);
            layTopBar.Name = "layTopBar";
            layTopBar.Size = new Size(350, 30);
            layTopBar.TabIndex = 4;
            layTopBar.MouseDown += flowLayoutPanel1_MouseDown;
            // 
            // btnWindowsClosed
            // 
            btnWindowsClosed.BackColor = Color.LightCoral;
            btnWindowsClosed.FlatAppearance.BorderSize = 0;
            btnWindowsClosed.FlatStyle = FlatStyle.Flat;
            btnWindowsClosed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWindowsClosed.Location = new Point(318, 3);
            btnWindowsClosed.Name = "btnWindowsClosed";
            btnWindowsClosed.Size = new Size(29, 23);
            btnWindowsClosed.TabIndex = 5;
            btnWindowsClosed.Text = "X";
            btnWindowsClosed.UseVisualStyleBackColor = false;
            btnWindowsClosed.Click += btnWindowsClosed_Click;
            // 
            // btnWindowsMinimized
            // 
            btnWindowsMinimized.BackColor = Color.Ivory;
            btnWindowsMinimized.FlatAppearance.BorderSize = 0;
            btnWindowsMinimized.FlatStyle = FlatStyle.Flat;
            btnWindowsMinimized.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWindowsMinimized.Location = new Point(283, 3);
            btnWindowsMinimized.Name = "btnWindowsMinimized";
            btnWindowsMinimized.Size = new Size(29, 23);
            btnWindowsMinimized.TabIndex = 6;
            btnWindowsMinimized.Text = "_";
            btnWindowsMinimized.UseVisualStyleBackColor = false;
            btnWindowsMinimized.Click += btnWindowsMinimized_Click;
            // 
            // pnlTrabajo
            // 
            pnlTrabajo.Controls.Add(btnAlumno);
            pnlTrabajo.Controls.Add(btnAdmin);
            pnlTrabajo.Dock = DockStyle.Fill;
            pnlTrabajo.Location = new Point(0, 30);
            pnlTrabajo.Name = "pnlTrabajo";
            pnlTrabajo.Size = new Size(350, 550);
            pnlTrabajo.TabIndex = 5;
            // 
            // layFooter
            // 
            layFooter.BackColor = Color.DarkSlateGray;
            layFooter.Controls.Add(lblStated);
            layFooter.Controls.Add(label1);
            layFooter.Dock = DockStyle.Bottom;
            layFooter.FlowDirection = FlowDirection.RightToLeft;
            layFooter.Location = new Point(0, 580);
            layFooter.Name = "layFooter";
            layFooter.Size = new Size(350, 20);
            layFooter.TabIndex = 0;
            // 
            // lblStated
            // 
            lblStated.AutoSize = true;
            lblStated.Location = new Point(331, 0);
            lblStated.Name = "lblStated";
            lblStated.Size = new Size(16, 15);
            lblStated.TabIndex = 0;
            lblStated.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 0);
            label1.Margin = new Padding(3, 0, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Estado:";
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(86, 177);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(155, 55);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAlumno
            // 
            btnAlumno.Location = new Point(86, 257);
            btnAlumno.Name = "btnAlumno";
            btnAlumno.Size = new Size(155, 55);
            btnAlumno.TabIndex = 2;
            btnAlumno.Text = "Alumno";
            btnAlumno.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 600);
            Controls.Add(pnlTrabajo);
            Controls.Add(layFooter);
            Controls.Add(layTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Log";
            Text = "Log";
            layTopBar.ResumeLayout(false);
            pnlTrabajo.ResumeLayout(false);
            layFooter.ResumeLayout(false);
            layFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlTopBar;
        private FlowLayoutPanel layTopBar;
        private Button btnWindowsClosed;
        private Button btnWindowsMinimized;
        private Panel pnlTrabajo;
        private FlowLayoutPanel layFooter;
        private Label lblStated;
        private Label label1;
        private Button btnAlumno;
        private Button btnAdmin;
    }
}
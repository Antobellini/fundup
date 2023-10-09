namespace CapaPresentacion
{
    partial class DashboardForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panelLeft = new Panel();
            btnAboutUs = new Button();
            panelSide = new Panel();
            btnReportes = new Button();
            btnMovimientos = new Button();
            btnTablero = new Button();
            panel2 = new Panel();
            pbLogoN = new PictureBox();
            btnSlider = new Button();
            pbLogoCompleto = new PictureBox();
            panel3 = new Panel();
            lblHora = new Label();
            btnCerrar = new Button();
            panel4 = new Panel();
            lbl2 = new Label();
            lblRol = new Label();
            lblTitulo = new Label();
            lblUsuario = new Label();
            lbl1 = new Label();
            panelContainer = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelLeft.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoCompleto).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(30, 50, 94);
            panelLeft.BorderStyle = BorderStyle.Fixed3D;
            panelLeft.Controls.Add(btnAboutUs);
            panelLeft.Controls.Add(panelSide);
            panelLeft.Controls.Add(btnReportes);
            panelLeft.Controls.Add(btnMovimientos);
            panelLeft.Controls.Add(btnTablero);
            panelLeft.Controls.Add(panel2);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(223, 720);
            panelLeft.TabIndex = 0;
            // 
            // btnAboutUs
            // 
            btnAboutUs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAboutUs.FlatAppearance.BorderSize = 0;
            btnAboutUs.FlatStyle = FlatStyle.Flat;
            btnAboutUs.ForeColor = Color.White;
            btnAboutUs.Image = (Image)resources.GetObject("btnAboutUs.Image");
            btnAboutUs.Location = new Point(3, 669);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.Size = new Size(46, 44);
            btnAboutUs.TabIndex = 1;
            btnAboutUs.UseVisualStyleBackColor = true;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.White;
            panelSide.Location = new Point(2, 158);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(8, 44);
            panelSide.TabIndex = 2;
            // 
            // btnReportes
            // 
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(10, 254);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(211, 44);
            btnReportes.TabIndex = 1;
            btnReportes.Text = "      Reportes";
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnMovimientos
            // 
            btnMovimientos.FlatAppearance.BorderSize = 0;
            btnMovimientos.FlatStyle = FlatStyle.Flat;
            btnMovimientos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMovimientos.ForeColor = Color.White;
            btnMovimientos.Image = (Image)resources.GetObject("btnMovimientos.Image");
            btnMovimientos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMovimientos.Location = new Point(10, 208);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(211, 44);
            btnMovimientos.TabIndex = 1;
            btnMovimientos.Text = "     Movimientos";
            btnMovimientos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // btnTablero
            // 
            btnTablero.FlatAppearance.BorderSize = 0;
            btnTablero.FlatStyle = FlatStyle.Flat;
            btnTablero.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTablero.ForeColor = Color.White;
            btnTablero.Image = (Image)resources.GetObject("btnTablero.Image");
            btnTablero.ImageAlign = ContentAlignment.MiddleLeft;
            btnTablero.Location = new Point(5, 158);
            btnTablero.Name = "btnTablero";
            btnTablero.Size = new Size(216, 44);
            btnTablero.TabIndex = 1;
            btnTablero.Text = "      Tablero";
            btnTablero.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTablero.UseVisualStyleBackColor = true;
            btnTablero.Click += BtnDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pbLogoN);
            panel2.Controls.Add(btnSlider);
            panel2.Controls.Add(pbLogoCompleto);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 149);
            panel2.TabIndex = 0;
            // 
            // pbLogoN
            // 
            pbLogoN.Image = (Image)resources.GetObject("pbLogoN.Image");
            pbLogoN.Location = new Point(3, 71);
            pbLogoN.Name = "pbLogoN";
            pbLogoN.Size = new Size(46, 50);
            pbLogoN.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoN.TabIndex = 0;
            pbLogoN.TabStop = false;
            // 
            // btnSlider
            // 
            btnSlider.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSlider.BackgroundImage = (Image)resources.GetObject("btnSlider.BackgroundImage");
            btnSlider.FlatAppearance.BorderSize = 0;
            btnSlider.FlatStyle = FlatStyle.Flat;
            btnSlider.ForeColor = Color.White;
            btnSlider.Image = (Image)resources.GetObject("btnSlider.Image");
            btnSlider.Location = new Point(175, 3);
            btnSlider.Name = "btnSlider";
            btnSlider.Size = new Size(46, 44);
            btnSlider.TabIndex = 1;
            btnSlider.UseVisualStyleBackColor = true;
            btnSlider.Click += Button1_Click;
            // 
            // pbLogoCompleto
            // 
            pbLogoCompleto.Image = (Image)resources.GetObject("pbLogoCompleto.Image");
            pbLogoCompleto.Location = new Point(60, 47);
            pbLogoCompleto.Name = "pbLogoCompleto";
            pbLogoCompleto.Size = new Size(156, 99);
            pbLogoCompleto.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoCompleto.TabIndex = 13;
            pbLogoCompleto.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblHora);
            panel3.Controls.Add(btnCerrar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(223, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(977, 49);
            panel3.TabIndex = 0;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.FromArgb(30, 50, 94);
            lblHora.Location = new Point(71, 17);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(83, 19);
            lblHora.TabIndex = 8;
            lblHora.Text = "HH:MM:SS";
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.FromArgb(30, 50, 94);
            btnCerrar.Location = new Point(920, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(57, 49);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 50, 94);
            panel4.Controls.Add(lbl2);
            panel4.Controls.Add(lblRol);
            panel4.Controls.Add(lblTitulo);
            panel4.Controls.Add(lblUsuario);
            panel4.Controls.Add(lbl1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(223, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(977, 100);
            panel4.TabIndex = 1;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.White;
            lbl2.Location = new Point(108, 55);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(46, 19);
            lbl2.TabIndex = 14;
            lbl2.Text = "Role:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRol.ForeColor = Color.White;
            lblRol.Location = new Point(160, 55);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(62, 19);
            lblRol.TabIndex = 14;
            lblRol.Text = "Admin";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(465, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(251, 33);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "Bienvenid@ de vuelta!";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(160, 20);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(180, 19);
            lblUsuario.TabIndex = 14;
            lblUsuario.Text = "Maximiliano Montaña";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.White;
            lbl1.Location = new Point(85, 20);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(69, 19);
            lbl1.TabIndex = 14;
            lbl1.Text = "Usuario:";
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(223, 149);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(977, 571);
            panelContainer.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // DashboardForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panelContainer);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelLeft);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "Form_Dashboard";
            WindowState = FormWindowState.Maximized;
            panelLeft.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogoN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoCompleto).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbLogoCompleto;
        private System.Windows.Forms.Button btnTablero;
        private System.Windows.Forms.Button btnSlider;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTitulo;
        private PictureBox pbLogoN;
    }
}
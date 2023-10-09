using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class DashboardForm : Form
    {
        int panelWidth;
        bool Hidden;

        public DashboardForm()
        {
            InitializeComponent();
            panelWidth = panelLeft.Width;
            Hidden = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void slidePanel(Button btn)
        {
            panelSide.Height = btn.Height;
            panelSide.Top = btn.Top;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Tablero";
            slidePanel(btnTablero);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 55)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Movimientos";
            slidePanel(btnMovimientos);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Reportes";
            slidePanel(btnReportes);
        }
    }
}

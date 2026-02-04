using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        // Para mover la ventana sin bordes
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            // Bordes redondeados
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
            // Paleta de colores moderna
            this.BackColor = Color.FromArgb(45, 45, 48);
            lblTime.ForeColor = Color.FromArgb(220, 220, 220);
            lblDate.ForeColor = Color.FromArgb(100, 181, 246);
            
            // Habilitar arrastre del formulario
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
            
            // También permitir arrastrar desde los labels
            lblTime.MouseDown += Form1_MouseDown;
            lblTime.MouseMove += Form1_MouseMove;
            lblTime.MouseUp += Form1_MouseUp;
            
            lblDate.MouseDown += Form1_MouseDown;
            lblDate.MouseMove += Form1_MouseMove;
            lblDate.MouseUp += Form1_MouseUp;
        }
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            
            // Animación sutil: pulso en los segundos
            int seconds = DateTime.Now.Second;
            lblTime.ForeColor = seconds % 2 == 0 
                ? Color.FromArgb(220, 220, 220) 
                : Color.FromArgb(200, 200, 200);
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            // Sombra sutil en el borde
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen shadowPen = new Pen(Color.FromArgb(50, 0, 0, 0), 3))
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, 40, 40, 180, 90);
                path.AddArc(Width - 41, 0, 40, 40, 270, 90);
                path.AddArc(Width - 41, Height - 41, 40, 40, 0, 90);
                path.AddArc(0, Height - 41, 40, 40, 90, 90);
                path.CloseFigure();
                e.Graphics.DrawPath(shadowPen, path);
            }
        }
    }
}

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ArtNetManager
{
    class ArtUI_Canvas : Panel
    {
        private Bitmap canvas;
        private Point start;
        private bool isMouseOver = false;

        public ArtUI_Canvas(Point location, Size size, Color color) : base()
        {
            this.DoubleBuffered = true;
            this.Location = location;
            this.Size = size;
            this.BackColor = color;

            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.MouseDown += new MouseEventHandler(ArtNet_UI_Canvas_MouseDown);
            this.MouseEnter += new EventHandler(ArtNet_UI_Canvas_MouseEnter);
            this.MouseLeave += new EventHandler(ArtNet_UI_Canvas_MouseLeave);

            ResizeCanvas(this.ClientRectangle.Size);
        }

        public void ResizeCanvas(Size size)
        {
            this.Size = size;

            Bitmap temp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, PixelFormat.Format32bppRgb);
            temp.MakeTransparent();
            if (canvas != null)
            {
                canvas.Dispose();
            }
            canvas = temp;
        }

        public virtual void DrawCanvas(Graphics g)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (canvas == null)
                return;

            using (Bitmap tmp = new Bitmap(canvas))
            {
                using (Graphics g = Graphics.FromImage(tmp))
                {
                    DrawCanvas(g);
                    if (isMouseOver)
                    {
                        Pen pen = new Pen(Brushes.Red);
                        pen.Width = 2.0f;
                        pen.DashPattern = new float[] { 4.0f, 3.0f, 1.0f, 3.0f };
                        pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                        g.DrawRectangle(pen, new Rectangle(new Point(0, 0), new Size(this.Size.Width - 2, this.Size.Height - 2)));
                    }
                    else
                    {
                        Pen pen = new Pen(Color.Blue);
                        pen.Width = 2.0f;
                        pen.DashPattern = new float[] { 4.0f, 3.0f, 1.0f, 3.0f };
                        pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                        g.DrawRectangle(pen, new Rectangle(new Point(0, 0), new Size(this.Size.Width - 2, this.Size.Height - 2)));
                    }
                }
                e.Graphics.DrawImage(tmp, 0, 0);
            }
        }

        void ArtNet_UI_Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                start = e.Location;
                this.MouseUp += new MouseEventHandler(ArtNet_UI_Canvas_MouseUp);
                this.MouseMove += new MouseEventHandler(ArtNet_UI_Canvas_MouseMove);
            }
        }

        void ArtNet_UI_Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            this.MouseMove -= new MouseEventHandler(ArtNet_UI_Canvas_MouseMove);
            this.MouseUp -= new MouseEventHandler(ArtNet_UI_Canvas_MouseUp);
        }

        void ArtNet_UI_Canvas_MouseMove(object sender, MouseEventArgs e)
        {

            int newX = this.Location.X - (start.X - e.X);
            int newY = this.Location.Y - (start.Y - e.Y);

            if ((newX >= 0) && (newY >= 0))
            {
                if ((newX <= this.Parent.ClientSize.Width - this.ClientSize.Width) && (newY <= this.Parent.ClientSize.Height - this.ClientSize.Height))
                {
                    this.Location = new Point(newX, newY);
                }
            }
        }

        void ArtNet_UI_Canvas_MouseEnter(object sender, System.EventArgs e)
        {
            isMouseOver = true;
            Invalidate();
        }

        void ArtNet_UI_Canvas_MouseLeave(object sender, System.EventArgs e)
        {
            isMouseOver = false;
            Invalidate();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}

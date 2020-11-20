using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArtNetManager
{
    class ArtUI_Matrix : ArtUI_Canvas
    {
        private List<ArtUI_Pixel> pixels { get; set; }
        public ArtNetNode node { get; set; }
        private int port { get; set; }
        private int columns { get; set; }
        private int rows { get; set; }
        public bool isTagged { get; set; }

        public const int UPDATE_ULTRA_FAST = 5;
        public const int UPDATE_FAST = 20;
        public const int UPDATE_SLOW = 40;
        private Timer updateTimer { get; set; }

        public ArtUI_Matrix(ArtNetNode node, int port, Size matrixSize, Point location, Size pixelSize, Color color) : base(location, pixelSize, color)
        {
            this.columns = matrixSize.Width;
            this.rows = matrixSize.Height;
            this.node = node;
            this.port = port;
            isTagged = false;
        }

        public void Start(int interval)
        {
            updateTimer = new Timer();
            updateTimer.Interval = interval;
            updateTimer.Tick += new EventHandler(TriggerUpdate);
            updateTimer.Start();
        }

        private void TriggerUpdate(object sender, EventArgs e)
        {
            Invalidate();
        }

        public void Create()
        {
            pixels = new List<ArtUI_Pixel>();

            int i = 0;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    int x = c >= 0 ? c * Size.Width - 1 : 0;
                    int y = r >= 0 ? r * Size.Height - 1 : 0;

                    ArtUI_Pixel pixel = new ArtUI_Pixel();
                    pixel.Rect = new Rectangle(new Point(x, y), new Size(Size.Width, Size.Height));
                    pixel.Index = i++;
                    pixel.Port = port;
                    pixels.Add(pixel);
                }
            }

            ResizeCanvas(new Size(columns * Size.Width, rows * Size.Height));
        }

        public override void DrawCanvas(Graphics g)
        {
            g.Clear(Color.DarkGray); // Matrix Bkcolor
            foreach (ArtUI_Pixel pixel in pixels)
            {
                Color rgbColor = Color.Black;
                if ((node != null) && (node.PortValid(pixel.Port)))
                {
                    if (pixel.Index < 170)
                        rgbColor = node.Ports[pixel.Port].RgbData[pixel.Index]; // Get DMX Color
                }

                Pen blackPen = new Pen(Color.FromArgb(128, 96, 96, 96), 0.5f);
                g.DrawRectangle(blackPen, pixel.Rect);

                Brush pixBrush = new SolidBrush(rgbColor);
                g.FillRectangle(pixBrush, pixel.Rect);
            }

            if (node != null)
            {
                string txt = string.Format("{0}.{1}.{2}/{3}", node.Net, node.Subnet, port, pixels.Count);

                Font txtFont = new Font("Calibri", 10);

                SizeF txtSize = new SizeF();
                txtSize = g.MeasureString(txt, txtFont);

                if (isTagged)
                {
                    Brush brush = new SolidBrush(Color.Yellow);
                    g.FillRectangle(brush, 0.0F, 0.0F, txtSize.Width, txtSize.Height);

                    SolidBrush txtBrush = new SolidBrush(Color.Black);
                    g.DrawString(txt, txtFont, txtBrush, 0, 0);
                }
                else
                {
                    SolidBrush txtBrush = new SolidBrush(Color.White);
                    g.DrawString(txt, txtFont, txtBrush, 0, 0);
                }
            }
        }
    }
}

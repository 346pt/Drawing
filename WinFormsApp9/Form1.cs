namespace WinFormsApp9
{
    public partial class Form1 : Form
    {

        Bitmap bitmap = new Bitmap(450, 450);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 100; x < 135; x++)
            {
                for (int y = 100; y < 135; y++)
                {
                    bitmap.SetPixel(x, y, Color.Green);
                }
            }
            pictureBox1.Image = bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 400; i++)
            {
                for (int x = 0; x < 400; x++)
                {
                    bitmap.SetPixel(x, x, Color.Black);
                }
            }
            pictureBox1.Image = bitmap;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int y = 200;
            for (int x = 150; x < 400; x++)
            {
                if (x >= 400)
                {
                    x = 1;
                }
                bitmap.SetPixel(x, y, Color.Black);
            }
            pictureBox1.Image = bitmap;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = 200;
            for (int y = 0; y < 400; y++)
            {
                bitmap.SetPixel(x, y, Color.Black);
                if (y < 1)
                {
                    y = 1;
                }
            }
            pictureBox1.Image = bitmap;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 400; x++)
            {
                for (int y = 0; y < 400; y++)
                {
                    bitmap.SetPixel(x, y, Color.Transparent);
                }
            }
            pictureBox1.Image = bitmap;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 400; x++)
            {
                for (int y = 0; y < 400; y++)
                {
                    bitmap.SetPixel(x, y, Color.Black);
                }
            }

            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                bitmap.SetPixel(rnd.Next(0, 400), rnd.Next(0, 400), Color.White);
            }

            pictureBox1.Image = bitmap;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            int cx = pictureBox1.Width;
            int cy = pictureBox1.Height / 2;

            PointF[] ptf = new PointF[cx];
            int cw = 10;

            for (int i = 0; i < cx; i++)
            {
                ptf[i].X = i;
                ptf[i].Y = (float)((cy / 2) * (1 - Math.Sin(i * cw * Math.PI / (cx - 1))));
            }
            g.DrawLines(Pens.Black, ptf);
            g.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int y = 200;
            for (int x = 0; x < 400; x++)
            {
                bitmap.SetPixel(x, y, Color.Black);
            }
            int f = 200;
            for (y = 0; y < 400; y++)
            {
                bitmap.SetPixel(f, y, Color.Black);
            }

            int cx = 400;
            int cy = 400;
            int cw = 10;

            for (int i = 0; i < cx; i++)
            {
                double s = (cy / 2) * (1 - Math.Sin(i * cw * Math.PI / (cx - 1)));
                bitmap.SetPixel(i, (int)s, Color.Black);
            }
            pictureBox1.Image = bitmap;
        }
    }
}
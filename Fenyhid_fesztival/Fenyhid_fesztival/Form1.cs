namespace Fenyhid_fesztival
{
    public partial class Form1 : Form
    {
        private List<Fénykapu> kapuk = new List<Fénykapu>();
        private int kivalasztott = -1;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private float animT = 0f;
        private PointF gombPozicio;
        private bool estiNezet = false;
        public Form1()
        {
            InitializeComponent();
            kapuk.AddRange(new[]
            {
                new Fénykapu { Nev = "Fõkapu",      X = 90,  Y = 110, Sugar = 18, Szin = Color.Gold },
                new Fénykapu { Nev = "Ligetív",     X = 210, Y = 80,  Sugar = 16, Szin = Color.Blue },
                new Fénykapu { Nev = "Zenehíd",     X = 340, Y = 140, Sugar = 20, Szin = Color.Turquoise },
                new Fénykapu { Nev = "Kertfény",    X = 470, Y = 95,  Sugar = 17, Szin = Color.Green },
                new Fénykapu { Nev = "Színpadkapu", X = 610, Y = 150, Sugar = 21, Szin = Color.Red },
                new Fénykapu { Nev = "Esti boltív", X = 740, Y = 110, Sugar = 19, Szin = Color.Purple },
            });
            foreach (Fénykapu k in kapuk)
            {
                comboBox1.Items.Add(k.Nev);
            }
            timer.Interval = 16;
            timer.Tick += timer_Tick;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (estiNezet)
            {
                g.Clear(Color.FromArgb(10, 10, 40));
            }
            else
            {
                g.Clear(Color.SkyBlue);
            }


            Pen vonalPen = estiNezet ? new Pen(Color.CornflowerBlue, 2) : Pens.Gray;
            for (int i = 0; i < kapuk.Count - 1; i++)
            {
                g.DrawLine(vonalPen, kapuk[i].Pozicio(), kapuk[i + 1].Pozicio());
            }


            foreach (Fénykapu k in kapuk)
            {
                int i = kapuk.IndexOf(k);
                int sugar = (i == kivalasztott) ? k.Sugar + 8 : k.Sugar;
                Pen keret = (i == kivalasztott) ? Pens.White : Pens.Gray;

                if (estiNezet)
                {

                    g.FillEllipse(new SolidBrush(Color.FromArgb(60, k.Szin)),
                        k.X - sugar - 6, k.Y - sugar - 6, (sugar + 6) * 2, (sugar + 6) * 2);
                }

                g.FillEllipse(new SolidBrush(k.Szin),
                    k.X - sugar, k.Y - sugar, sugar * 2, sugar * 2);

                g.DrawEllipse(keret,
                    k.X - sugar, k.Y - sugar, sugar * 2, sugar * 2);

                Brush szovegSzin = estiNezet ? Brushes.White : Brushes.Black;
                g.DrawString(k.Nev, this.Font, szovegSzin, k.X - sugar, k.Y + sugar + 2);
            }


            g.FillEllipse(Brushes.Black, gombPozicio.X - 8, gombPozicio.Y - 8, 16, 16);
            g.FillEllipse(Brushes.Black, gombPozicio.X - 5, gombPozicio.Y - 5, 10, 10);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kivalasztott = comboBox1.SelectedIndex;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < kapuk.Count; i++)
            {
                int dx = e.X - kapuk[i].X;
                int dy = e.Y - kapuk[i].Y;
                double tavolsag = Math.Sqrt(dx * dx + dy * dy);

                if (tavolsag <= kapuk[i].Sugar + 5)
                {
                    kivalasztott = i;
                    comboBox1.SelectedIndex = i;
                    pictureBox1.Invalidate();
                    break;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            animT += 0.003f;
            if (animT >= 1f) animT = 0f;

            int n = kapuk.Count;
            float step = 1f / n;
            int i = (int)(animT / step) % n;
            int j = (i + 1) % n;
            float local = (animT - i * step) / step;

            PointF p0 = new PointF(kapuk[i].X, kapuk[i].Y);
            PointF p1 = new PointF(kapuk[j].X, kapuk[j].Y);

            gombPozicio = new PointF(
                p0.X + (p1.X - p0.X) * local,
                p0.Y + (p1.Y - p0.Y) * local);

            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            estiNezet = !estiNezet;
            button2.Text = estiNezet ? "Nappali nézet" : "Esti nézet";
            pictureBox1.Invalidate();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kivalasztott = -1;
            comboBox1.SelectedIndex = -1;
            estiNezet = false;
            timer.Stop();
            animT = 0f;
            pictureBox1.Invalidate();
        }
    }
}
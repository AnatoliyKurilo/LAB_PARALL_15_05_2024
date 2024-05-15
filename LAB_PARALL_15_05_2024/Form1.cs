using System.Drawing.Drawing2D;

namespace LAB_PARALL_15_05_2024
{
    public partial class Form1 : Form
    {
        public int X;
        public int Y;
        public int R;
        public int XDir;
        public int YDir;

        public GraphicsPath PathColor;
        public Color CircleColor;

        public Form1()
        {
            InitializeComponent();
            PathColor = new GraphicsPath();
            CircleColor = Color.Yellow;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDir = 1;
            YDir = -1;
            R = 30;
            X = pictureBox1.Width / 2;
            Y = pictureBox1.Height / 2;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            HatchBrush hbx = new HatchBrush(HatchStyle.SolidDiamond, CircleColor);
            g.FillEllipse(hbx, X - R, Y - R, 2 * R, 2 * R);


            PathColor.Reset();
            PathColor.StartFigure();
            PathColor.AddEllipse(X - R, Y - R, 2 * R, 2 * R);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (X - R < 0) XDir = 1;
            if (X + R + 5 > pictureBox1.Width) XDir = -1;
            if (Y - R < 0) YDir = 1;
            if (Y + R + 5 > pictureBox1.Height) YDir = -1;

            X += XDir;
            Y += YDir;

            pictureBox1.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point tchk = new Point(e.X, e.Y);
                if (PathColor.IsVisible(tchk))
                {Form2 form = new Form2();
                    form.CircleColor = CircleColor;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        CircleColor = form.CircleColor;
                        pictureBox1.Invalidate();
                        form.Close();
                    }
                }
            }
        }
    }
}

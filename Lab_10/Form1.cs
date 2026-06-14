namespace Lab_10
{
    public partial class Form1 : Form
    {
        private float t = 0f;
        private float angle = 0f;
        private System.Windows.Forms.Timer Task2Timer;

        private float offsetX = 0f;
        private float offsetY = 0f;
        private System.Windows.Forms.Timer Task3Timer;

        private float zoom = 1.0f;
        private System.Windows.Forms.Timer Task4Timer;

        public Form1()
        {
            Task2Timer = new System.Windows.Forms.Timer();
            Task2Timer.Interval = 50;
            Task2Timer.Tick += Task2_TimerTick;

            Task3Timer = new System.Windows.Forms.Timer();
            Task3Timer.Interval = 50;
            Task3Timer.Tick += Task3_TimerTick;

            Task4Timer = new System.Windows.Forms.Timer();
            Task4Timer.Interval = 50;
            Task4Timer.Tick += Task4_TimerTick;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = tabPage1.CreateGraphics();
            DrawKitten(graphics);
        }

        #region Task 2
        private void button2_Click(object sender, EventArgs e)
        {
            ClearInstances();

            if (Task2Timer.Enabled)
                Task2Timer.Stop();
            else
                Task2Timer.Start();
            EnableDoubleBuffering(tabPage2);
        }

        private void Task2_TimerTick(object sender, EventArgs e)
        {
            t += 0.03f;
            angle = angle + 5;
            tabPage2.Invalidate();
        }

        private void Task2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            float centerX = tabPage2.Width / 2f;
            float centerY = tabPage2.Height / 2f;

            graphics.TranslateTransform(centerX, centerY);
            graphics.RotateTransform(angle);
            graphics.TranslateTransform(-centerX, -centerY);

            DrawKitten(graphics);
        }

        #endregion

        #region Task 3
        private void button3_Click(object sender, EventArgs e)
        {
            ClearInstances();

            if (Task3Timer.Enabled)
                Task3Timer.Stop();
            else
                Task3Timer.Start();
            EnableDoubleBuffering(tabPage3);
        }

        private void Task3_TimerTick(object sender, EventArgs e)
        {
            t += 0.03f;

            if (t > 3.0f)
            {
                t = 0f;
            }

            float valX = 4f - 2f * t;
            float valY = 4f - (float)Math.Pow(t, 3);

            int scale = 80;
            offsetX = valX * scale;
            offsetY = valY * scale;

            tabPage3.Invalidate();
        }

        private void Task3_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            graphics.TranslateTransform(offsetX, offsetY);

            DrawKitten(graphics);
        }
        #endregion

        #region Task 4

        private void button4_Click(object sender, EventArgs e)
        {
            ClearInstances();
            if (Task4Timer.Enabled)
                Task4Timer.Stop();
            else
                Task4Timer.Start();
            EnableDoubleBuffering(tabPage4);
        }

        private void Task4_TimerTick(object sender, EventArgs e)
        {
            float catWidth = 300f;

            t += 0.01f;

            if (t > 1.0f)
            {
                t = 0f; 
            }

            float startX_pos = 400f;
            float endX_pos = -400;

            float startY_pos = -400f;
            float endY_pos = 400f;

            offsetX = startX_pos + (endX_pos - startX_pos) * t;
            offsetY = startY_pos + (endY_pos - startY_pos) * t;

            zoom = 1.0f + (t * 0.7f);

            tabPage4.Invalidate();
        }

        private void Task4_Paint(object sender, EventArgs e)
        {
            Graphics graphics = tabPage4.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            float currentCenterX = 450f + offsetX;
            float currentCenterY = 310f + offsetY;

            graphics.ScaleTransform(zoom, zoom);

            graphics.TranslateTransform(offsetX, offsetY);

            DrawKitten(graphics);
        }

        #endregion

        private void EnableDoubleBuffering(Control control)
        {
            var property = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            property?.SetValue(control, true, null);
        }

        private void DrawKitten(Graphics graphics)
        {
            Pen pen = new Pen(Brushes.Black, 1);
            SolidBrush black = new SolidBrush(Color.Black);
            SolidBrush yellow = new SolidBrush(Color.Yellow);
            SolidBrush pink = new SolidBrush(Color.Pink);

            graphics.DrawEllipse(pen, 300, 160, 300, 300);
            graphics.FillEllipse(black, 300, 160, 300, 300);

            graphics.DrawEllipse(pen, 350, 250, 70, 100);
            graphics.FillEllipse(yellow, 350, 250, 70, 100);

            graphics.DrawEllipse(pen, 480, 250, 70, 100);
            graphics.FillEllipse(yellow, 480, 250, 70, 100);

            graphics.DrawEllipse(pen, 380, 280, 20, 50);
            graphics.FillEllipse(black, 380, 280, 20, 50);

            graphics.DrawEllipse(pen, 500, 280, 20, 50);
            graphics.FillEllipse(black, 500, 280, 20, 50);

            PointF[] nose = new PointF[] { new PointF(420, 350), new PointF(480, 350), new PointF(450, 380) };
            graphics.DrawPolygon(pen, nose);
            graphics.FillPolygon(pink, nose);

            PointF[] rightEar = new PointF[] { new PointF(420, 164), new PointF(335, 125), new PointF(312, 250) };
            graphics.DrawCurve(pen, rightEar);
            graphics.FillClosedCurve(black, rightEar);

            PointF[] leftEar = new PointF[] { new PointF(480, 164), new PointF(565, 125), new PointF(588, 250) };
            graphics.DrawCurve(pen, leftEar);
            graphics.FillClosedCurve(black, leftEar);
        }

        private void ClearInstances()
        {
            angle = 0f;
            offsetX = 0f;
            offsetY = 0f;
            zoom = 1.0f;
            t = 0f;
        }
    }
}

namespace Lab10
{
    public partial class Form1 : Form
    {
        private float t = 0f;
        private float angle = 0f;
        private System.Windows.Forms.Timer animationTimer;

        private float offsetX = 0f;   
        private float offsetY = 0f;

        public Form1()
        {
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 50;
            animationTimer.Tick += Task2_TimerTick;
            DoubleBuffered = true;
            InitializeComponent();
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

        #region Task 1
        private void Task1Button_Click(object sender, EventArgs e)
        {
            Graphics graphics = tabPage1.CreateGraphics();
            DrawKitten(graphics);
        }
        #endregion

        #region Task 2
        private void Task2Button_Click(object sender, EventArgs e)
        {
            animationTimer.Start();
            EnableDoubleBuffering(tabPage2);
        }

        private void Task2_TimerTick(object sender, EventArgs e)
        {
            tabPage2.Invalidate();
            t = t + 10f;
            angle = angle + 5;
            Task2_Paint();
        }

        private void Task2_Paint()
        {
            Graphics graphics = tabPage2.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Рахуємо центр другого pictureBox
            float centerX = tabPage2.Width / 2f;
            float centerY = tabPage2.Height / 2f;

            // Застосовуємо трансформації обертання до холста
            graphics.TranslateTransform(centerX, centerY);
            graphics.RotateTransform(angle);
            graphics.TranslateTransform(-centerX, -centerY);

            // Викликаємо той самий метод малювання! Але тепер він підкоряється куту анімації.
            DrawKitten(graphics);
        }

        #endregion

        #region Task 3

        private void Task3_TimerTick(object sender, EventArgs e)
        {
            tabPage3.Invalidate();
            t = t + 10f;
            angle = angle + 5;
            Task3_Paint();
        }

        private void Task3_Paint()
        {
            Graphics graphics = tabPage3.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Зміщуємо ВСЮ графічну матрицю на прораховані offsetX та offsetY.
            // Завдяки цьому наш котик буде рухатися як єдине ціле, 
            // а його внутрішні координати ліній і кіл не зламаються.
            graphics.TranslateTransform(offsetX, offsetY);

            // Малюємо об'єкт за допомогою нашого універсального методу
            DrawKitten(graphics);
        }
        #endregion

        private void EnableDoubleBuffering(Control control)
        {
            var property = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            property?.SetValue(control, true, null);
        }
    }
}

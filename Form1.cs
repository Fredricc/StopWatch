namespace StopWatch
{
    public partial class StopWatch : Form
    {
        int timeHr, timeMn, timeSc, timeCss;
        bool isActive;
        public StopWatch()
        {
            InitializeComponent();
        }

        private void StopWatch_Load(object sender, EventArgs e)
        {
            ResetTimer();
            isActive = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTimer();
        }

        private void ResetTimer()
        {
            timeHr = 0;
            timeMn = 0;
            timeSc = 0;
            timeCss = 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeCss++;
                if (timeCss >= 60)
                {
                    timeSc++;
                    timeCss = 0;
                    if (timeSc >= 60)
                    {
                        timeMn++;
                        timeSc = 0;
                        if(timeMn >= 60)
                        {
                            timeHr++;
                            timeMn = 0;
                        }
                    }
                }
            }
            DrawTime();
        }

        private void DrawTime()
        {
            lblCs.Text = String.Format("{0:00}", timeCss);
            lblSc.Text = String.Format("{0:00}", timeSc);
            lblMin.Text = String.Format("{0:00}", timeMn);
            lblHr.Text = String.Format("{0:00}", timeHr);
        }
    }
}
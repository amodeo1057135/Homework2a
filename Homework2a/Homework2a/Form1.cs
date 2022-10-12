namespace Homework2a
{
    public partial class Form1 : Form
    {
        public Random rand = new Random();
        public Double sum, d = 0;
        public int tickCount = 0;
        public int maxIterations = 100;
        public int interval = 100;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.HideSelection = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < maxIterations; i++) {
                d = rand.NextDouble();
                sum += d;
                richTextBox1.AppendText(d + "\n");
            }
            richTextBox1.AppendText("Average: " + sum / maxIterations + "\n");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sum = 0;
            timer1.Interval = interval;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = rand.NextDouble();
            tickCount++;
            sum += d;
            richTextBox1.AppendText(d + "    avg: " + sum/tickCount + "\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
namespace _3_e_zadanie_go1x1noob
{
    public partial class Form1 : Form
    {
        MyCircle circle;
        MyRectangle rectangle;
        MyVagon vagon;
        Random ran = new Random();
        MyTrain train;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void create_Circle_Click(object sender, EventArgs e)
        {
            circle = new MyCircle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circle.NewCircle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {

            g = CreateGraphics();
            circle.Visualize_Circle(g);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rectangle = new MyRectangle(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rectangle.NewRectangle(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            rectangle.Visualize(g);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            vagon = new MyVagon(Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text));

        }

        private void button8_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            vagon.Visualize(g);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            train = new MyTrain(Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text));

        }

        private void button10_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            train.Visualize(g);
        }
    }
}
using DecoretorCircle.decorator;

namespace DecoretorCircle
{
    public partial class Form1 : Form
    {
        private Circle _circle;
        private Graphics _g;
        private Pen _p;
        public Form1()
        {
            InitializeComponent();
            _g = this.CreateGraphics();
            _p = new Pen(Color.Black);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBox1.Text);
            _circle = new SimpleCircle(radius);
            _circle.DisplayInConsole();
            _g.Clear(this.BackColor);
            _circle.DisplayOnForm(_g, _p, this.Width / 2, this.Height / 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_circle != null)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    _circle = new ColoredCircle(_circle, colorDialog1.Color);
                    _circle.DisplayInConsole();
                    _g.Clear(this.BackColor);
                    _p = new Pen(colorDialog1.Color);
                    _circle.DisplayOnForm(_g, _p, this.Width / 2, this.Height / 2);
                }
            }
            else
            {
                MessageBox.Show("Ви повинні спочатку створити коло, натиснувши на кнопку \"Створити коло\"", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using DecoretorCircle.decorator;

namespace DecoretorCircle
{
    public partial class Form1 : Form
    {
        private Circle _circle;
        private readonly Graphics _g;
        private readonly Pen _p;
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
            // Перевіряємо, чи є об'єкт класу Коло
            if (_circle != null)
            {
                // Викликаємо метод ShowDialog для ColorDialog
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Створюємо об'єкт класу ColoredCircle, який декорує попередній об'єкт вибраним кольором
                    _circle = new ColoredCircle(_circle, colorDialog1.Color);
                    // Викликаємо метод для відображення кола у консолі
                    _circle.DisplayInConsole();
                    _g.Clear(this.BackColor);
                    SolidBrush brush = new SolidBrush(colorDialog1.Color);
                    _g.FillEllipse(brush, this.Width / 2 - (int)_circle.radius, this.Height / 2 - (int)_circle.radius, (int)_circle.radius * 2, (int)_circle.radius * 2);
                    _g.DrawEllipse(_p, this.Width / 2 - (int)_circle.radius, this.Height / 2 - (int)_circle.radius, (int)_circle.radius * 2, (int)_circle.radius * 2);
                }
            }
            else
            {
                // Повідомляємо користувача, що потрібно спочатку створити коло
                MessageBox.Show("Ви повинні спочатку створити коло, натиснувши на кнопку \"Створити коло\"", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

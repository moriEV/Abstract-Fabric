using System.Drawing;
using System.Security.Policy;
namespace Abstract_Fabric
{
    public partial class Form1 : Form
    {
        private List<IShape> shapes = new List<IShape>();
        public Form1()
        {
            InitializeComponent();
            colorBox.Items.AddRange(new[] { "Red", "Blue" });
            colorBox.SelectedIndex = 0;
            shapeBox.Items.AddRange(new[] { "Circle", "Square", "Triangle" });
            shapeBox.SelectedIndex = 0;
        }

        private void AddingButton_Click(object sender, EventArgs e)
        {
            if (SizeUpDown.Value > 0)
            {

                ShapeFactories factory = null;
                switch (colorBox.SelectedItem.ToString())
                {
                    case "Red":
                        factory = new RedFactory(); break;
                    case "Blue":
                        factory = new BlueFactory(); break;
                    default:
                        break;
                }
                IShape shape = null;
                int x = (int)XUpDown.Value + 175;
                int y = (int)YUpDown.Value;
                int size = (int)SizeUpDown.Value;
                switch (shapeBox.SelectedItem.ToString())
                {
                    case "Circle":
                        shape = factory.CreateCircle(size,x,y);
                        break;
                    case "Square":
                        shape = factory.CreateSquare(size,x,y);
                        break;
                    case "Triangle":
                        shape = factory.CreateTriangle(size,x,y);
                        break;

                }
                shapes.Add(shape);
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Рисуем все фигуры из списка
            foreach (var shape in shapes)
            {
                // Вычисляем позицию для рисования


                shape.Draw(e.Graphics);
            }
        }

        private void shapeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shapes.Clear();
        }
    }
}

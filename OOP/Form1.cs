using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Reflection;
using Shapes;

namespace OOP
{
    public partial class Form1 : Form
    {
        private bool _tracking;
        private int _x;
        private int _y;
        private Shape _currentShape;
        private List<Shape> _shapes = new List<Shape>();
        private Pen _pen = new Pen(Color.Black);
        private Type[] _shapeObjects;

        public Form1()
        {
            _shapeObjects = Assembly.GetAssembly(typeof(Shape)).GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Shape))).ToArray();
            InitializeComponent();

            foreach (var shape in _shapeObjects)
                listBox1.Items.Add(shape.Name);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _x = e.X;
            _y = e.Y;
            _tracking = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _tracking = false;

            if (_currentShape != null)
                _shapes.Add(_currentShape);

            _currentShape = null;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_tracking)
                return;

            if (_currentShape == null)
            {
                if (listBox1.SelectedItem == null)
                    return;

                var item = listBox1.SelectedItem.ToString();

                foreach (var shape in _shapeObjects)
                {
                    if (shape.Name.Equals(item, StringComparison.Ordinal))
                    {
                        _currentShape = (Shape)Activator.CreateInstance(shape, new Point(_x, _y), e.Location);
                        break;
                    }
                }
            }
            else
            {
                _currentShape.Update(new Point(_x, _y), e.Location);
            }

            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in _shapes)
            {
                shape.Draw(e.Graphics, _pen);
            }

            if (_currentShape != null)
                _currentShape.Draw(e.Graphics, _pen);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();

            saveFileDlg.Filter = "xml files (*.xml)|*.xml";

            if (saveFileDlg.ShowDialog() == DialogResult.OK && saveFileDlg.FileName != "")
            {
                try
                {
                    using (Stream stream = File.Open(saveFileDlg.FileName, FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, _shapes);
                    }
                }
                catch (IOException)
                {
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "xml files (*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openFileDialog1.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            _shapes = (List<Shape>)bin.Deserialize(stream);
                        }

                        pictureBox1.Refresh();
                    }
                }
                catch (IOException)
                {
                }
            }
        }
    }
}

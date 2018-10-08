using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binary_tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "С клавиатуры: \n\nEnter - добавить \nDelete - удалить \nSpace - обновить";
        }

        BinaryTree tree = new BinaryTree();

        private void add_Click(object sender, EventArgs e)
        {
            if (Value.Text != "")
                tree.Add(int.Parse(Value.Text));
            Value.Text = "";
            Value.Focus();
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (Value.Text != "")
                tree.Delete(int.Parse(Value.Text));
            Value.Text = "";
            Value.Focus();
        }

        private void print_Click(object sender, EventArgs e)
        {
            Refresh();

            List<PointTree> pointTree = PrintTree.Print(tree, Tablo.Height, Tablo.Width);

            Font drawFont = new Font("Microsoft Sans Serif", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            if (pointTree != null)
                using (Graphics gf = Tablo.CreateGraphics())
                {
                    foreach (var point in pointTree)
                    {
                        gf.DrawLine(new Pen(Color.Black), point.NextPoint, point.LastPoint);
                        gf.DrawEllipse(new Pen(Color.Black), point.NextPoint.X, point.NextPoint.Y, 2, 2);
                        gf.DrawString(point.Value.ToString(), drawFont, drawBrush, point.NextPoint);
                    }
                }
            Value.Focus();
        }

        private void Value_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    add_Click(sender, e);
                    break;
                case Keys.Delete:
                    del_Click(sender, e);
                    break;
                case Keys.Space:
                    print_Click(sender, e);
                    break;
            }
        }

        private void Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;            
        }
    }
}

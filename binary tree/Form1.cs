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
            Error.ForeColor = Color.Red;
            Error.Text = "Напиши число =)";
        }

        BinaryTree tree = new BinaryTree();

        private void add_Click(object sender, EventArgs e)  //Кнопка Добавить, добавляет в дерево элемент со значением из ТекстБокс
        {
            if (Value.Text != "")
                tree.Add(int.Parse(Value.Text));
            Value.Text = "";
            Value.Focus();
        }

        private void del_Click(object sender, EventArgs e)  //Кнопка Удалить, удаляет элемент в дереве со значению из ТекстБокс
        {
            if (Value.Text != "")
                tree.Delete(int.Parse(Value.Text));
            Value.Text = "";
            Value.Focus();
        }

        private void print_Click(object sender, EventArgs e)    //Кнопка Обновить, отрисовывает на форме наше дерево
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

        #region // пытаемся уберечь пользователя от ошибок в форме

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

        public void Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))            
                    return;
            else            
                e.Handled = true;
            
        }

        private void Value_KeyUp(object sender, KeyEventArgs e)
        {
            int tmp;
            if (!int.TryParse(Value.Text, out tmp))
            {
                if (Value.Text.Length == 0)
                    Error.Text = "Напиши число =)";
                else
                    Error.Text = "Слишком большое число!";
                add.Enabled = false;
                del.Enabled = false;
            }
            else
            {
                Error.Text = "";
                add.Enabled = true;
                del.Enabled = true;
            }
        }
        #endregion
    }
}

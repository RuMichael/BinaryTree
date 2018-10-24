using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_tree
{
    public class BinaryTree
    {
        #region значения класса


        Element head;
        static List<Element> tree = new List<Element>();

        #endregion

        public int Count { get { return tree.Count; } }
        public Element Head { get { return head; } }

        public BinaryTree()
        {
            head = null;
        }

        public BinaryTree(int val)
        {
            head = new Element(val);
            tree.Add(head);
        }

        public BinaryTree(List<int> val)
        {
            foreach (var item in val)
                if (head == null)
                {
                    head = new Element(item);
                    tree.Add(head);
                }
                else
                    Add(item);            
        }

        /// <summary>
        /// добавление элемента в дерево
        /// </summary>
        /// <param name="val"></param>
        public void Add(int val)
        {
            if (head == null)
                head = new Element(val);
            else
            {
                Element tmp = head;
                bool check = false;
                while (!check)
                {
                    if (tmp.Value > val)
                        if (tmp.Left == null)
                        { tmp.Left = new Element(val); check = true; }
                        else
                            tmp = tmp.Left;
                    else
                    {
                        if (tmp.Value == val) return;
                        if (tmp.Right == null)
                        { tmp.Right = new Element(val); check = true; }
                        else
                            tmp = tmp.Right;
                    }
                }
            }
            tree.Add(new Element(val));
        }

        /// <summary>
        /// Удаляет элемент со значением key, если такой элемент есть в дереве.
        /// </summary>
        /// <param name="key"></param>
        public void Delete(int key)
        {
            Element tmp;
            if (head!=null && head.Value == key)
            {
                if (head.Left == null)
                    head = head.Right;
                else
                {
                    Element tmpR= head.Right;
                    head = head.Left;
                    tmp = head;
                    while (tmp.Right != null) tmp = tmp.Right;
                    tmp.Right = tmpR;
                }
                return;
            }

            tmp = Find(key);
            if (tmp == null) return;
            if (tmp.Left!=null && tmp.Left.Value == key)
            {
                if (tmp.Left.Left == null)
                    tmp.Left = tmp.Left.Right;
                else
                {
                    Element tmpR = tmp.Left.Right;
                    tmp.Left = tmp.Left.Left;
                    tmp = tmp.Left;
                    while (tmp.Right != null) tmp = tmp.Right;
                    tmp.Right = tmpR;
                }
            }
            else
                if (tmp.Right != null && tmp.Right.Value == key)
            {
                if (tmp.Right.Left == null)
                    tmp.Right = tmp.Right.Right;
                else
                {
                    Element tmpR = tmp.Right.Right;
                    tmp.Right = tmp.Right.Left;
                    tmp = tmp.Right;
                    while (tmp.Right != null) tmp = tmp.Right;
                    tmp.Right = tmpR;
                }
            }
            else
                return;            
        }

        /// <summary>
        /// Поиск элемента по значению key. Вернет либо элемент из дерева, либо null.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private Element Find(int key/*, out Element Last*/)
        {
            //Last = new Element();
            Element tmp = head;
            while (tmp != null && tmp.Value != key)
            {
                if (tmp.Left != null && key == tmp.Left.Value || tmp.Right != null && key == tmp.Right.Value) 
                    return tmp;
                if (key < tmp.Value)
                    tmp = tmp.Left;
                else
                    if (key > tmp.Value) tmp = tmp.Right;                
            }            
            return tmp;
        }
        
    }
}



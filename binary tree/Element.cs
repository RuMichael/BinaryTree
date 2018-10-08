using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_tree
{
    public class Element
    {
        int val;
        Element left;
        Element right;

        public Element() { }

        public Element(int val)
        {
            this.val = val;
            left = null;
            right = null;
        }

        public int Value { get { return val; } }
        public Element Left
        {
            set { left = value; }
            get { return left; }
        }
        public Element Right
        {
            set { right = value; }
            get { return right; }
        }
    }
}

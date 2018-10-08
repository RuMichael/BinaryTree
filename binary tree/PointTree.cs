using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace binary_tree
{
    class PointTree
    {
        public Point LastPoint { get; set; }
        public Point NextPoint{ get; set; }
        public int Value { get; set; }        

        public PointTree() {  }
    }
}

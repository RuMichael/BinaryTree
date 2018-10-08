using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace binary_tree
{
    static class PrintTree
    {      
        struct Stak
        {
            public Point LastPoint;
            public Element element;     //!
            public int Lvl;
            public static int MaxLvl;   //всего уровней (по высоте)
            public static int Height;   //высота окна для рисования!
            public int sizeL;   //левая граница (по ширине)
            public int sizeR;   //правая граница (по ширине)
        }

        static public List<PointTree> Print(BinaryTree tree, int height, int width)
        {
            Stak.Height = height;                       //выставили высоту    
            if (tree.Head != null)
                RezultMaxLvl(tree.Head);                //выставили максимальный уровень
            else
                return null;

            List<PointTree> Points = new List<PointTree>();

            Stack<Stak> stak = new Stack<Stak>();

            Stak tmpStak = new Stak { element = tree.Head, Lvl = 1, sizeL = 0, sizeR = width };
            PointTree tmpPoint = new PointTree { Value = tmpStak.element.Value, NextPoint = RezultPoint(tmpStak), LastPoint = RezultPoint(tmpStak) };
            Points.Add(tmpPoint);
            

            while (tmpStak.element.Left != null || stak.Count != 0 || tmpStak.element.Right != null)
            {
                if (tmpStak.element.Right != null)
                {
                    stak.Push(new Stak { element = tmpStak.element.Right, Lvl = tmpStak.Lvl + 1, sizeL = tmpPoint.NextPoint.X, sizeR = tmpStak.sizeR, LastPoint = tmpPoint.NextPoint });                    
                }
                if (tmpStak.element.Left != null)
                {
                    tmpStak.element = tmpStak.element.Left;
                    tmpStak.Lvl = tmpStak.Lvl + 1;
                    tmpStak.sizeR = tmpPoint.NextPoint.X;
                    tmpStak.LastPoint = tmpPoint.NextPoint;

                    tmpPoint = new PointTree { Value = tmpStak.element.Value, NextPoint = RezultPoint(tmpStak), LastPoint = tmpStak.LastPoint };
                    Points.Add(tmpPoint);
                }
                else
                {
                    tmpStak = stak.Pop();
                    tmpPoint = new PointTree { Value = tmpStak.element.Value, NextPoint = RezultPoint(tmpStak), LastPoint = tmpStak.LastPoint };
                    Points.Add(tmpPoint);
                }
            }

            return Points;
        }
        
        /// <summary>
        /// Расчитывает максимальный уровень в дереве.
        /// </summary>
        /// <param name="head"></param>
        private static void RezultMaxLvl(Element head)
        {
            Stack<Stak> rStak = new Stack<Stak>();      //RightStak аналог RES
            Stak.MaxLvl = 1;
            Stak tmpStak = new Stak { element = head, Lvl = 1 };            

            while (tmpStak.element.Left != null || rStak.Count != 0 || tmpStak.element.Right != null)
            {
                if (tmpStak.element.Right != null)
                {
                    rStak.Push(new Stak { element = tmpStak.element.Right, Lvl = tmpStak.Lvl + 1 });
                    if (tmpStak.Lvl + 1 > Stak.MaxLvl) Stak.MaxLvl = tmpStak.Lvl + 1;
                }
                if (tmpStak.element.Left != null)
                {
                    tmpStak.element = tmpStak.element.Left; tmpStak.Lvl = tmpStak.Lvl + 1;
                    if (tmpStak.Lvl > Stak.MaxLvl) Stak.MaxLvl = tmpStak.Lvl;
                }
                else
                { tmpStak = rStak.Pop(); }                
            }
        }

        /// <summary>
        /// Расчитывает координаты точки по данным из Stak.
        /// </summary>
        /// <param name="stak"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        static private Point RezultPoint(Stak stak) // MaxLvl заранее известен
        {
            Point rezult = new Point();
            int leftCount = CountTree(stak.element.Left);
            int rightCount = CountTree(stak.element.Right);
            rezult.X = stak.sizeL + ((stak.sizeR - stak.sizeL) / (leftCount + rightCount + 2) * (leftCount + 1));
            rezult.Y = Stak.Height * stak.Lvl / (Stak.MaxLvl+1);
            return rezult;
        }

        /// <summary>
        /// Счетчик элементов в ветке дерева, которая была передана
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        static private int CountTree(Element element)
        {
            int count = 0;
            if (element == null)
                return count;
            else
                count++;
            Stack<Element> RES = new Stack<Element>();  //RightElementStack

            while (element.Left != null || RES.Count != 0 || element.Right != null)
            {
                if (element.Right != null)
                    RES.Push(element.Right);
                if (element.Left != null)
                    { count++; element = element.Left; }
                else
                    { count++; element = RES.Pop(); }                        
            }
            return count;
        }   
        
    }
}

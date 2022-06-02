using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthSide
{
    internal class Point
    {
        private int coordinX;
        private int coordinY;
        private string pointName;
        public int CoordinX
        {
            get { return coordinX; }
        }
        public int CoordinY
        {
            get { return coordinY; }
        }
        public string PointName
        {
            get { return pointName; }
        }
        public Point(int coordinX, int coordinY, string pointName)
        {
            this.coordinX = coordinX;
            this.coordinY = coordinY;
            this.pointName = pointName;
        }
    }
}

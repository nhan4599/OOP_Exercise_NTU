using System;

namespace OOP_Exercise_NTU_Part2
{
    class Point
    {
        private int x, y;

        public Point()
        {
            this.x = this.y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return this.x;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetY()
        {
            return this.y;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public int[] GetXY()
        {
            int[] rs = new int[2];
            rs[0] = this.x;
            rs[1] = this.y;
            return rs;
        }

        public void SetXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", this.x, this.y);
        }
    }
}

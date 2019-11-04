namespace OOP_Exercise_NTU_Part2
{
    class Circle
    {
        private Point center;
        private int radius;

        public Circle()
        {
            center = new Point();
            radius = 1;
        }

        public Circle(int x, int y, int radius)
        {
            center = new Point(x, y);
            this.radius = radius;
        }

        public Circle(Point center, int radius) : this(center.GetX(), center.GetY(), radius) { }

        public int GetRadius()
        {
            return this.radius;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public Point GetCenter()
        {
            return this.center;
        }

        public void SetCenter(Point center)
        {
            this.center = center;
        }

        public int GetCenterX()
        {
            return this.center.GetX();
        }

        public void SetCenterX(int x)
        {
            this.center.SetX(x);
        }

        public int GetCenterY()
        {
            return this.center.GetY();
        }

        public void SetCenterY(int y)
        {
            this.center.SetY(y);
        }

        public int[] GetCenterXY()
        {
            return this.center.GetXY();
        }

        public void SetCenterXY(int x, int y)
        {
            this.center.SetXY(x, y);
        }

        public override string ToString()
        {
            return string.Format("Circle[radius={0},center={1}]",
                this.radius, this.center);
        }

        public double GetArea()
        {
            return this.radius * this.radius * System.Math.PI;
        }

        public double GetCircumFerence()
        {
            return this.radius * 2 * System.Math.PI;
        }

        public double Distance(Circle another) => center.Distance(another.GetCenter());
    }
}

namespace OOP_Exercise_NTU_Part2
{
    class Triangle
    {
        private Point v1, v2, v3;

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3) : this(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3)) { }

        public Triangle(Point v1, Point v2, Point v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public double GetPerimeter()
        {
            double edge1 = this.v1.Distance(this.v2);
            double edge2 = this.v2.Distance(this.v3);
            double edge3 = this.v1.Distance(this.v3);

            return edge1 + edge2 + edge3;
        }

        public new string GetType()
        {
            double edge1 = this.v1.Distance(this.v2);
            double edge2 = this.v2.Distance(this.v3);
            double edge3 = this.v1.Distance(this.v3);

            if (edge1==edge2 && edge1 == edge3)
            {
                return "Equilateral";
            }else if (edge1 == edge2 || edge1 == edge3 || edge2 == edge3)
            {
                return "Isosceles";
            }else
            {
                return "Scalene";
            }
        }
    }
}

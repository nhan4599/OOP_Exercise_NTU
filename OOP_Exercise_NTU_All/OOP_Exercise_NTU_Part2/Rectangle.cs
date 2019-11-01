namespace OOP_Exercise_NTU_Part2
{
    class Rectangle
    {
        private Point top_left, bottom_right;
        private readonly Point[] corners;
        private readonly double[] size;

        public Rectangle(Point top_left, Point bottom_right)
        {
            this.top_left = top_left;
            this.bottom_right = bottom_right;
            corners = new Point[] { top_left, new Point(bottom_right.GetX(), top_left.GetY()),
                                    new Point(top_left.GetX(), bottom_right.GetY()), bottom_right };
            size = new double[] { corners[0].Distance(corners[1]), corners[1].Distance(corners[1])};
        }

        public Point GetTopLeft()
        {
            return this.top_left;
        }

        public void SetTopLeft(Point top_left)
        {
            this.top_left = top_left;
        }

        public Point GetBottomRight()
        {
            return this.bottom_right;
        }

        public void SetBottomRight(Point bottom_right)
        {
            this.bottom_right = bottom_right;
        }

        public double GetArea()
        {
            return size[0] * size[1];
        }

        public double GetPerimeter()
        {
            return (size[0] + size[1]) * 2;
        }

        public new string GetType()
        {
            return size[0] == size[1] ? "Square" : "Rectangle";
        }

        public override string ToString()
        {
            return string.Format("Rectangle[TopLeft={0},BottomRight={1}]", this.top_left, this.bottom_right);
        }
    }
}

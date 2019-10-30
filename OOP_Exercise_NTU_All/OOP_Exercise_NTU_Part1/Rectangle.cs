namespace OOP_Exercise_NTU_NTU
{
    class Rectangle
    {
        private float length, width;

        public Rectangle()
        {
            this.length = this.width = 1;
        }

        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }

        public float GetLength()
        {
            return this.length;
        }

        public void SetLength(float length)
        {
            this.length = length;
        }

        public float GetWidth()
        {
            return this.width;
        }

        public void SetWidth(float width)
        {
            this.width = width;
        }

        public double GetArea()
        {
            return this.length * this.width;
        }

        public double GetPerimeter()
        {
            return (this.length + this.width) * 2;
        }

        public override string ToString()
        {
            return string.Format("Rectangle[length={0},width={1}]",
                this.length, this.width);
        }
    }

}
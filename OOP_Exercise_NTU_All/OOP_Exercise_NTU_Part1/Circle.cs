using System;

namespace OOP_Exercise_NTU_NTU
{
    class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }



        public Circle()
        {
            this.radius = 1;
        }

        public double GetRadius()
        {
            return this.radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return this.radius * this.radius * Math.PI;
        }

        public double GetCircumFerence()
        {
            return this.radius * 2 * Math.PI;
        }

        public override string ToString()
        {
            return string.Format("Circle[radius={0}]", this.radius);
        }
    }

}
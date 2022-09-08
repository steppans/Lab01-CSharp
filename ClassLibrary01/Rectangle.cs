namespace ClassLibrary01
{
    public class Rectangle
    {
        public double side1;
        public double side2;

        public Rectangle(double sideA, double sideB) // => (side1, side2) = (sideA, sideB);
        {
            if (sideA < 0 || sideB < 0)
            {
                sideA = 0;
                sideB = 0;
            }
            else
            {
                side1 = sideA;
                side2 = sideB;
            }
        }

        public double SideA { get => side1; set => side1 = value; }
        public double SideB { get => side2; set => side2 = value; }

        private double AreaCalculator() => side1 * side2;
        
        private double PerimeterCalculator() => 2 * side1 + 2 * side2;

        public double Area => this.AreaCalculator();

        public double Perimeter => this.PerimeterCalculator();
    }
}
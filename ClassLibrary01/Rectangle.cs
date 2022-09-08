namespace ClassLibrary01
{
    public class Rectangle
    {
        public double side1;
        public double side2;

        public Rectangle(double sideA, double sideB) // => (side1, side2) = (sideA, sideB);
        {
            side1 = sideA;
            side2 = sideB;
        }

        private double AreaCalculator() => side1 * side2;
        
        private double PerimeterCalculator() => 2 * side1 + 2 * side2;

        public double Area => this.AreaCalculator();

        public double Perimeter => this.PerimeterCalculator();
    }
}
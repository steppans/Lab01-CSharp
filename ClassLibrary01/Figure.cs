namespace ClassLibrary01
{
    public class Figure
    {
        private Point[] _points;
        private double _perimeter = 0; 

        public string? Name { get; set; } 

        public double Perimeter => _perimeter;

        public Figure(in Point point1, in Point point2,in Point point3)
        {
            _points = new Point[3] { point1, point2, point3 };
            PerimeterCalculator();
        }

        public Figure(in Point point1, in Point point2, in Point point3, in Point point4)
        {
            _points = new Point[4] { point1, point2, point3, point4 };
            PerimeterCalculator();
        }
            
        public Figure(in Point point1, in Point point2, in Point point3, in Point point4, in Point point5)
        {
            _points = new Point[5] { point1, point2, point3, point4, point5 };
            PerimeterCalculator();
        }

        public Figure(Point[] points)
        {
            _points = points;
            PerimeterCalculator();
        }

        private double LengthSide(in Point pointA, in Point pointB) =>
            Math.Sqrt(Math.Pow((pointA.X - pointB.X), 2) + Math.Pow((pointA.Y - pointB.Y), 2));

        private void PerimeterCalculator()
        {
            for (uint i = 0; i < _points.Length - 1; i++)
            {
                _perimeter += LengthSide(_points[i], _points[i + 1]);
            }
            _perimeter += LengthSide(_points[0], _points[_points.Length - 1]);
        }
    }
}

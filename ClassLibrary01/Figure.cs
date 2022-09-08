namespace ClassLibrary01
{
    public class Figure
    {
        private Point[] _points;
        private double _perimeter = 0; 

        public string? Name { get; set; } 

        public double Perimeter => _perimeter;

        public Figure(Point[] points)
        {
            _points = points;
            PerimeterCalculator();
        }

        public double LengthSide(in Point pointA, in Point pointB) =>               // public для тестов
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

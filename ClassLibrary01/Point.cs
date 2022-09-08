namespace ClassLibrary01
{
    public class Point
    {
        private int _x = 0;
        private int _y = 0;

        public int X => _x;
        public int Y => _y;

        public Point(int x, int y) => (_x, _y) = (x, y);
    }
}

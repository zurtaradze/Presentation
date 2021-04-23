namespace Presentation.Operator_overloading
{
    public class Point
    {
        public int x { get; }
        public int y { get; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(Point f, Point s)
        {
            return f.x == s.x && f.y == s.y;
        }

        public static bool operator !=(Point f, Point s)
        {
            return f.x != s.x || f.y != s.y;
        }
    }
}

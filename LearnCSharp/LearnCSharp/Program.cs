using LearnCSharp;

class Program
{
    public static void Main( string[] args )
    {
        Point leftTopPoint = new Point
        {
            X = 10,
            Y = 10
        };
        Point rightBottomPoint = new Point
        {
            X = 15,
            Y = 2
        };
        try
        {
            Rectangle rectangle = new Rectangle( leftTopPoint, rightBottomPoint );
            int square = rectangle.GetSquare();
            Console.WriteLine( square );
            Console.WriteLine( $"{rectangle.LeftTopPoint.ToString()} {rectangle.RightBottomPoint.ToString()}" );
        }
        catch ( ArgumentException ex )
        {
            Console.WriteLine( ex.Message );
        }
    }
}
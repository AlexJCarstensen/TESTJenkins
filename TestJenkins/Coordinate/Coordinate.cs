namespace Coordinate
{
    public class CoordinateTest : ICoordinateTest
    {
        public int x { get; set; }
        public int y { get; set; }
        public CoordinateTest(int coordinateX, int coordinateY)
        {
            x = coordinateX;
            y = coordinateY;
        }


       
    }
}
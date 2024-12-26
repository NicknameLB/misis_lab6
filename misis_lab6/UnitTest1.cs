namespace misis_lab6
{
    [TestClass]
    public class PolygonTests
    {
        [TestMethod()]
        public void ConvexTest1()
        {
            List<Point> points = new List<Point>();
            Point p1 = new Point(1, 1);
            Point p2 = new Point(2, 3);
            Point p3 = new Point(2, 0);
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            Polygon polygon = new Polygon(points);
            bool actual = polygon.IsConvex();
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void ConvexTest2()
        {
            List<Point> points = new List<Point>();
            Point p1 = new Point(1, 1);
            Point p2 = new Point(1, 3);
            Point p3 = new Point(2, 2);
            Point p4 = new Point(3, 2);
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);
            Polygon polygon = new Polygon(points);
            bool actual = polygon.IsConvex();
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void CollinearTest()
        {
            List<Point> points = new List<Point>();
            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 1);
            Point p3 = new Point(2, 2);
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            Polygon polygon = new Polygon(points);
            bool actual = polygon.AreCollinear();
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void ConvexTest3()
        {
            List<Point> points = new List<Point>();
            Point p1 = new Point(1, 1);
            Point p2 = new Point(1, 3);
            Point p3 = new Point(2, 2);
            Point p4 = new Point(3, 1);
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);
            Polygon polygon = new Polygon(points);
            bool actual = polygon.IsConvex();
            Assert.AreEqual(true, actual);
        }
    }
}
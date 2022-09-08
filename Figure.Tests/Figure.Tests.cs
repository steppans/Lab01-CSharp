namespace Figure.Tests
{
    using ClassLibrary01;

    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void LengthSide_2_3_and_4_7_return_2_sqrt_5()
        {
            // Arrange
            Point pointA = new(2, 3);
            Point pointB = new(4, 7);
            double ExpectedLength = Math.Sqrt(20);

            // Act
            Figure TestFig = new(new Point[1] {new Point(0, 0)});
            double ActualLength = TestFig.LengthSide( pointA, pointB);

            // Assert
            Assert.AreEqual(ExpectedLength, ActualLength);
        }

        [TestMethod]
        public void LengthSide_common_points_return_0()
        {
            // Arrange
            Point pointA = new(10, 6);
            Point pointB = new(10, 6);
            double ExpectedLength = 0;

            // Act
            Figure TestFig = new(new Point[1] { new Point(0, 0) });
            double ActualLength = TestFig.LengthSide(pointA, pointB);

            // Assert
            Assert.AreEqual(ExpectedLength, ActualLength);
        }

        [TestMethod]
        public void Perimeter_figure_5_5_10_return_20()
        {
            // Arrange
            Point pointA = new(1, 3);
            Point pointB = new(4, 7);
            Point pointC = new(7, 11);
            double ExpectedPerimeter = 20;

            // Act
            Figure TestFig = new(new Point[] { pointA, pointB, pointC });

            // Assert
            Assert.AreEqual(ExpectedPerimeter, TestFig.Perimeter);
        }

        [TestMethod]
        public void Perimeter_figure_random_points()
        {
            // Arrange
            Point pointA = new(2, 5);
            Point pointB = new(7, 3);
            Point pointC = new(9, 11);
            double ExpectedPerimeter = Math.Sqrt(29) + Math.Sqrt(68) + Math.Sqrt(85);

            // Act
            Figure TestFig = new(new Point[] { pointA, pointB, pointC });

            // Assert
            Assert.AreEqual(ExpectedPerimeter, TestFig.Perimeter);
        }
    }
}
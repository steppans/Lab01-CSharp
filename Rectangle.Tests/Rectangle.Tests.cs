namespace Rectangle.Tests
{
    using ClassLibrary01;

    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Area_9_and_5_return_45()
        {
            // Arrange
            double sideA = 9;
            double sideB = 5;
            double ExpectedArea = 45;

            // Act
            Rectangle TestRec = new(sideA, sideB);

            // Assert
            Assert.AreEqual(ExpectedArea, TestRec.Area);
        }

        [TestMethod]
        public void Area_negative_side_return_0()
        {
            // Arrange
            double sideA = 10;
            double sideB = -3;
            double ExpectedArea = 0;

            // Act
            Rectangle TestRec = new(sideA, sideB);

            // Assert
            Assert.AreEqual(ExpectedArea, TestRec.Area);
        }

        [TestMethod]
        public void Perimeter_10_and_7_return_34()
        {
            // Arrange
            double sideA = 10;
            double sideB = 7;
            double ExpectedPerimeter = 34;

            // Act
            Rectangle TestRec = new(sideA, sideB);

            // Assert
            Assert.AreEqual(ExpectedPerimeter, TestRec.Perimeter);
        }

        [TestMethod]
        public void Perimeter_negative_side_return_0()
        {
            // Arrange
            double sideA = -11;
            double sideB = 4;
            double ExpectedPerimeter = 0;

            // Act
            Rectangle TestRec = new(sideA, sideB);

            // Assert
            Assert.AreEqual(ExpectedPerimeter, TestRec.Perimeter);
        }
    }
}
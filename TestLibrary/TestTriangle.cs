using MBoxTaskLibrary;

namespace TestLibrary
{
    public class TestTriangle
    {
        [Fact]
        public void isCheckingTheTriangle_ReturnFalse()
        {
                //Arrange
                var triangle = new Triangle(2, 3, 4);

                //Act
                var result = triangle.CheckingTheTriangle();

                //Assert
                Assert.False(result);
        }

        [Fact]
        public void Square_3and4and5_Return6()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);
            double expected = 6;

            //Act
            var result = triangle.Square();

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
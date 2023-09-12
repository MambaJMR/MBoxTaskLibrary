using MBoxTaskLibrary;


namespace TestLibrary
{
    public class CircleTest
    {
        [Fact]
        public void Square_5_Return78_5()
        {
            //Arrange
            var circle = new Circle(5);
            double expected = 78.5398;

            //Act
            var result = circle.Square();

            //Assert
            Assert.Equal(expected, result);
        }
    }
}

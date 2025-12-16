using xUnitLibrary;

namespace XunitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 5, 4, 11)]
        [InlineData(6, 7, -67, 13)]
        [InlineData(4, 5, 0, 9)]
        [InlineData(5, 0, 0, 5)]
        [InlineData(3, -1, 4, 3)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(0, 1, 2, 0)]
        [InlineData(-2, -1, -3, 0)]
        [InlineData(0, 2, -1, 0)]
        [InlineData(0, -1, 2, 0)]
        [InlineData(0, -1, -2, 0)]
        public void Test1(int a, int b, int c, int expectedResult)
        {
            //Arrange
            int result;
            //Act
            result = xUtils.CalculateResult(a, b, c);
            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(11,"El resultat és positiu.")]
        [InlineData(13, "El resultat és positiu.")]
        [InlineData(9, "El resultat és positiu.")]
        [InlineData(5, "El resultat és positiu.")]
        [InlineData(3, "El resultat és positiu.")]
        [InlineData(0, "El resultat és zero.")]
        public void Test2 (int intResult, string expectedResult)
        {
            //Arrange
            string result;
            //Act
            result = xUtils.SendMsg(intResult);
            //Assert
            Assert.Equal(expectedResult,result);

        }
    }
}

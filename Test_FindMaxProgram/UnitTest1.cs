using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximum;

namespace Test_FindMaxProgram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(8,3,1)]
        [DataRow(3,8,1)]
        [DataRow(3,1,8)]
        public void MaxIntMethod_ShouldReturnMaxInteger(int n1, int n2, int n3)
        {
            //arrange
            int expectedMax = 8;
            int actualMax;
            //act
            actualMax = Program.MaxInt(n1, n2, n3);
            //Assert
            Assert.AreEqual(expectedMax, actualMax);
        }

    }
}

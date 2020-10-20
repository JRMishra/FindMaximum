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

        [TestMethod]
        [DataRow(8.5f,3.2f,1.7f)]
        [DataRow(3.2f,8.5f,1.7f)]
        [DataRow(3.2f,1.7f,8.5f)]
        public void MaxFloatMethod_ShouldReturnMaxFloat(float n1, float n2, float n3)
        {
            //arrange
            float expectedMax = 8.5f;
            float actualMax;
            //act
            actualMax = Program.MaxFloat(n1, n2, n3);
            //Assert
            Assert.AreEqual(expectedMax, actualMax);
        }

    }
}

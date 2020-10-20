using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximum;

namespace Test_FindMaxProgram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(8,3,21)]
        [DataRow(3,8,21)]
        [DataRow(3,21,8)]
        public void MaxIntMethod_ShouldReturnMaxInteger(int n1, int n2, int n3)
        {
            //arrange
            int expectedMax = 21;
            int actualMax;
            //act
            actualMax = Comparision.FindMax(n1, n2, n3);
            //Assert
            Assert.AreEqual(expectedMax, actualMax);
        }

        [TestMethod]
        [DataRow(8.5f,13.2f,1.7f)]
        [DataRow(13.2f,8.5f,1.7f)]
        [DataRow(13.2f,1.7f,8.5f)]
        public void MaxFloatMethod_ShouldReturnMaxFloat(float n1, float n2, float n3)
        {
            //arrange
            float expectedMax = 13.2f;
            float actualMax;
            //act
            actualMax = Comparision.FindMax(n1, n2, n3);
            //Assert
            Assert.AreEqual(expectedMax, actualMax);
        }

        [TestMethod]
        [DataRow("Corona", "Covid", "SarsCov2")]
        [DataRow("SarsCov2", "Covid", "Corona" )]
        [DataRow("Covid", "SarsCov2", "Corona")]
        public void MaxStringMethod_ShouldReturnMaxString(string s1, string s2, string s3)
        {
            //arrange
            string expectedMax = "SarsCov2";
            string actualMax;
            //act
            actualMax = Comparision.FindMax(s1, s2, s3);
            //Assert
            Assert.AreEqual(expectedMax, actualMax);
        }

    }
}

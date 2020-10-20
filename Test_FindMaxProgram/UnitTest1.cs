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
            Comparision<int> compareInt = new Comparision<int>(n1, n2, n3);
            int expectedMax = 21;

            //act
            int actualMax = compareInt.FindMax();

            //Assert
            Assert.AreEqual(expectedMax, actualMax);
        }

        [TestMethod]
        [DataRow(8.5f,13.2f,1.7f)]
        [DataRow(13.2f,8.5f,1.7f)]
        [DataRow(13.2f,1.7f,8.5f)]
        public void MaxFloatMethod_ShouldReturnMaxFloat(float f1, float f2, float f3)
        {
            //arrange
            Comparision<float> compareFloat = new Comparision<float>(f1, f2, f3);
            float expectedMax = 13.2f;

            //act
            float actualMax = compareFloat.FindMax();

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
            Comparision<string> compareString = new Comparision<string>(s1,s2,s3);
            string expectedMax = "SarsCov2";
            
            //act
            string actualMax = compareString.FindMax();

            //Assert
            Assert.AreEqual(expectedMax, actualMax);
        }

    }
}

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
        [DataRow(21)]
        [DataRow(21,3,11,8,17)]
        [DataRow(7,11,21,8)]
        public void MaxIntMethod_ShouldReturnMaxInteger(params int[] values)
        {
            //arrange
            Comparision<int> compareInt = new Comparision<int>(values);
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
        [DataRow(13.2f)]
        [DataRow(13.2f, 3.6f, 11.4f, 8.1f, 7.9f)]
        [DataRow(7.9f, 11.3f, 13.2f, 8.5f)]
        public void MaxFloatMethod_ShouldReturnMaxFloat(params float[] values)
        {
            //arrange
            Comparision<float> compareFloat = new Comparision<float>(values);
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
        [DataRow("SarsCov2", "Corona", "Covid", "pandemic","lockdown")]
        [DataRow("Covid", "SarsCov2", "Corona","pandemic")]
        public void MaxStringMethod_ShouldReturnMaxString(params string[] values)
        {
            //arrange
            Comparision<string> compareString = new Comparision<string>(values);
            string expectedMax = "SarsCov2";
            
            //act
            string actualMax = compareString.FindMax();

            //Assert
            Assert.AreEqual(expectedMax, actualMax);
        }

    }
}

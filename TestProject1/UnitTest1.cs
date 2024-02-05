namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            UpperCaseConversion.Model.UpperCaseModel model = new UpperCaseConversion.Model.UpperCaseModel();
            string input = "maison";
            string expected = "MAISON";
            // Act
            string actual = model.ConvertToUpperCase(input);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            UpperCaseConversion.Model.UpperCaseModel model = new UpperCaseConversion.Model.UpperCaseModel();
            string input = "Corse123";
            string expected = "CORSE123";
            // Act
            string actual = model.ConvertToUpperCase(input);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            UpperCaseConversion.Model.UpperCaseModel model = new UpperCaseConversion.Model.UpperCaseModel();
            string input = "%&ciel";
            string expected = "%&CIEL";
            // Act
            string actual = model.ConvertToUpperCase(input);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            UpperCaseConversion.Model.UpperCaseModel model = new UpperCaseConversion.Model.UpperCaseModel();
            string input = "!*port";
            string expected = "!*PORT";
            // Act
            string actual = model.ConvertToUpperCase(input);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
using StudentServiceLib;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_value_()
        {
            Student s = new Student();
            s.Score = 0;
            Assert.AreEqual(0, s.Score);
        }
    }
}
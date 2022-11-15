using StudentServiceLib;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private string m;

        [TestMethod]
        public void Test_value_0()
        {
            Student s = new Student();
            s.Score = 0;
            Assert.AreEqual(0, s.Score);
        }

        [TestMethod]
        public void Test_value_10()
        {
            Student s = new Student();
            s.Score = 10;
            Assert.AreEqual(10, s.Score);
        }

        [TestMethod]
        public void Test_value_over10()
        {
            String ExpextedOver10 = "Score must not exeed 10.0";
            String message = null ;
            Student s = new Student();
            try
            {
                s.Score = 11;

            }catch(Exception e)
            {
                message = e.Message;
            }
            Assert.AreEqual(ExpextedOver10, message);
            
        }
    }
}
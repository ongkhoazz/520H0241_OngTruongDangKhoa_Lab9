

using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentServiceLib;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        //comparison [8,10]
        [TestMethod]
        public void IsScoreEqualEight_Grade_A()
        {
            Student s = new Student();
            s.Score = 8;
            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void IsScoreEqualTen_Grade_A()
        {
            Student s = new Student();
            s.Score = 10;
            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);
        }
    

        // comparison[7,8)
        [TestMethod]
        public void IsScoreHigherEqualSeven_Grade_B()
        {
            Student s = new Student();
            s.Score = 7;
            char letter = s.getLetterScore();

            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void IsScoreLowerEight_Grade_B()
        {
            Student s = new Student();
            s.Score = 7.9;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        //comparison [5,7)
        [TestMethod]
        public void IsScoreHigherEqualfine_Grade_C()
        {
            Student s = new Student();
            s.Score = 5;
            char letter = s.getLetterScore();

            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void IsScoreLowerSeven_Grade_C()
        {
            Student s = new Student();
            s.Score = 6.5;
            char letter = s.getLetterScore();

            Assert.AreEqual('C', letter);
        }

        // Comparison[3.5,5)
        [TestMethod]
        public void IsScoreHigherEqualThreePointFine_Grade_D()
        {
            Student s = new Student();
            s.Score = 3.5;
            char letter = s.getLetterScore();

            Assert.AreEqual('D', letter);
        }
        [TestMethod]
        public void IsScoreLowerFine_Grade_D()
        {
            Student s = new Student();
            s.Score = 4.9;
            char letter = s.getLetterScore();

            Assert.AreEqual('D', letter);
        }

        // <=3.5
        [TestMethod]
        public void IsScoreLowerThreePointFine_Grade_E()
        {
            Student s = new Student();
            s.Score = 3.4;
            char letter = s.getLetterScore();

            Assert.AreEqual('E', letter);
        }

    }
}

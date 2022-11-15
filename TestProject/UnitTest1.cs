using StudentServiceLib;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckInvalidScore()
        {
            Student s = new Student();
            bool checkException = false;
            try
            {
                s.Score = 15;
            }
            catch
            {
                checkException = true;
            }
            Assert.IsTrue(checkException);
        }
        [TestMethod]
        public void LetterScoreShouldBe_A_IfScoreGreaterThan_8()
        {
            Student s = new Student();
            s.Score = 8;
            char rate = s.getLetterScore();
            Assert.AreEqual('A', rate);
        }

        [TestMethod]
        public void LetterScoreShouldBe_B_IfScoreGreaterThan_7()
        {
            Student s = new Student();
            s.Score = 7;
            char rate = s.getLetterScore();
            Assert.AreEqual('B', rate);
        }

        [TestMethod]
        public void LetterScoreShouldBe_C_IfScoreGreaterThan_5()
        {
            Student s = new Student();
            s.Score = 5;
            char rate = s.getLetterScore();
            Assert.AreEqual('C', rate);
        }

        [TestMethod]
        public void LetterScoreShouldBe_D_IfScoreGreaterThan_3AndAHalf()
        {
            Student s = new Student();
            s.Score = 3.5;
            char rate = s.getLetterScore();
            Assert.AreEqual('D', rate);
        }

        [TestMethod]
        public void LetterScoreShouldBe_E_IfScoreLessThan_3AndAHalf()
        {
            Student s = new Student();
            s.Score = 3.4;
            char rate = s.getLetterScore();
            Assert.AreEqual('E', rate);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(5)]
        public void CheckGetStudentAT(int id)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            StudentService s = new StudentService();
            s1.Id = 1;
            s2.Id = 2;
            s3.Id = 3;
            s4.Id = 4;
            bool checkStudent = false;
            try
            {
                s.getStudentAt(id);
            }
            catch
            {
               checkStudent = true;
            }
            Assert.IsTrue(checkStudent);

        }
    }
}
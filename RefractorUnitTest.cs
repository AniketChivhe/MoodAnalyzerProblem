using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refractor;

namespace RefractorTest
{
    [TestClass]
    public class RefractorUnitTest
    {
        MoodAnalyze moodAnalyser;
        string message = " I am in happy Mood";
        string message1 = " I am in sad Mood";
        //[TestInitialize]
        //public void SetUp()
        //{
        //    moodAnalyser = new MoodAnalyze(message);
        //}
        [TestMethod]
        public void TestMethodForHappyMood()

        {
            string expected = "happy";
            moodAnalyser = new MoodAnalyze(message);
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForSadMood()
        {
            string expected = "sad";
            MoodAnalyze moodAnalyser = new MoodAnalyze(message1);
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProb;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // TC 1.1 Return Sad To Test case Pass
        
        [TestMethod]
        public void ReturnSad()
        {
            //Arrange 
            string expected = "SAD";
            string message = " I am in Sad Mood";
            MoodAnalyze moodAnalyze = new MoodAnalyze(message);

            //Act
            string mood = moodAnalyze.analyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        public void ReturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in Happy Mood";

            MoodAnalyze moodAnalyze = new MoodAnalyze(message);
            //Act
            string mood = moodAnalyze.analyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
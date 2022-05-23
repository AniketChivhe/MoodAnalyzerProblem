using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC2_HandleException;


namespace TestProject1
{
    [TestClass]
    public class UnitTest2_UC2
    {
        /// <summary>
        /// TC 1.1 Return Sad To Test case Pass
        /// </summary>
        [TestMethod]
        public void ReturnSad()
        {
            //Arrange 
            string expected = "SAD";
            string message = " I am in Sad Mood";
            MoodAnalyze moodAnalyze = new MoodAnalyze(message);

            //Act
            string mood = moodAnalyze.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, mood);

        }
        /// <summary>
        /// TC 1.2 Return happy moood And TC2.1 - Given Null mood should return happy.
        /// </summary>
        [TestMethod]
        [DataRow("I am in HAPPY Mood")]
        [DataRow(null)]
        public void ReturnHappy(string message)
        {
            //Arrange
            string expected = "HAPPY";
            MoodAnalyze moodAnalyze = new MoodAnalyze(message);
            //Act
            string mood = moodAnalyze.AnalyzeMood();
            //Assert 
            Assert.AreEqual(expected, mood);
        }
    }
}

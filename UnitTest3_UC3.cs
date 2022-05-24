using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC3_CustomException;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest3_UC3
    {
        /// <summary>
        ///  TC 3.1: Given NULL Mood Should Throw MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void NULL_MOOD_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyzeUC3 moodAnalyze = new MoodAnalyzeUC3(message);
                string mood = moodAnalyze.AnalyzeMood();
            }
            catch (MoodAnalyzeException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        /// <summary>
        /// TC 3.2: Given Empty Mood Should Throw MoodAnalysisException Indicating Empty Mood.
        /// </summary>
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyzeUC3 moodAnalyze = new MoodAnalyzeUC3(message);
                string mood = moodAnalyze.AnalyzeMood();
            }
            catch (MoodAnalyzeException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}

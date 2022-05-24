using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC5_ReflectionParameterConstructor;

namespace TestProject1
{
    [TestClass]
    public class UnitTest5_UC5
    {
        /// <summary>
        /// Test Case 5.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyzeUC5("HAPPY");
            object obj = MoodAnalyzeFactory.CreateMoodAnalyseUsingParameterizedConstructor("UC5_ReflectionParameterConstructor.MoodAnalyzeUC5", "MoodAnalyzeUC5");
            expected.Equals(obj);
        }
        /// <summary>
        /// Test Case 5.2 Given Improper Class Name Should throw MoodAnalyssiException.
        /// </summary>
        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyzeFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerApp.DemoClass", "MoodAnalyse");

            }
            catch (MoodAnalyzeException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        /// <summary>
        /// Test Case 5.3 Given Improper Constructor Name Should throw MoodAnalyssiException.
        /// </summary>
        [TestMethod]
        public void GivenImproperConstructorNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyzeFactory.CreateMoodAnalyseUsingParameterizedConstructor("UC5_ReflectionParameterConstructor.MoodAnalyzeUC5", "DemoConstructor");

            }
            catch (MoodAnalyzeException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

    }
}

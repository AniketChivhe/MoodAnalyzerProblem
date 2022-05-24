using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;


namespace UC4_ReflectionDefaultConstructor
{
    public class MoodAnalyzeFactory
    {
        /// <summary>
        ///  method to create object of MoodAnalyse class.
        /// </summary>
        /// <param name="className">MoodAnalyseFactory</param>
        /// <param name="constructorName">CreateMoodAnalyse</param>
        /// <returns></returns>
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnaylseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnaylseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzeException(MoodAnalyzeException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalyzeException(MoodAnalyzeException.ExceptionType.NO_SUCH_METHOD, "Constructor is Not Found");
            }
        }
    }
}

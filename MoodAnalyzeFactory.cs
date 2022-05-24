using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UC5_ReflectionParameterConstructor
{
    public class MoodAnalyzeFactory
    {
        /// <summary>
        ///  method to create object of MoodAnalyze class.
        /// </summary>
        /// <param name="className">MoodAnalyseFactory</param>
        /// <param name="constructorName">CreateMoodAnalyse</param>
        /// <returns></returns>
        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName)
        {
            Type type = typeof(MoodAnalyzeUC5);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { "HAPPY" });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyzeException(MoodAnalyzeException.ExceptionType.NO_SUCH_METHOD, "Constructor is Not Found");
                }
            }
            else
            {
                throw new MoodAnalyzeException(MoodAnalyzeException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
        }
    }
}

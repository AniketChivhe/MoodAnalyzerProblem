using System;

namespace UC5_ReflectionParameterConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Refactror a To intialize parameter
            Console.WriteLine("Welcome To Mood Analyzer Problem - UC5_ReflectionParameterConstructor");
            MoodAnalyzeUC5 moodAnalyze = new MoodAnalyzeUC5("I am in Happy Mood");
            string mood = moodAnalyze.AnalyzeMood();

            Type type = typeof(MoodAnalyzeUC5);
            Console.WriteLine(type.FullName);

        }
    }
}
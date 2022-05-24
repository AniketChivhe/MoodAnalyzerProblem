using System;

namespace UC4_ReflectionDefaultConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Refactror a To intialize parameter
            Console.WriteLine("Welcome To Mood Analyzer Problem - UC4_Reflection to create Mood Analyzer with DefaultConstructor");
            MoodAnalyzeUC4 moodAnalyze = new MoodAnalyzeUC4("I am in Happy Mood");
            string mood = moodAnalyze.AnalyzeMood();

        }
    }
}
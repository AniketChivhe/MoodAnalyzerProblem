using System;

namespace UC3_CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Refactror a To intialize parameter
            Console.WriteLine("Welcome To Mood Analyzer Problem - UC3_CustomException");
            MoodAnalyzeUC3 moodAnalyze = new MoodAnalyzeUC3("I am in Happy Mood");
            string mood = moodAnalyze.AnalyzeMood();
        }
    }
}
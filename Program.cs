using System;

namespace UC2_HandleException
{
    class Program
    {
        static void Main(string[] args)
        {
            //Refactror a To intialize parameter
            Console.WriteLine("Welcome To Mood Analyzer Problem-- UC2_HandleExecption");
            MoodAnalyze moodAnalyze = new MoodAnalyze("I am in Happy Mood");
            string mood = moodAnalyze.AnalyzeMood();

        }
    }
}
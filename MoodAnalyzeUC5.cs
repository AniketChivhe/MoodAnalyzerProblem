﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5_ReflectionParameterConstructor
{
    public class MoodAnalyzeUC5
    {
        public MoodAnalyzeUC5() { }
        private string message;
        /// <summary>
        /// parameterised constructor
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyzeUC5(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzeException(MoodAnalyzeException.ExceptionType.Empty_Message, "Mood should not be Empty");
                }

                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzeException(MoodAnalyzeException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }

        }

    }
}
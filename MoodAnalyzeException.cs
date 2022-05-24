using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_CustomException
{
    public class MoodAnalyzeException : Exception
    {
        /// <summary>
        /// exception Enum
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE, Empty_Message
        }
        ////Creating 'type' variable of type ExceptionType
        private readonly ExceptionType type;
        public MoodAnalyzeException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}

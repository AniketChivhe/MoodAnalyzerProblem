using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProb
{
    public class MoodAnalyze
    {
        string message;
        public MoodAnalyze(string message)
        {
            this.message = message;
        }
        public string analyseMood()
        {
            if (message.ToLower().Contains("happy ANY"))
            {
                return "HAPPY";
            }
            else
            {
                return "SAD";
            }
        }
    }
}

using MoodAnalyser;
using MoodAnalyser_MS;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalysers
    {
        private string message;
        public MoodAnalysers(string message)
        {
            this.message = message;
        }
        public MoodAnalysers()
        {
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else if (this.message.Contains("Happy"))
                {
                    return "HAPPY";
                }
                else if (this.message.Contains("Any"))
                {
                    return "HAPPY";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MESSAGE, "Message should not be null");
            }
        }
    }

}

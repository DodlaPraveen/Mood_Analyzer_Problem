using System;

namespace MoodAnalyser_MS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***MOOD_ANALYSER***");
        }
        public string AnalyseMood(string mood)
        {
            if (mood.Equals("Happy"))
            {
                return mood + " mood";
            }
            else if (mood.Equals("Sad"))
            {
                return mood + " mood";
            }
            else if (mood.Equals("I am in Sad Mood"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}

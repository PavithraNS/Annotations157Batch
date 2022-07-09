using MoodAnalyser131Batch.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser131Batch
{
    public class MoodAnalyser
    {
        public string message; // I am in Happy mood

        public MoodAnalyser()
        {

        }

        public MoodAnalyser(string msg)
        {
            this.message = msg;
        }

        public void Test()
        {
            Console.WriteLine("testing");
        }

        [Custom("AnalysingMood","Anlaysing user mood based his/her message")]
        public string AnalyseMood()
        {
            try
            {
                if (message.Equals(string.Empty)) //""
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MOOD,"Message should not be empty");
                if (message.ToLower().Contains("happy"))
                    return "happy";
                else
                    return "sad";
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                //return ex.Message;
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MOOD, "Message should not be null");
            }
        }
    }
}

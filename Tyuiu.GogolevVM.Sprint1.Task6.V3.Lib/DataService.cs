using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GogolevVM.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string results = "";
            foreach (string word in words)

            {
                if (word.Length > 0)
                {
                    results +=  word[word.Length -1];
                }
            }
            return results;
        }
        
    }
}

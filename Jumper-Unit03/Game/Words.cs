using System;

namespace Jumper_Unit04
{

    public class listWords
    {
        List<string> Dictionary = new List<string>();

        int index;
        Random random = new Random();
        
        public listWords() 
        {
            Dictionary.Add("mormon");
            Dictionary.Add("lehi");
            Dictionary.Add("nephi");
            Dictionary.Add("bible");
            Dictionary.Add("jesus");
            Dictionary.Add("atonement");
            Dictionary.Add("scriptures");
        }

        public string pickWord() 
        {
            index = random.Next(Dictionary.Count);

            return Dictionary[index];
        }
    }
}
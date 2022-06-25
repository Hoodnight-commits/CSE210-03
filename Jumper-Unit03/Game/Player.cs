using System;

namespace Jumper_Unit04
{
    public class Player 
    {

    public List<string> wordtoList(string pickWord) 
    {
        char[] lettersList = pickWord.ToCharArray();
        var singleLetterList = lettersList.Select(c => c.ToString()).ToList();

        return singleLetterList;
    }


        string pickWord;
        int count;
        public Player() {}

        public void checkLetter() 
        {
            List<string> blankSpaces = new List<string>();

            Jumper jumper = new Jumper();
            listWords random = new listWords();

            var layout = jumper.Parachute();
            int count = jumper.GetCount();

            pickWord = random.pickWord();

            List<string> singleLetterList = wordtoList(pickWord);

            foreach (string letter in singleLetterList) 
            {
                blankSpaces.Add("_ ");
            }

            while (count > 3)
             {
                jumper.DrawJumper(layout);

                foreach (string item in blankSpaces)
                {
                    Console.Write(item);
                }

                string letterEntered = this.getLetter(pickWord);

                if (!singleLetterList.Contains(letterEntered)) 
                {
                    layout.RemoveAt(0);
                }

                if (singleLetterList.Contains(letterEntered)) 
                {
                    for (int i = 0; i < singleLetterList.Count; i++) 
                    {
                        if (singleLetterList[i] == letterEntered) 
                        {
                            blankSpaces[i] = letterEntered;
                        }
                    }
                }
                
                if (!blankSpaces.Contains("_ ")) 
                {
                    jumper.DrawJumper(layout);
                    foreach (string item in blankSpaces) 
                    {
                        Console.Write(item);
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine("You win!");
                    return;
                }

                count = layout.Count;
            }

            layout[0] = "   X";
            jumper.DrawJumper(layout);
        }

        public string getLetter(string pickWord) 
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Guess a letter [a-z]: ");
            string guessedLetter = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");

            return guessedLetter;
        }
    }
}

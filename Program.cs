internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please write a sentence: ");
        string inputSentence = Console.ReadLine();

        if (String.IsNullOrEmpty(inputSentence))
        {
            Console.WriteLine("Please write something: ");
        }
        else
        {
            ChangeChars(inputSentence);
        }
        
    }

    static void ChangeChars(string inputWord)
    {
      string[] wordList = inputWord.Split(" ");
      string[] reversedWords = new string[wordList.Length];
      
      int counter = 0;
      while (counter < wordList.Length)
      {
          string sentence = wordList[counter];
          string newSentence = sentence[sentence.Length - 1] + sentence.Substring(1, sentence.Length - 2) + sentence[0];
          reversedWords[counter] = newSentence;
          counter++;
      }
      foreach (var word in reversedWords)
      {
          Console.WriteLine(word);
      }
    }
}
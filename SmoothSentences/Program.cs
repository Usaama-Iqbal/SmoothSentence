using System;

public class SmoothSentenceChecker
{
    public static bool IsSmooth(string sentence)
    {
       
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

       
        if (words.Length < 2)
            return true;

        for (int i = 0; i < words.Length - 1; i++)
        {
           
            char lastCharOfCurrentWord = char.ToLower(words[i][words[i].Length - 1]);
            char firstCharOfNextWord = char.ToLower(words[i + 1][0]);

            
            if (lastCharOfCurrentWord != firstCharOfNextWord)
                return false;
        }

        return true;
    }
    public static void Main(string[] args)
    {
        string sentence1 = "Marta appreciated deep perpendicular right trapezoids";
        string sentence2 = "Someone is outside the doorway";
        string sentence3 = "She eats super righteously";


        Console.WriteLine(SmoothSentenceChecker.IsSmooth(sentence1));
        Console.WriteLine(SmoothSentenceChecker.IsSmooth(sentence2));
        Console.WriteLine(SmoothSentenceChecker.IsSmooth(sentence3));

    }
}


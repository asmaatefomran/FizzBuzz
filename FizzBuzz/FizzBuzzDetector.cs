namespace FizzBuzz;
using System.Text;

public class FizzBuzzDetector
{
    public (string Output, int totalCount)
        getOverlappings(string input)
    {
        StringBuilder output = new StringBuilder();
        string currentWord = "";

        int wordCount = 0;
        int fizzCount = 0;
        int buzzCount = 0;
        int fizzBuzzCount = 0;
        int totalCount = 0;

        for (int i = 0; i <= input.Length; i++)
        {
            if (i < input.Length &&
                (char.IsLetterOrDigit(input[i]) || input[i] == '\''))
            {
                currentWord += input[i];
            }
            else
            {
                if (currentWord.Length > 0)
                {
                    wordCount++;

                    if (wordCount % 3 == 0 && wordCount % 5 == 0)
                    {
                        output.Append("FizzBuzz");
                        fizzBuzzCount++;
                    }
                    else if (wordCount % 3 == 0)
                    {
                        output.Append("Fizz");
                        fizzCount++;
                    }
                    else if (wordCount % 5 == 0)
                    {
                        output.Append("Buzz");
                        buzzCount++;
                    }
                    else
                    {
                        output.Append(currentWord);
                    }

                    currentWord = "";
                }

                if (i < input.Length)
                    output.Append(input[i]);
            }
        }

        totalCount = fizzCount + buzzCount + fizzBuzzCount;

        return (output.ToString(), totalCount);
    }
}


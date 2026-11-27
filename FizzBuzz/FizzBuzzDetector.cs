namespace FizzBuzz;
using System.Text;

public class FizzBuzzDetector
{
    // The getOverlappings method replaces every third word with "Fizz",
    // every fifth word with "Buzz", and every fifteenth word (both third and fifth)
    // with "FizzBuzz"
    public (string Output, int totalCount)
        getOverlappings(string input)
    {
        StringBuilder output = new StringBuilder();
        // A String to store the current word until a separator is encountered
        string currentWord = "";

        //some counts to count the number of word that are replaced
        int wordCount = 0;
        int fizzCount = 0;
        int buzzCount = 0;
        int fizzBuzzCount = 0;
        int totalCount = 0;
        
        // Loop through every character in the input, including the final position
        // to make sure the last word is counted
        for (int i = 0; i <= input.Length; i++)
        {
            // Check if the current character is part of a word
            // Apostrophes are also considered part of a word
            if (i < input.Length &&
                (char.IsLetterOrDigit(input[i]) || input[i] == '\''))
            {
                // if so add the current character to the word being built
                currentWord += input[i];
            }
            else
            {
                // Process the word when a separator is found
                if (currentWord.Length > 0)
                {
                    wordCount++;
                    
                    // Replace every fifteenth word with "FizzBuzz"
                    if (wordCount % 3 == 0 && wordCount % 5 == 0)
                    {
                        output.Append("FizzBuzz");
                        fizzBuzzCount++;
                    }
                    // Replace every third word with "Fizz"
                    else if (wordCount % 3 == 0)
                    {
                        output.Append("Fizz");
                        fizzCount++;
                    }
                    // Replace every fifth word with "Buzz"
                    else if (wordCount % 5 == 0)
                    {
                        output.Append("Buzz");
                        buzzCount++;
                    }
                    // Keep the original word if no replacement is needed
                    else
                    {
                        output.Append(currentWord);
                    }

                    // Clear the current word before processing the next one
                    currentWord = "";
                }

                // Preserve separators such as spaces, commas, and punctuation and add them to the result
                if (i < input.Length)
                    output.Append(input[i]);
            }
        }

        // Calculate the total number of replacements
        totalCount = fizzCount + buzzCount + fizzBuzzCount;

        // Return the transformed text and the total replacement count
        return (output.ToString(), totalCount);
    }
}


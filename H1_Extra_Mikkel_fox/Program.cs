namespace H1_Extra_Mikkel_fox
{
    internal class Program
    {
        static void Main()
        {
            // Prompts user to write a sentence, which gets stored in the "input" variable
            Console.WriteLine("Write a sentence");
            string input = Console.ReadLine();

            // Splits the "input" variable up, into words in an array, by splitting it in the spaces
            string[] inputList = input.Split(" ");

            // takes the length of the array minus 1
            int length = inputList.Length;

            // Creates a new variable to keep track of the longest word length
            int longestWord = 0;

            // Creates a new variable to keep track of the output
            string outputWords = "";

            int currentWordLength;

            for (int i = 0; i < length; i++)
            {

            }
        }
    }
}


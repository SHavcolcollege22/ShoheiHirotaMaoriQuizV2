string[] MaoriTerms = {"kia ora", "awa", "kai", "waiata", "waka", "aroha", "morena", "maunga", "tamaki makaurau", "tahi"}; //I have declared my arrays which will be used in my quiz
string[] EnglishTerms = { "hello, hi", "food", "song, sing", "canoe", "love", "good morning", "auckland", "one"}; //I have declared my arrays which will be used in my quiz

int score = 0; //I have declared my score variable and set it to 0. this will calculate the total and keep a running total
Console.WriteLine("Please enter the difficulty level (easy, medium or hard)\n *NOTE please enter all your inputs in lowercase*");
string levelDifficulty = Console.ReadLine();

while (levelDifficulty != "easy" || levelDifficulty != "medium" || levelDifficulty != "hard")
{
    Console.WriteLine("Please enter a valid input. Remember, the only valid inputs for this program are 'easy', 'medium' and 'hard': ");
    levelDifficulty = Console.ReadLine();
}
foreach (string MaoriTerm in MaoriTerms)
{
    Console.WriteLine($"What is the meaning of {MaoriTerms}: ");
    string ans = Console.ReadLine();
    {
        if (ans == EnglishTerms)
        {
            Console.WriteLine("That was correct!");
            score++;

        }
        else
        {
            Console.WriteLine("That was incorrect.");
        }
    }
}
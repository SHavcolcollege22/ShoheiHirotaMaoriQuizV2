string[] maoriTermsEasy = { "kia ora", "awa", "kai", "waiata", "waka", "aroha", "morena", "maunga", "tamaki makaurau", "tahi" }; //I have declared my arrays which will be used in my quiz
string[] englishTermsEasy = { "hello", "river", "food", "song", "canoe", "love", "good morning", "mountain", "auckland", "one" }; //I have declared my arrays which will be used in my quiz
string[] englishTermsEasyOr = { "hi", "river", "food", "sing", "canoe", "love", "good morning", "mountain", "auckalnd", "one" };

string[] maoriTermsMedium = { "pounamu", "tamāhine", "tangi", "whānau", "whenua", "Kaumatua", "manuhiri", "motu", "one", "puke" };
string[] englishTermsMedium = { "jade", "daughter", "funeral", "family", "land", "elder", "guests", "island", "sand", "hill"  };
string[] englishTermsMediumOr = { "green stone", "daughter", "funeral", "family", "home land", "elderly", "visitors", "island", "earth", "hill" };

string[] englishTermsHard = { };
string[] MaoriTermsHard = { };

int indexEasy = 0; //I have declared my index variable for easy level and set it to 0. I have set this to 0 as the first index is 0
int scoreEasy = 0; //I have declared my score variable for easy level and set it to 0. this will calculate the total and keep a running total

int indexMedium = 0;
int scoreMedium = 0;

int indexHard = 0;
int scoreHard = 0;



Console.WriteLine("Please enter the difficulty level (easy, medium or hard)\n *NOTE please enter all your inputs in lowercase*");
string levelDifficulty = Console.ReadLine();

while (levelDifficulty != "easy" && levelDifficulty != "medium" && levelDifficulty != "hard")
{
    Console.WriteLine("Please enter a valid input. Remember, the only valid inputs for this program are 'easy', 'medium' and 'hard': ");
    levelDifficulty = Console.ReadLine();
}
if (levelDifficulty == "easy")
{
    foreach (string MaoriTermMedium in maoriTermsEasy)
    {
        Console.WriteLine($"What is the meaning of {maoriTermsEasy[indexEasy]}: ");
        string ans = Console.ReadLine();
        if (ans == englishTermsEasy[indexEasy] || ans == englishTermsEasyOr[indexEasy])
        {
            Console.WriteLine("That was correct!");
            scoreEasy++;

        }
        else
        {
            Console.WriteLine("That was incorrect.");
        }
        indexEasy++;
    }
    Console.WriteLine($"\n\nYour score was {scoreEasy} / 10");
}

if (levelDifficulty == "medium")
{
    foreach (string MaoriTermMedium in maoriTermsMedium)
    {
        Console.WriteLine($"What is the meaning of {maoriTermsMedium[indexMedium]}: ");
        string ans = Console.ReadLine();
        if (ans == englishTermsMedium[indexMedium] || ans == englishTermsMediumOr[indexMedium])
        {
            Console.WriteLine("That was correct!");
            scoreMedium++;

        }
        else
        {
            Console.WriteLine("That was incorrect.");
        }
        indexMedium++;
    }
    Console.WriteLine($"\n\nYour score was {scoreMedium} / 10");
}
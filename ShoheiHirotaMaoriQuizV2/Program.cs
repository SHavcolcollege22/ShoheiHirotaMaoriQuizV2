string[] maoriTermsEasy = { "kia ora", "awa", "kai", "waiata", "waka", "aroha", "morena", "maunga", "tamaki makaurau", "tahi" }; //I have declared my easy difficuly arrays which will be used in my quiz
string[] englishTermsEasy = { "hello", "river", "food", "song", "canoe", "love", "good morning", "mountain", "auckland", "one" }; //I have declared my arrays which will be used in my quiz
string[] englishTermsEasyOr = { "hi", "river", "food", "sing", "canoe", "love", "good morning", "mountain", "auckalnd", "one" }; // I have declared an 'Or' array as there may be more than one answer for a question. So if they get one of the two answers, then they will be correct/ and get a point


string[] maoriTermsMedium = { "pounamu", "tamāhine", "tangi", "whānau", "whenua", "Kaumatua", "manuhiri", "motu", "one", "puke" }; //I have declared my medium difficulty arrays. These are the questions the user will be asked to translate. 
string[] englishTermsMedium = { "jade", "daughter", "funeral", "family", "land", "elder", "guests", "island", "sand", "hill"  }; //I have delared my medium diffculty english term arrays. These are the correct translations to the questions. 
string[] englishTermsMediumOr = { "green stone", "daughter", "funeral", "family", "home land", "elderly", "visitors", "island", "earth", "hill" }; //I have declared my other medium difficulty english term arrays. There may be more than one translation so these are the other correct translations.

string[] englishTermsHard = { "greenstone / jade", "daughter", "funeral", "family", "land / home land", "elder / elderly", "guests / visitors", "island", "sand / earth", "hill" };
string[] MaoriTermsHard = { "pounamu", "tamahine", "tangi", "whanaua", "whenua", "kaumatua", "manuhiri", "motu", "one", "puke" };

int indexEasy = 0; //I have declared my index variable for easy level and set it to 0. I have set this to 0 so it starts from the very beginning.
int scoreEasy = 0; //I have declared my score variable for easy level and set it to 0. this will calculate the total and keep a running total

int indexMedium = 0; //I have declared my index variable for medium level and set it to 0. I have set this to 0 so it starts from the very beginning.
int scoreMedium = 0; //I have declared my score variable for medium level and set it to 0. This will calculate the total and keep a running total

int indexHard = 0; //I have declared my index variable for hard level and set it to 0. I have set this to 0 so it starts from the very beginning.
int scoreHard = 0; //I have declared my score variable for harf level and set it to 0. This will calculate the total and keep a running total



Console.WriteLine("Please enter the difficulty level (easy, medium or hard)\n *NOTE please enter all your inputs in lowercase*");
string levelDifficulty = Console.ReadLine();

while (levelDifficulty != "easy" && levelDifficulty != "medium" && levelDifficulty != "hard")
{
    Console.WriteLine("Please enter a valid input. Remember, the only valid inputs for this program are 'easy', 'medium' and 'hard': ");
    levelDifficulty = Console.ReadLine();
}
if (levelDifficulty == "easy")
{
    foreach (string MaoriTermEasy in maoriTermsEasy)
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

if (levelDifficulty == "hard")
{
    foreach (string englishTermHard in englishTermsHard)
    {
        Console.WriteLine($"What is the english translation of {englishTermHard[indexHard]}: ");
        string ans = Console.ReadLine();
        if (ans == MaoriTermsHard[indexHard])
        {
            Console.WriteLine("That was correct!");
            scoreHard++;

        }
        else
        {
            Console.WriteLine("That was incorrect.");
        }
        indexHard++;
    }
    Console.WriteLine($"\n\nYour score was {scoreHard} / 10");
}
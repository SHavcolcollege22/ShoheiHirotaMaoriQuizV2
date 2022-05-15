﻿//Psuedo Code:

// Set arrays
  // maoriTermEasy, englishTermsEasy, englishTermsEasyOr, maoriTermsMedium, englishTermsMedium, englishTermsMediumOr, englishTermsHard, maoriTermsHard

// Set Index variable
  // indexEasy, indexMedium, indexHard

// Set Score variable
  // scoreEasy, scoreMedium, scoreHard

// Display introduction to quiz
  // Ask the user for difficulty level input

// Do all of this in a while loop

  // While levelDifficulty not equal to 'easy', 'medium' and 'hard'
    // Print error message

  
  // If levelDifficulty == 'easy'
    // What is the correct definition of: Kia Ora?\n1: Hello / Hi\n2: Food\n3: Red\n4: Ocean
      // If answer == '1'
        // Print correct and add one point to the score count (ScoreEasy++)
      // Else
        // Print incorrect message as well as the correct answer


    // What is the correct definition of: Awa?\n1: Family\n2: School\n3: River\n4: Book
      // If answer == '3'
        // Print correct and add one point to the score count (ScoreEasy++)
      // Else
        // Print incorrect message as well as the correct answer

    // What is the correct definition of: Kai?\n1: Work\n2: Food\n3: Rich\n4: Park
      // If answer == '3'
        // Print correct and add one to the score count (ScoreEasy++)
     // Else
        // Print incorrect message as well as the correct answer

    // What is the correct definition of: Waiata?\n1: Soccer\n2: Sing / Song\n3: Apple\n4: Piano
      // If answer == '2'
        // Print correct and add one to the score count (ScoreEasy++)
     // Else
        // Print incorrect message as well as the correct answer


    // What is the correct definition of: Waka ?\n1: Boat\n2: Car\n3: Bike\n4: Canoe
      // If answer == '4'
        // Print correct and add one to the score count (ScoreEasy++)
     // Else
        // Print incorrect message as well as the correct answer

    // What is the correct definition of: Aroha?\n1: Love\n2: Hate\n3: Nuetral\n4: Pink
      // If answer == '1'
        // Print correct and add one to the score count (ScoreEasy++)
     // Else
        // Print incorrect message as well as the correct answer

    // What is the correct definition of: Morena ?\n1: Good morning\n2: Good evening\n3: Good night\n4: Good day
      // If answer == '1'
        // Print correct and add one to the score count (ScoreEasy++)
     // Else
        // Print incorrect message as well as the correct answer

    // What is the correct definition of: Maunga ?\n1: Volcano\n2: Lake\n3: Rocks\n4: Mountain 
      // If answer == '4'
        // Print correct and add one to the score count (ScoreEasy++)
     // Else
        // Print incorrect message as well as the correct answer

    // What is the correct definition of: Tāmaki Makaurau ? \n1: Wellignton\n2: Hamilton\n3: Auckalnd\n4: Christchurch
      // If answer == '3'
        // Print correct and add one to the score count (ScoreEasy++)
     // Else
        // Print incorrect message as well as the correct answer

    // What is the correct definition of: Tahi ? \n1: One\n2: Two\n3: Three\n4: Four
      // If answer == '1'
        // Print correct and add one to the score count (ScoreEasy++)
     // Else
        // Print incorrect message as well as the correct answer

   // Print the total score for how many questions the user got correct for easy level







  






  // If levelDifficulty == 'easy'
    // Foreach (string MaoriTermEasy in maoriTermsEasy)
      // What is the english translation of {maoriTermsEasy[indexEasy]}
        // If answer == englishTermsEasy[indexEasy] || answer == englishTermsEasyOr[indexEasy]
           // Print correct (and add one to the score count (scoreEasy++))
        // Else
           // Print incorrect
        // Add one to the index (indexEasy++) 
     // Print the total score for how many questions the user got correct for easy level
  // Reset the index for this level (indexEasy = indexEasy - 10) (Basically means to reset the questions)

  // If levelDifficulty == 'medium'
    // Foreach (string MaoriTermMedium in maoriTermMedium)
      // What is the english translation of {maoriTermMedium[indexMedium]}
        // If answer == englishTermsMedium[indexMedium] || answer == englishTermsMedium[indexMedium]
           // Print correct (and add one to the score count (scoreMedium++))
        // Else
           // Print incorrect
        // Add one the the index (indexMedium++)
     // Print the total score for how many questions the user got correct for medium level
  // Reset the index for this level (indexMedium = indexMedium - 10) (Basically means to reset the questions)


  // If levelDifficulty == 'hard'
    // Foreach (string EnglishTermsHard in englishTermsHard)
      // What is the Maori translation of {englishTermsHard[indexHard]}
        // If answer == maoriTermsHard[indexHard]
           // Print correct (and add one to the score count (scoreHard++))
        // Else
           // Print incorrect
        // Add one t the index (indexHard++)
     // Print the total sscore for how many questions the user got correct for hard level
  // Reset the index for this level (indexHard = indexHard - 10)

  // Ask the user if they want to continue or re do a level, if yes, please enter 'y'. If not, please press any key to exit the program/quiz: ");

// while (userInputChoice == 'y');

// Thank the user for using the program
 

 
string[] maoriTermsEasy = { "kia ora", "awa", "kai", "waiata", "waka", "aroha", "morena", "maunga", "tamaki makaurau", "tahi" }; //I have declared my easy difficuly arrays. These are the questions the user will be asked to translate. 
string[] englishTermsEasy = { "hello", "river", "food", "song", "canoe", "love", "good morning", "mountain", "auckland", "one" }; //I have declared my arrays which will be used in my quiz 
string[] englishTermsEasyOr = { "hi", "river", "food", "sing", "canoe", "love", "good morning", "mountain", "auckalnd", "one" }; // I have declared an 'Or' array as there may be more than one answer for a question. So if they get one of the two answers, then they will be correct/ and get a point

string[] maoriTermsMedium = { "pounamu", "Moana", "Haere mai", "Huarahi (hint, what you drive on)", "whenua", "Kaumatua", "manuhiri", "mahi", "one", "wahine" }; //I have declared my medium difficulty arrays. These are the questions the user will be asked to translate. 
string[] englishTermsMedium = { "jade", "sea", "welcome", "road", "land", "elder", "guests", "work", "sand", "wife"  }; //I have delared my medium diffculty english term arrays. These are the correct translations to the questions. 
string[] englishTermsMediumOr = { "green stone", "ocean", "enter", "highway", "home land", "elderly", "visitors", "activity", "earth", "woman" }; //I have declared my other medium difficulty english term arrays. There may be more than one translation so these are the other correct translations.

string[] englishTermsHard = { "greenstone / jade", "daughter", "funeral", "family", "land / home land", "elder / elderly", "guests / visitors", "clan / sub-tribe", "sand / earth", "hill" }; //I have declared my hard difficulty english arrays. These are the questions the user will be asked to translate.
string[] MaoriTermsHard = { "pounamu", "tamahine", "tangi", "whanau", "whenua", "kaumatua", "manuhiri", "hapu", "one", "puke" }; //I have declared my hard difficulty maori term arrays. These are the correct translations to the questions. 

int indexEasy = 0; //I have declared my index variable for easy level and set it to 0. I have set this to 0 so it starts from the very beginning.
int scoreEasy = 0; //I have declared my score variable for easy level and set it to 0. this will calculate the total and keep a running total

int indexMedium = 0; //I have declared my index variable for medium level and set it to 0. I have set this to 0 so it starts from the very beginning.
int scoreMedium = 0; //I have declared my score variable for medium level and set it to 0. This will calculate the total and keep a running total

int indexHard = 0; //I have declared my index variable for hard level and set it to 0. I have set this to 0 so it starts from the very beginning.
int scoreHard = 0; //I have declared my score variable for hard level and set it to 0. This will calculate the total and keep a running total

char userInputChoice = 'y';

do
{
    Console.WriteLine("Welcome to my Te Reo Māori quiz! There are 3 difficulty levels\n\neasy level are multiple choice questions where you just have to choose the correct option\nmedium level will ask you 10 harder questions and they will ask you for the English meaning of a Maori term.\nhard level will ask you 10 questions and they will ask you for the Māori translation of a English term. \n\nPlease enter the difficulty level (easy, medium or hard)\n");
    string levelDifficulty = Console.ReadLine();
    levelDifficulty = levelDifficulty.ToLower();
   

    while (levelDifficulty != "easy" && levelDifficulty != "medium" && levelDifficulty != "hard")
    {
        Console.WriteLine("Please enter a valid input. Remember, the only valid inputs for this program are 'easy', 'medium' and 'hard': "); //This is the statement that will be outputted while the while statement above is true.
        levelDifficulty = Console.ReadLine();
    }

    if (levelDifficulty == "easy") //This is the level difficulty 'easy'. If the user enters 'easy', then the following questions will execute.
    {
        Console.WriteLine("What is the correct definition of: Kia Ora?\n1: Hello / Hi\n2: Food\n3: Red\n4: Ocean "); //This is asking the question
        string ans = Console.ReadLine();
        if (ans == "1") //This is the only answer to the question
        
        {
            Console.WriteLine("That was correct!\n");
            scoreEasy++; // If the user answers '1', then they will get one point which will be added to the 'scoreEasy' variable will and calculated at the end 
            
        }
        else
        {
            Console.WriteLine("That was incorrect, the correct answer is 1 (Hello / Hi).\n"); //If the user gets the question wrong, they will get an incorrect message as well as the correct answer for future reference
            
        }
        // I have added Console.Clear after each question. This ensures a clear and easy view of the screen / next questions
       
        Console.WriteLine("What is the correct definition of: Awa?\n1: Family\n2: School\n3: River\n4: Book ");
        ans = Console.ReadLine();
        if (ans == "3")
        {
            Console.WriteLine("That was correct!\n");
            scoreEasy++;

        }
        else
        {
            Console.WriteLine("That was incorrect, the correct answer is 3 (River).\n");
        }

        Console.WriteLine("What is the correct definition of: Kai ?\n1: Work\n2: Food\n3: Rich\n4: Park ");
        ans = Console.ReadLine();
        if (ans == "2")
        {
            Console.WriteLine("That was correct!\n");
            scoreEasy++;

        }
        else
        {
            Console.WriteLine("That was incorrect, the correct answer is 2 (Food).\n");
        }

        Console.WriteLine("What is the correct definition of: Waiata?\n1: Soccer\n2: Sing / Song\n3: Apple\n4: Piano");
        ans = Console.ReadLine();
        if (ans == "2")
        {
            Console.WriteLine("That was correct!\n");
            scoreEasy++;
        }
        else
        {
            Console.WriteLine("That was incorrect, the correct answer is 2 (Sing / Song).\n");
        }

        Console.WriteLine("What is the correct definition of: Waka ?\n1: Boat\n2: Car\n3: Bike\n4: Canoe");
        ans = Console.ReadLine();
        if (ans == "4")
        {
            Console.WriteLine("That was correct!\n");
            scoreEasy++;
        }
        else
        {
            Console.WriteLine("That was incorrect, the correct answer is 4 (Canoe).\n");
        }

        Console.WriteLine("What is the correct definition of: Aroha?\n1: Love\n2: Hate\n3: Nuetral\n4: Pink");
        ans = Console.ReadLine();
        if (ans == "1")
        {
            Console.WriteLine("That was correct!\n");
            scoreEasy++;
        }
        else
        {
            Console.WriteLine("That was incorrect, the correct answer is 1 (Love).\n");
        }

        Console.WriteLine("What is the correct definition of: Morena ?\n1: Good morning\n2: Good evening\n3: Good night\n4: Good day ");
        ans = Console.ReadLine();
        if (ans == "1")
        {
            Console.WriteLine("That was correct!\n");
            scoreEasy++;
        }
        else
        {
            Console.WriteLine("That was incorrect, the correct answer is 1 (Good morning).\n");
        }

        Console.WriteLine("What is the correct definition of: Maunga ?\n1: Volcano\n2: Lake\n3: Rocks\n4: Mountain ");
        ans = Console.ReadLine();
        if (ans == "4")
        {
            Console.WriteLine("That was correct!\n");
            scoreEasy++;
        }
        else
        {
            Console.WriteLine("That was incorrect, the correct answer is 4 (Mountain).\n");
        }

        Console.WriteLine("What is the correct definition of: Tāmaki Makaurau ? \n1: Wellignton\n2: Hamilton\n3: Auckalnd\n4: Christchurch");
        ans = Console.ReadLine();
        if (ans == "3")
        {
            Console.WriteLine("That was correct!\n");
            scoreEasy++;
        }
        else
        {
            Console.WriteLine("That was incorrect, the correct answer is 3 (Auckland).\n");
        }

        Console.WriteLine("What is the correct definition of: Tahi ? \n1: One\n2: Two\n3: Three\n4: Four");
        ans = Console.ReadLine();
        if (ans == "1")
        {
            Console.WriteLine("That was correct!\n");
            scoreEasy++;
        }
        else
        {
            Console.WriteLine("That was incorrect, the correct answer is 1 (One).\n");
        }
        
        Console.WriteLine($"Your score was {scoreEasy} / 10");
    }

    /*  if (levelDifficulty == "easy")
      {
          foreach (string MaoriTermEasy in maoriTermsEasy)
          {
              Console.Write($"\nWhat is the english translation of {maoriTermsEasy[indexEasy]}: "); //I have added a line gap (\n) to make the code more clear the user. I also changed Console.WriteLine -> Console.Write. I did this so the user inputs their answer on the same line. 
              string ans = Console.ReadLine();
              ans = ans.ToLower(); //I have converted the asnwer to all lowercase.
              if (ans == englishTermsEasy[indexEasy] || ans == englishTermsEasyOr[indexEasy])
              {
                  Console.WriteLine("That was correct!");
                  scoreEasy++;

              }
              else
              {
                  Console.WriteLine($"That was incorrect!"); 
              }
              indexEasy++;
          }
          Console.WriteLine($"\n\nYour score was {scoreEasy} / 10");
          indexEasy = indexEasy - 10; //After the end of this level (easy level), I have minused 10 from the indexEasy variable. I did this so indexEasy resets to the beginning (0) and if the user wishes to re-do the same difficulty level, they will be able to do so. This resets the questions for 'easy' level.
      } */

    if (levelDifficulty == "medium")
    {
        foreach (string MaoriTermMedium in maoriTermsMedium)
        {
            Console.Write($"\nWhat is the english translation of {maoriTermsMedium[indexMedium]}: ");
            string ans = Console.ReadLine();
            ans = ans.ToLower(); //I have converted the asnwer to all lowercase.
            if (ans == englishTermsMedium[indexMedium] || ans == englishTermsMediumOr[indexMedium])
            {
                Console.WriteLine("That was correct!");
                scoreMedium++;

            }
            else
            {
                Console.WriteLine($"That was incorrect, the correct answer is {englishTermsMedium[indexMedium]}/{englishTermsMediumOr[indexMedium]}"); //After the user has entered the wrong answer, the correct answer will be revealed
            }
            indexMedium++;
        }
        Console.WriteLine($"\n\nYour score was {scoreMedium} / 10");
        indexMedium = indexMedium - 10; //After the end of this level (medium level), I have minused 10 from the indexMedium variable. I did this so indexMedium resets to the beginning (0) and if the user wishes to re-do the same difficulty level, they will be able to do so. This resets the questions for 'medium' level.
    }

    if (levelDifficulty == "hard")
    {
        foreach (string EnglishTermHard in englishTermsHard) // I have finally found the issue as to why my code did not work for difficulty level 'hard'. I had declared the same exact array in the foreach method which casued the code to bug. The solution was to change the 'englishTermHard' to 'EnglishTermHard'.
        {
            Console.Write($"\nWhat is the Māori translation of {englishTermsHard[indexHard]}: "); //I also had an issue here. I had a spelling error which caused the code to not run. I simply fixed spelling error and the code ran
            string ans = Console.ReadLine();
            ans = ans.ToLower(); //I have converted the asnwer to all lowercase.
            if (ans == MaoriTermsHard[indexHard])
            {
                Console.WriteLine("That was correct!");
                scoreHard++;

            }
            else
            {
                Console.WriteLine($"That was incorrect, the correct answer is {MaoriTermsHard[indexHard]}"); //After the user has entered the wrong answer, the correct answer will be revealed
            }
            indexHard++;
        }
        Console.WriteLine($"\n\nYour score was {scoreHard} / 10");
        indexHard = indexHard - 10; //After the end of this level (hard level), I have minused 10 from the indexHard variable. I did this so indexHard resets to the beginning (0) and if the user wishes to re-do the same difficulty level, they will be able to do so. This resets the questions for 'hard' level.
    }

    Console.Write("\nIf you wish to try another difficulty level or re-do the level, please enter 'y'.\nIf not, please press any key to exit the program/quiz: ");
    
   

} while (char.TryParse(Console.ReadLine(), out userInputChoice) && userInputChoice == 'y');


static void Outro() //I have added a method named "Outro"
{
    Console.WriteLine("\nThank you for using my program/quiz :). Press any key to leave..."); //This is the information it will display
    Console.ReadKey(); //This is also part of the method and it will wait for the user to press a key
}

Outro(); //I am calling the method here





/*
if (levelDifficulty == "easy") //This is the level difficulty 'easy'. If the user enters 'easy', then the following questions will execute.
{
    Console.WriteLine("What is the correct definition of: Kia Ora?\n1: Hello / Hi\n2: Food\n3: Red\n4: Ocean ");
    string ans = Console.ReadLine();
    if (ans == "1")
    {
        Console.WriteLine("That was correct!");
        scoreEasy++; // If the user answers 'hi' or 'hello', then they will get one point which will be added to the 'score' variable will and calculated at the end 
    }
    else
    {
        Console.WriteLine("That was incorrect.");
    }

    Console.WriteLine("What is the correct definition of: Awa?\n1: Family\n2: School\n3: River Red\n4: Book ");
    ans = Console.ReadLine();
    if (ans == "3")
    {
        Console.WriteLine("That was correct!");
        scoreEasy++;

    }
    else
    {
        Console.WriteLine("That was incorrect.");
    }

    Console.WriteLine("What is the correct definition of: Kai ?\n1: Work\n2: Food\n3: Rich\n4: Park ");
    ans = Console.ReadLine();
    if (ans == "2")
    {
        Console.WriteLine("That was correct!");
        scoreEasy++;

    }
    else
    {
        Console.WriteLine("That was incorrect.");
    }

    Console.WriteLine("What is the correct definition of: Waiata?\n1: Soccer\n2: Sing / Song\n3: Apple\n4: Piano");
    ans = Console.ReadLine();
    if (ans == "2")
    {
        Console.WriteLine("That was correct!");
        scoreEasy++;

    }
    else
    {
        Console.WriteLine("That was incorrect.");
    }

    Console.WriteLine("What is the correct definition of: Waka ?\n1: Boat\n2: Car\n3: Bike\n4: Canoe");
    ans = Console.ReadLine();
    if (ans == "4")
    {
        Console.WriteLine("That was correct!");
        scoreEasy++;

    }
    else
    {
        Console.WriteLine("That was incorrect.");
    }

    Console.WriteLine("What is the correct definition of: Aroha?\n1: Love\n2: Hate\n3: Nuetral\n4: Pink");
    ans = Console.ReadLine();
    if (ans == "1")
    {
        Console.WriteLine("That was correct!");
        scoreEasy++;

    }
    else
    {
        Console.WriteLine("That was incorrect.");
    }

    Console.WriteLine("What is the correct definition of: Morena ?\n1: Good morning\n2: Good evening\n3: Good night\n4: Good day ");
    ans = Console.ReadLine();
    if (ans == "1")
    {
        Console.WriteLine("That was correct!");
        scoreEasy++;

    }
    else
    {
        Console.WriteLine("That was incorrect.");
    }

    Console.WriteLine("What is the correct definition of: Maunga ?\n1: Volcano\n2: Lake\n3: Rocks\n4: Mountain ");
    ans = Console.ReadLine();
    if (ans == "4")
    {
        Console.WriteLine("That was correct!");
        scoreEasy++;

    }
    else
    {
        Console.WriteLine("That was incorrect.");
    }

    Console.WriteLine("What is the correct definition of: Tāmaki Makaurau ? \n1: Wellignton\n2: Hamilton\n3: Auckalnd\n4: Christchurch");
    ans = Console.ReadLine();
    if (ans == "3")
    {
        Console.WriteLine("That was correct!");
        scoreEasy++;
    }
    else
    {
        Console.WriteLine("That was incorrect.");
    }

    Console.WriteLine("What is the correct definition of: Tahi ? \n1: One\n2: Two\n3: Three\n4: Four");
    ans = Console.ReadLine();
    if (ans == "1")
    {
        Console.WriteLine("That was correct!");
        scoreEasy++;

    }
    else
    {
        Console.WriteLine("That was incorrect.");
    }
    Console.WriteLine($"Your score was {scoreEasy} / 10");
}
*/


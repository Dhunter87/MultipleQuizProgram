using System;
using System.Linq;
namespace SelfTrainingProject.MulitpleQuizProgram
{
    public class Quiz6
    {
        string name = NewProfile.FirstName;
        public static int score = 0;
        public static int finalScore = score;
        private string[] UserAnswer = new string[21];
        private string[] userAnswer = new string[21];
        private string[] QuizQuestion = new string[]
        {
            "1. The \"Game Gear\" was the 1990's hand held gaming console developed by which company?",
            "2. Which sign of the Zodiac is represented by the \"water bearer\"?",
            "3. What is the traditional gift for a 15th wedding anniversary?",
            "4. Which American rock band are best known for their 1967 hit \"Happy Together\"?",
            "5. in Which year were the nobel prizes first awarded?",
            "6. What is the hottest planet in our solar system?",
            "7. \"Concho y toro\" is a wine producing company based in which country?",
            "8. \"Chou\" is the french word for which vegetable?",
            "9. how many official languages are spoken in Switzerlnd?",
            "10. What vitamin is also knows as boitin?",
            "11. Cm is the abbreviation of which chemical element?",
            "12. What is the collective noun for a group of buzzards?",
            "13. What US state are Carson City and Reno?",
            "14. Which English football club plays at Deepdale?",
            "15. Which of the \"X-Men\" character was born James Howlett and is often known as logan?",
            "16. Which recurring \"Friends\" character was played by Maggie Wheeler?",
            "17. What two letter word can be placed before \"rising\", \"wards\" and \"set\" to make new words?",
            "18. What American singer released an album entitled \"Whats love got to do with it\"?",
            "19. What is the name of the capital city of the Republic of Indonesia?",
            "20. Which Brittish actor played Lucius Malfoy in the Harry Potter film series?",
            "21. BONUS QUESTION - Which European city would you find the \"Camp Nou\" stadiu,?"
        };
        private string[] QuizAnswer = new string[]
        {
            "sega",
            "aquarius",
            "crystal",
            "the turtles",
            "1901",
            "venus",
            "chile",
            "cabbage",
            "4",
            "b7",
            "curium",
            "wake",
            "nevada",
            "preston north end",
            "wolverine",
            "janice",
            "up",
            "tina turner",
            "jakarta",
            "jason isaacs",
            "barcelona"
        };
        public Quiz6()
        {
            for (int i = 0; i < QuizQuestion.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(QuizQuestion[i]);
                userAnswer[i] = Console.ReadLine();
                UserAnswer[i] = userAnswer[i].ToLower().Trim();
                if (string.Equals(UserAnswer[i], "quit"))
                {
                    break;
                }
                else if (string.Equals(UserAnswer[i], QuizAnswer[i]))
                {
                    Console.WriteLine("CORRECT!");
                    score++;
                }
                else if (string.Equals(UserAnswer[i], ""))
                {
                    UserAnswer[i] = "no answer!";
                    Console.WriteLine("No answer given!");
                }
                else
                {
                    Console.WriteLine("INCORRECT!");
                }
                if (string.Equals(QuizQuestion[i], QuizQuestion[19]))
                {
                    Console.WriteLine("congratulations you've reached the end of the quiz.");
                    Console.WriteLine("Your answers were : ");
                    Console.WriteLine("");

                    for (int j = 0; j < UserAnswer.Length; j++)
                    {
                        if (!(UserAnswer[j] == null))
                        {
                            try
                            {
                                Console.WriteLine(UserAnswer[j].First().ToString().ToUpper() + UserAnswer[j].Substring(1));
                            }
                            catch (InvalidOperationException)
                            {
                                Console.WriteLine("N/A");
                            }
                        }
                        else
                        {
                            Console.WriteLine("");
                        }
                    }
                }
                if (string.Equals(QuizQuestion[i], QuizQuestion[20]))
                {

                    if (string.Equals(UserAnswer[i], QuizAnswer[i]))
                    {
                        score += 4;
                    }
                    else
                    {
                    }
                }
                Console.WriteLine("score : " + score);
                Console.WriteLine("");
            }
            switch (score)
            {
                case 25:
                    Console.WriteLine("Final score : " + score);
                    Console.WriteLine("Congratulations you got the maximum score " + name + "!");
                    Console.WriteLine("");
                    break;
                case 24:
                case 23:
                case 22:
                case 21:
                case 20:
                    Console.WriteLine("Final score : " + score);
                    Console.WriteLine("Excellent score well done " + name + "!");
                    Console.WriteLine("");
                    break;
                case 19:
                case 18:
                case 17:
                case 16:
                case 15:
                    Console.WriteLine("Final score : " + score);
                    Console.WriteLine("Very good score well done " + name + "!");
                    Console.WriteLine("");
                    break;
                case 14:
                case 13:
                case 12:
                case 11:
                case 10:
                    Console.WriteLine("Final score : " + score);
                    Console.WriteLine("Well done " + name + "!");
                    Console.WriteLine("");
                    break;
                case 9:
                case 8:
                case 7:
                case 6:
                case 5:
                    Console.WriteLine("Final score : " + score);
                    Console.WriteLine("Nice try " + name + "!");
                    Console.WriteLine("");
                    break;
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Final score : " + score);
                    Console.WriteLine("Try harder " + name + "!");
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
using System;
using System.Linq;
namespace SelfTrainingProject.MulitpleQuizProgram
{
    public class Quiz9
    {
        string name = NewProfile.FirstName;
        public static int score = 0;
        public static int finalScore = score;        
        private string[] UserAnswer = new string[21];
        private string[] userAnswer = new string[21];
        private string[] QuizQuestion = new string[]
        {
            "1. What is the last name of the last British player to win the Wimbledons womens title?",
            "2. St George is the patron saint of England but in which country is he burried?",
            "3. Where was Marc Cohen walking when he put on his blue swade shoes?",
            "4. Which American singer was born Eleanora Fagan?",
            "5. Hepatitis affects which organ of the body?",
            "6. The Rolls Royce radiator ornament is called \"The Sprit of ....\", what?",
            "7. No 617 squadron of the Royal Air Force is better known as the what?",
            "8. Which Bill played the role of Compo in The Last of the Summer Wine?",
            "9. Which US state would you find Suffolk County on an island?",
            "10. What type of car was \"KITT\"on the original Knight Rider TV show?",
            "11. Who wrote the \"Famous Five\" series of books?",
            "12. What is the fourth book of the Old Testament?",
            "13. Rob Andrew was the director of rugby at which Premiership team until 2006?",
            "14. To what country does the island of Elba belong?",
            "15. What is the real sirname of Sting from The Police?",
            "16. Which film has the phrase \"life is like a box of chocolates, you never know what your gonna get\"?",
            "17. Where were the Bee Gees born?",
            "18. What is the name of the sequel of the film and book \"Twilight\"?",
            "19. Sarah Palin was the first femail governor of the state?",
            "20. The Great Orme is a prominent feature in which Welsh seaside town?",
            "21. BONUS QUESTION - What does the first letter of each answer spell out?"
        };
        private string[] QuizAnswer = new string[]
        {
            "wade",
            "isreal",
            "memphis",
            "billie holiday",
            "liver",
            "ecstasy",
            "dambusters",
            "owen",
            "new york",
            "trans-am",
            "enid blyton",
            "numbers",
            "newcastle",
            "italy",
            "sumner",
            "forrest gump",
            "isle of man",
            "new moon",
            "alaska",
            "llandudno",
            "wimbledon tennis final"
        };
        public Quiz9()
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
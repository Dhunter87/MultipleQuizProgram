using System;
using System.Linq;
namespace SelfTrainingProject.MulitpleQuizProgram
{
    public class Quiz2
    {
        string name = NewProfile.FirstName;
        public static int score = 0;
        public static int finalScore = score;
        private string[] UserAnswer = new string[21];
        private string[] userAnswer = new string[21];
        private string[] QuizQuestion = new string[]
        {
            "1. In Rugby Union, a bonus point is awarded to any teams who score at least how many tries in a match?",
            "2. What is the fifth planet from the sun?",
            "3. A Falchion is a type of .....?",
            "4. Who had a UK number one hit for four weeks in 1960 with \"My Old Mans a Dustman\"?",
            "5. According to the book of Genesis,who is the eldest son of \"Jacob\"?",
            "6. What is the square root of 1521?",
            "7. Which actors film roles have included \"Ben Braddock\" in \"The Graduate\" and \"Bernie Focker\" in \"Meet The Fockers\"?",
            "8. Who wrote the gothic novella \"Strange Case of Dr Jekl And Mr Hyde\"?",
            "9. In which year did the \"Big Ben\" first chime?",
            "10. Which was the first single by \"Queen\" to reach number one in the UK charts?",
            "11. Which star siqn is \"Queen Elizabeth II\"?",
            "12. What country would you expect a website ending with the extension \".cy\" to be based?",
            "13. What is the name of the mouse who is Dumbo's only friend in the 1941 Disney animated film?",
            "14. In which year was Donld Trump born?",
            "15. how many players may be on the court during a basketball game?",
            "16. What was the first flavour crisp introduced comercially in the UK other than salt?",
            "17. In which European country would you find the town of \"Duffel\"?",
            "18. In which Shakespearean play does the character of the Malvolio appear?",
            "19. What is the name given to a Champagne bottle four times the size of a standard 750ml bottle?",
            "20. David Lloyd George was a prime minister who represented which political party?",
            "21. BONUS QUESTION - Which team won Superbowl LII, the final of which was played on Febuary 4th, 2018?"
        };
        private string[] QuizAnswer = new string[]
        {
            "4",
            "jupiter",
            "sword",
            "lonne donegan",
            "reuben",
            "39",
            "dustin hoffman",
            "robert leuis stevenson",
            "1859",
            "bohemian rhapsody",
            "taurus",
            "cyprus",
            "timothy q. mouse",
            "1946",
            "10",
            "cheese and onion",
            "belgium",
            "twelfth night",
            "jeroboam",
            "liberal",
            "philadelphia eagles"
        };
        public Quiz2()
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
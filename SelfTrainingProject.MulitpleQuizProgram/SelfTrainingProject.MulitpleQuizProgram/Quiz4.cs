using System;
using System.Linq;
namespace SelfTrainingProject.MulitpleQuizProgram
{
    public class Quiz4
    {
        string name = NewProfile.FirstName;
        public static int score = 0;
        public static int finalScore = score;
        private string[] UserAnswer = new string[21];
        private string[] userAnswer = new string[21];
        private string[] QuizQuestion = new string[]
        {
            "1. Who performed the theme music to the 2015 James Bondfilm \"Spectre\"?",
            "2. Which american actress provides the voice of \"Bart Simpson\"?",
            "3. Who is the lead singr of the Irish rock band\"The Script\"?",
            "4. Canine Coding is an anagram of which popular ITV show?",
            "5. Which three letter word is the noun used for the young of a beever?",
            "6. \"Check out George, he knows all the chords\", are lyrics from which 1970's Dyre Straits song?",
            "7. How many squares are on a standard scrabble board?",
            "8. In which US state is Alcatraz?",
            "9. \"perro\"is the spanish word for which animal?",
            "10. Which actress played Professor Pomona Sprout in the Harry Potter films?",
            "11. The highest possible hand in a game of poker is known as a ...?",
            "12. Who Wrote the cautionary poem, \"Matilda who told lies and was burned to death\"?",
            "13. A car with the international liscence plate code of IL comes from which country?",
            "14. According the the proverb, when should you not change your horses?",
            "15. In the game of cludo, name the missing character, \"Miss Scarlet\", \"Colonel Mustard\", \"Mrs White\", \"Reverend Green\", \"Mrs Peacock\" and ...?",
            "16. A US presedent can be electred for a maximum of how many terms?",
            "17. Who was the manager of the England football team at the time of their 1966 world cup win?",
            "18. Which year was Concorde first flown?",
            "19. The name of Romanian currency is Romanian ...?",
            "20. Accordiing to the proverb, \"A heavy wallet gives you a ...\"?",
            "21. BONUS QUESTION - How many sides does a tetradecagon have?"
        };
        private string[] QuizAnswer = new string[]
        {
            "sam smith",
            "nancy cartwright",
            "danny o'donoghue",
            "dancing on ice",
            "kit",
            "sultans of swing",
            "225",
            "california",
            "dog",
            "miriam margoyles",
            "royal flush",
            "hilaire belloc",
            "israel",
            "midstream",
            "professor plum",
            "2",
            "alf ramsey",
            "1969",
            "leu",
            "light heart",
            "13"
        };
        public Quiz4()
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
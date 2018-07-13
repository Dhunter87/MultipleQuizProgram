using System;
using System.Linq;
namespace SelfTrainingProject.MulitpleQuizProgram
{
    public class Quiz8
    {
        string name = NewProfile.FirstName;
        public static int score = 0;
        public static int finalScore = score;
        private string[] UserAnswer = new string[21];
        private string[] userAnswer = new string[21];
        private string[] QuizQuestion = new string[]
        {
            "1. The German word \"luft\" translates into English as what?",
            "2. A chipolata is a type of what?",
            "3. What was Miss Marples first name?",
            "4. \"call me Ishmael\" are the opening words of which work of literature?",
            "5. In maths, what is 4 cubed?",
            "6. Who wrote the original book of Jurassic Park?",
            "7. What are the first five books of the Old Testament collectively called?",
            "8. What is the common name for ascorbic acid?",
            "9. Who won the 1998 football World Cup?",
            "10. In which US state was George Michael charged with \"lewd behavior\"?",
            "11. What singers real name is Vincent Damon Furnier?",
            "12. Which actor was the first to play Doctor Who?",
            "13. Before 2012, in what year did Britain last host the Summer Olympics?",
            "14. Which US state is Jack Daniel's whiskey distilled?",
            "15. Which chemical element has the symbol Cl?",
            "16. A group of ravens is called an?",
            "17. Which is the smallest planet in our solar system?",
            "18. To which animal does the term \"porcine\" refer?",
            "19. Then name of the inventor of the jet engine is Sir Frank what?",
            "20. What was the name of the first Brittish woman to trvel to space?",
            "21. BONUS QUESTION - Where would you find the ocean of storms?"
        };
        private string[] QuizAnswer = new string[]
        {
            "air",
            "sausage",
            "jane",
            "moby dick",
            "64",
            "michael crichton",
            "the pentateuch",
            "vitamin c",
            "france",
            "california",
            "alice cooper",
            "william hartnell",
            "1948",
            "tennessee",
            "chlorine",
            "unkindness",
            "mercury",
            "pigs",
            "whittle",
            "helen sharman",
            "on the moon"
        };
        public Quiz8()
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
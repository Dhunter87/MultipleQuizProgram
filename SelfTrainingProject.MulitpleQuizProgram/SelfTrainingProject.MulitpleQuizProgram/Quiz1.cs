using System;
using System.Linq;

namespace SelfTrainingProject.MulitpleQuizProgram
{
    public class Quiz1
    {
        string name = NewProfile.FirstName;
        public static int score = 0;
        public static readonly int finalScore = score;
        private string[] UserAnswer = new string[21];
        private string[] userAnswer = new string[21];
        private string[] QuizQuestion = new string[]
        {
            "1. Into which sea does the Nile flow?",
            "2. Three continents lie on the tropic of Capricorn - South America, Africa and which other continent?",
            "3. In American currency, 10 cents make a what?",
            "4. Africaans was developed from which european language?",
            "5. An Oranique is a cross between a tangerine and what other fruit?",
            "6. What Itailan word for \"scratched drawing\" can be found on walls all over the world?",
            "7. What musical features \"Some enchanted evening\" and \"Theres nothing like a dame\"?",
            "8. What was the name of the first manned lunar landing in 1969?",
            "9. Which boxer was named \"The Dark Destroyer\"?",
            "10. What was the name of Richie Valens \"girlfriend\"?",
            "11. What is the procedure called when an anaesthetic is injected close to the spinal chord?",
            "12. What poisonous oily liquid occurs naturally in tobacco leaves?",
            "13. Who had his first UK top 10 hit with \"Wichita Lineman\"?",
            "14. Which sign of the Zodiac is represented by the scales?",
            "15. Which country was Rudyard Kipling born?",
            "16. What is the gemstone for September?",
            "17. What instrument has been knicknamed the \"Mississippy Saxaphone\"?",
            "18. One and a half litres of Champagne is known as a what?",
            "19. The three particles that make up an atom are Neutron, Proton and what?",
            "20. What is the common name of the \"auora Borealis\"?",
            "21. BONUS QUESTION - What does the first letter of each answer spell out?"
        };
        private string[] QuizAnswer = new string[]
        {
            "mediterranean",
            "australia",
            "dime",
            "dutch",
            "orange",
            "graffitti",
            "south pacific",
            "apollo",
            "nigel benn",
            "donna",
            "epidural",
            "nicotine",
            "glen cambell",
            "libra",
            "india",
            "sapphire",
            "harmonica",
            "magnum",
            "electron",
            "northern lights",
            "mad dogs and englishmen"
        };
        public Quiz1()
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
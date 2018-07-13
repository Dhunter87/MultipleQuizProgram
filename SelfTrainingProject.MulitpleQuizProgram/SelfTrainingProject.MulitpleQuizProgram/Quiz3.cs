using System;
using System.Linq;
namespace SelfTrainingProject.MulitpleQuizProgram
{
    public class Quiz3
    {
        string name = NewProfile.FirstName;
        public static int score = 0;
        public static int finalScore = score;
        private string[] UserAnswer = new string[21];
        private string[] userAnswer = new string[21];
        private string[] QuizQuestion = new string[]
        {
            "1. Whats the colour of the \"bulls eye\" on a dart board?",
            "2. What is the name of postman Pat's pet cat?",
            "3. Whitch breed of dog has breeds Welsh, Scottish and Irish?",
            "4. At which race course is the Derby and the Oaks traditionally run?",
            "5. What do all fuels need to burn?",
            "6. Who played \"Bazel Fawlty\" in Fawlty Towers?",
            "7. Who is the author of the Harry Potter books?",
            "8. The collosseum is located in the capital of which country?",
            "9. How many sides does an octagon have?",
            "10. Who was the lead singer in the band \"The Police\"?",
            "11. In which famous film would you first have come across the character \"Dorothy Gale\"?",
            "12. What is the name of the animated star of the \"Tomb Raider\" franchise?",
            "13. According to Greek mythology, who turned everything he touched into gold?",
            "14. \"Gary\" and \"Phillip Neville\" represented England in which sport?",
            "15. The name of the longest river in the world is \"The ....\"?",
            "16. In snooker which colour ball is worth the most points?",
            "17. Which sign of the Zodiac is represented by the fishes?",
            "18. Which motorway circles London?",
            "19. Who starred n the movie \"Enter the Dragon\"?",
            "20. If you were riding a gondola, which city are you most likely to be in?",
            "21. BONUS QUESTION - In \"The Simpsons\" what type of animal is \"Santa's Little Helper\"?"
        };
        private string[] QuizAnswer = new string[]
        {
            "red",
            "jess",
            "terrier",
            "epsom",
            "oxygen",
            "john cleese",
            "j k rowling",
            "italy",
            "8",
            "sting",
            "the wizard of oz",
            "lara croft",
            "midas",
            "football",
            "nile",
            "black",
            "pisces",
            "m25",
            "bruce lee",
            "venice",
            "dog"
        };
        public Quiz3()
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
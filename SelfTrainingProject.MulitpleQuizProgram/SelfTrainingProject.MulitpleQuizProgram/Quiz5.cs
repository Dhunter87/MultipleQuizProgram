using System;
using System.Linq;
namespace SelfTrainingProject.MulitpleQuizProgram
{
    public class Quiz5
    {
        string name = NewProfile.FirstName;
        public static int score = 0;
        public static int finalScore = score;
        private string[] UserAnswer = new string[21];
        private string[] userAnswer = new string[21];
        private string[] QuizQuestion = new string[]
        {
            "1. in which year was halleys comet last visible from space?",
            "2. What is the capital of the US state Wyoming?",
            "3. From which language does the word \"futon\" originate?",
            "4. What is the fifth letter of the Greek alphabet?",
            "5. What actress played Lady Mary Crawley in Downton Abbey?",
            "6. Who was the original UK host of the ITV gameshow \"The Price is Right\"?",
            "7. What word is used for a period of playin polo, each of which lasts around 7 minutes?",
            "8. Which Hawaiian city was Barack Obama born?",
            "9. Which year did Tony Blair become Prime Minister of the UK?",
            "10. Which London Underground line has the most stations (60 stations)?",
            "11. A cube has how many edges?",
            "12. According to the proverb, what is \"in the detail\"?",
            "13. What is the last sign of the Zodiac alphabetically?",
            "14. What was the last film to be directed be Stanley Kubrick?",
            "15. Which country won the 2017 Womens Euro competition?",
            "16. Who created the cartoon cat Garfeild?",
            "17. How many furlongs in a mile?",
            "18. What do the fashon initials DKNY stand for?",
            "19. How many tarot cards are there in a pack?",
            "20. Rn is the symbol for which chemical element?",
            "21. BONUS QUESTION - What year was the national curriculum introduced into schools in the UK?"
        };
        private string[] QuizAnswer = new string[]
        {
            "1986",
            "cheyenne",
            "japanese",
            "epsilon",
            "michelle dockery",
            "lesley crowther",
            "chukka",
            "honolulu",
            "1997",
            "district line",
            "12",
            "the devil",
            "virgo",
            "eyes wide shut",
            "netherlands",
            "jim davis",
            "8",
            "donna karan new york",
            "78",
            "radon",
            "1988"
        };
        public Quiz5()
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
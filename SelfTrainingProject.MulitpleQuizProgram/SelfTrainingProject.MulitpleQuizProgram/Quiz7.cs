using System;
using System.Linq;
namespace SelfTrainingProject.MulitpleQuizProgram
{
    public class Quiz7
    {
        string name = NewProfile.FirstName;
        public static int score = 0;
        public static int finalScore = score;
        private string[] UserAnswer = new string[21];
        private string[] userAnswer = new string[21];
        private string[] QuizQuestion = new string[]
        {
            "1. What is the correct name for russian nesting dolls?",
            "2. In which English county is Drayton Manor Theme Park?",
            "3. According to the World Boxing Association, Which weight class is just below \"Heavyweight\"?",
            "4. Which legendary US film actor got his first leading role in the 1930 western \"The Big Trail\"?",
            "5. Zara Phillips got married to which former England rugby union player in 2011?",
            "6. The inventor of the pneumatic tyre in 1887 was John Boyn ...?",
            "7. \"Celeste\" and \"periwinkle\" are shades of which prime colour?",
            "8. In biblical terms, the Decalogue is another word for what?",
            "9. Shiekh Mujibur Rahman was the first ever presedent of which country?",
            "10. What is the capital city of Afghanistan?",
            "11. The colours of the Polish flag are white and ...?",
            "12. Which is the only US state to begin with the letter \"P\"?",
            "13. On a UK Monopoly board, which street shares the same colour as Leicester Square and Piccadilly?",
            "14. The bank Santander shares its name with a town in which country?",
            "15. Paraguay has boarders with Brazil, Bolivia and which other country?",
            "16. The national currency of Egypt is the ...?",
            "17. Which of the Beatles leads the wayon thw front of the Abbey Road album cover?",
            "18. Who is the Greek God of music?",
            "19. How many points is the letter \"j\" worth in a game of scrabble?",
            "20. Complete the proverb, Head is to hat, as hand is to .....?",
            "21. BONUS QUESTION - Algophobia is a fear of what?"
        };
        private string[] QuizAnswer = new string[]
        {
            "matryoshka",
            "staffodshire",
            "cruiserweight",
            "john wayne",
            "mike tindall",
            "dunlop",
            "blue",
            "The Ten Commandments",
            "bangladesh",
            "kabul",
            "red",
            "pennsyvania",
            "coventry street",
            "spain",
            "argentina",
            "pound",
            "john lennon",
            "apollo",
            "8",
            "glove",
            "pain"
        };
        public Quiz7()
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
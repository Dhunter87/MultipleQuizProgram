using System;
using System.Linq;
namespace SelfTrainingProject.MulitpleQuizProgram
{
    public class Quiz10
    {
        string name = NewProfile.FirstName;
        public static int score = 0;
        public static int finalScore = score;
        private string[] UserAnswer = new string[21];
        private string[] userAnswer = new string[21];
        private string[] QuizQuestion = new string[]
        {
            "1. The Blue Meanies were the enemy of the Beatles in which film?",
            "2. What song is most commonly sung to celebrate somone gettng a year older?",
            "3. Who composed the songs \"Puttin on the Ritz\", \"I've got to keep me love warm\" and \"White Christmas\"?",
            "4. What is the name of the dutch footballer who transferred from Arsenal to Man Utd in Aug 2012 for £23 million?",
            "5. how many sides does a icosagen have?",
            "6. Which large animal is the only creature thought to produce its own sun tan lotion from its natural secretions?",
            "7. In a musical about gangsters, who are with the guys in the title?",
            "8. Which Greek author was famous for his fables?",
            "9. Which 1988 western saw Emilio Esteves play \"billy The Kid\" alongside Charley Sheen and Kiefer Sutherland?",
            "10. Which Russian punk band were jailed for two years in Aug 2012 for their anti-putin protest andinciting hooliganism in an orthadox church?",
            "11. Which historical region of Greese includes the capital, Athens?",
            "12. Glenridding and Pooley stand at opposit ends of which lake, the second largest in Lake District?",
            "13. Where in London is there a bronze statue of Charly Chaplin?",
            "14. What is the name of the actress which played Hilda Ogdon in Corronation Street?",
            "15. Who is reported to have played his fiddle while Rome burned?",
            "16. What is te surname of the inventor of the worlds first motorcycle?",
            "17. What song from \"joseph and his technicoloured dreamcoat\" gave Jason Donovan a No1 UK hit in 1991?",
            "18. Which TV show from the 70s and 80s featured Michael Langdon as Charles Ingalls living on a farm with his 4 daughters?",
            "19. Which country did \"Posh and Becks\" marry?",
            "20. Which fantacy kingdom was found at the back of the wardrobe and featured Aslan and a white witch?",
            "21. BONUS QUESTION - What is the main character in the film \"The Raiders of the Lost Ark\"?"
        };
        private string[] QuizAnswer = new string[]
        {
            "the yellow submarine",
            "happy birthday",
            "irving",
            "robin van persie",
            "20",
            "hippopotamus",
            "dolls",
            "aesop",
            "young guns",
            "pussy riot",
            "attica",
            "ullswater",
            "leicester square",
            "jean alexander",
            "nero",
            "daimler",
            "any dream will do",
            "little house on the praire",
            "ireland",
            "narnia",
            "indiana jones"
        };
        public Quiz10()
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
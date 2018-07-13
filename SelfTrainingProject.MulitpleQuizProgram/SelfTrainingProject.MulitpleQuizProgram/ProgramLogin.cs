using System;
namespace SelfTrainingProject.MulitpleQuizProgram
{
    public class ProgramLogin
    {
        public static int j = 0;
        public static void loginAttempt()
        {
            int loginAttempts;
            for (loginAttempts = 1; loginAttempts <= 3; loginAttempts++)
            {
                NewProfile newUserProfile = new NewProfile();
                Console.WriteLine("");
                Console.WriteLine("login attempts : " + loginAttempts);
                Console.WriteLine("Please enter your username or type quit to exit: ");
                string userNameAttempt = Console.ReadLine();
                if (string.Equals(userNameAttempt, "quit"))
                {
                    break;
                }
                else if (string.Equals(userNameAttempt, newUserProfile.UserName))
                {
                    Console.WriteLine("Please enter your password or type quit to exit : ");
                    string passwordAttempt = Console.ReadLine();
                    if (string.Equals(userNameAttempt, "quit"))
                    {
                        break;
                    }
                    else if (string.Equals(passwordAttempt, newUserProfile.Password))
                    {
                        Console.WriteLine("Access Granted!");
                        Console.WriteLine("");
                        j = 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Access Denied!");
                    }
                }
                else
                {
                    Console.WriteLine("User name not found!");
                }
                if (loginAttempts == 3)
                {
                    Console.WriteLine("Login attempts limit reached!");
                    Console.WriteLine("");
                }
            }
        }
    }
}
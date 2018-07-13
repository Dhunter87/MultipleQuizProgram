using System;
namespace SelfTrainingProject.MulitpleQuizProgram
{
    public class NewProfile
    {
        public static int UserCount;

        private static string firstName;
        public static string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private static string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private static string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private static string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public static void addNewProfile()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Please enter your user name: ");
            userName = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            password = Console.ReadLine();

            UserCount++;
            Console.WriteLine("User count : " + UserCount);
            Console.WriteLine("");
        }
    }
}
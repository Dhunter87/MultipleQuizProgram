using System;

namespace SelfTrainingProject.MulitpleQuizProgram
{
    class Program: ProgramLogin
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string errorMessage = "Invalid input";

            Console.WriteLine("WELCOME!");
            while (ProgramLogin.j < 1)
            {
                Console.WriteLine("Please enter 1 to add new profile, 2 to login or type quit to exit program.");
                string entry = Console.ReadLine().ToLower();
                if (string.Equals(entry, "quit"))
                {
                    System.Environment.Exit(1);
                }
                else if (string.Equals(entry, ""))
                {
                    Console.WriteLine(errorMessage);
                    continue;
                }
                try
                {
                    int userEntry = int.Parse(entry);
                    if (userEntry == 1)
                    {
                        NewProfile.addNewProfile();
                    }
                    else if (userEntry == 2)
                    {
                        loginAttempt();
                    }
                    else
                    {
                        Console.WriteLine(errorMessage);
                        continue;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine(errorMessage + ". Exception handled!");
                }
            }
            for (int i = 0; i < 1;)
                try
                {
                    Console.WriteLine("MAIN MENU!");
                    Console.WriteLine("Please enter 1 for a random selcted quiz, 2 to select your quiz, 3 to logout or type \"Quit\" to exit Quiz program!");
                    Console.WriteLine("QUIZ TIPS: type quit to exit from a quiz, check spelling before submitting answers and use numbers for numerical answers!");
                    string input = Console.ReadLine();
                    input = input.ToLower().Trim();
                    if (string.Equals(input, "quit"))
                    {
                        Environment.Exit(1);
                    }
                    try
                    {
                        int Input = int.Parse(input);
                        if (Input == 1)
                        {
                            int randomNumber = random.Next(0, 11);
                            if (randomNumber == 1)
                            {
                                Quiz1 quiz1 = new Quiz1();
                            }
                            else if (randomNumber == 2)
                            {
                                Quiz2 quiz2 = new Quiz2();
                            }
                            else if (randomNumber == 3)
                            {
                                Quiz3 quiz3 = new Quiz3();
                            }
                            else if (randomNumber == 4)
                            {
                                Quiz4 quiz4 = new Quiz4();
                            }
                            else if (randomNumber == 5)
                            {
                                Quiz5 quiz5 = new Quiz5();
                            }
                            else if (randomNumber == 6)
                            {
                                Quiz6 quiz6 = new Quiz6();
                            }
                            else if (randomNumber == 7)
                            {
                                Quiz7 quiz7 = new Quiz7();
                            }
                            else if (randomNumber == 8)
                            {
                                Quiz8 quiz8 = new Quiz8();
                            }
                            else if (randomNumber == 9)
                            {
                                Quiz9 quiz9 = new Quiz9();
                            }
                            else if (randomNumber == 10)
                            {
                                Quiz10 quiz10 = new Quiz10();
                            }
                        }
                        else if (Input == 2)
                        {
                            Console.WriteLine("Please enter a numberbetween 1 and 10 to select quiz or type \"Quit\" to go back to main menu!");
                            string sndInput = Console.ReadLine();
                            sndInput = sndInput.ToLower().Trim();
                            if (string.Equals(sndInput, "quit"))
                            {
                                continue;
                            }
                            try
                            {
                                int SndInput = int.Parse(sndInput);
                                if (SndInput == 1)
                                {
                                    Quiz1 quiz1 = new Quiz1();
                                    Console.WriteLine("");
                                }
                                else if (SndInput == 2)
                                {
                                    Quiz2 quiz2 = new Quiz2();
                                    Console.WriteLine("");
                                }
                                else if (SndInput == 3)
                                {
                                    Quiz3 quiz3 = new Quiz3();
                                    Console.WriteLine("");
                                }
                                else if (SndInput == 4)
                                {
                                    Quiz4 quiz4 = new Quiz4();
                                    Console.WriteLine("");
                                }
                                else if (SndInput == 5)
                                {
                                    Quiz5 quiz5 = new Quiz5();
                                    Console.WriteLine("");
                                }
                                else if (SndInput == 6)
                                {
                                    Quiz6 quiz6 = new Quiz6();
                                    Console.WriteLine("");
                                }
                                else if (SndInput == 7)
                                {
                                    Quiz7 quiz7 = new Quiz7();
                                    Console.WriteLine("");
                                }
                                else if (SndInput == 8)
                                {
                                    Quiz8 quiz8 = new Quiz8();
                                    Console.WriteLine("");
                                }
                                else if (SndInput == 9)
                                {
                                    Quiz9 quiz9 = new Quiz9();
                                }
                                else if (SndInput == 10)
                                {
                                    Quiz10 quiz10 = new Quiz10();
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input!");
                                    Console.WriteLine("");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input!");
                                Console.WriteLine("");
                            }
                        }
                        else if (Input == 3)
                        {
                            ProgramLogin.j = 0;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                            Console.WriteLine("");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input!");
                        Console.WriteLine("");
                    }
                }
                catch (Exception)
                {

                }
        }
    }
}
//199 lines of code for original code, down from 728 lines
using System;

namespace Ex04.Menus.Test
{
    public static class MenuMethods
    {
        public static void ShowVersion()
        {
            string versionNumber = "21.1.4.8930";
            Console.WriteLine(versionNumber);
            waitForUserInput();
        }

        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            waitForUserInput();
        }

        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            waitForUserInput();
        }

        public static void CountSpaces()
        {
            Console.WriteLine("Please enter a sentence:");
            string inputFromUser = Console.ReadLine();
            int spaceCounter = 0;

            foreach (char letter in inputFromUser)
            {
                if (char.IsWhiteSpace(letter))
                {
                    spaceCounter++;
                }
            }

            Console.WriteLine("The number of spaces is: {0}", spaceCounter);
            waitForUserInput();
        }

        private static void waitForUserInput()
        {
            Console.WriteLine("Press KEY to continue...");
            Console.ReadKey();
        }
    }
}
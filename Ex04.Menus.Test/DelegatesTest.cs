using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public static class DelegatesTest
    {
        public static void RunDelegatesMenuTest()
        {
            MainMenu mainMenu = new MainMenu("--Menu with Delegates--");
            MainMenu versionAndSpaces = mainMenu.AddMenu("Version and Spaces");
            versionAndSpaces.AddMenuItem("Show Version").ItemClicked += MenuMethods.ShowVersion;
            versionAndSpaces.AddMenuItem("Count Spaces").ItemClicked += MenuMethods.CountSpaces;

            MainMenu dateAndTime = mainMenu.AddMenu("Show Date/Time");
            dateAndTime.AddMenuItem("Show Time").ItemClicked += MenuMethods.ShowTime;
            dateAndTime.AddMenuItem("Show Date").ItemClicked += MenuMethods.ShowDate;

            mainMenu.Show();
        }
    }
}
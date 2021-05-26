using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public static class InterfacesTest
    {
        public static void RunInterfacesMenuTest()
        {
            ShowDate showDate = new ShowDate();
            ShowTime showTime = new ShowTime();
            ShowVersion showVersion = new ShowVersion();
            CountSpaces countSpaces = new CountSpaces();

            MainMenu mainMenu = new MainMenu("--Menu with Interfaces--");
            MainMenu versionAndSpaces = mainMenu.AddMenu("Version and Spaces");
            versionAndSpaces.AddMenuItem("Show Version").AddItemClickedListener(showVersion);
            versionAndSpaces.AddMenuItem("Count Spaces").AddItemClickedListener(countSpaces);

            MainMenu dateAndTime = mainMenu.AddMenu("Show Date/Time");
            dateAndTime.AddMenuItem("Show Time").AddItemClickedListener(showTime);
            dateAndTime.AddMenuItem("Show Date").AddItemClickedListener(showDate);

            mainMenu.Show();
        }
    }
}
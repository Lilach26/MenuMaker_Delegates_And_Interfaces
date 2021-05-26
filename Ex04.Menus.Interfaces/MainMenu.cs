using System;
using System.Text;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : MenuItem
    {
        private readonly List<MenuItem> r_ItemsList;
        private bool m_IsSubMenu;

        public MainMenu(string i_Title) : base(i_Title)
        {
            r_ItemsList = new List<MenuItem>();
            m_IsSubMenu = true;
        }

        public MainMenu AddMenu(string i_MenuTitle)
        {
            MainMenu menu = new MainMenu(i_MenuTitle);
            r_ItemsList.Add(menu);
            m_IsSubMenu = false;

            return menu;
        }

        public MenuItem AddMenuItem(string i_ItemTitle)
        {
            MenuItem menuItem = new MenuItem(i_ItemTitle);
            r_ItemsList.Add(menuItem);

            return menuItem;
        }

        public override void Show()
        {
            int userChoice = -1;
            bool isExitOrBack = false;

            while (!isExitOrBack)
            {
                Console.Clear();
                printMenu();
                userChoice = getUserInput();

                if (userChoice == 0)
                {
                    isExitOrBack = true;
                }
                else
                {
                    r_ItemsList[userChoice - 1].Show();
                }
            }
        }

        private void printMenu()
        {
            StringBuilder menuToPrint = new StringBuilder();
            int index = 1;

            menuToPrint.AppendFormat("{0}", r_Title).AppendLine();
            menuToPrint.Append("=======================").AppendLine();

            foreach (MenuItem menuItem in r_ItemsList)
            {
                menuToPrint.AppendFormat("{0}. {1}", index, menuItem.Title).AppendLine();
                index++;
            }

            if (m_IsSubMenu)
            {
                menuToPrint.AppendLine("0. Back");
            }
            else
            {
                menuToPrint.AppendLine("0. Exit");
            }

            Console.WriteLine(menuToPrint);
        }

        private int getUserInput()
        {
            Console.Write("Please entet your menu option: ");
            string inputFromUser = Console.ReadLine();
            bool isValidInput = int.TryParse(inputFromUser, out int userChoice);

            while (!isValidInput || (userChoice < 0 || userChoice > 2))
            {
                Console.Write("Wrong Input! Please enter a valid option: ");
                inputFromUser = Console.ReadLine();
                isValidInput = int.TryParse(inputFromUser, out userChoice);
            }

            return userChoice;
        }
    }
}
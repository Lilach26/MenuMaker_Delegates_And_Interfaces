using System;
using System.Text;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        public event Action ItemClicked;

        protected readonly string r_Title;

        public MenuItem(string i_Title)
        {
            r_Title = i_Title;
        }

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        public virtual void Show()
        {
            Console.Clear();
            OnItemClicked();
        }

        public virtual void OnItemClicked()
        {
            if (ItemClicked != null)
            {
                ItemClicked.Invoke();
            }
        }
    }
}
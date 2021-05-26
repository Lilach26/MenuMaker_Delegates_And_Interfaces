using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private readonly List<IMenuListener> r_MenuListeners;
        protected readonly string r_Title;

        public MenuItem(string i_Title)
        {
            r_Title = i_Title;
            r_MenuListeners = new List<IMenuListener>();
        }

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        public List<IMenuListener> MenuListeners
        {
            get
            {
                return r_MenuListeners;
            }
        }

        public virtual void Show()
        {
            Console.Clear();
            notifyItemClicked();
        }

        public void AddItemClickedListener(IMenuListener i_ItemListener)
        {
            r_MenuListeners.Add(i_ItemListener);
        }

        public void RemoveItemClickedListener(IMenuListener i_ItemListener)
        {
            r_MenuListeners.Remove(i_ItemListener);
        }

        private void notifyItemClicked()
        {
            foreach (IMenuListener listener in r_MenuListeners)
            {
                listener.ItemClicked();
            }
        }
    }
}
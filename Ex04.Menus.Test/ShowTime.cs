using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal sealed class ShowTime : IMenuListener
    {
        void IMenuListener.ItemClicked()
        {
            MenuMethods.ShowTime();
        }
    }
}

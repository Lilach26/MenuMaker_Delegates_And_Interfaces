using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal sealed class ShowVersion : IMenuListener
    {
        void IMenuListener.ItemClicked()
        {
            MenuMethods.ShowVersion();
        }
    }
}

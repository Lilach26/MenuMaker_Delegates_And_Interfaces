using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal sealed class CountSpaces : IMenuListener
    {
        void IMenuListener.ItemClicked()
        {
            MenuMethods.CountSpaces();
        }
    }
}

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal sealed class ShowDate : IMenuListener
    {
        void IMenuListener.ItemClicked()
        {
            MenuMethods.ShowDate();
        }
    }
}

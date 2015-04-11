using RestauRater.Models.Interfaces;
using System.Collections.Generic;

namespace RestauRater.MenuProvider.Interfaces
{
    public interface IMenuProvider
    {
        IEnumerable<IMenuItem> GetMenuItems(string category);
    }
}

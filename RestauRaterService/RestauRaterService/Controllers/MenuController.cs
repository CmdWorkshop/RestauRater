using RestauRater.MenuProvider;
using RestauRater.MenuProvider.Interfaces;
using RestauRater.Models.Interfaces;
using System.Collections.Generic;
using System.Web.Http;

namespace RestauRaterService.Controllers
{
    public class MenuController : ApiController
    {
        private IMenuProvider menuProvider;

        public MenuController()
        {
            menuProvider = new MenuProvider();
        }

        public MenuController(IMenuProvider menuProvider)
        {
            this.menuProvider = menuProvider;         
        }

        [HttpGet]
        public IEnumerable<IMenuItem> Items(string category = "ALL")
        {
            return this.menuProvider.GetMenuItems(category);
        }
    }
}
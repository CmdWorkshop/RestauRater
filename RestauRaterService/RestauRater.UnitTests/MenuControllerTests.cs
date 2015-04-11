using NSubstitute;
using RestauRater.MenuProvider.Interfaces;
using RestauRater.Models;
using RestauRater.Models.Interfaces;
using RestauRaterService.Controllers;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RestauRater.UnitTests
{
    public class MenuControllerTests
    {
        [Fact]
        public void Items_CategoryProvided_CategoryPassedToMenuProvider()
        {
            IMenuProvider mockedMenuProvider = Substitute.For<IMenuProvider>();
            MenuController controller = new MenuController(mockedMenuProvider);

            controller.Items("TestCategory");

            mockedMenuProvider.Received(1).GetMenuItems("TestCategory");
        }

        [Fact]
        public void Items_NoCategoryProvided_AllPassedToMenuProvider()
        {
            IMenuProvider mockedMenuProvider = Substitute.For<IMenuProvider>();
            MenuController controller = new MenuController(mockedMenuProvider);

            controller.Items();

            mockedMenuProvider.Received(1).GetMenuItems("ALL");
        }

        [Fact]
        public void Items_MenuProviderReturnsMenuItems_MenuItemsReturned()
        {
            IMenuProvider mockedMenuProvider = Substitute.For<IMenuProvider>();

            mockedMenuProvider.GetMenuItems("ALL").Returns(new List<IMenuItem> { new MenuItem("TestItem1", string.Empty, 1, string.Empty), new MenuItem("TestItem2", string.Empty, 1, string.Empty) });
            MenuController controller = new MenuController(mockedMenuProvider);

            List<IMenuItem> menuItems = controller.Items().ToList();

            Assert.Equal(2, menuItems.Count());
            Assert.Equal("TestItem1", menuItems[0].Name);
            Assert.Equal("TestItem2", menuItems[1].Name);
        }

        [Fact]
        public void Items_MenuProviderReturnsNoItems_EmptyCollectionReturned()
        {
            IMenuProvider mockedMenuProvider = Substitute.For<IMenuProvider>();

            mockedMenuProvider.GetMenuItems("ALL").Returns(Enumerable.Empty<IMenuItem>());
            MenuController controller = new MenuController(mockedMenuProvider);

            IEnumerable<IMenuItem> menuItems = controller.Items();

            Assert.False(menuItems.Any());
        }
    }
}

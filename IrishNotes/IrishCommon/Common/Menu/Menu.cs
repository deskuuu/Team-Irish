namespace IrishCommon.Common.Menu
{
    using System;
    using System.Collections.Generic;

    public class Menu
    {
        private List<string> appMenu;

        public Menu()
        {
            this.appMenu = new List<string>();
        }

        private void CreateMenu()
        {
            var makeANewProfille = MenuItems.MakeProfile;
            var makeNoteWithoughtProfille = MenuItems.MakeNoteWithoughtProfille;
            var logOn = MenuItems.LogOn;
            var quit = MenuItems.Quit;

            var menuList = new List<string> { makeANewProfille, makeNoteWithoughtProfille, logOn, quit };

            this.appMenu.AddRange(menuList);
        }

        public void PrinMenu()
        {
            CreateMenu();

            Console.SetCursorPosition(3,13); //for test
            Console.WriteLine(MenuItems.Caption);

            for (int i = 0; i < this.appMenu.Count; i++)
            {
                Console.WriteLine("* " + appMenu[i] + "  ");
                Console.WriteLine($"         For this menu item click {i}");
            }

            //foreach (var menuItem in this.appMenu)
            //{
            //    Console.Write("* " + menuItem + "  ");
            //    // Console.WriteLine(new string(' ', menuItem.Length));
            //}
        }
    }
}

namespace IrishNotes.Common.Menu
{
    using System;
    using System.Collections.Generic;

    using Interfaces;
    using Enumerations;

    public class Menu : IDrowable, IColorable
    {
        /// <summary>
        /// Automatic property with default value.
        /// </summary>
        public TextColorType TextColorType { get; set; } = TextColorType.DarkMagenta;

        private ICollection<string> appMenu;

        /// <summary>
        /// Create a menu list with first capacity constant MenuItemCount int.
        /// </summary>
        public Menu()
        {
            this.appMenu = new List<string>(MenuConstants.MenuItemCount);
        }

        /// <summary>
        /// Create the app menu with options constant MenuItemCount int.
        /// </summary>
        private void CreateMenu()
        {
            var makeANewProfille = MenuConstants.MakeProfile;
            var makeNoteWithoughtProfille = MenuConstants.MakeNoteWithoughtProfille;
            var logOn = MenuConstants.LogOn;
            var quit = MenuConstants.Quit;

            this.appMenu.Add(makeANewProfille);
            this.appMenu.Add(makeNoteWithoughtProfille);
            this.appMenu.Add(logOn);
            this.appMenu.Add(quit);
        }

        public void SetCursorPositionAt(int left, int top)
        {
            Console.SetCursorPosition(left, top);
        }

        public void Draw()
        {
            this.CreateMenu();

            SetCursorPositionAt(10,4);
            ChangeTextColorByUserChoiceWrite(TextColorType, MenuConstants.Caption);
            SetCursorPositionAt(0, 5);
            foreach (var menuItem in this.appMenu)
            {
                ChangeTextColorByUserChoiceWrite(TextColorType, "* ");
                Console.WriteLine(menuItem);
                Console.WriteLine(new string(' ', menuItem.Length));
            }
        }

        public void Clean()
        {
            this.appMenu.Clear();
            Console.Write(appMenu);
        }

        public void ChangeTextColorByUserChoiceWrite(TextColorType color, string text)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write(text);
            Console.ForegroundColor = originalColor;
        }
    }
}

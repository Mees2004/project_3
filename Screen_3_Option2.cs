using System;

namespace ScreenManagement
{
    public class Screen_3_Option2 : Screen
    {
        public Screen_3_Option2()
        {

        }

        public override void Show()
        {
            Log("[Option 2]");

            ConsoleKeyInfo input;

            do
            {
                Console.Clear();

                Display("Option 2");
                Display("");

                input = Console.ReadKey();
            }
            while (input.Key != ConsoleKey.Escape);

            base.Back();
        }
    }
}
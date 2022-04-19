using System;

namespace ScreenManagement
{
    public class Screen_3_Option1 : Screen
    {
        public Screen_3_Option1()
        {

        }

        public override void Show()
        {
            Log("[Option 1]");

            ConsoleKeyInfo input;

            do
            {
                Console.Clear();

                Display("Option 1");
                Display("");

                input = Console.ReadKey();
            }
            while (input.Key != ConsoleKey.Escape);

            base.Back();
        }
    }
}
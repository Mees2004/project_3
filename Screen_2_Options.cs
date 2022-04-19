using System;

namespace ScreenManagement
{
    public class Screen_2_Options : Screen
    {
        private readonly Screen _option1;
        private readonly Screen _option2;

        public Screen_2_Options()
        {
            _option1 = new Screen_3_Option1();
            _option2 = new Screen_3_Option2();

            _option1.SetPrevious(this);
            _option2.SetPrevious(this);
        }

        public override void Show()
        {
            Log("[Step 2]");

            ConsoleKeyInfo input;

            do
            {
                Console.Clear();

                Display("Please choose one of the following:");
                Display("");
                Display("[1] Option 1");
                Display("[2] Option 2");
                Display("");

                input = Console.ReadKey();
            }
            while (input.Key != ConsoleKey.D1 && input.Key != ConsoleKey.D2);

            if (input.Key == ConsoleKey.D1)
            {
                _option1.Show();
            }

            if (input.Key == ConsoleKey.D2)
            {
                _option2.Show();
            }
        }
    }
}
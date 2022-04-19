using System;

namespace ScreenManagement
{
    public class Screen_1_Welcome : Screen
    {
        private readonly Screen _next;

        public Screen_1_Welcome()
        {
            _next = new Screen_2_Options();
            _next.SetPrevious(this);
        }

        public override void Show()
        {
            Log("[Step 1]");

            ConsoleKeyInfo input;

            do
            {
                Console.Clear();

                Display("Welcome, dear guest.");
                Display("My name is Alfred and I will guide you.");
                Display("");
                Display("Please hit [ENTER] to continue...");
                Display("");

                input = Console.ReadKey();
            }
            while (input.Key != ConsoleKey.Enter);

            _next.Show();
        }
    }
}
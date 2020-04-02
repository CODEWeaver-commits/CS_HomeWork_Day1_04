using static System.Console;

namespace ConsoleIO
{
    public static class ConsoleInput
    {
        public static string Number { get; set; }
        
        public static void Input()
        {
            ConsoleOutput.WriteInputMessage();
            Number = ReadLine();
        }
    }
}

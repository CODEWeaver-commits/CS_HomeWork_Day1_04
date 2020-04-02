using static System.Console;

namespace ConsoleIO
{
    public static class ConsoleOutput
    {
        public static string ErrorMessage { get; set; }

        public static void WriteErrorMessage()
        {
            WriteLine(ErrorMessage);
            WriteLine("Для продолжения нажмите любую клавишу...");
            ReadKey();
            Clear();
        }
        public static void WriteInputMessage()
        {
            Write("Введите число: ");
        }
        public static void WriteOutput(int Result)
        {
            WriteLine($"Результат: {Result}");
        }
    }
}

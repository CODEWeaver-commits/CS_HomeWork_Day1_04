using ConsoleIO;
using System;

namespace CS_HomeWork_Day1_04
{
    public static class Logic
    {
        private static int Number { get; set; }
        private static string Result { get; set; }
        private static char[] NumArray { get; set; }
        private static void StringToInt(string Array)
        {
            Number = int.Parse(Array);
        }
        private static bool IsValidNumbers()
        {
            if (!(int.TryParse(ConsoleInput.Number, out int Number)))
            {
                ConsoleOutput.ErrorMessage = "Ошибка! Введите число!";
                return false;
            }
            else if (Number <= 0)
            {
                ConsoleOutput.ErrorMessage = "Ошибка! Число должно быть больше нуля!";
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void Initialization()
        {
            ConsoleInput.Input();
            while (!IsValidNumbers())
            {
                ConsoleOutput.WriteErrorMessage();
                ConsoleInput.Input();
            }
            
        }
        private static void SwitchNumbers()
        {
            NumArray = ConsoleInput.Number.ToCharArray();
            Array.Reverse(NumArray);
            Result = new string(NumArray);
            StringToInt(Result);
        }
        public static void DrawResult()
        {
            SwitchNumbers();
            ConsoleOutput.WriteOutput(Number);
        }
    }
}
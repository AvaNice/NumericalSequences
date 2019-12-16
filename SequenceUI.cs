using Serilog;
using System;

namespace NumericalSequences
{
    class SequenceUI : ISequenceUI
    {
        public int GetUserNumber()
        {
            string input;
            int result;

            Console.Write(TextMessages.ENTER_NUMBER);

            input = Console.ReadLine();

            try
            {
                result = Convert.ToInt32(input);

                return result;
            }
            catch (FormatException ex)
            {
                Log.Logger.Error($"{ex.Message}");
                ShowResult(TextMessages.INCORRECT_INPUT_FORMAT);
            }
            catch (OverflowException ex)
            {
                Log.Logger.Error($"{ex.Message}");
                ShowResult(TextMessages.INCORRECT_INPUT_FORMAT);
            }

            return GetUserNumber();
        }

        public void ShowResult(string result)
        {
            Console.Write(result);
        }
    }
}

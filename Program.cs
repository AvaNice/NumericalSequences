using Serilog;
using System;

namespace NumericalSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
               .WriteTo.File("log.txt").CreateLogger();

            int userNumber;
            ISequenceUI userInterface = new SequenceUI();
            var app = new NaturalNumbersSquareLessApp(userInterface);

            if (args.Length > 1)
            {
                try
                {
                    userNumber = Convert.ToInt32(args[0]);

                    app.RunApp(userNumber);
                }
                catch (FormatException ex)
                {
                    Log.Logger.Error($"{ex.Message}");
                    userInterface.ShowResult(TextMessages.CANT_READ_ARGS);
                }
                catch (OverflowException ex)
                {
                    Log.Logger.Error($"{ex.Message}");
                    userInterface.ShowResult(TextMessages.CANT_READ_ARGS);
                }
                catch (NullReferenceException ex)
                {
                    Log.Logger.Error($"{ex.Message}");
                    userInterface.ShowResult(TextMessages.CANT_READ_ARGS);
                }
            }
            else
            {
                userNumber = userInterface.GetUserNumber();

                app.RunApp(userNumber);
            }

             Console.ReadKey();
        }
    }
}

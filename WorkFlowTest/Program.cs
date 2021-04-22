using System;
using NLog;
using WorkFlowTest.DI;

namespace WorkFlowTest
{
    public class Program
    {
        public const int ErrorExitCode = 1;
        public const int SuccessExitCode = 0;

        private static void Main(string[] args)
        {
            try
            {
                LogManager.GetCurrentClassLogger().Info("<Starting WorkFlowTest Application>");

                var service = new ApplicationBuilder().Build();
                service.Invoke().GetAwaiter().GetResult();
                LogManager.GetCurrentClassLogger().Info("<Finishing WorkFlowTest Application>");
                Environment.Exit(SuccessExitCode);
            }
            catch (Exception e)
            {
                System.Console.Error.WriteLine(e);
                LogManager.GetCurrentClassLogger().Error(e);
            }
            Environment.Exit(ErrorExitCode);
        }
    }

}

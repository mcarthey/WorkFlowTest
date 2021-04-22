using System;
using NLog;
using NLog.Web;
using WorkFlowTest.DI;

namespace WorkFlowTest
{
    public class Program
    {
        public const int ErrorExitCode = 1;
        public const int SuccessExitCode = 0;

        private static void Main(string[] args)
        {
            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                logger.Info("<Starting WorkFlowTest Application>");

                var service = new ApplicationBuilder().Build();
                service.Invoke().GetAwaiter().GetResult();
                logger.Info("<Finishing WorkFlowTest Application>");
                Environment.Exit(SuccessExitCode);
            }
            catch (Exception e)
            {
                System.Console.Error.WriteLine(e);
                logger.Error(e);
            }
            Environment.Exit(ErrorExitCode);
        }
    }

}

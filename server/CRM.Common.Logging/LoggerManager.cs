using CRM.Common.Logging.Contract;
using NLog;
using System;
using System.Collections.Generic;

namespace CRM.Common.Logging
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public LoggerManager()
        {

        }

        public void LogDebug(string message)
        {
            System.Diagnostics.Contracts.Contract.Assert(!string.IsNullOrEmpty(message));
            logger.Debug(message);
        }


        public void LogError(string message, Exception exception)
        {
            System.Diagnostics.Contracts.Contract.Assert(!string.IsNullOrEmpty(message));
            System.Diagnostics.Contracts.Contract.Assert(exception != null);

            logger.Error(exception, message);
        }

        public void LogInfo(string message)
        {
            System.Diagnostics.Contracts.Contract.Assert(!string.IsNullOrEmpty(message));
            logger.Info(message);
        }

        public void LogWarn(string message)
        {
            System.Diagnostics.Contracts.Contract.Assert(!string.IsNullOrEmpty(message));
            logger.Warn(message);
        }

        
    }
}
